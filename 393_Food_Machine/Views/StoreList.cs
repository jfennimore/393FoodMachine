using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _393_Food_Machine.Views
{
    public partial class StoreList : Form
    {
        private List<Store> storeList;

        public StoreList()
        {
            InitializeComponent();
            //API Pull all Stores
        }

        private void newStoreButton_Click(object sender, EventArgs e)
        {
            (new EditStore()).Show();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void storeListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = storeListBox.SelectedIndex;
            String jsonStore = storeList.ElementAt(index).ToString();
            (new EditStore(jsonStore)).Show();
            this.Close();
        }
    }
}
