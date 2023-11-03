namespace RasterDBConvert
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
            this.dbFileName = new System.Windows.Forms.TextBox();
            this.SelectFile = new System.Windows.Forms.Button();
            this.newDatapointNames = new System.Windows.Forms.RichTextBox();
            this.convert = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dbFileName
            // 
            this.dbFileName.Location = new System.Drawing.Point(24, 22);
            this.dbFileName.Name = "dbFileName";
            this.dbFileName.Size = new System.Drawing.Size(413, 23);
            this.dbFileName.TabIndex = 0;
            // 
            // SelectFile
            // 
            this.SelectFile.Location = new System.Drawing.Point(443, 21);
            this.SelectFile.Name = "SelectFile";
            this.SelectFile.Size = new System.Drawing.Size(140, 23);
            this.SelectFile.TabIndex = 1;
            this.SelectFile.Text = "Select file";
            this.SelectFile.UseVisualStyleBackColor = true;
            this.SelectFile.Click += new System.EventHandler(this.SelectFile_Click);
            // 
            // newDatapointNames
            // 
            this.newDatapointNames.Location = new System.Drawing.Point(24, 104);
            this.newDatapointNames.Name = "newDatapointNames";
            this.newDatapointNames.Size = new System.Drawing.Size(413, 334);
            this.newDatapointNames.TabIndex = 2;
            this.newDatapointNames.Text = resources.GetString("newDatapointNames.Text");
            // 
            // convert
            // 
            this.convert.Location = new System.Drawing.Point(448, 104);
            this.convert.Name = "convert";
            this.convert.Size = new System.Drawing.Size(140, 97);
            this.convert.TabIndex = 3;
            this.convert.Text = "Convert";
            this.convert.UseVisualStyleBackColor = true;
            this.convert.Click += new System.EventHandler(this.convert_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "DB var volgorde";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.convert);
            this.Controls.Add(this.newDatapointNames);
            this.Controls.Add(this.SelectFile);
            this.Controls.Add(this.dbFileName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox dbFileName;
        private Button SelectFile;
        private RichTextBox newDatapointNames;
        private Button convert;
        private Label label1;
    }
}