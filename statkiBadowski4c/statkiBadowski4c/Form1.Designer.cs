
namespace statkiBadowski4c
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.gracz = new System.Windows.Forms.Panel();
            this.komputer = new System.Windows.Forms.Panel();
            this.Info = new System.Windows.Forms.Label();
            this.image = new System.Windows.Forms.ImageList(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.jeden = new System.Windows.Forms.RadioButton();
            this.dwa = new System.Windows.Forms.RadioButton();
            this.trzy = new System.Windows.Forms.RadioButton();
            this.cztery = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gracz
            // 
            this.gracz.Location = new System.Drawing.Point(12, 193);
            this.gracz.Name = "gracz";
            this.gracz.Size = new System.Drawing.Size(500, 500);
            this.gracz.TabIndex = 0;
            // 
            // komputer
            // 
            this.komputer.Location = new System.Drawing.Point(551, 193);
            this.komputer.Name = "komputer";
            this.komputer.Size = new System.Drawing.Size(500, 500);
            this.komputer.TabIndex = 1;
            // 
            // Info
            // 
            this.Info.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Info.Location = new System.Drawing.Point(329, 35);
            this.Info.Name = "Info";
            this.Info.Size = new System.Drawing.Size(381, 66);
            this.Info.TabIndex = 0;
            this.Info.Text = "placeholder";
            // 
            // image
            // 
            this.image.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.image.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("image.ImageStream")));
            this.image.TransparentColor = System.Drawing.Color.Transparent;
            this.image.Images.SetKeyName(0, "statekEnd.png");
            this.image.Images.SetKeyName(1, "statekMid.png");
            this.image.Images.SetKeyName(2, "statekSolo.png");
            this.image.Images.SetKeyName(3, "statekEndfrfr.png");
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.jeden);
            this.panel1.Controls.Add(this.dwa);
            this.panel1.Controls.Add(this.trzy);
            this.panel1.Controls.Add(this.cztery);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(206, 107);
            this.panel1.TabIndex = 2;
            // 
            // jeden
            // 
            this.jeden.AutoSize = true;
            this.jeden.Location = new System.Drawing.Point(3, 78);
            this.jeden.Name = "jeden";
            this.jeden.Size = new System.Drawing.Size(114, 19);
            this.jeden.TabIndex = 3;
            this.jeden.TabStop = true;
            this.jeden.Text = "Statki 1 kratkowe";
            this.jeden.UseVisualStyleBackColor = true;
            // 
            // dwa
            // 
            this.dwa.AutoSize = true;
            this.dwa.Location = new System.Drawing.Point(3, 53);
            this.dwa.Name = "dwa";
            this.dwa.Size = new System.Drawing.Size(114, 19);
            this.dwa.TabIndex = 2;
            this.dwa.TabStop = true;
            this.dwa.Text = "Statki 2 kratkowe";
            this.dwa.UseVisualStyleBackColor = true;
            // 
            // trzy
            // 
            this.trzy.AutoSize = true;
            this.trzy.Location = new System.Drawing.Point(3, 28);
            this.trzy.Name = "trzy";
            this.trzy.Size = new System.Drawing.Size(114, 19);
            this.trzy.TabIndex = 1;
            this.trzy.TabStop = true;
            this.trzy.Text = "Statki 3 kratkowe";
            this.trzy.UseVisualStyleBackColor = true;
            // 
            // cztery
            // 
            this.cztery.AutoSize = true;
            this.cztery.Location = new System.Drawing.Point(3, 3);
            this.cztery.Name = "cztery";
            this.cztery.Size = new System.Drawing.Size(117, 19);
            this.cztery.TabIndex = 0;
            this.cztery.TabStop = true;
            this.cztery.Text = "Statek 4 kratkowy";
            this.cztery.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1063, 705);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Info);
            this.Controls.Add(this.komputer);
            this.Controls.Add(this.gracz);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel gracz;
        private System.Windows.Forms.Panel komputer;
        private System.Windows.Forms.Label Info;
        private System.Windows.Forms.ImageList image;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton jeden;
        private System.Windows.Forms.RadioButton dwa;
        private System.Windows.Forms.RadioButton trzy;
        private System.Windows.Forms.RadioButton cztery;
    }
}
