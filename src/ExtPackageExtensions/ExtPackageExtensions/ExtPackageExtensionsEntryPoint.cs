using ExtPackageExtensions.Commands;
using ExtPackageExtensions.Events;
using NextDesign.Desktop;
using NextDesign.Desktop.ExtensionPoints;
using NextDesign.Extension;
using System;
using System.Windows;

namespace ExtPackageExtensions
{
    /// <summary>
    /// エクステンションのエントリポイントです
    /// </summary>
    public class ExtPackageExtensionsEntryPoint : ExtensionBase
    {
        /// <summary>
        /// アクティベート時の処理です。
        /// </summary>
        protected override void OnActivate()
        {
            // リボン
            ExtensionPoints.Ribbon.AddTab("ExtPackageExtensions").AddGroup("Group1").AddLargeButton<HelloCommand>("Hello world");

            // イベント
            ExtensionPoints.Events.Application.RegisterOnAfterStart<ApplicationAfterStart>();
        }
    }
}
