; ModuleID = 'marshal_methods.armeabi-v7a.ll'
source_filename = "marshal_methods.armeabi-v7a.ll"
target datalayout = "e-m:e-p:32:32-Fi8-i64:64-v128:64:128-a:0:32-n32-S64"
target triple = "armv7-unknown-linux-android21"

%struct.MarshalMethodName = type {
	i64, ; uint64_t id
	ptr ; char* name
}

%struct.MarshalMethodsManagedClass = type {
	i32, ; uint32_t token
	ptr ; MonoClass klass
}

@assembly_image_cache = dso_local local_unnamed_addr global [126 x ptr] zeroinitializer, align 4

; Each entry maps hash of an assembly name to an index into the `assembly_image_cache` array
@assembly_image_cache_hashes = dso_local local_unnamed_addr constant [252 x i32] [
	i32 2616222, ; 0: System.Net.NetworkInformation.dll => 0x27eb9e => 102
	i32 38948123, ; 1: ar\Microsoft.Maui.Controls.resources.dll => 0x2524d1b => 0
	i32 42244203, ; 2: he\Microsoft.Maui.Controls.resources.dll => 0x284986b => 9
	i32 42639949, ; 3: System.Threading.Thread => 0x28aa24d => 116
	i32 67008169, ; 4: zh-Hant\Microsoft.Maui.Controls.resources => 0x3fe76a9 => 33
	i32 72070932, ; 5: Microsoft.Maui.Graphics.dll => 0x44bb714 => 53
	i32 83839681, ; 6: ms\Microsoft.Maui.Controls.resources.dll => 0x4ff4ac1 => 17
	i32 117431740, ; 7: System.Runtime.InteropServices => 0x6ffddbc => 109
	i32 136584136, ; 8: zh-Hans\Microsoft.Maui.Controls.resources.dll => 0x8241bc8 => 32
	i32 140062828, ; 9: sk\Microsoft.Maui.Controls.resources.dll => 0x859306c => 25
	i32 159306688, ; 10: System.ComponentModel.Annotations => 0x97ed3c0 => 88
	i32 165246403, ; 11: Xamarin.AndroidX.Collection.dll => 0x9d975c3 => 59
	i32 182336117, ; 12: Xamarin.AndroidX.SwipeRefreshLayout.dll => 0xade3a75 => 77
	i32 205061960, ; 13: System.ComponentModel => 0xc38ff48 => 91
	i32 209399409, ; 14: Xamarin.AndroidX.Browser.dll => 0xc7b2e71 => 57
	i32 317674968, ; 15: vi\Microsoft.Maui.Controls.resources => 0x12ef55d8 => 30
	i32 318968648, ; 16: Xamarin.AndroidX.Activity.dll => 0x13031348 => 54
	i32 321963286, ; 17: fr\Microsoft.Maui.Controls.resources.dll => 0x1330c516 => 8
	i32 342366114, ; 18: Xamarin.AndroidX.Lifecycle.Common => 0x146817a2 => 66
	i32 371796662, ; 19: AppPortfolio.dll => 0x16292ab6 => 83
	i32 374914964, ; 20: System.Transactions.Local => 0x1658bf94 => 118
	i32 379916513, ; 21: System.Threading.Thread.dll => 0x16a510e1 => 116
	i32 385762202, ; 22: System.Memory.dll => 0x16fe439a => 100
	i32 395744057, ; 23: _Microsoft.Android.Resource.Designer => 0x17969339 => 34
	i32 409257351, ; 24: tr\Microsoft.Maui.Controls.resources.dll => 0x1864c587 => 28
	i32 442565967, ; 25: System.Collections => 0x1a61054f => 87
	i32 450948140, ; 26: Xamarin.AndroidX.Fragment.dll => 0x1ae0ec2c => 65
	i32 456227837, ; 27: System.Web.HttpUtility.dll => 0x1b317bfd => 119
	i32 469710990, ; 28: System.dll => 0x1bff388e => 121
	i32 489220957, ; 29: es\Microsoft.Maui.Controls.resources.dll => 0x1d28eb5d => 6
	i32 498788369, ; 30: System.ObjectModel => 0x1dbae811 => 106
	i32 513247710, ; 31: Microsoft.Extensions.Primitives.dll => 0x1e9789de => 48
	i32 530272170, ; 32: System.Linq.Queryable => 0x1f9b4faa => 98
	i32 538707440, ; 33: th\Microsoft.Maui.Controls.resources.dll => 0x201c05f0 => 27
	i32 539058512, ; 34: Microsoft.Extensions.Logging => 0x20216150 => 45
	i32 627609679, ; 35: Xamarin.AndroidX.CustomView => 0x2568904f => 63
	i32 627931235, ; 36: nl\Microsoft.Maui.Controls.resources => 0x256d7863 => 19
	i32 662205335, ; 37: System.Text.Encodings.Web.dll => 0x27787397 => 113
	i32 672442732, ; 38: System.Collections.Concurrent => 0x2814a96c => 84
	i32 759454413, ; 39: System.Net.Requests => 0x2d445acd => 104
	i32 775507847, ; 40: System.IO.Compression => 0x2e394f87 => 96
	i32 777317022, ; 41: sk\Microsoft.Maui.Controls.resources => 0x2e54ea9e => 25
	i32 789151979, ; 42: Microsoft.Extensions.Options => 0x2f0980eb => 47
	i32 823281589, ; 43: System.Private.Uri.dll => 0x311247b5 => 107
	i32 830298997, ; 44: System.IO.Compression.Brotli => 0x317d5b75 => 95
	i32 869139383, ; 45: hi\Microsoft.Maui.Controls.resources.dll => 0x33ce03b7 => 10
	i32 880668424, ; 46: ru\Microsoft.Maui.Controls.resources.dll => 0x347def08 => 24
	i32 904024072, ; 47: System.ComponentModel.Primitives.dll => 0x35e25008 => 89
	i32 918734561, ; 48: pt-BR\Microsoft.Maui.Controls.resources.dll => 0x36c2c6e1 => 21
	i32 961460050, ; 49: it\Microsoft.Maui.Controls.resources.dll => 0x394eb752 => 14
	i32 967690846, ; 50: Xamarin.AndroidX.Lifecycle.Common.dll => 0x39adca5e => 66
	i32 975236339, ; 51: System.Diagnostics.Tracing => 0x3a20ecf3 => 94
	i32 990727110, ; 52: ro\Microsoft.Maui.Controls.resources.dll => 0x3b0d4bc6 => 23
	i32 992768348, ; 53: System.Collections.dll => 0x3b2c715c => 87
	i32 1012816738, ; 54: Xamarin.AndroidX.SavedState.dll => 0x3c5e5b62 => 76
	i32 1028951442, ; 55: Microsoft.Extensions.DependencyInjection.Abstractions => 0x3d548d92 => 44
	i32 1035644815, ; 56: Xamarin.AndroidX.AppCompat => 0x3dbaaf8f => 55
	i32 1043950537, ; 57: de\Microsoft.Maui.Controls.resources.dll => 0x3e396bc9 => 4
	i32 1044663988, ; 58: System.Linq.Expressions.dll => 0x3e444eb4 => 97
	i32 1052210849, ; 59: Xamarin.AndroidX.Lifecycle.ViewModel.dll => 0x3eb776a1 => 68
	i32 1082857460, ; 60: System.ComponentModel.TypeConverter => 0x408b17f4 => 90
	i32 1084122840, ; 61: Xamarin.Kotlin.StdLib => 0x409e66d8 => 81
	i32 1098259244, ; 62: System => 0x41761b2c => 121
	i32 1108272742, ; 63: sv\Microsoft.Maui.Controls.resources.dll => 0x420ee666 => 26
	i32 1117529484, ; 64: pl\Microsoft.Maui.Controls.resources.dll => 0x429c258c => 20
	i32 1118262833, ; 65: ko\Microsoft.Maui.Controls.resources => 0x42a75631 => 16
	i32 1157931901, ; 66: Microsoft.EntityFrameworkCore.Abstractions => 0x4504a37d => 37
	i32 1168523401, ; 67: pt\Microsoft.Maui.Controls.resources => 0x45a64089 => 22
	i32 1178241025, ; 68: Xamarin.AndroidX.Navigation.Runtime.dll => 0x463a8801 => 73
	i32 1202000627, ; 69: Microsoft.EntityFrameworkCore.Abstractions.dll => 0x47a512f3 => 37
	i32 1204575371, ; 70: Microsoft.Extensions.Caching.Memory.dll => 0x47cc5c8b => 40
	i32 1214827643, ; 71: CommunityToolkit.Mvvm => 0x4868cc7b => 35
	i32 1260983243, ; 72: cs\Microsoft.Maui.Controls.resources => 0x4b2913cb => 2
	i32 1293217323, ; 73: Xamarin.AndroidX.DrawerLayout.dll => 0x4d14ee2b => 64
	i32 1308624726, ; 74: hr\Microsoft.Maui.Controls.resources.dll => 0x4e000756 => 11
	i32 1324164729, ; 75: System.Linq => 0x4eed2679 => 99
	i32 1336711579, ; 76: zh-HK\Microsoft.Maui.Controls.resources.dll => 0x4fac999b => 31
	i32 1373134921, ; 77: zh-Hans\Microsoft.Maui.Controls.resources => 0x51d86049 => 32
	i32 1376866003, ; 78: Xamarin.AndroidX.SavedState => 0x52114ed3 => 76
	i32 1406073936, ; 79: Xamarin.AndroidX.CoordinatorLayout => 0x53cefc50 => 60
	i32 1430672901, ; 80: ar\Microsoft.Maui.Controls.resources => 0x55465605 => 0
	i32 1461004990, ; 81: es\Microsoft.Maui.Controls.resources => 0x57152abe => 6
	i32 1461234159, ; 82: System.Collections.Immutable.dll => 0x5718a9ef => 85
	i32 1462112819, ; 83: System.IO.Compression.dll => 0x57261233 => 96
	i32 1469204771, ; 84: Xamarin.AndroidX.AppCompat.AppCompatResources => 0x57924923 => 56
	i32 1470490898, ; 85: Microsoft.Extensions.Primitives => 0x57a5e912 => 48
	i32 1479771757, ; 86: System.Collections.Immutable => 0x5833866d => 85
	i32 1480492111, ; 87: System.IO.Compression.Brotli.dll => 0x583e844f => 95
	i32 1526286932, ; 88: vi\Microsoft.Maui.Controls.resources.dll => 0x5af94a54 => 30
	i32 1543031311, ; 89: System.Text.RegularExpressions.dll => 0x5bf8ca0f => 115
	i32 1622152042, ; 90: Xamarin.AndroidX.Loader.dll => 0x60b0136a => 70
	i32 1624863272, ; 91: Xamarin.AndroidX.ViewPager2 => 0x60d97228 => 79
	i32 1636350590, ; 92: Xamarin.AndroidX.CursorAdapter => 0x6188ba7e => 62
	i32 1639515021, ; 93: System.Net.Http.dll => 0x61b9038d => 101
	i32 1639986890, ; 94: System.Text.RegularExpressions => 0x61c036ca => 115
	i32 1657153582, ; 95: System.Runtime => 0x62c6282e => 111
	i32 1658251792, ; 96: Xamarin.Google.Android.Material.dll => 0x62d6ea10 => 80
	i32 1677501392, ; 97: System.Net.Primitives.dll => 0x63fca3d0 => 103
	i32 1679769178, ; 98: System.Security.Cryptography => 0x641f3e5a => 112
	i32 1689493916, ; 99: Microsoft.EntityFrameworkCore.dll => 0x64b3a19c => 36
	i32 1729485958, ; 100: Xamarin.AndroidX.CardView.dll => 0x6715dc86 => 58
	i32 1743415430, ; 101: ca\Microsoft.Maui.Controls.resources => 0x67ea6886 => 1
	i32 1744735666, ; 102: System.Transactions.Local.dll => 0x67fe8db2 => 118
	i32 1766324549, ; 103: Xamarin.AndroidX.SwipeRefreshLayout => 0x6947f945 => 77
	i32 1770582343, ; 104: Microsoft.Extensions.Logging.dll => 0x6988f147 => 45
	i32 1780572499, ; 105: Mono.Android.Runtime.dll => 0x6a216153 => 124
	i32 1782862114, ; 106: ms\Microsoft.Maui.Controls.resources => 0x6a445122 => 17
	i32 1788241197, ; 107: Xamarin.AndroidX.Fragment => 0x6a96652d => 65
	i32 1793755602, ; 108: he\Microsoft.Maui.Controls.resources => 0x6aea89d2 => 9
	i32 1808609942, ; 109: Xamarin.AndroidX.Loader => 0x6bcd3296 => 70
	i32 1813058853, ; 110: Xamarin.Kotlin.StdLib.dll => 0x6c111525 => 81
	i32 1813201214, ; 111: Xamarin.Google.Android.Material => 0x6c13413e => 80
	i32 1818569960, ; 112: Xamarin.AndroidX.Navigation.UI.dll => 0x6c652ce8 => 74
	i32 1828688058, ; 113: Microsoft.Extensions.Logging.Abstractions.dll => 0x6cff90ba => 46
	i32 1853025655, ; 114: sv\Microsoft.Maui.Controls.resources => 0x6e72ed77 => 26
	i32 1858542181, ; 115: System.Linq.Expressions => 0x6ec71a65 => 97
	i32 1875935024, ; 116: fr\Microsoft.Maui.Controls.resources => 0x6fd07f30 => 8
	i32 1893218855, ; 117: cs\Microsoft.Maui.Controls.resources.dll => 0x70d83a27 => 2
	i32 1910275211, ; 118: System.Collections.NonGeneric.dll => 0x71dc7c8b => 86
	i32 1953182387, ; 119: id\Microsoft.Maui.Controls.resources.dll => 0x746b32b3 => 13
	i32 1968388702, ; 120: Microsoft.Extensions.Configuration.dll => 0x75533a5e => 41
	i32 1998845772, ; 121: Microsoft.EntityFrameworkCore.InMemory.dll => 0x7723f74c => 38
	i32 2003115576, ; 122: el\Microsoft.Maui.Controls.resources => 0x77651e38 => 5
	i32 2019465201, ; 123: Xamarin.AndroidX.Lifecycle.ViewModel => 0x785e97f1 => 68
	i32 2045470958, ; 124: System.Private.Xml => 0x79eb68ee => 108
	i32 2055257422, ; 125: Xamarin.AndroidX.Lifecycle.LiveData.Core.dll => 0x7a80bd4e => 67
	i32 2066184531, ; 126: de\Microsoft.Maui.Controls.resources => 0x7b277953 => 4
	i32 2079903147, ; 127: System.Runtime.dll => 0x7bf8cdab => 111
	i32 2090596640, ; 128: System.Numerics.Vectors => 0x7c9bf920 => 105
	i32 2127167465, ; 129: System.Console => 0x7ec9ffe9 => 92
	i32 2159891885, ; 130: Microsoft.Maui => 0x80bd55ad => 51
	i32 2169148018, ; 131: hu\Microsoft.Maui.Controls.resources => 0x814a9272 => 12
	i32 2181898931, ; 132: Microsoft.Extensions.Options.dll => 0x820d22b3 => 47
	i32 2192057212, ; 133: Microsoft.Extensions.Logging.Abstractions => 0x82a8237c => 46
	i32 2193016926, ; 134: System.ObjectModel.dll => 0x82b6c85e => 106
	i32 2201107256, ; 135: Xamarin.KotlinX.Coroutines.Core.Jvm.dll => 0x83323b38 => 82
	i32 2201231467, ; 136: System.Net.Http => 0x8334206b => 101
	i32 2207618523, ; 137: it\Microsoft.Maui.Controls.resources => 0x839595db => 14
	i32 2252897993, ; 138: Microsoft.EntityFrameworkCore => 0x86487ec9 => 36
	i32 2266799131, ; 139: Microsoft.Extensions.Configuration.Abstractions => 0x871c9c1b => 42
	i32 2279755925, ; 140: Xamarin.AndroidX.RecyclerView.dll => 0x87e25095 => 75
	i32 2303942373, ; 141: nb\Microsoft.Maui.Controls.resources => 0x89535ee5 => 18
	i32 2305521784, ; 142: System.Private.CoreLib.dll => 0x896b7878 => 122
	i32 2353062107, ; 143: System.Net.Primitives => 0x8c40e0db => 103
	i32 2366048013, ; 144: hu\Microsoft.Maui.Controls.resources.dll => 0x8d07070d => 12
	i32 2368005991, ; 145: System.Xml.ReaderWriter.dll => 0x8d24e767 => 120
	i32 2371007202, ; 146: Microsoft.Extensions.Configuration => 0x8d52b2e2 => 41
	i32 2395872292, ; 147: id\Microsoft.Maui.Controls.resources => 0x8ece1c24 => 13
	i32 2401565422, ; 148: System.Web.HttpUtility => 0x8f24faee => 119
	i32 2416538583, ; 149: AppPortfolio => 0x900973d7 => 83
	i32 2427813419, ; 150: hi\Microsoft.Maui.Controls.resources => 0x90b57e2b => 10
	i32 2435356389, ; 151: System.Console.dll => 0x912896e5 => 92
	i32 2436099724, ; 152: Microsoft.EntityFrameworkCore.InMemory => 0x9133ee8c => 38
	i32 2475788418, ; 153: Java.Interop.dll => 0x93918882 => 123
	i32 2480646305, ; 154: Microsoft.Maui.Controls => 0x93dba8a1 => 49
	i32 2503351294, ; 155: ko\Microsoft.Maui.Controls.resources.dll => 0x95361bfe => 16
	i32 2550873716, ; 156: hr\Microsoft.Maui.Controls.resources => 0x980b3e74 => 11
	i32 2570120770, ; 157: System.Text.Encodings.Web => 0x9930ee42 => 113
	i32 2576534780, ; 158: ja\Microsoft.Maui.Controls.resources.dll => 0x9992ccfc => 15
	i32 2593496499, ; 159: pl\Microsoft.Maui.Controls.resources => 0x9a959db3 => 20
	i32 2605712449, ; 160: Xamarin.KotlinX.Coroutines.Core.Jvm => 0x9b500441 => 82
	i32 2617129537, ; 161: System.Private.Xml.dll => 0x9bfe3a41 => 108
	i32 2620871830, ; 162: Xamarin.AndroidX.CursorAdapter.dll => 0x9c375496 => 62
	i32 2626831493, ; 163: ja\Microsoft.Maui.Controls.resources => 0x9c924485 => 15
	i32 2724373263, ; 164: System.Runtime.Numerics.dll => 0xa262a30f => 110
	i32 2732626843, ; 165: Xamarin.AndroidX.Activity => 0xa2e0939b => 54
	i32 2737747696, ; 166: Xamarin.AndroidX.AppCompat.AppCompatResources.dll => 0xa32eb6f0 => 56
	i32 2740698338, ; 167: ca\Microsoft.Maui.Controls.resources.dll => 0xa35bbce2 => 1
	i32 2752995522, ; 168: pt-BR\Microsoft.Maui.Controls.resources => 0xa41760c2 => 21
	i32 2758225723, ; 169: Microsoft.Maui.Controls.Xaml => 0xa4672f3b => 50
	i32 2764765095, ; 170: Microsoft.Maui.dll => 0xa4caf7a7 => 51
	i32 2778768386, ; 171: Xamarin.AndroidX.ViewPager.dll => 0xa5a0a402 => 78
	i32 2785988530, ; 172: th\Microsoft.Maui.Controls.resources => 0xa60ecfb2 => 27
	i32 2801831435, ; 173: Microsoft.Maui.Graphics => 0xa7008e0b => 53
	i32 2810250172, ; 174: Xamarin.AndroidX.CoordinatorLayout.dll => 0xa78103bc => 60
	i32 2853208004, ; 175: Xamarin.AndroidX.ViewPager => 0xaa107fc4 => 78
	i32 2861189240, ; 176: Microsoft.Maui.Essentials => 0xaa8a4878 => 52
	i32 2909740682, ; 177: System.Private.CoreLib => 0xad6f1e8a => 122
	i32 2916838712, ; 178: Xamarin.AndroidX.ViewPager2.dll => 0xaddb6d38 => 79
	i32 2919462931, ; 179: System.Numerics.Vectors.dll => 0xae037813 => 105
	i32 2959614098, ; 180: System.ComponentModel.dll => 0xb0682092 => 91
	i32 2978675010, ; 181: Xamarin.AndroidX.DrawerLayout => 0xb18af942 => 64
	i32 3038032645, ; 182: _Microsoft.Android.Resource.Designer.dll => 0xb514b305 => 34
	i32 3053864966, ; 183: fi\Microsoft.Maui.Controls.resources.dll => 0xb6064806 => 7
	i32 3057625584, ; 184: Xamarin.AndroidX.Navigation.Common => 0xb63fa9f0 => 71
	i32 3059408633, ; 185: Mono.Android.Runtime => 0xb65adef9 => 124
	i32 3059793426, ; 186: System.ComponentModel.Primitives => 0xb660be12 => 89
	i32 3069363400, ; 187: Microsoft.Extensions.Caching.Abstractions.dll => 0xb6f2c4c8 => 39
	i32 3147165239, ; 188: System.Diagnostics.Tracing.dll => 0xbb95ee37 => 94
	i32 3178803400, ; 189: Xamarin.AndroidX.Navigation.Fragment.dll => 0xbd78b0c8 => 72
	i32 3195844289, ; 190: Microsoft.Extensions.Caching.Abstractions => 0xbe7cb6c1 => 39
	i32 3220365878, ; 191: System.Threading => 0xbff2e236 => 117
	i32 3258312781, ; 192: Xamarin.AndroidX.CardView => 0xc235e84d => 58
	i32 3265493905, ; 193: System.Linq.Queryable.dll => 0xc2a37b91 => 98
	i32 3280506390, ; 194: System.ComponentModel.Annotations.dll => 0xc3888e16 => 88
	i32 3305363605, ; 195: fi\Microsoft.Maui.Controls.resources => 0xc503d895 => 7
	i32 3316684772, ; 196: System.Net.Requests.dll => 0xc5b097e4 => 104
	i32 3317135071, ; 197: Xamarin.AndroidX.CustomView.dll => 0xc5b776df => 63
	i32 3346324047, ; 198: Xamarin.AndroidX.Navigation.Runtime => 0xc774da4f => 73
	i32 3357674450, ; 199: ru\Microsoft.Maui.Controls.resources => 0xc8220bd2 => 24
	i32 3358260929, ; 200: System.Text.Json => 0xc82afec1 => 114
	i32 3362522851, ; 201: Xamarin.AndroidX.Core => 0xc86c06e3 => 61
	i32 3366347497, ; 202: Java.Interop => 0xc8a662e9 => 123
	i32 3374999561, ; 203: Xamarin.AndroidX.RecyclerView => 0xc92a6809 => 75
	i32 3381016424, ; 204: da\Microsoft.Maui.Controls.resources => 0xc9863768 => 3
	i32 3428513518, ; 205: Microsoft.Extensions.DependencyInjection.dll => 0xcc5af6ee => 43
	i32 3458724246, ; 206: pt\Microsoft.Maui.Controls.resources.dll => 0xce27f196 => 22
	i32 3471940407, ; 207: System.ComponentModel.TypeConverter.dll => 0xcef19b37 => 90
	i32 3476120550, ; 208: Mono.Android => 0xcf3163e6 => 125
	i32 3484440000, ; 209: ro\Microsoft.Maui.Controls.resources => 0xcfb055c0 => 23
	i32 3485117614, ; 210: System.Text.Json.dll => 0xcfbaacae => 114
	i32 3580758918, ; 211: zh-HK\Microsoft.Maui.Controls.resources => 0xd56e0b86 => 31
	i32 3592228221, ; 212: zh-Hant\Microsoft.Maui.Controls.resources.dll => 0xd61d0d7d => 33
	i32 3608519521, ; 213: System.Linq.dll => 0xd715a361 => 99
	i32 3641597786, ; 214: Xamarin.AndroidX.Lifecycle.LiveData.Core => 0xd90e5f5a => 67
	i32 3643446276, ; 215: tr\Microsoft.Maui.Controls.resources => 0xd92a9404 => 28
	i32 3643854240, ; 216: Xamarin.AndroidX.Navigation.Fragment => 0xd930cda0 => 72
	i32 3657292374, ; 217: Microsoft.Extensions.Configuration.Abstractions.dll => 0xd9fdda56 => 42
	i32 3660523487, ; 218: System.Net.NetworkInformation => 0xda2f27df => 102
	i32 3672681054, ; 219: Mono.Android.dll => 0xdae8aa5e => 125
	i32 3682565725, ; 220: Xamarin.AndroidX.Browser => 0xdb7f7e5d => 57
	i32 3724971120, ; 221: Xamarin.AndroidX.Navigation.Common.dll => 0xde068c70 => 71
	i32 3748608112, ; 222: System.Diagnostics.DiagnosticSource => 0xdf6f3870 => 93
	i32 3751619990, ; 223: da\Microsoft.Maui.Controls.resources.dll => 0xdf9d2d96 => 3
	i32 3786282454, ; 224: Xamarin.AndroidX.Collection => 0xe1ae15d6 => 59
	i32 3792276235, ; 225: System.Collections.NonGeneric => 0xe2098b0b => 86
	i32 3823082795, ; 226: System.Security.Cryptography.dll => 0xe3df9d2b => 112
	i32 3841636137, ; 227: Microsoft.Extensions.DependencyInjection.Abstractions.dll => 0xe4fab729 => 44
	i32 3849253459, ; 228: System.Runtime.InteropServices.dll => 0xe56ef253 => 109
	i32 3896106733, ; 229: System.Collections.Concurrent.dll => 0xe839deed => 84
	i32 3896760992, ; 230: Xamarin.AndroidX.Core.dll => 0xe843daa0 => 61
	i32 3920221145, ; 231: nl\Microsoft.Maui.Controls.resources.dll => 0xe9a9d3d9 => 19
	i32 3928044579, ; 232: System.Xml.ReaderWriter => 0xea213423 => 120
	i32 3931092270, ; 233: Xamarin.AndroidX.Navigation.UI => 0xea4fb52e => 74
	i32 3955647286, ; 234: Xamarin.AndroidX.AppCompat.dll => 0xebc66336 => 55
	i32 4025784931, ; 235: System.Memory => 0xeff49a63 => 100
	i32 4046471985, ; 236: Microsoft.Maui.Controls.Xaml.dll => 0xf1304331 => 50
	i32 4073602200, ; 237: System.Threading.dll => 0xf2ce3c98 => 117
	i32 4091086043, ; 238: el\Microsoft.Maui.Controls.resources.dll => 0xf3d904db => 5
	i32 4094352644, ; 239: Microsoft.Maui.Essentials.dll => 0xf40add04 => 52
	i32 4100113165, ; 240: System.Private.Uri => 0xf462c30d => 107
	i32 4101842092, ; 241: Microsoft.Extensions.Caching.Memory => 0xf47d24ac => 40
	i32 4103439459, ; 242: uk\Microsoft.Maui.Controls.resources.dll => 0xf4958463 => 29
	i32 4126470640, ; 243: Microsoft.Extensions.DependencyInjection => 0xf5f4f1f0 => 43
	i32 4150914736, ; 244: uk\Microsoft.Maui.Controls.resources => 0xf769eeb0 => 29
	i32 4182413190, ; 245: Xamarin.AndroidX.Lifecycle.ViewModelSavedState.dll => 0xf94a8f86 => 69
	i32 4213026141, ; 246: System.Diagnostics.DiagnosticSource.dll => 0xfb1dad5d => 93
	i32 4249188766, ; 247: nb\Microsoft.Maui.Controls.resources.dll => 0xfd45799e => 18
	i32 4271975918, ; 248: Microsoft.Maui.Controls.dll => 0xfea12dee => 49
	i32 4274623895, ; 249: CommunityToolkit.Mvvm.dll => 0xfec99597 => 35
	i32 4274976490, ; 250: System.Runtime.Numerics => 0xfecef6ea => 110
	i32 4292120959 ; 251: Xamarin.AndroidX.Lifecycle.ViewModelSavedState => 0xffd4917f => 69
], align 4

@assembly_image_cache_indices = dso_local local_unnamed_addr constant [252 x i32] [
	i32 102, ; 0
	i32 0, ; 1
	i32 9, ; 2
	i32 116, ; 3
	i32 33, ; 4
	i32 53, ; 5
	i32 17, ; 6
	i32 109, ; 7
	i32 32, ; 8
	i32 25, ; 9
	i32 88, ; 10
	i32 59, ; 11
	i32 77, ; 12
	i32 91, ; 13
	i32 57, ; 14
	i32 30, ; 15
	i32 54, ; 16
	i32 8, ; 17
	i32 66, ; 18
	i32 83, ; 19
	i32 118, ; 20
	i32 116, ; 21
	i32 100, ; 22
	i32 34, ; 23
	i32 28, ; 24
	i32 87, ; 25
	i32 65, ; 26
	i32 119, ; 27
	i32 121, ; 28
	i32 6, ; 29
	i32 106, ; 30
	i32 48, ; 31
	i32 98, ; 32
	i32 27, ; 33
	i32 45, ; 34
	i32 63, ; 35
	i32 19, ; 36
	i32 113, ; 37
	i32 84, ; 38
	i32 104, ; 39
	i32 96, ; 40
	i32 25, ; 41
	i32 47, ; 42
	i32 107, ; 43
	i32 95, ; 44
	i32 10, ; 45
	i32 24, ; 46
	i32 89, ; 47
	i32 21, ; 48
	i32 14, ; 49
	i32 66, ; 50
	i32 94, ; 51
	i32 23, ; 52
	i32 87, ; 53
	i32 76, ; 54
	i32 44, ; 55
	i32 55, ; 56
	i32 4, ; 57
	i32 97, ; 58
	i32 68, ; 59
	i32 90, ; 60
	i32 81, ; 61
	i32 121, ; 62
	i32 26, ; 63
	i32 20, ; 64
	i32 16, ; 65
	i32 37, ; 66
	i32 22, ; 67
	i32 73, ; 68
	i32 37, ; 69
	i32 40, ; 70
	i32 35, ; 71
	i32 2, ; 72
	i32 64, ; 73
	i32 11, ; 74
	i32 99, ; 75
	i32 31, ; 76
	i32 32, ; 77
	i32 76, ; 78
	i32 60, ; 79
	i32 0, ; 80
	i32 6, ; 81
	i32 85, ; 82
	i32 96, ; 83
	i32 56, ; 84
	i32 48, ; 85
	i32 85, ; 86
	i32 95, ; 87
	i32 30, ; 88
	i32 115, ; 89
	i32 70, ; 90
	i32 79, ; 91
	i32 62, ; 92
	i32 101, ; 93
	i32 115, ; 94
	i32 111, ; 95
	i32 80, ; 96
	i32 103, ; 97
	i32 112, ; 98
	i32 36, ; 99
	i32 58, ; 100
	i32 1, ; 101
	i32 118, ; 102
	i32 77, ; 103
	i32 45, ; 104
	i32 124, ; 105
	i32 17, ; 106
	i32 65, ; 107
	i32 9, ; 108
	i32 70, ; 109
	i32 81, ; 110
	i32 80, ; 111
	i32 74, ; 112
	i32 46, ; 113
	i32 26, ; 114
	i32 97, ; 115
	i32 8, ; 116
	i32 2, ; 117
	i32 86, ; 118
	i32 13, ; 119
	i32 41, ; 120
	i32 38, ; 121
	i32 5, ; 122
	i32 68, ; 123
	i32 108, ; 124
	i32 67, ; 125
	i32 4, ; 126
	i32 111, ; 127
	i32 105, ; 128
	i32 92, ; 129
	i32 51, ; 130
	i32 12, ; 131
	i32 47, ; 132
	i32 46, ; 133
	i32 106, ; 134
	i32 82, ; 135
	i32 101, ; 136
	i32 14, ; 137
	i32 36, ; 138
	i32 42, ; 139
	i32 75, ; 140
	i32 18, ; 141
	i32 122, ; 142
	i32 103, ; 143
	i32 12, ; 144
	i32 120, ; 145
	i32 41, ; 146
	i32 13, ; 147
	i32 119, ; 148
	i32 83, ; 149
	i32 10, ; 150
	i32 92, ; 151
	i32 38, ; 152
	i32 123, ; 153
	i32 49, ; 154
	i32 16, ; 155
	i32 11, ; 156
	i32 113, ; 157
	i32 15, ; 158
	i32 20, ; 159
	i32 82, ; 160
	i32 108, ; 161
	i32 62, ; 162
	i32 15, ; 163
	i32 110, ; 164
	i32 54, ; 165
	i32 56, ; 166
	i32 1, ; 167
	i32 21, ; 168
	i32 50, ; 169
	i32 51, ; 170
	i32 78, ; 171
	i32 27, ; 172
	i32 53, ; 173
	i32 60, ; 174
	i32 78, ; 175
	i32 52, ; 176
	i32 122, ; 177
	i32 79, ; 178
	i32 105, ; 179
	i32 91, ; 180
	i32 64, ; 181
	i32 34, ; 182
	i32 7, ; 183
	i32 71, ; 184
	i32 124, ; 185
	i32 89, ; 186
	i32 39, ; 187
	i32 94, ; 188
	i32 72, ; 189
	i32 39, ; 190
	i32 117, ; 191
	i32 58, ; 192
	i32 98, ; 193
	i32 88, ; 194
	i32 7, ; 195
	i32 104, ; 196
	i32 63, ; 197
	i32 73, ; 198
	i32 24, ; 199
	i32 114, ; 200
	i32 61, ; 201
	i32 123, ; 202
	i32 75, ; 203
	i32 3, ; 204
	i32 43, ; 205
	i32 22, ; 206
	i32 90, ; 207
	i32 125, ; 208
	i32 23, ; 209
	i32 114, ; 210
	i32 31, ; 211
	i32 33, ; 212
	i32 99, ; 213
	i32 67, ; 214
	i32 28, ; 215
	i32 72, ; 216
	i32 42, ; 217
	i32 102, ; 218
	i32 125, ; 219
	i32 57, ; 220
	i32 71, ; 221
	i32 93, ; 222
	i32 3, ; 223
	i32 59, ; 224
	i32 86, ; 225
	i32 112, ; 226
	i32 44, ; 227
	i32 109, ; 228
	i32 84, ; 229
	i32 61, ; 230
	i32 19, ; 231
	i32 120, ; 232
	i32 74, ; 233
	i32 55, ; 234
	i32 100, ; 235
	i32 50, ; 236
	i32 117, ; 237
	i32 5, ; 238
	i32 52, ; 239
	i32 107, ; 240
	i32 40, ; 241
	i32 29, ; 242
	i32 43, ; 243
	i32 29, ; 244
	i32 69, ; 245
	i32 93, ; 246
	i32 18, ; 247
	i32 49, ; 248
	i32 35, ; 249
	i32 110, ; 250
	i32 69 ; 251
], align 4

@marshal_methods_number_of_classes = dso_local local_unnamed_addr constant i32 0, align 4

@marshal_methods_class_cache = dso_local local_unnamed_addr global [0 x %struct.MarshalMethodsManagedClass] zeroinitializer, align 4

; Names of classes in which marshal methods reside
@mm_class_names = dso_local local_unnamed_addr constant [0 x ptr] zeroinitializer, align 4

@mm_method_names = dso_local local_unnamed_addr constant [1 x %struct.MarshalMethodName] [
	%struct.MarshalMethodName {
		i64 0, ; id 0x0; name: 
		ptr @.MarshalMethodName.0_name; char* name
	} ; 0
], align 8

; get_function_pointer (uint32_t mono_image_index, uint32_t class_index, uint32_t method_token, void*& target_ptr)
@get_function_pointer = internal dso_local unnamed_addr global ptr null, align 4

; Functions

; Function attributes: "min-legal-vector-width"="0" mustprogress nofree norecurse nosync "no-trapping-math"="true" nounwind "stack-protector-buffer-size"="8" uwtable willreturn
define void @xamarin_app_init(ptr nocapture noundef readnone %env, ptr noundef %fn) local_unnamed_addr #0
{
	%fnIsNull = icmp eq ptr %fn, null
	br i1 %fnIsNull, label %1, label %2

1: ; preds = %0
	%putsResult = call noundef i32 @puts(ptr @.str.0)
	call void @abort()
	unreachable 

2: ; preds = %1, %0
	store ptr %fn, ptr @get_function_pointer, align 4, !tbaa !3
	ret void
}

; Strings
@.str.0 = private unnamed_addr constant [40 x i8] c"get_function_pointer MUST be specified\0A\00", align 1

;MarshalMethodName
@.MarshalMethodName.0_name = private unnamed_addr constant [1 x i8] c"\00", align 1

; External functions

; Function attributes: noreturn "no-trapping-math"="true" nounwind "stack-protector-buffer-size"="8"
declare void @abort() local_unnamed_addr #2

; Function attributes: nofree nounwind
declare noundef i32 @puts(ptr noundef) local_unnamed_addr #1
attributes #0 = { "min-legal-vector-width"="0" mustprogress nofree norecurse nosync "no-trapping-math"="true" nounwind "stack-protector-buffer-size"="8" "target-cpu"="generic" "target-features"="+armv7-a,+d32,+dsp,+fp64,+neon,+vfp2,+vfp2sp,+vfp3,+vfp3d16,+vfp3d16sp,+vfp3sp,-aes,-fp-armv8,-fp-armv8d16,-fp-armv8d16sp,-fp-armv8sp,-fp16,-fp16fml,-fullfp16,-sha2,-thumb-mode,-vfp4,-vfp4d16,-vfp4d16sp,-vfp4sp" uwtable willreturn }
attributes #1 = { nofree nounwind }
attributes #2 = { noreturn "no-trapping-math"="true" nounwind "stack-protector-buffer-size"="8" "target-cpu"="generic" "target-features"="+armv7-a,+d32,+dsp,+fp64,+neon,+vfp2,+vfp2sp,+vfp3,+vfp3d16,+vfp3d16sp,+vfp3sp,-aes,-fp-armv8,-fp-armv8d16,-fp-armv8d16sp,-fp-armv8sp,-fp16,-fp16fml,-fullfp16,-sha2,-thumb-mode,-vfp4,-vfp4d16,-vfp4d16sp,-vfp4sp" }

; Metadata
!llvm.module.flags = !{!0, !1, !7}
!0 = !{i32 1, !"wchar_size", i32 4}
!1 = !{i32 7, !"PIC Level", i32 2}
!llvm.ident = !{!2}
!2 = !{!"Xamarin.Android remotes/origin/release/8.0.1xx @ f1b7113872c8db3dfee70d11925e81bb752dc8d0"}
!3 = !{!4, !4, i64 0}
!4 = !{!"any pointer", !5, i64 0}
!5 = !{!"omnipotent char", !6, i64 0}
!6 = !{!"Simple C++ TBAA"}
!7 = !{i32 1, !"min_enum_size", i32 4}
