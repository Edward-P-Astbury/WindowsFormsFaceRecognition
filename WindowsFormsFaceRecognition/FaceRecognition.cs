using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Face;
using Emgu.CV.Structure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capture = Emgu.CV.Capture;

namespace WindowsFormsFaceRecognition
{
    public class FaceRecognition : Form
    {
        private double distance = 1E+19; // scientific notation
        private CascadeClassifier CascadeClassifier = new CascadeClassifier(Environment.CurrentDirectory + "/Haarcascade/haarcascade_frontalface_alt.xml");
        private Image<Bgr, byte> frame = null;
        private Capture camera;
        private Mat mat = new Mat(); // stores values of image
        private List<Image<Gray, byte>> trainedFaces = new List<Image<Gray, byte>>();
        private List<int> personLabels = new List<int>();
        private bool saveImage = false;
        private string imageName;
        private PictureBox picBoxFrameLarge;
        private PictureBox picBoxFrameSmall;
        private string personName;
        private bool faceDetectionOn = false; // allow for the saving of images and thus face detection
        private List<string> names = new List<string>();
        private EigenFaceRecognizer eigenFaceRecognizer; // facial recognition class that works with grayscale images
        
        public bool FaceDetectionOn { get => faceDetectionOn; set => faceDetectionOn = value; }

        public FaceRecognition()
        {
            if (!Directory.Exists(Environment.CurrentDirectory + "\\Image"))
            {
                Directory.CreateDirectory(Environment.CurrentDirectory + "\\Image");
            }
        }

        public void GetPersonName(Control control)
        {
            Timer timer = new Timer();
            timer.Tick += timer_getPersonName_Tick;
            timer.Interval = 100;
            timer.Start();
            void timer_getPersonName_Tick(object sender, EventArgs e)
            {
                control.Text = personName;
            }
        }

        public void OpenCamera(PictureBox pictureBox_Camera, PictureBox pictureBox_Trained)
        {
            picBoxFrameLarge = pictureBox_Camera;
            picBoxFrameSmall = pictureBox_Trained;
            camera = new Capture();
            camera.ImageGrabbed += CameraImageCaptured;
            camera.Start();
        }

        public void SaveImage(string imageName)
        {
            this.imageName = imageName;
            saveImage = true;
        }

        private void SaveImage(Rectangle face)
        {
            if (saveImage)
            {
                Image<Bgr, byte> image = frame.Convert<Bgr, byte>();
                image.ROI = face;
                image.Resize(100, 100, Inter.Cubic).Save(Environment.CurrentDirectory + "\\Image\\" + imageName + ".jpg");
                saveImage = false;
                TrainedImage();
            }
        }

        private void CameraImageCaptured(object sender, EventArgs e)
        {
            camera.Retrieve(mat);
            frame = mat.ToImage<Bgr, byte>().Resize(picBoxFrameLarge.Width, picBoxFrameLarge.Height, Inter.Cubic);
            DetectFace();
            picBoxFrameLarge.Image = frame.Bitmap;
        }

        private void DetectFace()
        {
            Image<Bgr, byte> image = frame.Convert<Bgr, byte>();
            Mat mat = new Mat();
            CvInvoke.CvtColor(frame, mat, ColorConversion.Bgr2Gray);
            CvInvoke.EqualizeHist(mat, mat);
            Rectangle[] array = CascadeClassifier.DetectMultiScale(mat, 1.1, 4);
            if (array.Length != 0)
            {
                foreach (Rectangle rectangle in array)
                {
                    CvInvoke.Rectangle(frame, rectangle, new Bgr(Color.LimeGreen).MCvScalar, 2);
                    SaveImage(rectangle);
                    image.ROI = rectangle;
                    TrainedImage();
                    CheckName(image, rectangle);
                }
            }
            else
            {
                personName = "";
            }
        }

        private void TrainedImage()
        {
            try
            {
                int number = 0;
                trainedFaces.Clear();
                personLabels.Clear();
                names.Clear();
                string[] files = Directory.GetFiles(Directory.GetCurrentDirectory() + "\\Image", "*.jpg", SearchOption.AllDirectories);

                foreach (string text in files)
                {
                    Image<Gray, byte> item = new Image<Gray, byte>(text);
                    trainedFaces.Add(item);
                    personLabels.Add(number);
                    names.Add(text);
                    number++;
                }

                eigenFaceRecognizer = new EigenFaceRecognizer(number, distance);
                eigenFaceRecognizer.Train(trainedFaces.ToArray(), personLabels.ToArray());
            }
            catch
            {
                // exception handling
            }
        }

        // Add comments for presentation
        // https://stackoverflow.com/questions/68998808/face-recognition-in-c-sharp-using-eigenfacerecognizer-recognizing-an-unknown-f
        // https://github.com/emgucv/emgucv/issues/597
        private void CheckName(Image<Bgr, byte> resultImage, Rectangle face)
        {
            try
            {
                if (FaceDetectionOn)
                {
                    Image<Gray, byte> image = resultImage.Convert<Gray, byte>().Resize(100, 100, Inter.Cubic);
                    CvInvoke.EqualizeHist(image, image);
                    FaceRecognizer.PredictionResult predictionResult = eigenFaceRecognizer.Predict(image);

                    // whenever a new face is detected, .Predict() method always returns predictionResult.Label = 0 and predictionResult.Distance = 0
                    // and recognizes that face as same as the  most latest correctly recognized face.
                    // reference - https://stackoverflow.com/questions/68998808/face-recognition-in-c-sharp-using-eigenfacerecognizer-recognizing-an-unknown-f
                    if (predictionResult.Label != -1 && predictionResult.Distance < distance)
                    {
                        picBoxFrameSmall.Image = trainedFaces[predictionResult.Label].Bitmap;
                        personName = names[predictionResult.Label].Replace(Environment.CurrentDirectory + "\\Image\\", "").Replace(".jpg", "");
                        CvInvoke.PutText(frame, personName, new Point(face.X - 2, face.Y - 2), FontFace.HersheyPlain, 1.0, new Bgr(Color.LimeGreen).MCvScalar);
                    }
                    else
                    {
                        CvInvoke.PutText(frame, "UNKNOWN", new Point(face.X - 2, face.Y - 2), FontFace.HersheyPlain, 1.0, new Bgr(Color.OrangeRed).MCvScalar);
                    }
                }
            }
            catch
            {
                // error handling
            }
        }
    }
}
