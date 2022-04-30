
namespace TextGeneratorProgram
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
            this.button_background_image = new System.Windows.Forms.Button();
            this.text_background_image = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.text_font_folder = new System.Windows.Forms.TextBox();
            this.button_font_folder = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.text_save_location = new System.Windows.Forms.TextBox();
            this.button_save_location = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.text_input_text = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.trackbar_right = new System.Windows.Forms.TrackBar();
            this.picture_preview = new System.Windows.Forms.PictureBox();
            this.trackbar_left = new System.Windows.Forms.TrackBar();
            this.button_generate = new System.Windows.Forms.Button();
            this.numeric_right = new System.Windows.Forms.NumericUpDown();
            this.numeric_left = new System.Windows.Forms.NumericUpDown();
            this.label_generate_status = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trackbar_right)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_preview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackbar_left)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_right)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_left)).BeginInit();
            this.SuspendLayout();
            // 
            // button_background_image
            // 
            this.button_background_image.Location = new System.Drawing.Point(310, 70);
            this.button_background_image.Name = "button_background_image";
            this.button_background_image.Size = new System.Drawing.Size(33, 20);
            this.button_background_image.TabIndex = 0;
            this.button_background_image.Text = "...";
            this.button_background_image.UseVisualStyleBackColor = true;
            this.button_background_image.Click += new System.EventHandler(this.button1_Click);
            // 
            // text_background_image
            // 
            this.text_background_image.Location = new System.Drawing.Point(12, 70);
            this.text_background_image.Name = "text_background_image";
            this.text_background_image.Size = new System.Drawing.Size(292, 20);
            this.text_background_image.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Background Image";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Font Folder";
            // 
            // text_font_folder
            // 
            this.text_font_folder.Location = new System.Drawing.Point(12, 122);
            this.text_font_folder.Name = "text_font_folder";
            this.text_font_folder.Size = new System.Drawing.Size(292, 20);
            this.text_font_folder.TabIndex = 4;
            // 
            // button_font_folder
            // 
            this.button_font_folder.Location = new System.Drawing.Point(310, 121);
            this.button_font_folder.Name = "button_font_folder";
            this.button_font_folder.Size = new System.Drawing.Size(33, 20);
            this.button_font_folder.TabIndex = 3;
            this.button_font_folder.Text = "...";
            this.button_font_folder.UseVisualStyleBackColor = true;
            this.button_font_folder.Click += new System.EventHandler(this.button_font_folder_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Save Location";
            // 
            // text_save_location
            // 
            this.text_save_location.Location = new System.Drawing.Point(12, 170);
            this.text_save_location.Name = "text_save_location";
            this.text_save_location.Size = new System.Drawing.Size(292, 20);
            this.text_save_location.TabIndex = 7;
            // 
            // button_save_location
            // 
            this.button_save_location.Location = new System.Drawing.Point(310, 169);
            this.button_save_location.Name = "button_save_location";
            this.button_save_location.Size = new System.Drawing.Size(33, 20);
            this.button_save_location.TabIndex = 6;
            this.button_save_location.Text = "...";
            this.button_save_location.UseVisualStyleBackColor = true;
            this.button_save_location.Click += new System.EventHandler(this.button_save_location_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(359, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Preview";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Text";
            // 
            // text_input_text
            // 
            this.text_input_text.Location = new System.Drawing.Point(12, 223);
            this.text_input_text.Name = "text_input_text";
            this.text_input_text.Size = new System.Drawing.Size(292, 20);
            this.text_input_text.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 261);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Boundaries";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 280);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Right";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 325);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Left";
            // 
            // trackbar_right
            // 
            this.trackbar_right.Location = new System.Drawing.Point(43, 277);
            this.trackbar_right.Maximum = 100;
            this.trackbar_right.Name = "trackbar_right";
            this.trackbar_right.Size = new System.Drawing.Size(233, 45);
            this.trackbar_right.TabIndex = 17;
            this.trackbar_right.ValueChanged += new System.EventHandler(this.trackbar_left_ValueChanged);
            // 
            // picture_preview
            // 
            this.picture_preview.Location = new System.Drawing.Point(362, 70);
            this.picture_preview.Name = "picture_preview";
            this.picture_preview.Size = new System.Drawing.Size(426, 50);
            this.picture_preview.TabIndex = 18;
            this.picture_preview.TabStop = false;
            // 
            // trackbar_left
            // 
            this.trackbar_left.Location = new System.Drawing.Point(43, 325);
            this.trackbar_left.Maximum = 0;
            this.trackbar_left.Name = "trackbar_left";
            this.trackbar_left.Size = new System.Drawing.Size(233, 45);
            this.trackbar_left.TabIndex = 19;
            this.trackbar_left.ValueChanged += new System.EventHandler(this.trackbar_right_ValueChanged);
            // 
            // button_generate
            // 
            this.button_generate.Location = new System.Drawing.Point(634, 451);
            this.button_generate.Name = "button_generate";
            this.button_generate.Size = new System.Drawing.Size(154, 52);
            this.button_generate.TabIndex = 21;
            this.button_generate.Text = "Generate";
            this.button_generate.UseVisualStyleBackColor = true;
            this.button_generate.Click += new System.EventHandler(this.button_generate_Click);
            // 
            // numeric_right
            // 
            this.numeric_right.Location = new System.Drawing.Point(282, 280);
            this.numeric_right.Name = "numeric_right";
            this.numeric_right.Size = new System.Drawing.Size(61, 20);
            this.numeric_right.TabIndex = 22;
            this.numeric_right.ValueChanged += new System.EventHandler(this.numeric_left_ValueChanged);
            // 
            // numeric_left
            // 
            this.numeric_left.Location = new System.Drawing.Point(282, 325);
            this.numeric_left.Name = "numeric_left";
            this.numeric_left.Size = new System.Drawing.Size(61, 20);
            this.numeric_left.TabIndex = 23;
            this.numeric_left.ValueChanged += new System.EventHandler(this.numeric_right_ValueChanged);
            // 
            // label_generate_status
            // 
            this.label_generate_status.AutoSize = true;
            this.label_generate_status.Location = new System.Drawing.Point(634, 432);
            this.label_generate_status.Name = "label_generate_status";
            this.label_generate_status.Size = new System.Drawing.Size(43, 13);
            this.label_generate_status.TabIndex = 24;
            this.label_generate_status.Text = "Status: ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(490, 250);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 25;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 515);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label_generate_status);
            this.Controls.Add(this.numeric_left);
            this.Controls.Add(this.numeric_right);
            this.Controls.Add(this.button_generate);
            this.Controls.Add(this.trackbar_left);
            this.Controls.Add(this.picture_preview);
            this.Controls.Add(this.trackbar_right);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.text_input_text);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.text_save_location);
            this.Controls.Add(this.button_save_location);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.text_font_folder);
            this.Controls.Add(this.button_font_folder);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.text_background_image);
            this.Controls.Add(this.button_background_image);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.trackbar_right)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_preview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackbar_left)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_right)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_left)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_background_image;
        private System.Windows.Forms.TextBox text_background_image;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox text_font_folder;
        private System.Windows.Forms.Button button_font_folder;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox text_save_location;
        private System.Windows.Forms.Button button_save_location;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox text_input_text;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TrackBar trackbar_right;
        private System.Windows.Forms.PictureBox picture_preview;
        private System.Windows.Forms.TrackBar trackbar_left;
        private System.Windows.Forms.Button button_generate;
        private System.Windows.Forms.NumericUpDown numeric_right;
        private System.Windows.Forms.NumericUpDown numeric_left;
        private System.Windows.Forms.Label label_generate_status;
        private System.Windows.Forms.Button button1;
    }
}

