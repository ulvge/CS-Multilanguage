using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _23_Multilanguage {
    class SetMultiLang {
        public static void SetLanguage(string lang) {
            System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(lang);
            Properties.Settings.Default.DefaultLanguage = lang;
            Properties.Settings.Default.Save();

            foreach (Form form in Application.OpenForms) {
                LoadLanguage(form, form.GetType());

                //右键菜单找不到，需要通过反射。菜单栏，可以找到，不需要反射
                ContextMenuStrip contextMenuStrip = FrmMain_FindContextMenuStrip(form);
                if (contextMenuStrip != null) {
                    LoadLanguage(contextMenuStrip, form.GetType());
                }
            }
        }

        public static string getResource(object obj, string name) {
            string astring = string.Empty;
            // System.Reflection.Assembly为资源的主程序集，这里为Demo
            Type type = obj.GetType();
            try {
                ResourceManager resManagerA = new ResourceManager(type);
                astring = resManagerA.GetString(name);
            } catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }
            return astring;
        }
        public static void LoadLanguage(Control control, Type formType) {
            if (control != null) {
                ComponentResourceManager resources = new ComponentResourceManager(formType);
                resources.ApplyResources(control, "$this");
                LoadingControl(control, resources);
            }
        }
        private static void LoadingControl(Control control, ComponentResourceManager resources) {
            if (control is MenuStrip) {
                //将资源与控件对应
                MenuStrip ms = (MenuStrip)control;
                resources.ApplyResources(ms, ms.Name);
                foreach (ToolStripMenuItem c in ms.Items) {
                    //遍历菜单
                    LoadingToolStripMenu(c, resources);
                }
            }
            if (control is ContextMenuStrip) {
                //将资源与控件对应
                ContextMenuStrip ms = (ContextMenuStrip)control;
                resources.ApplyResources(ms, ms.Name);
                Console.WriteLine("ContextMenuStrip:" + ms.Name);
                foreach (ToolStripMenuItem tsm in ms.Items) {
                    Console.WriteLine("ToolStripMenuItem:" + tsm.Name);
                    //遍历菜单
                    LoadingToolStripMenu(tsm, resources);//会打印此级菜单的所有子菜单，即一次性打印完成
                }
            }

            foreach (Control c in control.Controls) {
                resources.ApplyResources(c, c.Name);
                LoadingControl(c, resources);
            }
        }
        private static void LoadingToolStripMenu(ToolStripMenuItem item, ComponentResourceManager resources) {
            if (item is ToolStripMenuItem) {
                resources.ApplyResources(item, item.Name);

                foreach (ToolStripMenuItem c in item.DropDownItems) {
                    Console.WriteLine("LoadingToolStripMenu:" + c.Name);
                    LoadingToolStripMenu(c, resources);
                    c.CheckState = CheckState.Unchecked;
                }
            } else {
                Console.WriteLine("LoadingToolStripMenu: err.................");
            }
        }
        /// <summary>
        ///  搜索Form的ContextMenuStrip
        ///  右键菜单找不到，需要通过反射。菜单栏，可以找到，不需要反射
        ///  https://blog.csdn.net/CodeMJ/article/details/85233513
        /// </summary>
        /// <param name="form"></param>
        private static ContextMenuStrip FrmMain_FindContextMenuStrip(Form form) {
            if (form is null) return null;
            System.Reflection.FieldInfo[] fieldInfo = form.GetType().GetFields(System.Reflection.BindingFlags.NonPublic |
            System.Reflection.BindingFlags.Instance);
            for (int i = 0; i < fieldInfo.Length; i++) {
                switch (fieldInfo[i].FieldType.Name) {
                    case "ContextMenuStrip": {
                            ContextMenuStrip contextMenuStrip = (ContextMenuStrip)fieldInfo[i].GetValue(form);
                            return contextMenuStrip;
                        }
                }
            }
            return null;
        }
    }
}
