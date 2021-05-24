
namespace FacebookBackupViewer
{
    partial class ucMessage
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblSenderName = new System.Windows.Forms.Label();
            this.lblTimestamp = new System.Windows.Forms.Label();
            this.lblContent = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblSenderName
            // 
            this.lblSenderName.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenderName.Location = new System.Drawing.Point(0, 0);
            this.lblSenderName.Name = "lblSenderName";
            this.lblSenderName.Size = new System.Drawing.Size(700, 23);
            this.lblSenderName.TabIndex = 0;
            this.lblSenderName.Text = "sender_name";
            // 
            // lblTimestamp
            // 
            this.lblTimestamp.Location = new System.Drawing.Point(0, 23);
            this.lblTimestamp.Name = "lblTimestamp";
            this.lblTimestamp.Size = new System.Drawing.Size(700, 17);
            this.lblTimestamp.TabIndex = 1;
            this.lblTimestamp.Text = "timestamp";
            // 
            // lblContent
            // 
            this.lblContent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblContent.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblContent.Location = new System.Drawing.Point(0, 38);
            this.lblContent.Name = "lblContent";
            this.lblContent.Size = new System.Drawing.Size(698, 60);
            this.lblContent.TabIndex = 2;
            this.lblContent.Text = "content";
            // 
            // ucMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lblContent);
            this.Controls.Add(this.lblTimestamp);
            this.Controls.Add(this.lblSenderName);
            this.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ucMessage";
            this.Size = new System.Drawing.Size(698, 98);
            this.Load += new System.EventHandler(this.ucMessage_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblSenderName;
        private System.Windows.Forms.Label lblTimestamp;
        private System.Windows.Forms.Label lblContent;
    }
}
