
namespace ProjectPetShop
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
            this.PanelTop = new System.Windows.Forms.Panel();
            this.btnMin = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.PanelSide = new System.Windows.Forms.Panel();
            this.PanelSelect = new System.Windows.Forms.Panel();
            this.btnClient = new System.Windows.Forms.Button();
            this.btnBooking = new System.Windows.Forms.Button();
            this.btnAnimal = new System.Windows.Forms.Button();
            this.btnService = new System.Windows.Forms.Button();
            this.btnBreed = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.PanelCenter = new System.Windows.Forms.Panel();
            this.PanelTop.SuspendLayout();
            this.PanelSide.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelTop
            // 
            this.PanelTop.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.PanelTop.Controls.Add(this.btnMin);
            this.PanelTop.Controls.Add(this.btnExit);
            this.PanelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTop.Location = new System.Drawing.Point(0, 0);
            this.PanelTop.Name = "PanelTop";
            this.PanelTop.Size = new System.Drawing.Size(998, 55);
            this.PanelTop.TabIndex = 0;
            // 
            // btnMin
            // 
            this.btnMin.FlatAppearance.BorderSize = 0;
            this.btnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMin.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMin.ForeColor = System.Drawing.Color.White;
            this.btnMin.Location = new System.Drawing.Point(841, 3);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(75, 51);
            this.btnMin.TabIndex = 1;
            this.btnMin.Text = "_";
            this.btnMin.UseVisualStyleBackColor = true;
            this.btnMin.Click += new System.EventHandler(this.button1_Click_4);
            // 
            // btnExit
            // 
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(922, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 51);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "x";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.button1_Click_3);
            // 
            // PanelSide
            // 
            this.PanelSide.BackColor = System.Drawing.SystemColors.Highlight;
            this.PanelSide.Controls.Add(this.PanelSelect);
            this.PanelSide.Controls.Add(this.btnClient);
            this.PanelSide.Controls.Add(this.btnBooking);
            this.PanelSide.Controls.Add(this.btnAnimal);
            this.PanelSide.Controls.Add(this.btnService);
            this.PanelSide.Controls.Add(this.btnBreed);
            this.PanelSide.Controls.Add(this.btnHome);
            this.PanelSide.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelSide.Location = new System.Drawing.Point(0, 55);
            this.PanelSide.Name = "PanelSide";
            this.PanelSide.Size = new System.Drawing.Size(255, 529);
            this.PanelSide.TabIndex = 1;
            // 
            // PanelSelect
            // 
            this.PanelSelect.BackColor = System.Drawing.Color.White;
            this.PanelSelect.Location = new System.Drawing.Point(12, 37);
            this.PanelSelect.Name = "PanelSelect";
            this.PanelSelect.Size = new System.Drawing.Size(33, 54);
            this.PanelSelect.TabIndex = 7;
            // 
            // btnClient
            // 
            this.btnClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClient.ForeColor = System.Drawing.Color.White;
            this.btnClient.Location = new System.Drawing.Point(61, 117);
            this.btnClient.Name = "btnClient";
            this.btnClient.Size = new System.Drawing.Size(175, 54);
            this.btnClient.TabIndex = 6;
            this.btnClient.Text = "Clients";
            this.btnClient.UseVisualStyleBackColor = true;
            this.btnClient.Click += new System.EventHandler(this.btnClient_Click);
            // 
            // btnBooking
            // 
            this.btnBooking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBooking.ForeColor = System.Drawing.Color.White;
            this.btnBooking.Location = new System.Drawing.Point(61, 431);
            this.btnBooking.Name = "btnBooking";
            this.btnBooking.Size = new System.Drawing.Size(175, 54);
            this.btnBooking.TabIndex = 4;
            this.btnBooking.Text = "Booking";
            this.btnBooking.UseVisualStyleBackColor = true;
            this.btnBooking.Click += new System.EventHandler(this.btnBooking_Click);
            // 
            // btnAnimal
            // 
            this.btnAnimal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnimal.ForeColor = System.Drawing.Color.White;
            this.btnAnimal.Location = new System.Drawing.Point(61, 272);
            this.btnAnimal.Name = "btnAnimal";
            this.btnAnimal.Size = new System.Drawing.Size(175, 54);
            this.btnAnimal.TabIndex = 3;
            this.btnAnimal.Text = "Animals";
            this.btnAnimal.UseVisualStyleBackColor = true;
            this.btnAnimal.Click += new System.EventHandler(this.btnAnimal_Click);
            // 
            // btnService
            // 
            this.btnService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnService.ForeColor = System.Drawing.Color.White;
            this.btnService.Location = new System.Drawing.Point(61, 353);
            this.btnService.Name = "btnService";
            this.btnService.Size = new System.Drawing.Size(175, 54);
            this.btnService.TabIndex = 2;
            this.btnService.Text = "Services";
            this.btnService.UseVisualStyleBackColor = true;
            this.btnService.Click += new System.EventHandler(this.btnService_Click);
            // 
            // btnBreed
            // 
            this.btnBreed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBreed.ForeColor = System.Drawing.Color.White;
            this.btnBreed.Location = new System.Drawing.Point(61, 196);
            this.btnBreed.Name = "btnBreed";
            this.btnBreed.Size = new System.Drawing.Size(175, 54);
            this.btnBreed.TabIndex = 1;
            this.btnBreed.Text = "Breeds";
            this.btnBreed.UseVisualStyleBackColor = true;
            this.btnBreed.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // btnHome
            // 
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Location = new System.Drawing.Point(61, 37);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(175, 54);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // PanelCenter
            // 
            this.PanelCenter.BackColor = System.Drawing.SystemColors.ControlDark;
            this.PanelCenter.BackgroundImage = global::ProjectPetShop.Properties.Resources._20150718_235853000_iOS;
            this.PanelCenter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PanelCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelCenter.Location = new System.Drawing.Point(255, 55);
            this.PanelCenter.Name = "PanelCenter";
            this.PanelCenter.Size = new System.Drawing.Size(743, 529);
            this.PanelCenter.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 584);
            this.Controls.Add(this.PanelCenter);
            this.Controls.Add(this.PanelSide);
            this.Controls.Add(this.PanelTop);
            this.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.PanelTop.ResumeLayout(false);
            this.PanelSide.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelTop;
        private System.Windows.Forms.Panel PanelSide;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Panel PanelCenter;
        private System.Windows.Forms.Button btnClient;
        private System.Windows.Forms.Button btnBooking;
        private System.Windows.Forms.Button btnAnimal;
        private System.Windows.Forms.Button btnService;
        private System.Windows.Forms.Button btnBreed;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Panel PanelSelect;
    }
}

