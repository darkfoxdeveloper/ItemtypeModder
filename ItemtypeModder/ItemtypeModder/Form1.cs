using System;
using System.IO;
using System.Windows.Forms;

namespace ItemtypeModder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SetClientLocationBtn_Click(object sender, EventArgs e)
        {
            DialogResult dRes = browserDialog.ShowDialog();
            if (dRes == DialogResult.OK)
            {
                Core.Path = browserDialog.SelectedPath;
                if (!File.Exists(Path.Combine(Core.Path, "Conquer.exe")))
                {
                    Core.Path = "";
                    lblSelectedPath.Text = "Not selected...";
                    MessageBox.Show("Invalid or corrupted client detected", "ItemtypeModder", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (Core.Path.Length > 0)
                {
                    setClientLocationBtn.Enabled = false;
                    lblSelectedPath.Text = Core.Path;
                }
            }
        }

        private void BtnStartModding_Click(object sender, EventArgs e)
        {
            string ItemtypePath = Path.Combine(Core.Path, "ini", "itemtype.dat");
            Itemtype it = new Itemtype(ItemtypePath)
            {
                Separator = " "
            };
            it.Decrypt();
            it.LoadItems();
            foreach(Item item in it.Items)
            {
                item.Import(it.Separator);
                string ItemId = item.Get(Item.Atribute.ID);
                if (ItemId.EndsWith("9"))
                {
                    string oldName = item.Get(Item.Atribute.Name);
                    string qualityIdent = "[S]";
                    if (cbSuper.Checked)
                    {
                        if (!oldName.StartsWith(qualityIdent))
                        {
                            item.Set(Item.Atribute.Name, qualityIdent + oldName);
                        }
                    } else
                    {
                        item.Set(Item.Atribute.Name, oldName.Replace(qualityIdent, ""));
                    }
                }
                if (ItemId.EndsWith("8"))
                {
                    string oldName = item.Get(Item.Atribute.Name);
                    string qualityIdent = "[E]";
                    if (cbElite.Checked)
                    {
                        if (!oldName.StartsWith(qualityIdent))
                        {
                            item.Set(Item.Atribute.Name, qualityIdent + oldName);
                        }
                    }
                    else
                    {
                        item.Set(Item.Atribute.Name, oldName.Replace(qualityIdent, ""));
                    }
                }
                if (ItemId.EndsWith("7"))
                {
                    string oldName = item.Get(Item.Atribute.Name);

                    string qualityIdent = "[U]";
                    if (cbUnique.Checked)
                    {
                        if (!oldName.StartsWith(qualityIdent))
                        {
                            item.Set(Item.Atribute.Name, qualityIdent + oldName);
                        }
                    }
                    else
                    {
                        item.Set(Item.Atribute.Name, oldName.Replace(qualityIdent, ""));
                    }
                }
                if (ItemId.EndsWith("6"))
                {
                    string oldName = item.Get(Item.Atribute.Name);
                    string qualityIdent = "[R]";
                    if (cbRefinated.Checked)
                    {
                        if (!oldName.StartsWith(qualityIdent))
                        {
                            item.Set(Item.Atribute.Name, qualityIdent + oldName);
                        }
                    }
                    else
                    {
                        item.Set(Item.Atribute.Name, oldName.Replace(qualityIdent, ""));
                    }
                }
                if (cbMoonboxTokens.Checked)
                {
                    if (ItemId.Equals("721010"))
                    {
                        item.Set(Item.Atribute.Name, "PeaceToken");
                    }
                    if (ItemId.Equals("721011"))
                    {
                        item.Set(Item.Atribute.Name, "ChaosToken");
                    }
                    if (ItemId.Equals("721012"))
                    {
                        item.Set(Item.Atribute.Name, "DesertedToken");
                    }
                    if (ItemId.Equals("721013"))
                    {
                        item.Set(Item.Atribute.Name, "ProsperousToken");
                    }
                    if (ItemId.Equals("721014"))
                    {
                        item.Set(Item.Atribute.Name, "DisturbedToken");
                    }
                    if (ItemId.Equals("721015"))
                    {
                        item.Set(Item.Atribute.Name, "CalmedToken");
                    }
                } else
                {
                    if (ItemId.Equals("721010"))
                    {
                        item.Set(Item.Atribute.Name, "CommandToken");
                    }
                    if (ItemId.Equals("721011"))
                    {
                        item.Set(Item.Atribute.Name, "CommandToken");
                    }
                    if (ItemId.Equals("721012"))
                    {
                        item.Set(Item.Atribute.Name, "CommandToken");
                    }
                    if (ItemId.Equals("721013"))
                    {
                        item.Set(Item.Atribute.Name, "CommandToken");
                    }
                    if (ItemId.Equals("721014"))
                    {
                        item.Set(Item.Atribute.Name, "CommandToken");
                    }
                    if (ItemId.Equals("721015"))
                    {
                        item.Set(Item.Atribute.Name, "CommandToken");
                    }
                }
                item.Export(it.Separator);
            }
            it.SaveItems();
            lblSelectedPath.Text = "Successfully modded itemtype.";
        }
    }
}
