namespace neutrino_interactions
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
            this.findbutton = new System.Windows.Forms.Button();
            this.Arraybox = new System.Windows.Forms.TextBox();
            this.inputbox = new System.Windows.Forms.TextBox();
            this.sortbutton = new System.Windows.Forms.Button();
            this.editbox = new System.Windows.Forms.TextBox();
            this.editbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // findbutton
            // 
            this.findbutton.Location = new System.Drawing.Point(135, 39);
            this.findbutton.Name = "findbutton";
            this.findbutton.Size = new System.Drawing.Size(75, 20);
            this.findbutton.TabIndex = 1;
            this.findbutton.Text = "Find";
            this.findbutton.UseVisualStyleBackColor = true;
            this.findbutton.Click += new System.EventHandler(this.findbutton_Click);
            // 
            // Arraybox
            // 
            this.Arraybox.Location = new System.Drawing.Point(12, 10);
            this.Arraybox.Multiline = true;
            this.Arraybox.Name = "Arraybox";
            this.Arraybox.Size = new System.Drawing.Size(100, 335);
            this.Arraybox.TabIndex = 0;
            this.Arraybox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // inputbox
            // 
            this.inputbox.Location = new System.Drawing.Point(123, 10);
            this.inputbox.Name = "inputbox";
            this.inputbox.Size = new System.Drawing.Size(100, 20);
            this.inputbox.TabIndex = 2;
            this.inputbox.TextChanged += new System.EventHandler(this.inputbox_TextChanged);
            // 
            // sortbutton
            // 
            this.sortbutton.Location = new System.Drawing.Point(135, 65);
            this.sortbutton.Name = "sortbutton";
            this.sortbutton.Size = new System.Drawing.Size(75, 23);
            this.sortbutton.TabIndex = 3;
            this.sortbutton.Text = "Sort";
            this.sortbutton.UseVisualStyleBackColor = true;
            this.sortbutton.Click += new System.EventHandler(this.sortbutton_Click);
            // 
            // editbox
            // 
            this.editbox.Location = new System.Drawing.Point(123, 144);
            this.editbox.Name = "editbox";
            this.editbox.Size = new System.Drawing.Size(100, 20);
            this.editbox.TabIndex = 4;
            this.editbox.TextChanged += new System.EventHandler(this.editbox_TextChanged);
            // 
            // editbutton
            // 
            this.editbutton.Location = new System.Drawing.Point(135, 170);
            this.editbutton.Name = "editbutton";
            this.editbutton.Size = new System.Drawing.Size(75, 23);
            this.editbutton.TabIndex = 5;
            this.editbutton.Text = "Enter";
            this.editbutton.UseVisualStyleBackColor = true;
            this.editbutton.Click += new System.EventHandler(this.editbutton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 358);
            this.Controls.Add(this.editbutton);
            this.Controls.Add(this.editbox);
            this.Controls.Add(this.sortbutton);
            this.Controls.Add(this.inputbox);
            this.Controls.Add(this.findbutton);
            this.Controls.Add(this.Arraybox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button findbutton;
        private System.Windows.Forms.TextBox Arraybox;
        private System.Windows.Forms.TextBox inputbox;
        private System.Windows.Forms.Button sortbutton;
        private System.Windows.Forms.TextBox editbox;
        private System.Windows.Forms.Button editbutton;
    }
}

