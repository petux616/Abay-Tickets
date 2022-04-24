
namespace Abay_Tickets
{
    partial class main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            System.Windows.Forms.Label point_ALabel;
            System.Windows.Forms.Label point_BLabel;
            System.Windows.Forms.Label bus_nameLabel;
            System.Windows.Forms.Label dateLabel;
            System.Windows.Forms.Label passanger_nameLabel;
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataSet1 = new Abay_Tickets.DataSet1();
            this.bookingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bookingBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bookingBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.point_ATextBox = new System.Windows.Forms.TextBox();
            this.point_BTextBox = new System.Windows.Forms.TextBox();
            this.bus_nameTextBox = new System.Windows.Forms.TextBox();
            this.dateTextBox = new System.Windows.Forms.TextBox();
            this.passanger_nameTextBox = new System.Windows.Forms.TextBox();
            this.bookingDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            point_ALabel = new System.Windows.Forms.Label();
            point_BLabel = new System.Windows.Forms.Label();
            bus_nameLabel = new System.Windows.Forms.Label();
            dateLabel = new System.Windows.Forms.Label();
            passanger_nameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingBindingNavigator)).BeginInit();
            this.bookingBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookingDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(838, 282);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(334, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Booking";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bookingBindingSource
            // 
            this.bookingBindingSource.DataMember = "booking";
            this.bookingBindingSource.DataSource = this.dataSet1;
            // 
            // bookingBindingNavigator
            // 
            this.bookingBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bookingBindingNavigator.BindingSource = this.bookingBindingSource;
            this.bookingBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.bookingBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bookingBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bookingBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.bookingBindingNavigatorSaveItem});
            this.bookingBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.bookingBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bookingBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bookingBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bookingBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bookingBindingNavigator.Name = "bookingBindingNavigator";
            this.bookingBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.bookingBindingNavigator.Size = new System.Drawing.Size(820, 27);
            this.bookingBindingNavigator.TabIndex = 3;
            this.bookingBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bookingBindingNavigatorSaveItem
            // 
            this.bookingBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bookingBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("bookingBindingNavigatorSaveItem.Image")));
            this.bookingBindingNavigatorSaveItem.Name = "bookingBindingNavigatorSaveItem";
            this.bookingBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.bookingBindingNavigatorSaveItem.Text = "Save Data";
            this.bookingBindingNavigatorSaveItem.Click += new System.EventHandler(this.bookingBindingNavigatorSaveItem_Click);
            // 
            // point_ALabel
            // 
            point_ALabel.AutoSize = true;
            point_ALabel.Location = new System.Drawing.Point(12, 118);
            point_ALabel.Name = "point_ALabel";
            point_ALabel.Size = new System.Drawing.Size(56, 17);
            point_ALabel.TabIndex = 3;
            point_ALabel.Text = "point A:";
            // 
            // point_ATextBox
            // 
            this.point_ATextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bookingBindingSource, "point A", true));
            this.point_ATextBox.Location = new System.Drawing.Point(137, 115);
            this.point_ATextBox.Name = "point_ATextBox";
            this.point_ATextBox.Size = new System.Drawing.Size(242, 22);
            this.point_ATextBox.TabIndex = 4;
            // 
            // point_BLabel
            // 
            point_BLabel.AutoSize = true;
            point_BLabel.Location = new System.Drawing.Point(12, 146);
            point_BLabel.Name = "point_BLabel";
            point_BLabel.Size = new System.Drawing.Size(56, 17);
            point_BLabel.TabIndex = 5;
            point_BLabel.Text = "point B:";
            // 
            // point_BTextBox
            // 
            this.point_BTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bookingBindingSource, "point B", true));
            this.point_BTextBox.Location = new System.Drawing.Point(137, 143);
            this.point_BTextBox.Name = "point_BTextBox";
            this.point_BTextBox.Size = new System.Drawing.Size(242, 22);
            this.point_BTextBox.TabIndex = 6;
            // 
            // bus_nameLabel
            // 
            bus_nameLabel.AutoSize = true;
            bus_nameLabel.Location = new System.Drawing.Point(12, 174);
            bus_nameLabel.Name = "bus_nameLabel";
            bus_nameLabel.Size = new System.Drawing.Size(75, 17);
            bus_nameLabel.TabIndex = 7;
            bus_nameLabel.Text = "Bus name:";
            // 
            // bus_nameTextBox
            // 
            this.bus_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bookingBindingSource, "Bus name", true));
            this.bus_nameTextBox.Location = new System.Drawing.Point(137, 171);
            this.bus_nameTextBox.Name = "bus_nameTextBox";
            this.bus_nameTextBox.Size = new System.Drawing.Size(242, 22);
            this.bus_nameTextBox.TabIndex = 8;
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Location = new System.Drawing.Point(12, 202);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new System.Drawing.Size(42, 17);
            dateLabel.TabIndex = 9;
            dateLabel.Text = "Date:";
            // 
            // dateTextBox
            // 
            this.dateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bookingBindingSource, "Date", true));
            this.dateTextBox.Location = new System.Drawing.Point(137, 199);
            this.dateTextBox.Name = "dateTextBox";
            this.dateTextBox.Size = new System.Drawing.Size(242, 22);
            this.dateTextBox.TabIndex = 10;
            // 
            // passanger_nameLabel
            // 
            passanger_nameLabel.AutoSize = true;
            passanger_nameLabel.Location = new System.Drawing.Point(12, 230);
            passanger_nameLabel.Name = "passanger_nameLabel";
            passanger_nameLabel.Size = new System.Drawing.Size(119, 17);
            passanger_nameLabel.TabIndex = 11;
            passanger_nameLabel.Text = "Passanger name:";
            // 
            // passanger_nameTextBox
            // 
            this.passanger_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bookingBindingSource, "Passanger name", true));
            this.passanger_nameTextBox.Location = new System.Drawing.Point(137, 227);
            this.passanger_nameTextBox.Name = "passanger_nameTextBox";
            this.passanger_nameTextBox.Size = new System.Drawing.Size(242, 22);
            this.passanger_nameTextBox.TabIndex = 12;
            // 
            // bookingDataGridView
            // 
            this.bookingDataGridView.AutoGenerateColumns = false;
            this.bookingDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bookingDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.bookingDataGridView.DataSource = this.bookingBindingSource;
            this.bookingDataGridView.Location = new System.Drawing.Point(-1, 322);
            this.bookingDataGridView.Name = "bookingDataGridView";
            this.bookingDataGridView.RowHeadersWidth = 51;
            this.bookingDataGridView.RowTemplate.Height = 24;
            this.bookingDataGridView.Size = new System.Drawing.Size(821, 167);
            this.bookingDataGridView.TabIndex = 13;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "point A";
            this.dataGridViewTextBoxColumn1.HeaderText = "point A";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "point B";
            this.dataGridViewTextBoxColumn2.HeaderText = "point B";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Bus name";
            this.dataGridViewTextBoxColumn3.HeaderText = "Bus name";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Date";
            this.dataGridViewTextBoxColumn4.HeaderText = "Date";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Passanger name";
            this.dataGridViewTextBoxColumn5.HeaderText = "Passanger name";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(820, 637);
            this.Controls.Add(this.bookingDataGridView);
            this.Controls.Add(point_ALabel);
            this.Controls.Add(this.point_ATextBox);
            this.Controls.Add(point_BLabel);
            this.Controls.Add(this.point_BTextBox);
            this.Controls.Add(bus_nameLabel);
            this.Controls.Add(this.bus_nameTextBox);
            this.Controls.Add(dateLabel);
            this.Controls.Add(this.dateTextBox);
            this.Controls.Add(passanger_nameLabel);
            this.Controls.Add(this.passanger_nameTextBox);
            this.Controls.Add(this.bookingBindingNavigator);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "main";
            this.Text = "main";
            this.Load += new System.EventHandler(this.main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingBindingNavigator)).EndInit();
            this.bookingBindingNavigator.ResumeLayout(false);
            this.bookingBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookingDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource bookingBindingSource;
        private System.Windows.Forms.BindingNavigator bookingBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton bookingBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox point_ATextBox;
        private System.Windows.Forms.TextBox point_BTextBox;
        private System.Windows.Forms.TextBox bus_nameTextBox;
        private System.Windows.Forms.TextBox dateTextBox;
        private System.Windows.Forms.TextBox passanger_nameTextBox;
        private System.Windows.Forms.DataGridView bookingDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}