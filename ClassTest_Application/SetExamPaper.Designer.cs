namespace ClassTest_Application
{
    partial class SetExamPaper
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.Q1_comboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Q1_op4Box = new System.Windows.Forms.TextBox();
            this.Q1_op3Box = new System.Windows.Forms.TextBox();
            this.Q1_op2Box = new System.Windows.Forms.TextBox();
            this.Q1_op1Box = new System.Windows.Forms.TextBox();
            this.Q1Box = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.browse_button = new System.Windows.Forms.Button();
            this.path_textBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button_upload = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Q1_comboBox);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.Q1_op4Box);
            this.panel2.Controls.Add(this.Q1_op3Box);
            this.panel2.Controls.Add(this.Q1_op2Box);
            this.panel2.Controls.Add(this.Q1_op1Box);
            this.panel2.Controls.Add(this.Q1Box);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(259, 213);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(534, 339);
            this.panel2.TabIndex = 66;
            // 
            // Q1_comboBox
            // 
            this.Q1_comboBox.BackColor = System.Drawing.SystemColors.Window;
            this.Q1_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Q1_comboBox.FormattingEnabled = true;
            this.Q1_comboBox.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D"});
            this.Q1_comboBox.Location = new System.Drawing.Point(226, 277);
            this.Q1_comboBox.Name = "Q1_comboBox";
            this.Q1_comboBox.Size = new System.Drawing.Size(56, 24);
            this.Q1_comboBox.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkGreen;
            this.label2.Location = new System.Drawing.Point(121, 282);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "Correct Ans :";
            // 
            // Q1_op4Box
            // 
            this.Q1_op4Box.BackColor = System.Drawing.Color.Gainsboro;
            this.Q1_op4Box.Location = new System.Drawing.Point(259, 179);
            this.Q1_op4Box.Multiline = true;
            this.Q1_op4Box.Name = "Q1_op4Box";
            this.Q1_op4Box.Size = new System.Drawing.Size(264, 53);
            this.Q1_op4Box.TabIndex = 5;
            // 
            // Q1_op3Box
            // 
            this.Q1_op3Box.BackColor = System.Drawing.Color.LightGray;
            this.Q1_op3Box.Location = new System.Drawing.Point(3, 179);
            this.Q1_op3Box.Multiline = true;
            this.Q1_op3Box.Name = "Q1_op3Box";
            this.Q1_op3Box.Size = new System.Drawing.Size(247, 53);
            this.Q1_op3Box.TabIndex = 4;
            // 
            // Q1_op2Box
            // 
            this.Q1_op2Box.BackColor = System.Drawing.Color.LightGray;
            this.Q1_op2Box.Location = new System.Drawing.Point(259, 104);
            this.Q1_op2Box.Multiline = true;
            this.Q1_op2Box.Name = "Q1_op2Box";
            this.Q1_op2Box.Size = new System.Drawing.Size(264, 53);
            this.Q1_op2Box.TabIndex = 3;
            // 
            // Q1_op1Box
            // 
            this.Q1_op1Box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Q1_op1Box.Location = new System.Drawing.Point(3, 104);
            this.Q1_op1Box.Multiline = true;
            this.Q1_op1Box.Name = "Q1_op1Box";
            this.Q1_op1Box.Size = new System.Drawing.Size(247, 53);
            this.Q1_op1Box.TabIndex = 2;
            this.Q1_op1Box.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Q1Box
            // 
            this.Q1Box.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.Q1Box.Location = new System.Drawing.Point(3, 32);
            this.Q1Box.Multiline = true;
            this.Q1Box.Name = "Q1Box";
            this.Q1Box.Size = new System.Drawing.Size(520, 55);
            this.Q1Box.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(3, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Question :";
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.BackColor = System.Drawing.Color.SeaGreen;
            this.buttonSubmit.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSubmit.Location = new System.Drawing.Point(469, 588);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(99, 43);
            this.buttonSubmit.TabIndex = 6;
            this.buttonSubmit.Text = "Submit";
            this.buttonSubmit.UseVisualStyleBackColor = false;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 22);
            this.label3.TabIndex = 72;
            this.label3.Text = "label3";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // browse_button
            // 
            this.browse_button.BackColor = System.Drawing.Color.Lavender;
            this.browse_button.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browse_button.ForeColor = System.Drawing.Color.DarkBlue;
            this.browse_button.Location = new System.Drawing.Point(802, 23);
            this.browse_button.Name = "browse_button";
            this.browse_button.Size = new System.Drawing.Size(93, 46);
            this.browse_button.TabIndex = 9;
            this.browse_button.Text = "Browse";
            this.browse_button.UseVisualStyleBackColor = false;
            this.browse_button.Click += new System.EventHandler(this.upload_button_Click);
            // 
            // path_textBox
            // 
            this.path_textBox.BackColor = System.Drawing.SystemColors.Menu;
            this.path_textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.path_textBox.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.path_textBox.Location = new System.Drawing.Point(262, 23);
            this.path_textBox.Multiline = true;
            this.path_textBox.Name = "path_textBox";
            this.path_textBox.Size = new System.Drawing.Size(534, 46);
            this.path_textBox.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkBlue;
            this.label4.Location = new System.Drawing.Point(136, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 22);
            this.label4.TabIndex = 75;
            this.label4.Text = "File Name :";
            // 
            // button_upload
            // 
            this.button_upload.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.button_upload.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_upload.Location = new System.Drawing.Point(469, 102);
            this.button_upload.Name = "button_upload";
            this.button_upload.Size = new System.Drawing.Size(99, 47);
            this.button_upload.TabIndex = 10;
            this.button_upload.Text = "Upload";
            this.button_upload.UseVisualStyleBackColor = false;
            this.button_upload.Click += new System.EventHandler(this.button_upload_Click);
            // 
            // SetExamPaper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(1011, 675);
            this.Controls.Add(this.button_upload);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.path_textBox);
            this.Controls.Add(this.browse_button);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "SetExamPaper";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Set Exam Paper";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SetExamPaper_FormClosing);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox Q1_op3Box;
        private System.Windows.Forms.TextBox Q1_op2Box;
        private System.Windows.Forms.TextBox Q1_op1Box;
        private System.Windows.Forms.TextBox Q1Box;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Q1_comboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Q1_op4Box;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button browse_button;
        private System.Windows.Forms.TextBox path_textBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_upload;
    }
}