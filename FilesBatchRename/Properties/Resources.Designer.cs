﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace FilesBatchRename.Properties {
    using System;
    
    
    /// <summary>
    ///   一个强类型的资源类，用于查找本地化的字符串等。
    /// </summary>
    // 此类是由 StronglyTypedResourceBuilder
    // 类通过类似于 ResGen 或 Visual Studio 的工具自动生成的。
    // 若要添加或移除成员，请编辑 .ResX 文件，然后重新运行 ResGen
    // (以 /str 作为命令选项)，或重新生成 VS 项目。
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   返回此类使用的缓存的 ResourceManager 实例。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("FilesBatchRename.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   重写当前线程的 CurrentUICulture 属性，对
        ///   使用此强类型资源类的所有资源查找执行重写。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   查找类似 请填写要删除的内容！ 的本地化字符串。
        /// </summary>
        internal static string DeleteContent {
            get {
                return ResourceManager.GetString("DeleteContent", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 所有文件(*.*)|*.* 的本地化字符串。
        /// </summary>
        internal static string DialogFilterText {
            get {
                return ResourceManager.GetString("DialogFilterText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 文件夹路径不能为空 的本地化字符串。
        /// </summary>
        internal static string FilePathIsNotEmpty {
            get {
                return ResourceManager.GetString("FilePathIsNotEmpty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 路径不存在！请重新输入 的本地化字符串。
        /// </summary>
        internal static string FilePathIsNotExists {
            get {
                return ResourceManager.GetString("FilePathIsNotExists", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 自定义的插入位置必须大于0 的本地化字符串。
        /// </summary>
        internal static string GreaterThanZero {
            get {
                return ResourceManager.GetString("GreaterThanZero", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 请填写要插入的内容！ 的本地化字符串。
        /// </summary>
        internal static string NewContent {
            get {
                return ResourceManager.GetString("NewContent", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 请填写新的扩展名！ 的本地化字符串。
        /// </summary>
        internal static string NewExtension {
            get {
                return ResourceManager.GetString("NewExtension", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 请填写新的文件名！ 的本地化字符串。
        /// </summary>
        internal static string NewFileName {
            get {
                return ResourceManager.GetString("NewFileName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 请先调整配置！ 的本地化字符串。
        /// </summary>
        internal static string OptionFirst {
            get {
                return ResourceManager.GetString("OptionFirst", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 要删除的字符开始位置以及删除个数都必须大于0！ 的本地化字符串。
        /// </summary>
        internal static string PositionAndCountMustGreaterThanZero {
            get {
                return ResourceManager.GetString("PositionAndCountMustGreaterThanZero", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 请填写要查找的内容！ 的本地化字符串。
        /// </summary>
        internal static string SearchContent {
            get {
                return ResourceManager.GetString("SearchContent", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 提示 的本地化字符串。
        /// </summary>
        internal static string Tips {
            get {
                return ResourceManager.GetString("Tips", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 文件总数： 的本地化字符串。
        /// </summary>
        internal static string TotalFileCount {
            get {
                return ResourceManager.GetString("TotalFileCount", resourceCulture);
            }
        }
    }
}