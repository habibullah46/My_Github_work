namespace new_calculator
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
            this.txt_ValueOne = new System.Windows.Forms.TextBox();
            this.txt_ValueTwo = new System.Windows.Forms.TextBox();
            this.txt_Answer = new System.Windows.Forms.TextBox();
            this.cbm_Choice = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_error = new System.Windows.Forms.Label();
            this.btn_clear = new System.Windows.Forms.Button();
            this.lbl_last_Operator = new System.Windows.Forms.Label();
            this.btn_History = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_ValueOne
            // 
            this.txt_ValueOne.Location = new System.Drawing.Point(388, 90);
            this.txt_ValueOne.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_ValueOne.Name = "txt_ValueOne";
            this.txt_ValueOne.Size = new System.Drawing.Size(202, 22);
            this.txt_ValueOne.TabIndex = 0;
            // 
            // txt_ValueTwo
            // 
            this.txt_ValueTwo.Location = new System.Drawing.Point(388, 140);
            this.txt_ValueTwo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_ValueTwo.Name = "txt_ValueTwo";
            this.txt_ValueTwo.Size = new System.Drawing.Size(202, 22);
            this.txt_ValueTwo.TabIndex = 1;
            // 
            // txt_Answer
            // 
            this.txt_Answer.Location = new System.Drawing.Point(388, 233);
            this.txt_Answer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Answer.Name = "txt_Answer";
            this.txt_Answer.Size = new System.Drawing.Size(202, 22);
            this.txt_Answer.TabIndex = 2;
            // 
            // cbm_Choice
            // 
            this.cbm_Choice.FormattingEnabled = true;
            this.cbm_Choice.Items.AddRange(new object[] {
            "ADD",
            "SUB",
            "MUL",
            "DIVID"});
            this.cbm_Choice.Location = new System.Drawing.Point(388, 186);
            this.cbm_Choice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbm_Choice.Name = "cbm_Choice";
            this.cbm_Choice.Size = new System.Drawing.Size(202, 24);
            this.cbm_Choice.TabIndex = 3;
            this.cbm_Choice.SelectedIndexChanged += new System.EventHandler(this.cbm_Choice_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(698, 78);
            this.panel1.TabIndex = 9;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(174, 2);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(89, 62);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(268, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Calculator";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 326);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(698, 44);
            this.panel2.TabIndex = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 82);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(207, 214);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_error
            // 
            this.lbl_error.AutoSize = true;
            this.lbl_error.ForeColor = System.Drawing.Color.Red;
            this.lbl_error.Location = new System.Drawing.Point(524, 276);
            this.lbl_error.Name = "lbl_error";
            this.lbl_error.Size = new System.Drawing.Size(0, 16);
            this.lbl_error.TabIndex = 0;
            // 
            // btn_clear
            // 
            this.btn_clear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_clear.Location = new System.Drawing.Point(388, 262);
            this.btn_clear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(95, 30);
            this.btn_clear.TabIndex = 12;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // lbl_last_Operator
            // 
            this.lbl_last_Operator.AutoSize = true;
            this.lbl_last_Operator.Location = new System.Drawing.Point(11, 307);
            this.lbl_last_Operator.Name = "lbl_last_Operator";
            this.lbl_last_Operator.Size = new System.Drawing.Size(91, 16);
            this.lbl_last_Operator.TabIndex = 13;
            this.lbl_last_Operator.Text = "Last Operator:";
            // 
            // btn_History
            // 
            this.btn_History.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_History.Location = new System.Drawing.Point(590, 298);
            this.btn_History.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_History.Name = "btn_History";
            this.btn_History.Size = new System.Drawing.Size(82, 23);
            this.btn_History.TabIndex = 14;
            this.btn_History.Text = "History";
            this.btn_History.UseVisualStyleBackColor = true;
            this.btn_History.Click += new System.EventHandler(this.btn_History_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(262, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "Value One :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(262, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 16);
            this.label3.TabIndex = 16;
            this.label3.Text = "Value Two : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(262, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 16);
            this.label4.TabIndex = 17;
            this.label4.Text = "Choice: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(262, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 16);
            this.label5.TabIndex = 18;
            this.label5.Text = "Answer :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 370);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_History);
            this.Controls.Add(this.lbl_last_Operator);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.lbl_error);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cbm_Choice);
            this.Controls.Add(this.txt_Answer);
            this.Controls.Add(this.txt_ValueTwo);
            this.Controls.Add(this.txt_ValueOne);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_ValueOne;
        private System.Windows.Forms.TextBox txt_ValueTwo;
        private System.Windows.Forms.TextBox txt_Answer;
        private System.Windows.Forms.ComboBox cbm_Choice;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_error;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Label lbl_last_Operator;
        private System.Windows.Forms.Button btn_History;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

