// ------------------------------------------------------------------------------
//  <auto-generated>
//    Generated by Xsd2Code. Version 2.1.3226.27803
//   <NameSpace>Umc.Core.Tools.VSGesture.Actions</NameSpace><Collection>List</Collection><codeType>CSharp</codeType><EnableDataBinding>False</EnableDataBinding><HidePrivateFieldInIDE>False</HidePrivateFieldInIDE><EnableSummaryComment>False</EnableSummaryComment><CustomUsings></CustomUsings><CollectionBase></CollectionBase>
//  <auto-generated>
// ------------------------------------------------------------------------------
namespace Umc.Core.Tools.VSGesture.Actions {
    using System;
    using System.Diagnostics;
    using System.Xml.Serialization;
    using System.Collections;
    using System.Xml.Schema;
    using System.ComponentModel;
    using System.Collections.Generic;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.3074")]
    //[System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://tempuri.org/VSGestureInfo.xsd")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://tempuri.org/VSGestureInfo.xsd", IsNullable=false)]
    public partial class VSGestureInfo {
        
        private UserSettingsType userSettingsField;
        
        private List<GestureActionMapperTypeGesture> gestureActionMapperField;
        
        public VSGestureInfo() {
            if ((this.gestureActionMapperField == null)) {
                this.gestureActionMapperField = new List<GestureActionMapperTypeGesture>();
            }
            if ((this.userSettingsField == null)) {
                this.userSettingsField = new UserSettingsType();
            }
        }
        
        /// <remarks/>
        public UserSettingsType UserSettings {
            get {
                return this.userSettingsField;
            }
            set {
                this.userSettingsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Gesture", IsNullable=false)]
        public List<GestureActionMapperTypeGesture> GestureActionMapper {
            get {
                return this.gestureActionMapperField;
            }
            set {
                this.gestureActionMapperField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.3074")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/VSGestureInfo.xsd")]
    public partial class UserSettingsType {
        
        private string lineColorField;
        
        private string lineThicknessField;
        
        private bool enableVSGestureField;
        
        private bool enableVSGestureAlramField;
        
        public UserSettingsType() {
            this.lineColorField = "255,0,0";
            this.lineThicknessField = "Thickness5";
            this.enableVSGestureField = true;
            this.enableVSGestureAlramField = true;
        }
        
        /// <remarks/>
        public string LineColor {
            get {
                return this.lineColorField;
            }
            set {
                this.lineColorField = value;
            }
        }
        
        /// <remarks/>
        public string LineThickness {
            get {
                return this.lineThicknessField;
            }
            set {
                this.lineThicknessField = value;
            }
        }
        
        /// <remarks/>
        public bool EnableVSGesture {
            get {
                return this.enableVSGestureField;
            }
            set {
                this.enableVSGestureField = value;
            }
        }
        
        /// <remarks/>
        public bool EnableVSGestureAlram {
            get {
                return this.enableVSGestureAlramField;
            }
            set {
                this.enableVSGestureAlramField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.3074")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://tempuri.org/VSGestureInfo.xsd")]
    public partial class GestureActionMapperTypeGesture {
        
        private GestureActionMapperItems gestureActionTypeField;
        
        private ActionType actionTypeField;
        
        private string gestureItemNameField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public GestureActionMapperItems GestureActionType {
            get {
                return this.gestureActionTypeField;
            }
            set {
                this.gestureActionTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ActionType ActionType {
            get {
                return this.actionTypeField;
            }
            set {
                this.actionTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string GestureItemName {
            get {
                return this.gestureItemNameField;
            }
            set {
                this.gestureItemNameField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.3074")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/VSGestureInfo.xsd")]
    public enum GestureActionMapperItems {
        
        /// <remarks/>
        ArrowDown,
        
        /// <remarks/>
        ArrowLeft,
        
        /// <remarks/>
        ArrowRight,
        
        /// <remarks/>
        ArrowUp,
        
        /// <remarks/>
        Check,
        
        /// <remarks/>
        ChevronDown,
        
        /// <remarks/>
        ChevronLeft,
        
        /// <remarks/>
        ChevronRight,
        
        /// <remarks/>
        ChevronUp,
        
        /// <remarks/>
        Circle,
        
        /// <remarks/>
        Curlicue,
        
        /// <remarks/>
        DoubleCircle,
        
        /// <remarks/>
        DoubleCurlicue,
        
        /// <remarks/>
        DoubleTap,
        
        /// <remarks/>
        Down,
        
        /// <remarks/>
        DownLeft,
        
        /// <remarks/>
        DownLeftLong,
        
        /// <remarks/>
        DownRight,
        
        /// <remarks/>
        DownRightLong,
        
        /// <remarks/>
        DownUp,
        
        /// <remarks/>
        Exclamation,
        
        /// <remarks/>
        Left,
        
        /// <remarks/>
        LeftDown,
        
        /// <remarks/>
        LeftRight,
        
        /// <remarks/>
        LeftUp,
        
        /// <remarks/>
        NoGesture,
        
        /// <remarks/>
        Right,
        
        /// <remarks/>
        RightDown,
        
        /// <remarks/>
        RightLeft,
        
        /// <remarks/>
        RightUp,
        
        /// <remarks/>
        ScratchOut,
        
        /// <remarks/>
        SemicircleLeft,
        
        /// <remarks/>
        SemicircleRight,
        
        /// <remarks/>
        Square,
        
        /// <remarks/>
        Star,
        
        /// <remarks/>
        Tap,
        
        /// <remarks/>
        Triangle,
        
        /// <remarks/>
        Up,
        
        /// <remarks/>
        UpDown,
        
        /// <remarks/>
        UpLeft,
        
        /// <remarks/>
        UpLeftLong,
        
        /// <remarks/>
        UpRight,
        
        /// <remarks/>
        UpRightLong,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.3074")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/VSGestureInfo.xsd")]
    public enum ActionType {
        
        /// <remarks/>
        Action,
        
        /// <remarks/>
        Command,
    }
}
