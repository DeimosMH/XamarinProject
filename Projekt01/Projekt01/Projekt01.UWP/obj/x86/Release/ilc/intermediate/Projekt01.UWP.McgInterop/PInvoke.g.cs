#define MCG_WINRT_SUPPORTED
using Mcg.System;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.WindowsRuntime;


// -----------------------------------------------------------------------------------------------------------
// 
// WARNING: THIS SOURCE FILE IS FOR 32-BIT BUILDS ONLY!
// 
// MCG GENERATED CODE
// 
// This C# source file is generated by MCG and is added into the application at compile time to support interop features.
// 
// It has three primary components:
// 
// 1. Public type definitions with interop implementation used by this application including WinRT & COM data structures and P/Invokes.
// 
// 2. The '__Interop' class containing marshaling code that acts as a bridge from managed code to native code.
// 
// 3. The 'McgNative' class containing marshaling code and native type definitions that call into native code and are called by native code.
// 
// -----------------------------------------------------------------------------------------------------------
// 
// warning CS0067: The event 'event' is never used
#pragma warning disable 67
// warning CS0169: The field 'field' is never used
#pragma warning disable 169
// warning CS0649: Field 'field' is never assigned to, and will always have its default value 0
#pragma warning disable 414
// warning CS0414: The private field 'field' is assigned but its value is never used
#pragma warning disable 649
// warning CS1591: Missing XML comment for publicly visible type or member 'Type_or_Member'
#pragma warning disable 1591
// warning CS0108 'member1' hides inherited member 'member2'. Use the new keyword if hiding was intended.
#pragma warning disable 108
// warning CS0114 'member1' hides inherited member 'member2'.  To make the current method override that implementation, add the override keyword. Otherwise add the new keyword.
#pragma warning disable 114
// warning CS0659 'type' overrides Object.Equals but does not override GetHashCode.
#pragma warning disable 659
// warning CS0465 Introducing a 'Finalize' method can interfere with destructor invocation. Did you intend to declare a destructor?
#pragma warning disable 465
// warning CS0028 'function declaration' has the wrong signature to be an entry point
#pragma warning disable 28
// warning CS0162 Unreachable code Detected
#pragma warning disable 162
// warning CS0628 new protected member declared in sealed class
#pragma warning disable 628

namespace __Interop
{
	/// <summary>
	/// P/Invoke class for module '[MRT]'
	/// </summary>
	public unsafe static partial class _MRT_
	{
		// Signature, RhWaitForPendingFinalizers, [fwd] [return] [Mcg.CodeGen.VoidReturnMarshaller] void__void, [fwd] [in] [Mcg.CodeGen.BlittableValueMarshaller] int__int, 
		[global::System.Runtime.InteropServices.McgGeneratedMarshallingCode]
		[global::System.Runtime.InteropServices.McgPInvokeMarshalStub("System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Runtime.RuntimeImports", "RhWaitForPendingFinalizers")]
		public static void RhWaitForPendingFinalizers(int allowReentrantWait)
		{
			// Marshalling
			// Call to native method
			global::__Interop._MRT__PInvokes.RhWaitForPendingFinalizers(allowReentrantWait);
			global::System.Runtime.InteropServices.DebugAnnotations.PreviousCallContainsUserCode();
			// Return
		}

		// Signature, _RhYield, [fwd] [return] [Mcg.CodeGen.BlittableValueMarshaller] int__int, 
		[global::System.Runtime.InteropServices.McgGeneratedMarshallingCode]
		[global::System.Runtime.InteropServices.McgPInvokeMarshalStub("System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Runtime.RuntimeImports", "_RhYield")]
		public static int _RhYield()
		{
			// Setup
			int unsafe___value;
			// Marshalling
			// Call to native method
			unsafe___value = global::__Interop._MRT__PInvokes._RhYield();
			global::System.Runtime.InteropServices.DebugAnnotations.PreviousCallContainsUserCode();
			// Return
			return unsafe___value;
		}

		// Signature, RhCompatibleReentrantWaitAny, [fwd] [return] [Mcg.CodeGen.BlittableValueMarshaller] int__int, [fwd] [in] [Mcg.CodeGen.BlittableValueMarshaller] int__int, [fwd] [in] [Mcg.CodeGen.BlittableValueMarshaller] int__int, [fwd] [in] [Mcg.CodeGen.BlittableValueMarshaller] int__int, [fwd] [in] [Mcg.CodeGen.BlittableValueMarshaller] System_IntPtr___ptr__w64 int *, 
		[global::System.Runtime.InteropServices.McgGeneratedMarshallingCode]
		[global::System.Runtime.InteropServices.McgPInvokeMarshalStub("System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Runtime.RuntimeImports", "RhCompatibleReentrantWaitAny")]
		public static int RhCompatibleReentrantWaitAny(
					int alertable, 
					int timeout, 
					int count, 
					global::System.IntPtr* handles)
		{
			// Setup
			int unsafe___value;
			// Marshalling
			// Call to native method
			unsafe___value = global::__Interop._MRT__PInvokes.RhCompatibleReentrantWaitAny(
								alertable, 
								timeout, 
								count, 
								((global::System.IntPtr*)handles)
							);
			global::System.Runtime.InteropServices.DebugAnnotations.PreviousCallContainsUserCode();
			// Return
			return unsafe___value;
		}

		// Signature, _ecvt_s, [fwd] [return] [Mcg.CodeGen.VoidReturnMarshaller] void__void, [fwd] [in] [Mcg.CodeGen.BlittableValueMarshaller] byte___ptrunsigned char *, [fwd] [in] [Mcg.CodeGen.BlittableValueMarshaller] int__int, [fwd] [in] [Mcg.CodeGen.BlittableValueMarshaller] double__double, [fwd] [in] [Mcg.CodeGen.BlittableValueMarshaller] int__int, [fwd] [in] [Mcg.CodeGen.BlittableValueMarshaller] int___ptrint *, [fwd] [in] [Mcg.CodeGen.BlittableValueMarshaller] int___ptrint *, 
		[global::System.Runtime.InteropServices.McgGeneratedMarshallingCode]
		[global::System.Runtime.InteropServices.McgPInvokeMarshalStub("System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Runtime.RuntimeImports", "_ecvt_s")]
		public static void _ecvt_s(
					byte* buffer, 
					int sizeInBytes, 
					double value, 
					int count, 
					int* dec, 
					int* sign)
		{
			// Marshalling
			// Call to native method
			global::__Interop._MRT__PInvokes._ecvt_s(
								((byte*)buffer), 
								sizeInBytes, 
								value, 
								count, 
								((int*)dec), 
								((int*)sign)
							);
			global::System.Runtime.InteropServices.DebugAnnotations.PreviousCallContainsUserCode();
			// Return
		}

		// Signature, memmove, [fwd] [return] [Mcg.CodeGen.VoidReturnMarshaller] void__void, [fwd] [in] [Mcg.CodeGen.BlittableValueMarshaller] byte___ptrunsigned char *, [fwd] [in] [Mcg.CodeGen.BlittableValueMarshaller] byte___ptrunsigned char *, [fwd] [in] [Mcg.CodeGen.BlittableValueMarshaller] uint__unsigned int, 
		[global::System.Runtime.InteropServices.McgGeneratedMarshallingCode]
		[global::System.Runtime.InteropServices.McgPInvokeMarshalStub("System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Runtime.RuntimeImports", "memmove")]
		public static void memmove(
					byte* dmem, 
					byte* smem, 
					uint size)
		{
			// Marshalling
			// Call to native method
			global::__Interop._MRT__PInvokes.memmove(
								((byte*)dmem), 
								((byte*)smem), 
								size
							);
			global::System.Runtime.InteropServices.DebugAnnotations.PreviousCallContainsUserCode();
			// Return
		}
	}

	/// <summary>
	/// P/Invoke class for module '*'
	/// </summary>
	public unsafe static partial class _
	{
		// Signature, CallingConventionConverter_GetStubs, [fwd] [return] [Mcg.CodeGen.VoidReturnMarshaller] void__void, [fwd] [out] [managedbyref] [nativebyref] [Mcg.CodeGen.BlittableValueMarshaller] System_IntPtr____w64 int, [fwd] [out] [managedbyref] [nativebyref] [Mcg.CodeGen.BlittableValueMarshaller] System_IntPtr____w64 int, [fwd] [out] [managedbyref] [nativebyref] [Mcg.CodeGen.BlittableValueMarshaller] System_IntPtr____w64 int, [fwd] [out] [managedbyref] [nativebyref] [Mcg.CodeGen.BlittableValueMarshaller] System_IntPtr____w64 int, [fwd] [out] [managedbyref] [nativebyref] [Mcg.CodeGen.BlittableValueMarshaller] System_IntPtr____w64 int, 
		[global::System.Runtime.InteropServices.McgGeneratedMarshallingCode]
		[global::System.Runtime.InteropServices.McgPInvokeMarshalStub("System.Private.TypeLoader, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "Internal.Runtime.TypeLoader.CallConverterThunk", "CallingConventionConverter_GetStubs")]
		public static void CallingConventionConverter_GetStubs(
					out global::System.IntPtr returnVoidStub, 
					out global::System.IntPtr returnIntegerStub, 
					out global::System.IntPtr commonStub, 
					out global::System.IntPtr returnFloatingPointReturn4Thunk, 
					out global::System.IntPtr returnFloatingPointReturn8Thunk)
		{
			// Setup
			global::System.IntPtr unsafe_returnVoidStub;
			global::System.IntPtr unsafe_returnIntegerStub;
			global::System.IntPtr unsafe_commonStub;
			global::System.IntPtr unsafe_returnFloatingPointReturn4Thunk;
			global::System.IntPtr unsafe_returnFloatingPointReturn8Thunk;
			// Marshalling
			// Call to native method
			global::__Interop.__PInvokes.CallingConventionConverter_GetStubs(
								&(unsafe_returnVoidStub), 
								&(unsafe_returnIntegerStub), 
								&(unsafe_commonStub), 
								&(unsafe_returnFloatingPointReturn4Thunk), 
								&(unsafe_returnFloatingPointReturn8Thunk)
							);
			global::System.Runtime.InteropServices.DebugAnnotations.PreviousCallContainsUserCode();
			returnFloatingPointReturn8Thunk = unsafe_returnFloatingPointReturn8Thunk;
			returnFloatingPointReturn4Thunk = unsafe_returnFloatingPointReturn4Thunk;
			commonStub = unsafe_commonStub;
			returnIntegerStub = unsafe_returnIntegerStub;
			returnVoidStub = unsafe_returnVoidStub;
			// Return
		}
	}

	/// <summary>
	/// P/Invoke class for module 'api-ms-win-core-errorhandling-l1-1-1.dll'
	/// </summary>
	public unsafe static partial class api_ms_win_core_errorhandling_l1_1_1_dll
	{
		// Signature, GetLastError, [fwd] [return] [Mcg.CodeGen.BlittableValueMarshaller] int__int, 
		[global::System.Runtime.InteropServices.McgGeneratedMarshallingCode]
		[global::System.Runtime.InteropServices.McgPInvokeMarshalStub("System.Runtime.Extensions, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "Interop+mincore", "GetLastError")]
		public static int GetLastError()
		{
			// Setup
			int unsafe___value;
			// Marshalling
			// Call to native method
			unsafe___value = global::__Interop.api_ms_win_core_errorhandling_l1_1_1_dll_PInvokes.GetLastError();
			global::System.Runtime.InteropServices.DebugAnnotations.PreviousCallContainsUserCode();
			// Return
			return unsafe___value;
		}
	}

	/// <summary>
	/// P/Invoke class for module 'api-ms-win-core-winrt-l1-1-0.dll'
	/// </summary>
	public unsafe static partial class api_ms_win_core_winrt_l1_1_0_dll
	{
		// Signature, RoInitialize, [fwd] [return] [Mcg.CodeGen.BlittableValueMarshaller] int__int, [fwd] [in] [Mcg.CodeGen.BlittableValueMarshaller] uint__unsigned int, 
		[global::System.Runtime.InteropServices.McgGeneratedMarshallingCode]
		[global::System.Runtime.InteropServices.McgPInvokeMarshalStub("System.Private.WinRTInterop.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089", "mincore+mincore_PInvokes", "RoInitialize")]
		public static int RoInitialize(uint initType)
		{
			// Setup
			int unsafe___value;
			// Marshalling
			// Call to native method
			unsafe___value = global::__Interop.api_ms_win_core_winrt_l1_1_0_dll_PInvokes.RoInitialize(initType);
			global::System.Runtime.InteropServices.DebugAnnotations.PreviousCallContainsUserCode();
			// Return
			return unsafe___value;
		}
	}

	/// <summary>
	/// P/Invoke class for module 'api-ms-win-core-localization-l1-2-1.dll'
	/// </summary>
	public unsafe static partial class api_ms_win_core_localization_l1_2_1_dll
	{
		// Signature, IsValidLocaleName, [fwd] [return] [Mcg.CodeGen.BlittableValueMarshaller] int__int, [fwd] [in] [Mcg.CodeGen.BlittableValueMarshaller] char___ptrwchar_t *, 
		[global::System.Runtime.InteropServices.McgGeneratedMarshallingCode]
		[global::System.Runtime.InteropServices.McgPInvokeMarshalStub("System.Private.WinRTInterop.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089", "mincore+mincore_PInvokes", "IsValidLocaleName")]
		public static int IsValidLocaleName(char* lpLocaleName)
		{
			// Setup
			int unsafe___value;
			// Marshalling
			// Call to native method
			unsafe___value = global::__Interop.api_ms_win_core_localization_l1_2_1_dll_PInvokes.IsValidLocaleName(((ushort*)lpLocaleName));
			global::System.Runtime.InteropServices.DebugAnnotations.PreviousCallContainsUserCode();
			// Return
			return unsafe___value;
		}

		// Signature, ResolveLocaleName, [fwd] [return] [Mcg.CodeGen.BlittableValueMarshaller] int__int, [fwd] [in] [Mcg.CodeGen.BlittableValueMarshaller] char___ptrwchar_t *, [fwd] [in] [Mcg.CodeGen.BlittableValueMarshaller] char___ptrwchar_t *, [fwd] [in] [Mcg.CodeGen.BlittableValueMarshaller] int__int, 
		[global::System.Runtime.InteropServices.McgGeneratedMarshallingCode]
		[global::System.Runtime.InteropServices.McgPInvokeMarshalStub("System.Private.WinRTInterop.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089", "mincore+mincore_PInvokes", "ResolveLocaleName")]
		public static int ResolveLocaleName(
					char* lpNameToResolve, 
					char* lpLocaleName, 
					int cchLocaleName)
		{
			// Setup
			int unsafe___value;
			// Marshalling
			// Call to native method
			unsafe___value = global::__Interop.api_ms_win_core_localization_l1_2_1_dll_PInvokes.ResolveLocaleName(
								((ushort*)lpNameToResolve), 
								((ushort*)lpLocaleName), 
								cchLocaleName
							);
			global::System.Runtime.InteropServices.DebugAnnotations.PreviousCallContainsUserCode();
			// Return
			return unsafe___value;
		}

		// Signature, GetCPInfoExW, [fwd] [return] [Mcg.CodeGen.BlittableValueMarshaller] int__int, [fwd] [in] [Mcg.CodeGen.BlittableValueMarshaller] uint__unsigned int, [fwd] [in] [Mcg.CodeGen.BlittableValueMarshaller] uint__unsigned int, [fwd] [in] [Mcg.CodeGen.BlittableValueMarshaller] Interop_mincore_CPINFOEXW__System_Text_Encoding_CodePages___ptr__Interop_mincore_CPINFOEXW__System_Text_Encoding_CodePages *, 
		[global::System.Runtime.InteropServices.McgGeneratedMarshallingCode]
		[global::System.Runtime.InteropServices.McgPInvokeMarshalStub("System.Text.Encoding.CodePages, Version=4.0.1.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "Interop+mincore", "GetCPInfoExW")]
		public static int GetCPInfoExW(
					uint CodePage, 
					uint dwFlags, 
					global::Interop_mincore_CPINFOEXW__System_Text_Encoding_CodePages* lpCPInfoEx)
		{
			// Setup
			int unsafe___value;
			// Marshalling
			// Call to native method
			unsafe___value = global::__Interop.api_ms_win_core_localization_l1_2_1_dll_PInvokes.GetCPInfoExW(
								CodePage, 
								dwFlags, 
								((global::Interop_mincore_CPINFOEXW__System_Text_Encoding_CodePages*)lpCPInfoEx)
							);
			global::System.Runtime.InteropServices.DebugAnnotations.PreviousCallContainsUserCode();
			// Return
			return unsafe___value;
		}

		// Signature, FormatMessage, [fwd] [return] [Mcg.CodeGen.BlittableValueMarshaller] int__int, [fwd] [in] [Mcg.CodeGen.BlittableValueMarshaller] int__int, [fwd] [in] [Mcg.CodeGen.BlittableValueMarshaller] System_IntPtr____w64 int, [fwd] [in] [Mcg.CodeGen.BlittableValueMarshaller] uint__unsigned int, [fwd] [in] [Mcg.CodeGen.BlittableValueMarshaller] int__int, [fwd] [out] [Mcg.CodeGen.StringBuilderMarshaller] System_Text_StringBuilder__wchar_t *, [fwd] [in] [Mcg.CodeGen.BlittableValueMarshaller] int__int, [fwd] [in] [Mcg.CodeGen.BlittableArrayMarshaller] rg_System_IntPtr____w64 int *, 
		[global::System.Runtime.InteropServices.McgGeneratedMarshallingCode]
		[global::System.Runtime.InteropServices.McgPInvokeMarshalStub("Microsoft.Win32.Primitives, Version=4.0.1.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "Interop+mincore", "FormatMessage")]
		public static int FormatMessage(
					int dwFlags, 
					global::System.IntPtr lpSource, 
					uint dwMessageId, 
					int dwLanguageId, 
					global::System.Text.StringBuilder lpBuffer, 
					int nSize, 
					global::System.IntPtr[] arguments)
		{
			// Setup
			ushort* unsafe_lpBuffer = default(ushort*);
			global::System.IntPtr* unsafe_arguments;
			int unsafe___value;
			try
			{
				// Marshalling
				if (lpBuffer == null)
					unsafe_lpBuffer = null;
				else
				{
					unsafe_lpBuffer = (ushort*)global::__Interop.McgHelpers.CoTaskMemAllocAndZeroMemory(new global::System.IntPtr(checked(lpBuffer.Capacity * 2 
										+ 2)));
					if (unsafe_lpBuffer == null)
						throw new global::System.OutOfMemoryException();
				}
				fixed (global::System.IntPtr* pinned_arguments = global::__Interop.McgHelpers.GetArrayForCompat(arguments))
				{
					unsafe_arguments = (global::System.IntPtr*)pinned_arguments;
					// Call to native method
					unsafe___value = global::__Interop.api_ms_win_core_localization_l1_2_1_dll_PInvokes.FormatMessage(
										dwFlags, 
										lpSource, 
										dwMessageId, 
										dwLanguageId, 
										unsafe_lpBuffer, 
										nSize, 
										unsafe_arguments
									);
					global::System.Runtime.InteropServices.DebugAnnotations.PreviousCallContainsUserCode();
					global::System.Runtime.InteropServices.McgMarshal.SaveLastWin32Error();
				}
				if (lpBuffer != null)
					global::System.Runtime.InteropServices.McgMarshal.UnicodeStringToStringBuilder(
										unsafe_lpBuffer, 
										lpBuffer
									);
				// Return
				return unsafe___value;
			}
			finally
			{
				// Cleanup
				if (unsafe_lpBuffer != null)
					global::System.Runtime.InteropServices.ExternalInterop.SafeCoTaskMemFree(unsafe_lpBuffer);
			}
		}
	}

	/// <summary>
	/// P/Invoke class for module 'api-ms-win-core-winrt-robuffer-l1-1-0.dll'
	/// </summary>
	public unsafe static partial class api_ms_win_core_winrt_robuffer_l1_1_0_dll
	{
		// Signature, RoGetBufferMarshaler, [fwd] [return] [Mcg.CodeGen.BlittableValueMarshaller] int__int, [fwd] [out] [managedbyref] [nativebyref] [Mcg.CodeGen.ComInterfaceMarshaller] System_Runtime_InteropServices_IMarshal__System_Runtime_WindowsRuntime__System_Runtime_InteropServices__IMarshal__System_Runtime_WindowsRuntime *, 
		[global::System.Runtime.InteropServices.McgGeneratedMarshallingCode]
		[global::System.Runtime.InteropServices.McgPInvokeMarshalStub("System.Runtime.WindowsRuntime, Version=4.0.11.0, Culture=neutral, PublicKeyToken=b77a5c561934e089", "Interop+mincore", "RoGetBufferMarshaler")]
		public static int RoGetBufferMarshaler(out global::System.Runtime.InteropServices.IMarshal__System_Runtime_WindowsRuntime bufferMarshalerPtr)
		{
			// Setup
			void* unsafe_bufferMarshalerPtr = default(void*);
			int unsafe___value;
			try
			{
				// Marshalling
				unsafe_bufferMarshalerPtr = null;
				// Call to native method
				unsafe___value = global::__Interop.api_ms_win_core_winrt_robuffer_l1_1_0_dll_PInvokes.RoGetBufferMarshaler(&(unsafe_bufferMarshalerPtr));
				global::System.Runtime.InteropServices.DebugAnnotations.PreviousCallContainsUserCode();
				bufferMarshalerPtr = (global::System.Runtime.InteropServices.IMarshal__System_Runtime_WindowsRuntime)global::System.Runtime.InteropServices.McgMarshal.ComInterfaceToObject(
									((global::System.IntPtr)unsafe_bufferMarshalerPtr), 
									global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Runtime.InteropServices.IMarshal,System.Runtime.WindowsRuntime, Version=4.0.11.0, Culture=neutral, Public" +
											"KeyToken=b77a5c561934e089")
								);
				// Return
				return unsafe___value;
			}
			finally
			{
				// Cleanup
				global::System.Runtime.InteropServices.McgMarshal.ComSafeRelease(new global::System.IntPtr(((void*)unsafe_bufferMarshalerPtr)));
			}
		}
	}

	/// <summary>
	/// P/Invoke class for module 'api-ms-win-core-com-l1-1-0.dll'
	/// </summary>
	public unsafe static partial class api_ms_win_core_com_l1_1_0_dll
	{
		// Signature, CoCreateInstance, [fwd] [return] [Mcg.CodeGen.BlittableValueMarshaller] int__int, [fwd] [in] [Mcg.CodeGen.BlittableValueMarshaller] byte___ptrunsigned char *, [fwd] [in] [Mcg.CodeGen.BlittableValueMarshaller] System_IntPtr____w64 int, [fwd] [in] [Mcg.CodeGen.BlittableValueMarshaller] int__int, [fwd] [in] [Mcg.CodeGen.BlittableValueMarshaller] byte___ptrunsigned char *, [fwd] [out] [managedbyref] [nativebyref] [Mcg.CodeGen.BlittableValueMarshaller] System_IntPtr____w64 int, 
		[global::System.Runtime.InteropServices.McgGeneratedMarshallingCode]
		[global::System.Runtime.InteropServices.McgPInvokeMarshalStub("System.Private.StackTraceGenerator, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "Internal.StackTraceGenerator.StackTraceGenerator", "CoCreateInstance")]
		public static int CoCreateInstance(
					byte* rclsid, 
					global::System.IntPtr pUnkOuter, 
					int dwClsContext, 
					byte* riid, 
					out global::System.IntPtr ppv)
		{
			// Setup
			global::System.IntPtr unsafe_ppv;
			int unsafe___value;
			// Marshalling
			// Call to native method
			unsafe___value = global::__Interop.api_ms_win_core_com_l1_1_0_dll_PInvokes.CoCreateInstance(
								((byte*)rclsid), 
								pUnkOuter, 
								dwClsContext, 
								((byte*)riid), 
								&(unsafe_ppv)
							);
			global::System.Runtime.InteropServices.DebugAnnotations.PreviousCallContainsUserCode();
			ppv = unsafe_ppv;
			// Return
			return unsafe___value;
		}
	}

	/// <summary>
	/// P/Invoke class for module 'oleaut32.dll'
	/// </summary>
	public unsafe static partial class oleaut32_dll
	{
		// Signature, SysFreeString, [fwd] [return] [Mcg.CodeGen.VoidReturnMarshaller] void__void, [fwd] [in] [Mcg.CodeGen.BlittableValueMarshaller] System_IntPtr____w64 int, 
		[global::System.Runtime.InteropServices.McgGeneratedMarshallingCode]
		[global::System.Runtime.InteropServices.McgPInvokeMarshalStub("System.Private.StackTraceGenerator, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "Internal.LightweightInterop.MarshalExtensions", "SysFreeString")]
		public static void SysFreeString(global::System.IntPtr bstr)
		{
			// Marshalling
			// Call to native method
			global::__Interop.oleaut32_dll_PInvokes.SysFreeString(bstr);
			global::System.Runtime.InteropServices.DebugAnnotations.PreviousCallContainsUserCode();
			// Return
		}
	}

	/// <summary>
	/// P/Invoke class for module 'ntdll.dll'
	/// </summary>
	public unsafe static partial class ntdll_dll
	{
		// Signature, RtlIpv6AddressToStringExW, [fwd] [return] [Mcg.CodeGen.BlittableValueMarshaller] uint__unsigned int, [fwd] [in] [Mcg.CodeGen.BlittableArrayMarshaller] rg_byte__unsigned char *, [fwd] [in] [Mcg.CodeGen.BlittableValueMarshaller] uint__unsigned int, [fwd] [in] [Mcg.CodeGen.BlittableValueMarshaller] ushort__unsigned short, [fwd] [out] [Mcg.CodeGen.StringBuilderMarshaller] System_Text_StringBuilder__wchar_t *, [fwd] [in] [out] [managedbyref] [nativebyref] [Mcg.CodeGen.BlittableValueMarshaller] uint__unsigned int, 
		[global::System.Runtime.InteropServices.McgGeneratedMarshallingCode]
		[global::System.Runtime.InteropServices.McgPInvokeMarshalStub("System.Net.Primitives, Version=4.0.11.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "Interop+NtDll", "RtlIpv6AddressToStringExW")]
		public static uint RtlIpv6AddressToStringExW(
					byte[] address, 
					uint scopeId, 
					ushort port, 
					global::System.Text.StringBuilder addressString, 
					ref uint addressStringLength)
		{
			// Setup
			byte* unsafe_address;
			ushort* unsafe_addressString = default(ushort*);
			uint unsafe_addressStringLength;
			uint unsafe___value;
			try
			{
				// Marshalling
				fixed (byte* pinned_address = global::__Interop.McgHelpers.GetArrayForCompat(address))
				{
					unsafe_address = (byte*)pinned_address;
					if (addressString == null)
						unsafe_addressString = null;
					else
					{
						unsafe_addressString = (ushort*)global::__Interop.McgHelpers.CoTaskMemAllocAndZeroMemory(new global::System.IntPtr(checked(addressString.Capacity * 2 
											+ 2)));
						if (unsafe_addressString == null)
							throw new global::System.OutOfMemoryException();
					}
					unsafe_addressStringLength = addressStringLength;
					// Call to native method
					unsafe___value = global::__Interop.ntdll_dll_PInvokes.RtlIpv6AddressToStringExW(
										unsafe_address, 
										scopeId, 
										port, 
										unsafe_addressString, 
										&(unsafe_addressStringLength)
									);
					global::System.Runtime.InteropServices.DebugAnnotations.PreviousCallContainsUserCode();
					addressStringLength = unsafe_addressStringLength;
					if (addressString != null)
						global::System.Runtime.InteropServices.McgMarshal.UnicodeStringToStringBuilder(
											unsafe_addressString, 
											addressString
										);
				}
				// Return
				return unsafe___value;
			}
			finally
			{
				// Cleanup
				if (unsafe_addressString != null)
					global::System.Runtime.InteropServices.ExternalInterop.SafeCoTaskMemFree(unsafe_addressString);
			}
		}

		// Signature, RtlIpv4AddressToStringExW, [fwd] [return] [Mcg.CodeGen.BlittableValueMarshaller] uint__unsigned int, [fwd] [in] [Mcg.CodeGen.BlittableArrayMarshaller] rg_byte__unsigned char *, [fwd] [in] [Mcg.CodeGen.BlittableValueMarshaller] ushort__unsigned short, [fwd] [out] [Mcg.CodeGen.StringBuilderMarshaller] System_Text_StringBuilder__wchar_t *, [fwd] [in] [out] [managedbyref] [nativebyref] [Mcg.CodeGen.BlittableValueMarshaller] uint__unsigned int, 
		[global::System.Runtime.InteropServices.McgGeneratedMarshallingCode]
		[global::System.Runtime.InteropServices.McgPInvokeMarshalStub("System.Net.Primitives, Version=4.0.11.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "Interop+NtDll", "RtlIpv4AddressToStringExW")]
		public static uint RtlIpv4AddressToStringExW(
					byte[] address, 
					ushort port, 
					global::System.Text.StringBuilder addressString, 
					ref uint addressStringLength)
		{
			// Setup
			byte* unsafe_address;
			ushort* unsafe_addressString = default(ushort*);
			uint unsafe_addressStringLength;
			uint unsafe___value;
			try
			{
				// Marshalling
				fixed (byte* pinned_address = global::__Interop.McgHelpers.GetArrayForCompat(address))
				{
					unsafe_address = (byte*)pinned_address;
					if (addressString == null)
						unsafe_addressString = null;
					else
					{
						unsafe_addressString = (ushort*)global::__Interop.McgHelpers.CoTaskMemAllocAndZeroMemory(new global::System.IntPtr(checked(addressString.Capacity * 2 
											+ 2)));
						if (unsafe_addressString == null)
							throw new global::System.OutOfMemoryException();
					}
					unsafe_addressStringLength = addressStringLength;
					// Call to native method
					unsafe___value = global::__Interop.ntdll_dll_PInvokes.RtlIpv4AddressToStringExW(
										unsafe_address, 
										port, 
										unsafe_addressString, 
										&(unsafe_addressStringLength)
									);
					global::System.Runtime.InteropServices.DebugAnnotations.PreviousCallContainsUserCode();
					addressStringLength = unsafe_addressStringLength;
					if (addressString != null)
						global::System.Runtime.InteropServices.McgMarshal.UnicodeStringToStringBuilder(
											unsafe_addressString, 
											addressString
										);
				}
				// Return
				return unsafe___value;
			}
			finally
			{
				// Cleanup
				if (unsafe_addressString != null)
					global::System.Runtime.InteropServices.ExternalInterop.SafeCoTaskMemFree(unsafe_addressString);
			}
		}
	}

	public unsafe static partial class _MRT__PInvokes
	{
		[global::System.Runtime.InteropServices.McgGeneratedNativeCallCode]
		[global::System.Runtime.InteropServices.DllImport("[MRT]", CallingConvention=global::System.Runtime.InteropServices.CallingConvention.Winapi)]
		public extern static void RhWaitForPendingFinalizers(int allowReentrantWait);

		[global::System.Runtime.InteropServices.McgGeneratedNativeCallCode]
		[global::System.Runtime.InteropServices.DllImport("[MRT]", EntryPoint="RhYield", CallingConvention=global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public extern static int _RhYield();

		[global::System.Runtime.InteropServices.McgGeneratedNativeCallCode]
		[global::System.Runtime.InteropServices.DllImport("[MRT]", CallingConvention=global::System.Runtime.InteropServices.CallingConvention.Winapi)]
		public extern static int RhCompatibleReentrantWaitAny(
					int alertable, 
					int timeout, 
					int count, 
					global::System.IntPtr* handles);

		[global::System.Runtime.InteropServices.McgGeneratedNativeCallCode]
		[global::System.Runtime.InteropServices.DllImport("[MRT]", CallingConvention=global::System.Runtime.InteropServices.CallingConvention.Winapi)]
		public extern static void _ecvt_s(
					byte* buffer, 
					int sizeInBytes, 
					double value, 
					int count, 
					int* dec, 
					int* sign);

		[global::System.Runtime.InteropServices.McgGeneratedNativeCallCode]
		[global::System.Runtime.InteropServices.DllImport("[MRT]", CallingConvention=global::System.Runtime.InteropServices.CallingConvention.Winapi)]
		public extern static void memmove(
					byte* dmem, 
					byte* smem, 
					uint size);
	}

	public unsafe static partial class __PInvokes
	{
		[global::System.Runtime.InteropServices.McgGeneratedNativeCallCode]
		[global::System.Runtime.InteropServices.DllImport("*", CallingConvention=global::System.Runtime.InteropServices.CallingConvention.Winapi)]
		public extern static void CallingConventionConverter_GetStubs(
					global::System.IntPtr* returnVoidStub, 
					global::System.IntPtr* returnIntegerStub, 
					global::System.IntPtr* commonStub, 
					global::System.IntPtr* returnFloatingPointReturn4Thunk, 
					global::System.IntPtr* returnFloatingPointReturn8Thunk);
	}

	public unsafe static partial class api_ms_win_core_errorhandling_l1_1_1_dll_PInvokes
	{
		[global::System.Runtime.InteropServices.McgGeneratedNativeCallCode]
		[global::System.Runtime.InteropServices.DllImport("api-ms-win-core-errorhandling-l1-1-1.dll", CallingConvention=global::System.Runtime.InteropServices.CallingConvention.Winapi)]
		public extern static int GetLastError();
	}

	public unsafe static partial class api_ms_win_core_winrt_l1_1_0_dll_PInvokes
	{
		[global::System.Runtime.InteropServices.McgGeneratedNativeCallCode]
		[global::System.Runtime.InteropServices.DllImport("api-ms-win-core-winrt-l1-1-0.dll", CallingConvention=global::System.Runtime.InteropServices.CallingConvention.Winapi)]
		public extern static int RoInitialize(uint initType);
	}

	public unsafe static partial class api_ms_win_core_localization_l1_2_1_dll_PInvokes
	{
		[global::System.Runtime.InteropServices.McgGeneratedNativeCallCode]
		[global::System.Runtime.InteropServices.DllImport("api-ms-win-core-localization-l1-2-1.dll", CallingConvention=global::System.Runtime.InteropServices.CallingConvention.Winapi)]
		public extern static int IsValidLocaleName(ushort* lpLocaleName);

		[global::System.Runtime.InteropServices.McgGeneratedNativeCallCode]
		[global::System.Runtime.InteropServices.DllImport("api-ms-win-core-localization-l1-2-1.dll", CallingConvention=global::System.Runtime.InteropServices.CallingConvention.Winapi)]
		public extern static int ResolveLocaleName(
					ushort* lpNameToResolve, 
					ushort* lpLocaleName, 
					int cchLocaleName);

		[global::System.Runtime.InteropServices.McgGeneratedNativeCallCode]
		[global::System.Runtime.InteropServices.DllImport("api-ms-win-core-localization-l1-2-1.dll", CallingConvention=global::System.Runtime.InteropServices.CallingConvention.Winapi)]
		public extern static int GetCPInfoExW(
					uint CodePage, 
					uint dwFlags, 
					global::Interop_mincore_CPINFOEXW__System_Text_Encoding_CodePages* lpCPInfoEx);

		[global::System.Runtime.InteropServices.McgGeneratedNativeCallCode]
		[global::System.Runtime.InteropServices.DllImport("api-ms-win-core-localization-l1-2-1.dll", EntryPoint="FormatMessageW", CallingConvention=global::System.Runtime.InteropServices.CallingConvention.Winapi)]
		public extern static int FormatMessage(
					int dwFlags, 
					global::System.IntPtr lpSource, 
					uint dwMessageId, 
					int dwLanguageId, 
					ushort* lpBuffer, 
					int nSize, 
					global::System.IntPtr* arguments);
	}

	public unsafe static partial class api_ms_win_core_winrt_robuffer_l1_1_0_dll_PInvokes
	{
		[global::System.Runtime.InteropServices.McgGeneratedNativeCallCode]
		[global::System.Runtime.InteropServices.DllImport("api-ms-win-core-winrt-robuffer-l1-1-0.dll", CallingConvention=global::System.Runtime.InteropServices.CallingConvention.StdCall)]
		public extern static int RoGetBufferMarshaler(void** bufferMarshalerPtr);
	}

	public unsafe static partial class api_ms_win_core_com_l1_1_0_dll_PInvokes
	{
		[global::System.Runtime.InteropServices.McgGeneratedNativeCallCode]
		[global::System.Runtime.InteropServices.DllImport("api-ms-win-core-com-l1-1-0.dll", CallingConvention=global::System.Runtime.InteropServices.CallingConvention.Winapi)]
		public extern static int CoCreateInstance(
					byte* rclsid, 
					global::System.IntPtr pUnkOuter, 
					int dwClsContext, 
					byte* riid, 
					global::System.IntPtr* ppv);
	}

	public unsafe static partial class oleaut32_dll_PInvokes
	{
		[global::System.Runtime.InteropServices.McgGeneratedNativeCallCode]
		[global::System.Runtime.InteropServices.DllImport("oleaut32.dll", EntryPoint="#6", CallingConvention=global::System.Runtime.InteropServices.CallingConvention.Winapi)]
		public extern static void SysFreeString(global::System.IntPtr bstr);
	}

	public unsafe static partial class ntdll_dll_PInvokes
	{
		[global::System.Runtime.InteropServices.McgGeneratedNativeCallCode]
		[global::System.Runtime.InteropServices.DllImport("ntdll.dll", CallingConvention=global::System.Runtime.InteropServices.CallingConvention.Winapi)]
		public extern static uint RtlIpv6AddressToStringExW(
					byte* address, 
					uint scopeId, 
					ushort port, 
					ushort* addressString, 
					uint* addressStringLength);

		[global::System.Runtime.InteropServices.McgGeneratedNativeCallCode]
		[global::System.Runtime.InteropServices.DllImport("ntdll.dll", CallingConvention=global::System.Runtime.InteropServices.CallingConvention.Winapi)]
		public extern static uint RtlIpv4AddressToStringExW(
					byte* address, 
					ushort port, 
					ushort* addressString, 
					uint* addressStringLength);
	}
}

