﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Throne.World.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class StrRes {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal StrRes() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Throne.World.Properties.StrRes", typeof(StrRes).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
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
        ///   Looks up a localized string similar to Executing this command will permanently drop the entire database. Continue? (Y/N).
        /// </summary>
        internal static string CMD_DropDb {
            get {
                return ResourceManager.GetString("CMD_DropDb", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Executing this command will permanently overwrite the entire database. Continue? (Y/N).
        /// </summary>
        internal static string CMD_OverwriteDb {
            get {
                return ResourceManager.GetString("CMD_OverwriteDb", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Authentication failed..
        /// </summary>
        internal static string CMSG_AuthenticationFailed {
            get {
                return ResourceManager.GetString("CMSG_AuthenticationFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The name is unavailable. Please choose a different name..
        /// </summary>
        internal static string CMSG_CharacterNameUnavailable {
            get {
                return ResourceManager.GetString("CMSG_CharacterNameUnavailable", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The item could not be found in your inventory..
        /// </summary>
        internal static string CMSG_InventoryNoItem {
            get {
                return ResourceManager.GetString("CMSG_InventoryNoItem", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Not enough inventory space. (Need {0}).
        /// </summary>
        internal static string CMSG_NotEnoughInventorySpace {
            get {
                return ResourceManager.GetString("CMSG_NotEnoughInventorySpace", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Requested an invalid portal. {0}.
        /// </summary>
        internal static string MSG_NoPortalHere {
            get {
                return ResourceManager.GetString("MSG_NoPortalHere", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Bad backlog value given in {0}. Backlog of 10 to 100 recommended..
        /// </summary>
        internal static string SMSG_BacklogRecommend {
            get {
                return ResourceManager.GetString("SMSG_BacklogRecommend", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Building map database..
        /// </summary>
        internal static string SMSG_BuildMapDb {
            get {
                return ResourceManager.GetString("SMSG_BuildMapDb", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A task ({0}) tried to begin before the object was ready..
        /// </summary>
        internal static string SMSG_CharacterObjectNotReadyForTasks {
            get {
                return ResourceManager.GetString("SMSG_CharacterObjectNotReadyForTasks", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to CharacterTimer:ActorTimer for task: {0}.
        /// </summary>
        internal static string SMSG_CharacterTimerString {
            get {
                return ResourceManager.GetString("SMSG_CharacterTimerString", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to There were not enough strings..
        /// </summary>
        internal static string SMSG_ChatMessageBadStrings {
            get {
                return ResourceManager.GetString("SMSG_ChatMessageBadStrings", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The message was empty..
        /// </summary>
        internal static string SMSG_ChatMessageEmpty {
            get {
                return ResourceManager.GetString("SMSG_ChatMessageEmpty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Message sender doesn&apos;t match..
        /// </summary>
        internal static string SMSG_ChatMessageInvalidSender {
            get {
                return ResourceManager.GetString("SMSG_ChatMessageInvalidSender", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot send more than 17 items. (byte limit overflow).
        /// </summary>
        internal static string SMSG_DepositoryByteLimitOverflow {
            get {
                return ResourceManager.GetString("SMSG_DepositoryByteLimitOverflow", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Script classes must have unique names, duplicate &apos;{0}&apos; found in &apos;{1}&apos;..
        /// </summary>
        internal static string SMSG_DuplicateScript {
            get {
                return ResourceManager.GetString("SMSG_DuplicateScript", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The IP address provided in {0} is invalid..
        /// </summary>
        internal static string SMSG_HostInvalid {
            get {
                return ResourceManager.GetString("SMSG_HostInvalid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The incoming packet footer value in {0} cannot be empty and must be 8 characters long..
        /// </summary>
        internal static string SMSG_IncomingFooterInvalid {
            get {
                return ResourceManager.GetString("SMSG_IncomingFooterInvalid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Contacting {0} service..
        /// </summary>
        internal static string SMSG_IPCDeviceConnect {
            get {
                return ResourceManager.GetString("SMSG_IPCDeviceConnect", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Established a connection with {0} service..
        /// </summary>
        internal static string SMSG_IPCDeviceConnected {
            get {
                return ResourceManager.GetString("SMSG_IPCDeviceConnected", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Loading of one or multiple types in &apos;{0}&apos; failed, classes in this file won&apos;t be loaded. Naming in main source may have changed. Delete the cache folder if this error persists..
        /// </summary>
        internal static string SMSG_LoadScriptAssemblyFailed {
            get {
                return ResourceManager.GetString("SMSG_LoadScriptAssemblyFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Logged in..
        /// </summary>
        internal static string SMSG_LoggedIn {
            get {
                return ResourceManager.GetString("SMSG_LoggedIn", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Logged out..
        /// </summary>
        internal static string SMSG_LoggedOut {
            get {
                return ResourceManager.GetString("SMSG_LoggedOut", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Done fetching info for {0} maps. (of {1}).
        /// </summary>
        internal static string SMSG_MapBuildDone {
            get {
                return ResourceManager.GetString("SMSG_MapBuildDone", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Map data file not found..
        /// </summary>
        internal static string SMSG_MapDataNotFound {
            get {
                return ResourceManager.GetString("SMSG_MapDataNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Map file not found: {0}.
        /// </summary>
        internal static string SMSG_MapFileNotFound {
            get {
                return ResourceManager.GetString("SMSG_MapFileNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Map index not found at &apos;{0}&apos;..
        /// </summary>
        internal static string SMSG_MapIndexNotFound {
            get {
                return ResourceManager.GetString("SMSG_MapIndexNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Information loaded..
        /// </summary>
        internal static string SMSG_MapLoad {
            get {
                return ResourceManager.GetString("SMSG_MapLoad", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Map was not loaded.
        /// </summary>
        internal static string SMSG_MapNotLoaded {
            get {
                return ResourceManager.GetString("SMSG_MapNotLoaded", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Map ID {0} does not exist..
        /// </summary>
        internal static string SMSG_NonsuchMap {
            get {
                return ResourceManager.GetString("SMSG_NonsuchMap", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Override failed. Script class &apos;{0}&apos; not found ({1} @ {2})..
        /// </summary>
        internal static string SMSG_NonsuchOverride {
            get {
                return ResourceManager.GetString("SMSG_NonsuchOverride", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Remove failed. Script class &apos;{0}&apos; not found ({1} @ {2})..
        /// </summary>
        internal static string SMSG_NonsuchRemove {
            get {
                return ResourceManager.GetString("SMSG_NonsuchRemove", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Document ID {0} is not unique..
        /// </summary>
        internal static string SMSG_NonUniqueMap {
            get {
                return ResourceManager.GetString("SMSG_NonUniqueMap", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Script not found..
        /// </summary>
        internal static string SMSG_NoScript {
            get {
                return ResourceManager.GetString("SMSG_NoScript", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Script list not found at &apos;{0}&apos;..
        /// </summary>
        internal static string SMSG_NoScriptList {
            get {
                return ResourceManager.GetString("SMSG_NoScriptList", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The outgoing packet footer value in {0} cannot be empty and must be 8 characters long..
        /// </summary>
        internal static string SMSG_OutgoingFooterInvalid {
            get {
                return ResourceManager.GetString("SMSG_OutgoingFooterInvalid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The port provided in {0} is invalid..
        /// </summary>
        internal static string SMSG_PortInvalid {
            get {
                return ResourceManager.GetString("SMSG_PortInvalid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Task ({0}) was already running and was overridden..
        /// </summary>
        internal static string SMSG_RunningTaskOverride {
            get {
                return ResourceManager.GetString("SMSG_RunningTaskOverride", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Scenery file not found. {0}.
        /// </summary>
        internal static string SMSG_SceneryNotFound {
            get {
                return ResourceManager.GetString("SMSG_SceneryNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Scenery could not be loaded..
        /// </summary>
        internal static string SMSG_SceneryNotLoaded {
            get {
                return ResourceManager.GetString("SMSG_SceneryNotLoaded", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Error while loading script &apos;{0}&apos; ({1})..
        /// </summary>
        internal static string SMSG_ScriptExcption {
            get {
                return ResourceManager.GetString("SMSG_ScriptExcption", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to initiate &apos;{0}&apos;..
        /// </summary>
        internal static string SMSG_ScriptInitiateFailed {
            get {
                return ResourceManager.GetString("SMSG_ScriptInitiateFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Done loading {0} scripts (of {1})..
        /// </summary>
        internal static string SMSG_ScriptListLoaded {
            get {
                return ResourceManager.GetString("SMSG_ScriptListLoaded", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Loading scripts, this might take a few minutes....
        /// </summary>
        internal static string SMSG_ScriptLoad {
            get {
                return ResourceManager.GetString("SMSG_ScriptLoad", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to (Jump) lost synchronization..
        /// </summary>
        internal static string SMSG_SynchroLost {
            get {
                return ResourceManager.GetString("SMSG_SynchroLost", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Warp info for index {0} in map {1} does not exist..
        /// </summary>
        internal static string SMSG_WarpNotFound {
            get {
                return ResourceManager.GetString("SMSG_WarpNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ({0}) The gear unequip position requested matches the slot, but not the item&apos;s position..
        /// </summary>
        internal static string VMSG_ItemSlotMismatch {
            get {
                return ResourceManager.GetString("VMSG_ItemSlotMismatch", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ({0}) An attempt was made to unequip an empty slot..
        /// </summary>
        internal static string VMSG_NoEquip {
            get {
                return ResourceManager.GetString("VMSG_NoEquip", resourceCulture);
            }
        }
    }
}