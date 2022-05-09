namespace imagesANDtxt
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
            this.textBox = new System.Windows.Forms.TextBox();
            this.image = new System.Windows.Forms.PictureBox();
            this.path = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.openFile = new System.Windows.Forms.Button();
            this.web = new System.Windows.Forms.RadioButton();
            this.img = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.convert = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.langs = new System.Windows.Forms.ListBox();
            this.apikey = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.image)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(426, 101);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(258, 337);
            this.textBox.TabIndex = 0;
            // 
            // image
            // 
            this.image.Location = new System.Drawing.Point(12, 101);
            this.image.Name = "image";
            this.image.Size = new System.Drawing.Size(283, 337);
            this.image.TabIndex = 1;
            this.image.TabStop = false;
            // 
            // path
            // 
            this.path.Location = new System.Drawing.Point(12, 72);
            this.path.Name = "path";
            this.path.Size = new System.Drawing.Size(672, 23);
            this.path.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Впишите сюда URL адрес иливыберите файл";
            // 
            // openFile
            // 
            this.openFile.Location = new System.Drawing.Point(290, 43);
            this.openFile.Name = "openFile";
            this.openFile.Size = new System.Drawing.Size(116, 23);
            this.openFile.TabIndex = 4;
            this.openFile.Text = "Выбрать файл";
            this.openFile.UseVisualStyleBackColor = true;
            // 
            // web
            // 
            this.web.AutoSize = true;
            this.web.Location = new System.Drawing.Point(6, 22);
            this.web.Name = "web";
            this.web.Size = new System.Drawing.Size(49, 19);
            this.web.TabIndex = 5;
            this.web.TabStop = true;
            this.web.Text = "WEB";
            this.web.UseVisualStyleBackColor = true;
            // 
            // img
            // 
            this.img.AutoSize = true;
            this.img.Location = new System.Drawing.Point(6, 47);
            this.img.Name = "img";
            this.img.Size = new System.Drawing.Size(47, 19);
            this.img.TabIndex = 6;
            this.img.TabStop = true;
            this.img.Text = "IMG";
            this.img.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.web);
            this.groupBox1.Controls.Add(this.img);
            this.groupBox1.Location = new System.Drawing.Point(301, 101);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(119, 79);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Формат";
            // 
            // convert
            // 
            this.convert.Location = new System.Drawing.Point(301, 196);
            this.convert.Name = "convert";
            this.convert.Size = new System.Drawing.Size(119, 58);
            this.convert.TabIndex = 8;
            this.convert.Text = "Конвертировать";
            this.convert.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // langs
            // 
            this.langs.FormattingEnabled = true;
            this.langs.ItemHeight = 15;
            this.langs.Location = new System.Drawing.Point(301, 260);
            this.langs.Name = "langs";
            this.langs.Size = new System.Drawing.Size(119, 169);
            this.langs.TabIndex = 9;
            // 
            // apikey
            // 
            this.apikey.Location = new System.Drawing.Point(150, 12);
            this.apikey.Name = "apikey";
            this.apikey.Size = new System.Drawing.Size(100, 23);
            this.apikey.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "Впишите ваш apikey";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.apikey);
            this.Controls.Add(this.langs);
            this.Controls.Add(this.convert);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.openFile);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.path);
            this.Controls.Add(this.image);
            this.Controls.Add(this.textBox);
            this.Name = "Form1";
            this.Text = "IMGtoTXT";
            ((System.ComponentModel.ISupportInitialize)(this.image)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBox;
        private PictureBox image;
        private TextBox path;
        private Label label1;
        private Button openFile;
        private RadioButton web;
        private RadioButton img;
        private GroupBox groupBox1;
        private Button convert;
        private OpenFileDialog openFileDialog1;
        private ListBox langs;
        private TextBox apikey;
        private Label label2;
    }
}