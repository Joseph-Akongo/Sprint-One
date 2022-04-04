namespace neutrino_interactions
{
    partial class TangoInc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TangoInc));
            this.findbutton = new System.Windows.Forms.Button();
            this.inputbox = new System.Windows.Forms.TextBox();
            this.addbutton = new System.Windows.Forms.Button();
            this.initilise = new System.Windows.Forms.Button();
            this.Arraybox = new System.Windows.Forms.ListBox();
            this.deletbutton = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.bubblesort = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // findbutton
            // 
            this.findbutton.Location = new System.Drawing.Point(177, 237);
            this.findbutton.Name = "findbutton";
            this.findbutton.Size = new System.Drawing.Size(75, 20);
            this.findbutton.TabIndex = 1;
            this.findbutton.Text = "Find";
            this.findbutton.UseVisualStyleBackColor = true;
            this.findbutton.Click += new System.EventHandler(this.findbutton_Click);
            // 
            // inputbox
            // 
            this.inputbox.BackColor = System.Drawing.SystemColors.Window;
            this.inputbox.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.inputbox.Location = new System.Drawing.Point(167, 185);
            this.inputbox.Name = "inputbox";
            this.inputbox.Size = new System.Drawing.Size(100, 20);
            this.inputbox.TabIndex = 2;
            this.inputbox.TextChanged += new System.EventHandler(this.inputbox_TextChanged);
            this.inputbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.inputbox_KeyDown);
            this.inputbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inputbox_KeyPress);
            // 
            // addbutton
            // 
            this.addbutton.Location = new System.Drawing.Point(177, 263);
            this.addbutton.Name = "addbutton";
            this.addbutton.Size = new System.Drawing.Size(75, 23);
            this.addbutton.TabIndex = 5;
            this.addbutton.Text = "Add";
            this.addbutton.UseVisualStyleBackColor = true;
            this.addbutton.Click += new System.EventHandler(this.editbutton_Click);
            // 
            // initilise
            // 
            this.initilise.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.initilise.Location = new System.Drawing.Point(177, 127);
            this.initilise.Name = "initilise";
            this.initilise.Size = new System.Drawing.Size(75, 23);
            this.initilise.TabIndex = 6;
            this.initilise.Text = "Initilise";
            this.initilise.UseVisualStyleBackColor = false;
            this.initilise.Click += new System.EventHandler(this.initilise_Click);
            // 
            // Arraybox
            // 
            this.Arraybox.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.Arraybox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Arraybox.ForeColor = System.Drawing.SystemColors.Window;
            this.Arraybox.FormattingEnabled = true;
            this.Arraybox.ItemHeight = 18;
            this.Arraybox.Location = new System.Drawing.Point(12, 94);
            this.Arraybox.Name = "Arraybox";
            this.Arraybox.Size = new System.Drawing.Size(139, 436);
            this.Arraybox.TabIndex = 7;
            this.Arraybox.Click += new System.EventHandler(this.Arraybox_Click);
            // 
            // deletbutton
            // 
            this.deletbutton.Location = new System.Drawing.Point(177, 292);
            this.deletbutton.Name = "deletbutton";
            this.deletbutton.Size = new System.Drawing.Size(75, 23);
            this.deletbutton.TabIndex = 8;
            this.deletbutton.Text = "Delete";
            this.deletbutton.UseVisualStyleBackColor = true;
            this.deletbutton.Click += new System.EventHandler(this.deletbutton_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("Perpetua Titling MT", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.richTextBox1.Location = new System.Drawing.Point(12, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(277, 69);
            this.richTextBox1.TabIndex = 9;
            this.richTextBox1.Text = "Astronomical Processing";
            // 
            // bubblesort
            // 
            this.bubblesort.Location = new System.Drawing.Point(177, 156);
            this.bubblesort.Name = "bubblesort";
            this.bubblesort.Size = new System.Drawing.Size(75, 23);
            this.bubblesort.TabIndex = 10;
            this.bubblesort.Text = "Sort";
            this.bubblesort.UseVisualStyleBackColor = true;
            this.bubblesort.Click += new System.EventHandler(this.bubblesort_Click);
            // 
            // TangoInc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(292, 542);
            this.Controls.Add(this.bubblesort);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.deletbutton);
            this.Controls.Add(this.Arraybox);
            this.Controls.Add(this.initilise);
            this.Controls.Add(this.addbutton);
            this.Controls.Add(this.inputbox);
            this.Controls.Add(this.findbutton);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TangoInc";
            this.Text = "Tango Inc.";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button findbutton;
        private System.Windows.Forms.TextBox inputbox;
        private System.Windows.Forms.Button addbutton;
        private System.Windows.Forms.Button initilise;
        private System.Windows.Forms.ListBox Arraybox;
        private System.Windows.Forms.Button deletbutton;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button bubblesort;
    }
}

