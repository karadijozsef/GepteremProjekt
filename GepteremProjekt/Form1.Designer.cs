namespace GepteremProjekt
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
            this.ertekelespanel = new System.Windows.Forms.Panel();
            this.savebutton = new System.Windows.Forms.Button();
            this.jobbrabutton = new System.Windows.Forms.Button();
            this.balrabutton = new System.Windows.Forms.Button();
            this.pictureBox_image = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_image)).BeginInit();
            this.SuspendLayout();
            // 
            // ertekelespanel
            // 
            this.ertekelespanel.Location = new System.Drawing.Point(379, 28);
            this.ertekelespanel.Name = "ertekelespanel";
            this.ertekelespanel.Size = new System.Drawing.Size(409, 273);
            this.ertekelespanel.TabIndex = 4;
            // 
            // savebutton
            // 
            this.savebutton.BackgroundImage = global::GepteremProjekt.Properties.Resources.ment;
            this.savebutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.savebutton.Location = new System.Drawing.Point(122, 270);
            this.savebutton.Name = "savebutton";
            this.savebutton.Size = new System.Drawing.Size(134, 126);
            this.savebutton.TabIndex = 3;
            this.savebutton.UseVisualStyleBackColor = true;
            this.savebutton.Click += new System.EventHandler(this.savebutton_Click);
            // 
            // jobbrabutton
            // 
            this.jobbrabutton.BackgroundImage = global::GepteremProjekt.Properties.Resources.jobb;
            this.jobbrabutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.jobbrabutton.Location = new System.Drawing.Point(262, 108);
            this.jobbrabutton.Name = "jobbrabutton";
            this.jobbrabutton.Size = new System.Drawing.Size(111, 85);
            this.jobbrabutton.TabIndex = 2;
            this.jobbrabutton.UseVisualStyleBackColor = true;
            this.jobbrabutton.Click += new System.EventHandler(this.jobbrabutton_Click);
            // 
            // balrabutton
            // 
            this.balrabutton.BackgroundImage = global::GepteremProjekt.Properties.Resources.bal;
            this.balrabutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.balrabutton.Location = new System.Drawing.Point(12, 108);
            this.balrabutton.Name = "balrabutton";
            this.balrabutton.Size = new System.Drawing.Size(101, 85);
            this.balrabutton.TabIndex = 1;
            this.balrabutton.UseVisualStyleBackColor = true;
            this.balrabutton.Click += new System.EventHandler(this.balrabutton_Click);
            // 
            // pictureBox_image
            // 
            this.pictureBox_image.Location = new System.Drawing.Point(122, 45);
            this.pictureBox_image.Name = "pictureBox_image";
            this.pictureBox_image.Size = new System.Drawing.Size(134, 180);
            this.pictureBox_image.TabIndex = 0;
            this.pictureBox_image.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ertekelespanel);
            this.Controls.Add(this.savebutton);
            this.Controls.Add(this.jobbrabutton);
            this.Controls.Add(this.balrabutton);
            this.Controls.Add(this.pictureBox_image);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_image)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_image;
        private System.Windows.Forms.Button balrabutton;
        private System.Windows.Forms.Button jobbrabutton;
        private System.Windows.Forms.Button savebutton;
        private System.Windows.Forms.Panel ertekelespanel;
    }
}

