﻿using System.IO;
using UnityEngine;
using ToolbarControl_NS;
using System.Reflection;

namespace QuickIVA
{
    [KSPAddon(KSPAddon.Startup.MainMenu, true)]
    public class RegisterToolbar : MonoBehaviour
    {
        public static string VERSION;
        public static string MOD = "";
        public static string relativePath;
        public static string PATH = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location).Replace(@"\", "/") + "/../";

        void Start()
        {
            ToolbarControl.RegisterMod(QStockToolbar.MODID, QStockToolbar.MODNAME);

            VERSION = Assembly.GetExecutingAssembly().GetName().Version.Major + "." + Assembly.GetExecutingAssembly().GetName().Version.Minor + Assembly.GetExecutingAssembly().GetName().Version.Build;
            MOD = Assembly.GetExecutingAssembly().GetName().Name;
            relativePath =  MOD;
            PATH = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "/../";

            QStockToolbar.TexturePath = relativePath + "/Textures/StockToolBar";

        }
    }
}