namespace Fast_Ten_Fingers
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtbox_words = new System.Windows.Forms.TextBox();
            this.lbl_word = new System.Windows.Forms.Label();
            this.lbl_point = new System.Windows.Forms.Label();
            this.lbl_time = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btn_start = new System.Windows.Forms.Button();
            this.lbl_yourpoint = new System.Windows.Forms.Label();
            this.lbl_true = new System.Windows.Forms.Label();
            this.lbl_false = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtbox_words
            // 
            this.txtbox_words.Location = new System.Drawing.Point(12, 276);
            this.txtbox_words.Name = "txtbox_words";
            this.txtbox_words.Size = new System.Drawing.Size(403, 30);
            this.txtbox_words.TabIndex = 1;
            this.txtbox_words.Visible = false;
            this.txtbox_words.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // lbl_word
            // 
            this.lbl_word.AutoSize = true;
            this.lbl_word.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_word.Location = new System.Drawing.Point(155, 110);
            this.lbl_word.Name = "lbl_word";
            this.lbl_word.Size = new System.Drawing.Size(116, 46);
            this.lbl_word.TabIndex = 2;
            this.lbl_word.Text = "Word";
            this.lbl_word.Visible = false;
            // 
            // lbl_point
            // 
            this.lbl_point.AutoSize = true;
            this.lbl_point.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_point.Location = new System.Drawing.Point(314, 9);
            this.lbl_point.Name = "lbl_point";
            this.lbl_point.Size = new System.Drawing.Size(74, 29);
            this.lbl_point.TabIndex = 3;
            this.lbl_point.Text = "Point:";
            this.lbl_point.Visible = false;
            // 
            // lbl_time
            // 
            this.lbl_time.AutoSize = true;
            this.lbl_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_time.Location = new System.Drawing.Point(7, 9);
            this.lbl_time.Name = "lbl_time";
            this.lbl_time.Size = new System.Drawing.Size(107, 29);
            this.lbl_time.TabIndex = 4;
            this.lbl_time.Text = "Time: 60";
            this.lbl_time.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(133, 186);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(159, 62);
            this.btn_start.TabIndex = 5;
            this.btn_start.Text = "Start";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_yourpoint
            // 
            this.lbl_yourpoint.AutoSize = true;
            this.lbl_yourpoint.Location = new System.Drawing.Point(158, 76);
            this.lbl_yourpoint.Name = "lbl_yourpoint";
            this.lbl_yourpoint.Size = new System.Drawing.Size(108, 25);
            this.lbl_yourpoint.TabIndex = 6;
            this.lbl_yourpoint.Text = "Your Point:";
            this.lbl_yourpoint.Visible = false;
            // 
            // lbl_true
            // 
            this.lbl_true.AutoSize = true;
            this.lbl_true.ForeColor = System.Drawing.Color.LawnGreen;
            this.lbl_true.Location = new System.Drawing.Point(23, 336);
            this.lbl_true.Name = "lbl_true";
            this.lbl_true.Size = new System.Drawing.Size(59, 25);
            this.lbl_true.TabIndex = 7;
            this.lbl_true.Text = "True:";
            this.lbl_true.Visible = false;
            // 
            // lbl_false
            // 
            this.lbl_false.AutoSize = true;
            this.lbl_false.BackColor = System.Drawing.Color.DimGray;
            this.lbl_false.ForeColor = System.Drawing.Color.Red;
            this.lbl_false.Location = new System.Drawing.Point(286, 336);
            this.lbl_false.Name = "lbl_false";
            this.lbl_false.Size = new System.Drawing.Size(66, 25);
            this.lbl_false.TabIndex = 7;
            this.lbl_false.Text = "False:";
            this.lbl_false.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(427, 385);
            this.Controls.Add(this.lbl_false);
            this.Controls.Add(this.lbl_true);
            this.Controls.Add(this.lbl_yourpoint);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.lbl_time);
            this.Controls.Add(this.lbl_point);
            this.Controls.Add(this.lbl_word);
            this.Controls.Add(this.txtbox_words);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fast Ten Fingers";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbox_words;
        private System.Windows.Forms.Label lbl_word;
        private System.Windows.Forms.Label lbl_point;
        private System.Windows.Forms.Label lbl_time;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Label lbl_yourpoint;
        private System.Windows.Forms.Label lbl_true;
        private System.Windows.Forms.Label lbl_false;
    }
}

