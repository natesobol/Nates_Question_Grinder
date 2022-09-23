namespace Question_Grinder
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.questionParse = new System.Windows.Forms.TextBox();
            this.backParse = new System.Windows.Forms.TextBox();
            this.frontParse = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dirText = new System.Windows.Forms.TextBox();
            this.frontWrong1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.frontWrong2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.frontWrong3 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(282, 153);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(199, 60);
            this.button1.TabIndex = 0;
            this.button1.Text = "Upload File";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(282, 248);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(199, 64);
            this.button2.TabIndex = 1;
            this.button2.Text = "Parse";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Front Correct Parse";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(216, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Question Front Parse";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Back Parse";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 318);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 25);
            this.label6.TabIndex = 7;
            this.label6.Text = "Dir:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // questionParse
            // 
            this.questionParse.Location = new System.Drawing.Point(19, 142);
            this.questionParse.Name = "questionParse";
            this.questionParse.Size = new System.Drawing.Size(225, 20);
            this.questionParse.TabIndex = 8;
            this.questionParse.Text = "map_questionText.Put(map_questionText.Size + 1, \"";
            // 
            // backParse
            // 
            this.backParse.Location = new System.Drawing.Point(19, 91);
            this.backParse.Name = "backParse";
            this.backParse.Size = new System.Drawing.Size(223, 20);
            this.backParse.TabIndex = 9;
            this.backParse.Text = "\")";
            // 
            // frontParse
            // 
            this.frontParse.Location = new System.Drawing.Point(19, 40);
            this.frontParse.Name = "frontParse";
            this.frontParse.Size = new System.Drawing.Size(224, 20);
            this.frontParse.TabIndex = 10;
            this.frontParse.Text = "map_correctAnswer.Put(map_questionText.Size, \"";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(313, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(138, 112);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // dirText
            // 
            this.dirText.Location = new System.Drawing.Point(10, 346);
            this.dirText.Multiline = true;
            this.dirText.Name = "dirText";
            this.dirText.Size = new System.Drawing.Size(221, 64);
            this.dirText.TabIndex = 12;
            // 
            // frontWrong1
            // 
            this.frontWrong1.Location = new System.Drawing.Point(18, 193);
            this.frontWrong1.Name = "frontWrong1";
            this.frontWrong1.Size = new System.Drawing.Size(225, 20);
            this.frontWrong1.TabIndex = 13;
            this.frontWrong1.Text = "map_wrongAnswer1.Put(map_questionText.Size, \"";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(217, 25);
            this.label2.TabIndex = 14;
            this.label2.Text = "Front Wrong 1 Parse ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(211, 25);
            this.label5.TabIndex = 15;
            this.label5.Text = "Front Wrong 2 Parse";
            // 
            // frontWrong2
            // 
            this.frontWrong2.Location = new System.Drawing.Point(19, 244);
            this.frontWrong2.Name = "frontWrong2";
            this.frontWrong2.Size = new System.Drawing.Size(225, 20);
            this.frontWrong2.TabIndex = 16;
            this.frontWrong2.Text = "map_wrongAnswer2.Put(map_questionText.Size, \"";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(14, 267);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(211, 25);
            this.label7.TabIndex = 17;
            this.label7.Text = "Front Wrong 3 Parse";
            // 
            // frontWrong3
            // 
            this.frontWrong3.Location = new System.Drawing.Point(18, 295);
            this.frontWrong3.Name = "frontWrong3";
            this.frontWrong3.Size = new System.Drawing.Size(225, 20);
            this.frontWrong3.TabIndex = 18;
            this.frontWrong3.Text = "map_wrongAnswer3.Put(map_questionText.Size, \"";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 433);
            this.Controls.Add(this.frontWrong3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.frontWrong2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.frontWrong1);
            this.Controls.Add(this.dirText);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.frontParse);
            this.Controls.Add(this.backParse);
            this.Controls.Add(this.questionParse);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Nate\'s Question Grinder";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox questionParse;
        private System.Windows.Forms.TextBox backParse;
        private System.Windows.Forms.TextBox frontParse;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox dirText;
        private System.Windows.Forms.TextBox frontWrong1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox frontWrong2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox frontWrong3;
    }
}

