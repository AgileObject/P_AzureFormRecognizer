namespace AzureFormRecognizer
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            buttonClose = new Button();
            buttonCreateSearchablePDF = new Button();
            buttonSelectFile = new Button();
            buttonResult = new Button();
            pictureBoxSelectedFile = new PictureBox();
            checkBoxPDFIsCreated = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSelectedFile).BeginInit();
            SuspendLayout();
            // 
            // buttonClose
            // 
            buttonClose.Location = new Point(1240, 893);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(94, 29);
            buttonClose.TabIndex = 0;
            buttonClose.Text = "close";
            buttonClose.UseVisualStyleBackColor = true;
            buttonClose.Click += buttonClose_Click;
            // 
            // buttonCreateSearchablePDF
            // 
            buttonCreateSearchablePDF.Location = new Point(34, 82);
            buttonCreateSearchablePDF.Name = "buttonCreateSearchablePDF";
            buttonCreateSearchablePDF.Size = new Size(214, 29);
            buttonCreateSearchablePDF.TabIndex = 1;
            buttonCreateSearchablePDF.Text = "Create Searchable PDF...";
            buttonCreateSearchablePDF.UseVisualStyleBackColor = true;
            buttonCreateSearchablePDF.Click += buttonCreateSearchablePDF_Click;
            // 
            // buttonSelectFile
            // 
            buttonSelectFile.Location = new Point(34, 28);
            buttonSelectFile.Name = "buttonSelectFile";
            buttonSelectFile.Size = new Size(214, 29);
            buttonSelectFile.TabIndex = 2;
            buttonSelectFile.Text = "Select file...";
            buttonSelectFile.UseVisualStyleBackColor = true;
            buttonSelectFile.Click += buttonSelectFile_Click;
            // 
            // buttonResult
            // 
            buttonResult.Location = new Point(34, 138);
            buttonResult.Name = "buttonResult";
            buttonResult.Size = new Size(214, 29);
            buttonResult.TabIndex = 3;
            buttonResult.Text = "Open result";
            buttonResult.UseVisualStyleBackColor = true;
            buttonResult.Click += buttonResult_Click;
            // 
            // pictureBoxSelectedFile
            // 
            pictureBoxSelectedFile.Location = new Point(286, 30);
            pictureBoxSelectedFile.Name = "pictureBoxSelectedFile";
            pictureBoxSelectedFile.Size = new Size(1048, 845);
            pictureBoxSelectedFile.TabIndex = 4;
            pictureBoxSelectedFile.TabStop = false;
            // 
            // checkBoxPDFIsCreated
            // 
            checkBoxPDFIsCreated.AutoSize = true;
            checkBoxPDFIsCreated.Location = new Point(254, 82);
            checkBoxPDFIsCreated.Name = "checkBoxPDFIsCreated";
            checkBoxPDFIsCreated.Size = new Size(18, 17);
            checkBoxPDFIsCreated.TabIndex = 5;
            checkBoxPDFIsCreated.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1364, 934);
            Controls.Add(checkBoxPDFIsCreated);
            Controls.Add(pictureBoxSelectedFile);
            Controls.Add(buttonResult);
            Controls.Add(buttonSelectFile);
            Controls.Add(buttonCreateSearchablePDF);
            Controls.Add(buttonClose);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "AzureFormRecognizer";
            ((System.ComponentModel.ISupportInitialize)pictureBoxSelectedFile).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonClose;
        private Button buttonCreateSearchablePDF;
        private Button buttonSelectFile;
        private Button buttonResult;
        private PictureBox pictureBoxSelectedFile;
        private CheckBox checkBoxPDFIsCreated;
    }
}
