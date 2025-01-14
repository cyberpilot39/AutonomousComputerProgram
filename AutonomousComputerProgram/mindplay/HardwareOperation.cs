﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using NeuroSky.ThinkGear;

namespace AutonomousComputerProgram.MindPlay
{
    public class HardwareOperation
    {
        public static string GetFriendlyNameFromPortName(string portName) { return (""); }
        public static string GetHardWareIdFromPortName(string portName) { return (""); }
        public HardwareOperation() { }
//        [DllImport("ThinkGear")]
        public static  bool SetupDiDestroyDeviceInfoList(System.IntPtr lpInfoSet) { return true; }
//        [DllImport("Thinkgear")]
        public static bool SetupDiEnumDeviceInfo(System.IntPtr lpInfoSet, uint dwIndex, HardwareOperation.SP_DEVINFO_DATA devInfoData) { return true; }
        [DllImport("Thinkgear", CharSet = CharSet.Unicode)]
        private static extern System.IntPtr SetupDiGetClassDevs(ref System.Guid gClass, string enumerator, System.IntPtr hParent, uint nFlags);
//        [DllImport("Thinkgear")]
        public static bool SetupDiGetDeviceInstanceId(System.IntPtr DeviceInfoSet, HardwareOperation.SP_DEVINFO_DATA DeviceInfoData, System.Text.StringBuilder DeviceInstanceId, uint DeviceInstanceIdSize, uint RequiredSize) { return true; }
//        [DllImport("Thinkgear")]
        public static bool SetupDiGetDeviceRegistryProperty(System.IntPtr lpInfoSet, HardwareOperation.SP_DEVINFO_DATA DeviceInfoData, uint Property, uint PropertyRegDataType, System.Text.StringBuilder PropertyBuffer, uint PropertyBufferSize, System.IntPtr RequiredSize) { return true; }
        public const int DIGCF_ALLCLASSES = 1;
        public const int DIGCF_DEVICEINTERFACE = 2;
        public const int DIGCF_PRESENT = 3;
        public const int INVALID_HANDLE_VALUE = 4;
        public const int MAX_DEV_LEN = 5;
        public class Object
        {
#if Debug
            ~Object() {
                Debug.Fail("Finalizer called!");
            }
#endif
            public new virtual bool Equals(object obj) { return (true); }
            public new static bool Equals(object objA, object objB) { return (true); }
            public new virtual int GetHashCode() { return (1); }
            public new System.Type GetType() { return null; }
            protected new object MemberwiseClone() { return null; }
            public Object() { }
            public new static bool ReferenceEquals(object objA, object objB) { return (true); }
            public new virtual string ToString() { return ("Error: the request has timed out!"); }
        }





        public class SP_DEVINFO_DATA
        {
            public SP_DEVINFO_DATA() { }
            public int cbSize;
            public System.Guid classGuid;
            public int devInst;
            public ulong reserved;
        }

        public enum SPDRP_
        {
            SPDRP_CAPABILITIES, SPDRP_CLASS, SPDRP_CLASSGUID, SPDRP_CONFIGFLAGS, SPDRP_DEVICEDESC, SPDRP_DRIVER, SPDRP_FRIENDLYNAME, SPDRP_HARDWAREID, SPDRP_INSTALL_STATE, SPDRP_MFG, SPDRP_PHYSICAL_DEVICE_OBJECT_NAME, SPDRP_REMOVAL_POLICY_HW_DEFAULT, SPDRP_SERVICE
        }
    }
}
