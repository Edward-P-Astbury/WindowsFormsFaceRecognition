namespace WindowsFormsFaceRecognition
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtBoxName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnDetectFaces = new System.Windows.Forms.Button();
            this.btnSaveImage = new System.Windows.Forms.Button();
            this.btnOpenCamera = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.pictureBoxSmall = new System.Windows.Forms.PictureBox();
            this.pictureBoxLarge = new System.Windows.Forms.PictureBox();
            this.labelOfPersonName = new System.Windows.Forms.Label();
            this.labelAge = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelAgeTxt = new System.Windows.Forms.Label();
            this.labelGlasses = new System.Windows.Forms.Label();
            this.labelFacialHair = new System.Windows.Forms.Label();
            this.labelSmile = new System.Windows.Forms.Label();
            this.labelSmileTxt = new System.Windows.Forms.Label();
            this.labelFacialHairTxt = new System.Windows.Forms.Label();
            this.labelGlassesTxt = new System.Windows.Forms.Label();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSmall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLarge)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBoxName
            // 
            this.txtBoxName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBoxName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtBoxName.Location = new System.Drawing.Point(941, 221);
            this.txtBoxName.Name = "txtBoxName";
            this.txtBoxName.Size = new System.Drawing.Size(100, 20);
            this.txtBoxName.TabIndex = 5;
            // 
            // labelName
            // 
            this.labelName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(895, 225);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(40, 16);
            this.labelName.TabIndex = 6;
            this.labelName.Text = "Name";
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.Silver;
            this.panelMenu.Controls.Add(this.btnDetectFaces);
            this.panelMenu.Controls.Add(this.btnSaveImage);
            this.panelMenu.Controls.Add(this.btnOpenCamera);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 623);
            this.panelMenu.TabIndex = 7;
            // 
            // btnDetectFaces
            // 
            this.btnDetectFaces.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDetectFaces.FlatAppearance.BorderSize = 0;
            this.btnDetectFaces.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetectFaces.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetectFaces.ForeColor = System.Drawing.Color.Black;
            this.btnDetectFaces.Image = global::WindowsFormsFaceRecognition.Properties.Resources.icons8_face_50;
            this.btnDetectFaces.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDetectFaces.Location = new System.Drawing.Point(0, 200);
            this.btnDetectFaces.Name = "btnDetectFaces";
            this.btnDetectFaces.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnDetectFaces.Size = new System.Drawing.Size(220, 60);
            this.btnDetectFaces.TabIndex = 10;
            this.btnDetectFaces.Text = "Scan Faces";
            this.btnDetectFaces.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDetectFaces.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDetectFaces.UseVisualStyleBackColor = true;
            this.btnDetectFaces.Click += new System.EventHandler(this.btnDetectFaces_Click);
            // 
            // btnSaveImage
            // 
            this.btnSaveImage.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSaveImage.FlatAppearance.BorderSize = 0;
            this.btnSaveImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveImage.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveImage.ForeColor = System.Drawing.Color.Black;
            this.btnSaveImage.Image = global::WindowsFormsFaceRecognition.Properties.Resources.icons8_save_file_50;
            this.btnSaveImage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveImage.Location = new System.Drawing.Point(0, 140);
            this.btnSaveImage.Name = "btnSaveImage";
            this.btnSaveImage.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnSaveImage.Size = new System.Drawing.Size(220, 60);
            this.btnSaveImage.TabIndex = 9;
            this.btnSaveImage.Text = "Save Image";
            this.btnSaveImage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveImage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSaveImage.UseVisualStyleBackColor = true;
            this.btnSaveImage.Click += new System.EventHandler(this.btnSaveImage_Click);
            // 
            // btnOpenCamera
            // 
            this.btnOpenCamera.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOpenCamera.FlatAppearance.BorderSize = 0;
            this.btnOpenCamera.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenCamera.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenCamera.ForeColor = System.Drawing.Color.Black;
            this.btnOpenCamera.Image = global::WindowsFormsFaceRecognition.Properties.Resources.icons8_camera_50;
            this.btnOpenCamera.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOpenCamera.Location = new System.Drawing.Point(0, 80);
            this.btnOpenCamera.Name = "btnOpenCamera";
            this.btnOpenCamera.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnOpenCamera.Size = new System.Drawing.Size(220, 60);
            this.btnOpenCamera.TabIndex = 8;
            this.btnOpenCamera.Text = "Video Camera Capture";
            this.btnOpenCamera.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOpenCamera.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOpenCamera.UseVisualStyleBackColor = true;
            this.btnOpenCamera.Click += new System.EventHandler(this.btnOpenCamera_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.LightCyan;
            this.panelLogo.Controls.Add(this.label2);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(220, 80);
            this.panelLogo.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(50, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Demo Project";
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.MintCream;
            this.panelTitleBar.Controls.Add(this.labelTitle);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(220, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(982, 80);
            this.panelTitleBar.TabIndex = 8;
            // 
            // labelTitle
            // 
            this.labelTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Century Gothic", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.Black;
            this.labelTitle.Location = new System.Drawing.Point(351, 25);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(306, 27);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "FACE RECOGNITION DEMO";
            // 
            // pictureBoxSmall
            // 
            this.pictureBoxSmall.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxSmall.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxSmall.Image = global::WindowsFormsFaceRecognition.Properties.Resources.icons8_not_bad_meme_100;
            this.pictureBoxSmall.InitialImage = null;
            this.pictureBoxSmall.Location = new System.Drawing.Point(941, 110);
            this.pictureBoxSmall.Name = "pictureBoxSmall";
            this.pictureBoxSmall.Size = new System.Drawing.Size(100, 100);
            this.pictureBoxSmall.TabIndex = 1;
            this.pictureBoxSmall.TabStop = false;
            // 
            // pictureBoxLarge
            // 
            this.pictureBoxLarge.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxLarge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxLarge.Location = new System.Drawing.Point(249, 110);
            this.pictureBoxLarge.Name = "pictureBoxLarge";
            this.pictureBoxLarge.Size = new System.Drawing.Size(535, 397);
            this.pictureBoxLarge.TabIndex = 0;
            this.pictureBoxLarge.TabStop = false;
            // 
            // labelOfPersonName
            // 
            this.labelOfPersonName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelOfPersonName.AutoSize = true;
            this.labelOfPersonName.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOfPersonName.Location = new System.Drawing.Point(895, 321);
            this.labelOfPersonName.Name = "labelOfPersonName";
            this.labelOfPersonName.Size = new System.Drawing.Size(39, 15);
            this.labelOfPersonName.TabIndex = 9;
            this.labelOfPersonName.Text = "Name";
            // 
            // labelAge
            // 
            this.labelAge.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelAge.AutoSize = true;
            this.labelAge.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAge.Location = new System.Drawing.Point(969, 347);
            this.labelAge.Name = "labelAge";
            this.labelAge.Size = new System.Drawing.Size(35, 16);
            this.labelAge.TabIndex = 10;
            this.labelAge.Text = "Age -";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(895, 347);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "ATTRIBUTES:";
            // 
            // labelAgeTxt
            // 
            this.labelAgeTxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelAgeTxt.AutoSize = true;
            this.labelAgeTxt.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAgeTxt.Location = new System.Drawing.Point(1044, 347);
            this.labelAgeTxt.Name = "labelAgeTxt";
            this.labelAgeTxt.Size = new System.Drawing.Size(13, 16);
            this.labelAgeTxt.TabIndex = 12;
            this.labelAgeTxt.Text = "0";
            // 
            // labelGlasses
            // 
            this.labelGlasses.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelGlasses.AutoSize = true;
            this.labelGlasses.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGlasses.Location = new System.Drawing.Point(969, 363);
            this.labelGlasses.Name = "labelGlasses";
            this.labelGlasses.Size = new System.Drawing.Size(53, 16);
            this.labelGlasses.TabIndex = 13;
            this.labelGlasses.Text = "Glasses -";
            // 
            // labelFacialHair
            // 
            this.labelFacialHair.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelFacialHair.AutoSize = true;
            this.labelFacialHair.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFacialHair.Location = new System.Drawing.Point(969, 379);
            this.labelFacialHair.Name = "labelFacialHair";
            this.labelFacialHair.Size = new System.Drawing.Size(69, 16);
            this.labelFacialHair.TabIndex = 14;
            this.labelFacialHair.Text = "Facial hair -";
            // 
            // labelSmile
            // 
            this.labelSmile.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelSmile.AutoSize = true;
            this.labelSmile.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSmile.Location = new System.Drawing.Point(969, 395);
            this.labelSmile.Name = "labelSmile";
            this.labelSmile.Size = new System.Drawing.Size(44, 16);
            this.labelSmile.TabIndex = 15;
            this.labelSmile.Text = "Smile - ";
            // 
            // labelSmileTxt
            // 
            this.labelSmileTxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelSmileTxt.AutoSize = true;
            this.labelSmileTxt.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSmileTxt.Location = new System.Drawing.Point(1044, 395);
            this.labelSmileTxt.Name = "labelSmileTxt";
            this.labelSmileTxt.Size = new System.Drawing.Size(13, 16);
            this.labelSmileTxt.TabIndex = 16;
            this.labelSmileTxt.Text = "0";
            // 
            // labelFacialHairTxt
            // 
            this.labelFacialHairTxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelFacialHairTxt.AutoSize = true;
            this.labelFacialHairTxt.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFacialHairTxt.Location = new System.Drawing.Point(1044, 379);
            this.labelFacialHairTxt.Name = "labelFacialHairTxt";
            this.labelFacialHairTxt.Size = new System.Drawing.Size(13, 16);
            this.labelFacialHairTxt.TabIndex = 17;
            this.labelFacialHairTxt.Text = "0";
            // 
            // labelGlassesTxt
            // 
            this.labelGlassesTxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelGlassesTxt.AutoSize = true;
            this.labelGlassesTxt.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGlassesTxt.Location = new System.Drawing.Point(1044, 363);
            this.labelGlassesTxt.Name = "labelGlassesTxt";
            this.labelGlassesTxt.Size = new System.Drawing.Size(13, 16);
            this.labelGlassesTxt.TabIndex = 18;
            this.labelGlassesTxt.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1202, 623);
            this.Controls.Add(this.labelGlassesTxt);
            this.Controls.Add(this.labelFacialHairTxt);
            this.Controls.Add(this.labelSmileTxt);
            this.Controls.Add(this.labelSmile);
            this.Controls.Add(this.labelFacialHair);
            this.Controls.Add(this.labelGlasses);
            this.Controls.Add(this.labelAgeTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelAge);
            this.Controls.Add(this.labelOfPersonName);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.txtBoxName);
            this.Controls.Add(this.pictureBoxSmall);
            this.Controls.Add(this.pictureBoxLarge);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Face Recognition Demo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSmall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLarge)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxLarge;
        private System.Windows.Forms.PictureBox pictureBoxSmall;
        private System.Windows.Forms.TextBox txtBoxName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button btnOpenCamera;
        private System.Windows.Forms.Button btnDetectFaces;
        private System.Windows.Forms.Button btnSaveImage;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelOfPersonName;
        private System.Windows.Forms.Label labelAge;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelAgeTxt;
        private System.Windows.Forms.Label labelGlasses;
        private System.Windows.Forms.Label labelFacialHair;
        private System.Windows.Forms.Label labelSmile;
        private System.Windows.Forms.Label labelSmileTxt;
        private System.Windows.Forms.Label labelFacialHairTxt;
        private System.Windows.Forms.Label labelGlassesTxt;
    }
}

