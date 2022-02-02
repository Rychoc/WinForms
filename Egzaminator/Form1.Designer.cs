
namespace Egzaminator
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.flowLayoutPanelGrid = new System.Windows.Forms.FlowLayoutPanel();
            this.lableProgress = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.lableGameRules = new System.Windows.Forms.Label();
            this.buttonStart = new System.Windows.Forms.Button();
            this.flowLayoutPanelRules = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanelRules.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanelGrid
            // 
            this.flowLayoutPanelGrid.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanelGrid.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.flowLayoutPanelGrid.Location = new System.Drawing.Point(108, 158);
            this.flowLayoutPanelGrid.Name = "flowLayoutPanelGrid";
            this.flowLayoutPanelGrid.Size = new System.Drawing.Size(470, 460);
            this.flowLayoutPanelGrid.TabIndex = 0;
            // 
            // lableProgress
            // 
            this.lableProgress.BackColor = System.Drawing.Color.Transparent;
            this.lableProgress.Font = new System.Drawing.Font("Candara", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lableProgress.Location = new System.Drawing.Point(75, 430);
            this.lableProgress.Margin = new System.Windows.Forms.Padding(75, 0, 0, 0);
            this.lableProgress.Name = "lableProgress";
            this.lableProgress.Size = new System.Drawing.Size(290, 20);
            this.lableProgress.TabIndex = 3;
            this.lableProgress.Text = "Zapełnienie sali obserwatorami:";
            this.lableProgress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // progressBar
            // 
            this.progressBar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.progressBar.Location = new System.Drawing.Point(60, 453);
            this.progressBar.Margin = new System.Windows.Forms.Padding(60, 3, 3, 3);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(335, 15);
            this.progressBar.Step = 1;
            this.progressBar.TabIndex = 0;
            // 
            // lableGameRules
            // 
            this.lableGameRules.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lableGameRules.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lableGameRules.Location = new System.Drawing.Point(75, 100);
            this.lableGameRules.Margin = new System.Windows.Forms.Padding(75, 100, 0, 0);
            this.lableGameRules.Name = "lableGameRules";
            this.lableGameRules.Size = new System.Drawing.Size(290, 330);
            this.lableGameRules.TabIndex = 7;
            this.lableGameRules.Text = resources.GetString("lableGameRules.Text");
            this.lableGameRules.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonStart
            // 
            this.buttonStart.BackColor = System.Drawing.Color.Transparent;
            this.buttonStart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonStart.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonStart.ForeColor = System.Drawing.Color.Black;
            this.buttonStart.Location = new System.Drawing.Point(60, 476);
            this.buttonStart.Margin = new System.Windows.Forms.Padding(60, 5, 0, 0);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(335, 60);
            this.buttonStart.TabIndex = 11;
            this.buttonStart.Text = "Zacznij grę!";
            this.buttonStart.UseVisualStyleBackColor = false;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // flowLayoutPanelRules
            // 
            this.flowLayoutPanelRules.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.flowLayoutPanelRules.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanelRules.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("flowLayoutPanelRules.BackgroundImage")));
            this.flowLayoutPanelRules.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.flowLayoutPanelRules.Controls.Add(this.lableGameRules);
            this.flowLayoutPanelRules.Controls.Add(this.lableProgress);
            this.flowLayoutPanelRules.Controls.Add(this.progressBar);
            this.flowLayoutPanelRules.Controls.Add(this.buttonStart);
            this.flowLayoutPanelRules.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.flowLayoutPanelRules.Location = new System.Drawing.Point(672, 1);
            this.flowLayoutPanelRules.Name = "flowLayoutPanelRules";
            this.flowLayoutPanelRules.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.flowLayoutPanelRules.Size = new System.Drawing.Size(435, 630);
            this.flowLayoutPanelRules.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1108, 630);
            this.Controls.Add(this.flowLayoutPanelRules);
            this.Controls.Add(this.flowLayoutPanelGrid);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sesja Egzaminator";
            this.flowLayoutPanelRules.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelGrid;
        private System.Windows.Forms.Label lableProgress;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label lableGameRules;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelRules;
    }
}

