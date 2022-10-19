using Microsoft.Azure.CognitiveServices.Vision.Face.Models;
using Microsoft.Azure.CognitiveServices.Vision.Face;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsFaceRecognition
{
    public partial class Form1 : Form
    {
        FaceRecognition faceRecognition;
        IFaceClient client;

        const string SUBSCRIPTION_KEY = "";
        const string ENDPOINT = "";
        const string RECOGNITION_MODEL4 = RecognitionModel.Recognition04;

        public Form1()
        {
            InitializeComponent();
            client = new FaceClient(new ApiKeyServiceClientCredentials(SUBSCRIPTION_KEY)) { Endpoint = ENDPOINT };
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            faceRecognition = new FaceRecognition();
        }

        private void btnOpenCamera_Click(object sender, EventArgs e)
        {
            faceRecognition.OpenCamera(pictureBoxLarge, pictureBoxSmall);
        }

        private void btnSaveImage_Click(object sender, EventArgs e)
        {
            faceRecognition.SaveImage(txtBoxName.Text);
            MessageBox.Show("Image saved successfully");
        }

        // https://stackoverflow.com/questions/73095624/unable-to-use-azure-face-api-forbidden-error
        // https://learn.microsoft.com/en-us/answers/questions/939127/unable-to-use-face-api-forbidden-error.html
        private async void btnDetectFaces_Click(object sender, EventArgs e)
        {
            faceRecognition.FaceDetectionOn = true;
            faceRecognition.GetPersonName(labelOfPersonName);

            // Detect emotion etc. with Azure
            string[] imageFile = Directory.GetFiles(Directory.GetCurrentDirectory() + "\\Image", "*.jpg", SearchOption.AllDirectories);


            try
            {
                foreach (var img in imageFile)
                {
                    IList<DetectedFace> detectedFaces;
                    var stream = new FileStream(img, FileMode.Open);

                    // detect face attributes
                    detectedFaces = await client.Face.DetectWithStreamAsync(stream,
                        recognitionModel: RECOGNITION_MODEL4, detectionModel: DetectionModel.Detection03,
                        returnFaceAttributes: new List<FaceAttributeType> { FaceAttributeType.Emotion, FaceAttributeType.Age,
                            FaceAttributeType.FacialHair, FaceAttributeType.Smile, FaceAttributeType.Glasses });

                    foreach (DetectedFace face in detectedFaces)
                    {
                        // name of label matches .jpg
                        if (labelOfPersonName.Text == img)
                        {
                            labelAgeTxt.Text = face.FaceAttributes.Age.ToString();
                            labelGlassesTxt.Text = face.FaceAttributes.Age.ToString();
                            labelFacialHairTxt.Text = face.FaceAttributes.Age.ToString();
                            labelSmileTxt.Text = face.FaceAttributes.Smile.ToString();
                        }
                    }
                }
            }
            catch
            {
                // TODO
            }
        }
    }
}
