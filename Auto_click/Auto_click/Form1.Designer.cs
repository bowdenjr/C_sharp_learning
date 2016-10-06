namespace Auto_click
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
            this.onbutton = new System.Windows.Forms.Button();
            this.offbutton = new System.Windows.Forms.Button();
            this.statusbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // onbutton
            // 
            this.onbutton.Location = new System.Drawing.Point(12, 12);
            this.onbutton.Name = "onbutton";
            this.onbutton.Size = new System.Drawing.Size(118, 67);
            this.onbutton.TabIndex = 0;
            this.onbutton.Text = "ON";
            this.onbutton.UseVisualStyleBackColor = true;
            this.onbutton.Click += new System.EventHandler(this.onbutton_Click);
            // 
            // offbutton
            // 
            this.offbutton.Location = new System.Drawing.Point(136, 12);
            this.offbutton.Name = "offbutton";
            this.offbutton.Size = new System.Drawing.Size(118, 67);
            this.offbutton.TabIndex = 0;
            this.offbutton.Text = "OFF";
            this.offbutton.UseVisualStyleBackColor = true;
            this.offbutton.Click += new System.EventHandler(this.offbutton_Click);
            // 
            // statusbox
            // 
            this.statusbox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.statusbox.Location = new System.Drawing.Point(84, 85);
            this.statusbox.Name = "statusbox";
            this.statusbox.Size = new System.Drawing.Size(100, 20);
            this.statusbox.TabIndex = 1;
            this.statusbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 119);
            this.Controls.Add(this.statusbox);
            this.Controls.Add(this.offbutton);
            this.Controls.Add(this.onbutton);
            this.Name = "Form1";
            this.Text = "Auto Control";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button onbutton;
        private System.Windows.Forms.Button offbutton;
        private System.Windows.Forms.TextBox statusbox;
    }
}

