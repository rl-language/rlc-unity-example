using System;
using System.Runtime.InteropServices;

public unsafe class RLCNative {
const string LIBDL = "libdl.so.2";
const int RTLD_NOW = 2;
[DllImport(LIBDL)] static extern IntPtr dlopen (string path, int flags);
[DllImport(LIBDL)] static extern int    dlclose(IntPtr handle);
[DllImport(LIBDL)] static extern IntPtr dlsym  (IntPtr handle, string name);
[DllImport(LIBDL, CharSet = CharSet.Ansi, ExactSpelling = true)]
static extern IntPtr dlerror();
static IntPtr LoadLibrary (string p) => dlopen (p, RTLD_NOW);
static string DlLastError()
{
    IntPtr p = dlerror();
    return p != IntPtr.Zero ? Marshal.PtrToStringAnsi(p) : null;
		}
static bool   FreeLibrary (IntPtr h)  { dlclose(h); return true; }
static IntPtr GetProcAddress(IntPtr h,string n)=>dlsym(h,n);
    public delegate void Delegaterl_m_init__Range(ref Range.Content self);
    public static Delegaterl_m_init__Range rl_m_init__Range;
    public delegate void Delegaterl_m_init__AnyGameAction(ref AnyGameAction.Content self);
    public static Delegaterl_m_init__AnyGameAction rl_m_init__AnyGameAction;
    public delegate void Delegaterl_m_init__Game(ref Game.Content self);
    public static Delegaterl_m_init__Game rl_m_init__Game;
    public delegate void Delegaterl_m_init__Board(ref Board.Content self);
    public static Delegaterl_m_init__Board rl_m_init__Board;
    public delegate void Delegaterl_m_init__BIntT0T3T_9(ref BIntT0T3T_9.Content self);
    public static Delegaterl_m_init__BIntT0T3T_9 rl_m_init__BIntT0T3T_9;
    public delegate void Delegaterl_m_init__strlit(ref char* self);
    public static Delegaterl_m_init__strlit rl_m_init__strlit;
    public delegate void Delegaterl_m_init__int8_t_1(ref int8_t_1.Content self);
    public static Delegaterl_m_init__int8_t_1 rl_m_init__int8_t_1;
    public delegate void Delegaterl_m_init__int8_t_8(ref int8_t_8.Content self);
    public static Delegaterl_m_init__int8_t_8 rl_m_init__int8_t_8;
    public delegate void Delegaterl_m_init__GameMark(ref GameMark.Content self);
    public static Delegaterl_m_init__GameMark rl_m_init__GameMark;
    public delegate void Delegaterl_m_assign__Game_Game(ref Game.Content self, ref Game.Content other);
    public static Delegaterl_m_assign__Game_Game rl_m_assign__Game_Game;
    public delegate void Delegaterl_m_assign__Board_Board(ref Board.Content self, ref Board.Content other);
    public static Delegaterl_m_assign__Board_Board rl_m_assign__Board_Board;
    public delegate void Delegaterl_m_assign__BIntT0T3T_9_BIntT0T3T_9(ref BIntT0T3T_9.Content self, ref BIntT0T3T_9.Content other);
    public static Delegaterl_m_assign__BIntT0T3T_9_BIntT0T3T_9 rl_m_assign__BIntT0T3T_9_BIntT0T3T_9;
    public delegate void Delegaterl_m_assign__strlit_strlit(ref char* self, ref char* other);
    public static Delegaterl_m_assign__strlit_strlit rl_m_assign__strlit_strlit;
    public delegate void Delegaterl_m_assign__AnyGameAction_GameMark(ref AnyGameAction.Content self, ref GameMark.Content other);
    public static Delegaterl_m_assign__AnyGameAction_GameMark rl_m_assign__AnyGameAction_GameMark;
    public delegate void Delegaterl_m_assign__AnyGameAction_AnyGameAction(ref AnyGameAction.Content self, ref AnyGameAction.Content other);
    public static Delegaterl_m_assign__AnyGameAction_AnyGameAction rl_m_assign__AnyGameAction_AnyGameAction;
    public delegate void Delegaterl_m_assign__GameMark_GameMark(ref GameMark.Content self, ref GameMark.Content other);
    public static Delegaterl_m_assign__GameMark_GameMark rl_m_assign__GameMark_GameMark;
    public delegate void Delegaterl_m_assign__BIntT0T3T_BIntT0T3T(ref BIntT0T3T.Content self, ref BIntT0T3T.Content other);
    public static Delegaterl_m_assign__BIntT0T3T_BIntT0T3T rl_m_assign__BIntT0T3T_BIntT0T3T;
    public delegate void Delegaterl_m_assign__Range_Range(ref Range.Content self, ref Range.Content other);
    public static Delegaterl_m_assign__Range_Range rl_m_assign__Range_Range;
    public delegate void Delegaterl_m_assign__String_String(ref String.Content self, ref String.Content other);
    public static Delegaterl_m_assign__String_String rl_m_assign__String_String;
    public delegate void Delegaterl_m_drop__String(ref String.Content self);
    public static Delegaterl_m_drop__String rl_m_drop__String;
    public delegate void Delegaterl_print_string__String(ref String.Content s);
    public static Delegaterl_print_string__String rl_print_string__String;
    public delegate void Delegaterl_print_string_lit__strlit(ref char* s);
    public static Delegaterl_print_string_lit__strlit rl_print_string_lit__strlit;
    public delegate void Delegaterl_print__String(ref String.Content to_print);
    public static Delegaterl_print__String rl_print__String;
    public delegate void Delegaterl_print__AnyGameAction(ref AnyGameAction.Content to_print);
    public static Delegaterl_print__AnyGameAction rl_print__AnyGameAction;
    public delegate void Delegaterl_print__Game(ref Game.Content to_print);
    public static Delegaterl_print__Game rl_print__Game;
    public delegate void Delegaterl_append_to_vector__int64_t_VectorTint8_tT(ref long to_add, ref VectorTint8_tT.Content output);
    public static Delegaterl_append_to_vector__int64_t_VectorTint8_tT rl_append_to_vector__int64_t_VectorTint8_tT;
    public delegate void Delegaterl_append_to_vector__double_VectorTint8_tT(ref double to_add, ref VectorTint8_tT.Content output);
    public static Delegaterl_append_to_vector__double_VectorTint8_tT rl_append_to_vector__double_VectorTint8_tT;
    public delegate void Delegaterl_append_to_vector__bool_VectorTint8_tT(ref bool to_add, ref VectorTint8_tT.Content output);
    public static Delegaterl_append_to_vector__bool_VectorTint8_tT rl_append_to_vector__bool_VectorTint8_tT;
    public delegate void Delegaterl_append_to_vector__int8_t_VectorTint8_tT(ref sbyte to_add, ref VectorTint8_tT.Content output);
    public static Delegaterl_append_to_vector__int8_t_VectorTint8_tT rl_append_to_vector__int8_t_VectorTint8_tT;
    public delegate void Delegaterl_append_to_vector__BIntT0T3T_9_VectorTint8_tT(ref BIntT0T3T_9.Content to_add, ref VectorTint8_tT.Content output);
    public static Delegaterl_append_to_vector__BIntT0T3T_9_VectorTint8_tT rl_append_to_vector__BIntT0T3T_9_VectorTint8_tT;
    public delegate void Delegaterl_as_byte_vector__Game_r_VectorTint8_tT(ref VectorTint8_tT.Content __result, ref Game.Content to_convert);
    public static Delegaterl_as_byte_vector__Game_r_VectorTint8_tT rl_as_byte_vector__Game_r_VectorTint8_tT;
    public delegate void Delegaterl_parse_from_vector__int64_t_VectorTint8_tT_int64_t_r_bool(ref bool __result, ref long result, ref VectorTint8_tT.Content input, ref long index);
    public static Delegaterl_parse_from_vector__int64_t_VectorTint8_tT_int64_t_r_bool rl_parse_from_vector__int64_t_VectorTint8_tT_int64_t_r_bool;
    public delegate void Delegaterl_parse_from_vector__double_VectorTint8_tT_int64_t_r_bool(ref bool __result, ref double result, ref VectorTint8_tT.Content input, ref long index);
    public static Delegaterl_parse_from_vector__double_VectorTint8_tT_int64_t_r_bool rl_parse_from_vector__double_VectorTint8_tT_int64_t_r_bool;
    public delegate void Delegaterl_parse_from_vector__bool_VectorTint8_tT_int64_t_r_bool(ref bool __result, ref bool result, ref VectorTint8_tT.Content input, ref long index);
    public static Delegaterl_parse_from_vector__bool_VectorTint8_tT_int64_t_r_bool rl_parse_from_vector__bool_VectorTint8_tT_int64_t_r_bool;
    public delegate void Delegaterl_parse_from_vector__int8_t_VectorTint8_tT_int64_t_r_bool(ref bool __result, ref sbyte result, ref VectorTint8_tT.Content input, ref long index);
    public static Delegaterl_parse_from_vector__int8_t_VectorTint8_tT_int64_t_r_bool rl_parse_from_vector__int8_t_VectorTint8_tT_int64_t_r_bool;
    public delegate void Delegaterl_parse_from_vector__BIntT0T3T_9_VectorTint8_tT_int64_t_r_bool(ref bool __result, ref BIntT0T3T_9.Content to_add, ref VectorTint8_tT.Content input, ref long index);
    public static Delegaterl_parse_from_vector__BIntT0T3T_9_VectorTint8_tT_int64_t_r_bool rl_parse_from_vector__BIntT0T3T_9_VectorTint8_tT_int64_t_r_bool;
    public delegate void Delegaterl_from_byte_vector__Game_VectorTint8_tT_r_bool(ref bool __result, ref Game.Content result, ref VectorTint8_tT.Content input);
    public static Delegaterl_from_byte_vector__Game_VectorTint8_tT_r_bool rl_from_byte_vector__Game_VectorTint8_tT_r_bool;
    public delegate void Delegaterl_from_byte_vector__AnyGameAction_VectorTint8_tT_r_bool(ref bool __result, ref AnyGameAction.Content result, ref VectorTint8_tT.Content input);
    public static Delegaterl_from_byte_vector__AnyGameAction_VectorTint8_tT_r_bool rl_from_byte_vector__AnyGameAction_VectorTint8_tT_r_bool;
    public delegate void Delegaterl_from_byte_vector__int8_t_VectorTint8_tT_int64_t_r_bool(ref bool __result, ref sbyte result, ref VectorTint8_tT.Content input, ref long read_bytes);
    public static Delegaterl_from_byte_vector__int8_t_VectorTint8_tT_int64_t_r_bool rl_from_byte_vector__int8_t_VectorTint8_tT_int64_t_r_bool;
    public delegate void Delegaterl_from_byte_vector__int64_t_VectorTint8_tT_int64_t_r_bool(ref bool __result, ref long result, ref VectorTint8_tT.Content input, ref long read_bytes);
    public static Delegaterl_from_byte_vector__int64_t_VectorTint8_tT_int64_t_r_bool rl_from_byte_vector__int64_t_VectorTint8_tT_int64_t_r_bool;
    public delegate void Delegaterl_from_byte_vector__GameMark_VectorTint8_tT_int64_t_r_bool(ref bool __result, ref GameMark.Content result, ref VectorTint8_tT.Content input, ref long read_bytes);
    public static Delegaterl_from_byte_vector__GameMark_VectorTint8_tT_int64_t_r_bool rl_from_byte_vector__GameMark_VectorTint8_tT_int64_t_r_bool;
    public delegate void Delegaterl_from_byte_vector__AnyGameAction_VectorTint8_tT_int64_t_r_bool(ref bool __result, ref AnyGameAction.Content result, ref VectorTint8_tT.Content input, ref long read_bytes);
    public static Delegaterl_from_byte_vector__AnyGameAction_VectorTint8_tT_int64_t_r_bool rl_from_byte_vector__AnyGameAction_VectorTint8_tT_int64_t_r_bool;
    public delegate void Delegaterl_m_size__VectorTint8_tT_r_int64_t(ref long __result, ref VectorTint8_tT.Content self);
    public static Delegaterl_m_size__VectorTint8_tT_r_int64_t rl_m_size__VectorTint8_tT_r_int64_t;
    public delegate void Delegaterl_m_size__VectorTdoubleT_r_int64_t(ref long __result, ref VectorTdoubleT.Content self);
    public static Delegaterl_m_size__VectorTdoubleT_r_int64_t rl_m_size__VectorTdoubleT_r_int64_t;
    public delegate void Delegaterl_m_size__VectorTStringT_r_int64_t(ref long __result, ref VectorTStringT.Content self);
    public static Delegaterl_m_size__VectorTStringT_r_int64_t rl_m_size__VectorTStringT_r_int64_t;
    public delegate void Delegaterl_m_size__VectorTAnyGameActionT_r_int64_t(ref long __result, ref VectorTAnyGameActionT.Content self);
    public static Delegaterl_m_size__VectorTAnyGameActionT_r_int64_t rl_m_size__VectorTAnyGameActionT_r_int64_t;
    public delegate void Delegaterl_m_size__VectorTGameMarkT_r_int64_t(ref long __result, ref VectorTGameMarkT.Content self);
    public static Delegaterl_m_size__VectorTGameMarkT_r_int64_t rl_m_size__VectorTGameMarkT_r_int64_t;
    public delegate void Delegaterl_m_size__VectorTBIntT0T3TT_r_int64_t(ref long __result, ref VectorTBIntT0T3TT.Content self);
    public static Delegaterl_m_size__VectorTBIntT0T3TT_r_int64_t rl_m_size__VectorTBIntT0T3TT_r_int64_t;
    public delegate void Delegaterl_m_drop_back__VectorTint8_tT_int64_t(ref VectorTint8_tT.Content self, ref long quantity);
    public static Delegaterl_m_drop_back__VectorTint8_tT_int64_t rl_m_drop_back__VectorTint8_tT_int64_t;
    public delegate void Delegaterl_m_pop__VectorTint8_tT_r_int8_t(ref sbyte __result, ref VectorTint8_tT.Content self);
    public static Delegaterl_m_pop__VectorTint8_tT_r_int8_t rl_m_pop__VectorTint8_tT_r_int8_t;
    public delegate void Delegaterl_m_pop__VectorTStringT_r_String(ref String.Content __result, ref VectorTStringT.Content self);
    public static Delegaterl_m_pop__VectorTStringT_r_String rl_m_pop__VectorTStringT_r_String;
    public delegate void Delegaterl_m_pop__VectorTdoubleT_r_double(ref double __result, ref VectorTdoubleT.Content self);
    public static Delegaterl_m_pop__VectorTdoubleT_r_double rl_m_pop__VectorTdoubleT_r_double;
    public delegate void Delegaterl_m_append__VectorTint8_tT_int8_t(ref VectorTint8_tT.Content self, ref sbyte value);
    public static Delegaterl_m_append__VectorTint8_tT_int8_t rl_m_append__VectorTint8_tT_int8_t;
    public delegate void Delegaterl_m_append__VectorTboolT_bool(ref VectorTboolT.Content self, ref bool value);
    public static Delegaterl_m_append__VectorTboolT_bool rl_m_append__VectorTboolT_bool;
    public delegate void Delegaterl_m_append__VectorTStringT_String(ref VectorTStringT.Content self, ref String.Content value);
    public static Delegaterl_m_append__VectorTStringT_String rl_m_append__VectorTStringT_String;
    public delegate void Delegaterl_m_append__VectorTdoubleT_double(ref VectorTdoubleT.Content self, ref double value);
    public static Delegaterl_m_append__VectorTdoubleT_double rl_m_append__VectorTdoubleT_double;
    public delegate void Delegaterl_m_append__VectorTAnyGameActionT_AnyGameAction(ref VectorTAnyGameActionT.Content self, ref AnyGameAction.Content value);
    public static Delegaterl_m_append__VectorTAnyGameActionT_AnyGameAction rl_m_append__VectorTAnyGameActionT_AnyGameAction;
    public delegate void Delegaterl_m_append__VectorTGameMarkT_GameMark(ref VectorTGameMarkT.Content self, ref GameMark.Content value);
    public static Delegaterl_m_append__VectorTGameMarkT_GameMark rl_m_append__VectorTGameMarkT_GameMark;
    public delegate void Delegaterl_m_append__VectorTBIntT0T3TT_BIntT0T3T(ref VectorTBIntT0T3TT.Content self, ref BIntT0T3T.Content value);
    public static Delegaterl_m_append__VectorTBIntT0T3TT_BIntT0T3T rl_m_append__VectorTBIntT0T3TT_BIntT0T3T;
    public delegate void Delegaterl_m_get__VectorTint8_tT_int64_t_r_int8_tRef(ref sbyte* __result, ref VectorTint8_tT.Content self, ref long index);
    public static Delegaterl_m_get__VectorTint8_tT_int64_t_r_int8_tRef rl_m_get__VectorTint8_tT_int64_t_r_int8_tRef;
    public delegate void Delegaterl_m_get__VectorTdoubleT_int64_t_r_doubleRef(ref double* __result, ref VectorTdoubleT.Content self, ref long index);
    public static Delegaterl_m_get__VectorTdoubleT_int64_t_r_doubleRef rl_m_get__VectorTdoubleT_int64_t_r_doubleRef;
    public delegate void Delegaterl_m_get__VectorTStringT_int64_t_r_StringRef(ref String.Content* __result, ref VectorTStringT.Content self, ref long index);
    public static Delegaterl_m_get__VectorTStringT_int64_t_r_StringRef rl_m_get__VectorTStringT_int64_t_r_StringRef;
    public delegate void Delegaterl_m_get__VectorTAnyGameActionT_int64_t_r_AnyGameActionRef(ref AnyGameAction.Content* __result, ref VectorTAnyGameActionT.Content self, ref long index);
    public static Delegaterl_m_get__VectorTAnyGameActionT_int64_t_r_AnyGameActionRef rl_m_get__VectorTAnyGameActionT_int64_t_r_AnyGameActionRef;
    public delegate void Delegaterl_m_get__VectorTboolT_int64_t_r_boolRef(ref bool* __result, ref VectorTboolT.Content self, ref long index);
    public static Delegaterl_m_get__VectorTboolT_int64_t_r_boolRef rl_m_get__VectorTboolT_int64_t_r_boolRef;
    public delegate void Delegaterl_m_get__VectorTGameMarkT_int64_t_r_GameMarkRef(ref GameMark.Content* __result, ref VectorTGameMarkT.Content self, ref long index);
    public static Delegaterl_m_get__VectorTGameMarkT_int64_t_r_GameMarkRef rl_m_get__VectorTGameMarkT_int64_t_r_GameMarkRef;
    public delegate void Delegaterl_m_get__VectorTBIntT0T3TT_int64_t_r_BIntT0T3TRef(ref BIntT0T3T.Content* __result, ref VectorTBIntT0T3TT.Content self, ref long index);
    public static Delegaterl_m_get__VectorTBIntT0T3TT_int64_t_r_BIntT0T3TRef rl_m_get__VectorTBIntT0T3TT_int64_t_r_BIntT0T3TRef;
    public delegate void Delegaterl_m_back__VectorTint8_tT_r_int8_tRef(ref sbyte* __result, ref VectorTint8_tT.Content self);
    public static Delegaterl_m_back__VectorTint8_tT_r_int8_tRef rl_m_back__VectorTint8_tT_r_int8_tRef;
    public delegate void Delegaterl_m_resize__VectorTdoubleT_int64_t(ref VectorTdoubleT.Content self, ref long new_size);
    public static Delegaterl_m_resize__VectorTdoubleT_int64_t rl_m_resize__VectorTdoubleT_int64_t;
    public delegate void Delegaterl_m_assign__VectorTint8_tT_VectorTint8_tT(ref VectorTint8_tT.Content self, ref VectorTint8_tT.Content other);
    public static Delegaterl_m_assign__VectorTint8_tT_VectorTint8_tT rl_m_assign__VectorTint8_tT_VectorTint8_tT;
    public delegate void Delegaterl_m_assign__VectorTStringT_VectorTStringT(ref VectorTStringT.Content self, ref VectorTStringT.Content other);
    public static Delegaterl_m_assign__VectorTStringT_VectorTStringT rl_m_assign__VectorTStringT_VectorTStringT;
    public delegate void Delegaterl_m_assign__VectorTdoubleT_VectorTdoubleT(ref VectorTdoubleT.Content self, ref VectorTdoubleT.Content other);
    public static Delegaterl_m_assign__VectorTdoubleT_VectorTdoubleT rl_m_assign__VectorTdoubleT_VectorTdoubleT;
    public delegate void Delegaterl_m_assign__VectorTboolT_VectorTboolT(ref VectorTboolT.Content self, ref VectorTboolT.Content other);
    public static Delegaterl_m_assign__VectorTboolT_VectorTboolT rl_m_assign__VectorTboolT_VectorTboolT;
    public delegate void Delegaterl_m_assign__VectorTAnyGameActionT_VectorTAnyGameActionT(ref VectorTAnyGameActionT.Content self, ref VectorTAnyGameActionT.Content other);
    public static Delegaterl_m_assign__VectorTAnyGameActionT_VectorTAnyGameActionT rl_m_assign__VectorTAnyGameActionT_VectorTAnyGameActionT;
    public delegate void Delegaterl_m_assign__VectorTGameMarkT_VectorTGameMarkT(ref VectorTGameMarkT.Content self, ref VectorTGameMarkT.Content other);
    public static Delegaterl_m_assign__VectorTGameMarkT_VectorTGameMarkT rl_m_assign__VectorTGameMarkT_VectorTGameMarkT;
    public delegate void Delegaterl_m_assign__VectorTBIntT0T3TT_VectorTBIntT0T3TT(ref VectorTBIntT0T3TT.Content self, ref VectorTBIntT0T3TT.Content other);
    public static Delegaterl_m_assign__VectorTBIntT0T3TT_VectorTBIntT0T3TT rl_m_assign__VectorTBIntT0T3TT_VectorTBIntT0T3TT;
    public delegate void Delegaterl_m_drop__VectorTint8_tT(ref VectorTint8_tT.Content self);
    public static Delegaterl_m_drop__VectorTint8_tT rl_m_drop__VectorTint8_tT;
    public delegate void Delegaterl_m_drop__VectorTdoubleT(ref VectorTdoubleT.Content self);
    public static Delegaterl_m_drop__VectorTdoubleT rl_m_drop__VectorTdoubleT;
    public delegate void Delegaterl_m_drop__VectorTStringT(ref VectorTStringT.Content self);
    public static Delegaterl_m_drop__VectorTStringT rl_m_drop__VectorTStringT;
    public delegate void Delegaterl_m_drop__VectorTAnyGameActionT(ref VectorTAnyGameActionT.Content self);
    public static Delegaterl_m_drop__VectorTAnyGameActionT rl_m_drop__VectorTAnyGameActionT;
    public delegate void Delegaterl_m_drop__VectorTboolT(ref VectorTboolT.Content self);
    public static Delegaterl_m_drop__VectorTboolT rl_m_drop__VectorTboolT;
    public delegate void Delegaterl_m_drop__VectorTGameMarkT(ref VectorTGameMarkT.Content self);
    public static Delegaterl_m_drop__VectorTGameMarkT rl_m_drop__VectorTGameMarkT;
    public delegate void Delegaterl_m_drop__VectorTBIntT0T3TT(ref VectorTBIntT0T3TT.Content self);
    public static Delegaterl_m_drop__VectorTBIntT0T3TT rl_m_drop__VectorTBIntT0T3TT;
    public delegate void Delegaterl_m_init__VectorTint8_tT(ref VectorTint8_tT.Content self);
    public static Delegaterl_m_init__VectorTint8_tT rl_m_init__VectorTint8_tT;
    public delegate void Delegaterl_m_init__VectorTdoubleT(ref VectorTdoubleT.Content self);
    public static Delegaterl_m_init__VectorTdoubleT rl_m_init__VectorTdoubleT;
    public delegate void Delegaterl_m_init__VectorTStringT(ref VectorTStringT.Content self);
    public static Delegaterl_m_init__VectorTStringT rl_m_init__VectorTStringT;
    public delegate void Delegaterl_m_init__VectorTAnyGameActionT(ref VectorTAnyGameActionT.Content self);
    public static Delegaterl_m_init__VectorTAnyGameActionT rl_m_init__VectorTAnyGameActionT;
    public delegate void Delegaterl_m_init__VectorTboolT(ref VectorTboolT.Content self);
    public static Delegaterl_m_init__VectorTboolT rl_m_init__VectorTboolT;
    public delegate void Delegaterl_m_init__VectorTGameMarkT(ref VectorTGameMarkT.Content self);
    public static Delegaterl_m_init__VectorTGameMarkT rl_m_init__VectorTGameMarkT;
    public delegate void Delegaterl_m_init__VectorTBIntT0T3TT(ref VectorTBIntT0T3TT.Content self);
    public static Delegaterl_m_init__VectorTBIntT0T3TT rl_m_init__VectorTBIntT0T3TT;
    public delegate void Delegaterl_m_to_indented_lines__String_r_String(ref String.Content __result, ref String.Content self);
    public static Delegaterl_m_to_indented_lines__String_r_String rl_m_to_indented_lines__String_r_String;
    public delegate void Delegaterl_m_reverse__String(ref String.Content self);
    public static Delegaterl_m_reverse__String rl_m_reverse__String;
    public delegate void Delegaterl_m_back__String_r_int8_tRef(ref sbyte* __result, ref String.Content self);
    public static Delegaterl_m_back__String_r_int8_tRef rl_m_back__String_r_int8_tRef;
    public delegate void Delegaterl_m_drop_back__String_int64_t(ref String.Content self, ref long quantity);
    public static Delegaterl_m_drop_back__String_int64_t rl_m_drop_back__String_int64_t;
    public delegate void Delegaterl_m_not_equal__String_strlit_r_bool(ref bool __result, ref String.Content self, ref char* other);
    public static Delegaterl_m_not_equal__String_strlit_r_bool rl_m_not_equal__String_strlit_r_bool;
    public delegate void Delegaterl_m_not_equal__String_String_r_bool(ref bool __result, ref String.Content self, ref String.Content other);
    public static Delegaterl_m_not_equal__String_String_r_bool rl_m_not_equal__String_String_r_bool;
    public delegate void Delegaterl_m_equal__String_String_r_bool(ref bool __result, ref String.Content self, ref String.Content other);
    public static Delegaterl_m_equal__String_String_r_bool rl_m_equal__String_String_r_bool;
    public delegate void Delegaterl_m_equal__String_strlit_r_bool(ref bool __result, ref String.Content self, ref char* other);
    public static Delegaterl_m_equal__String_strlit_r_bool rl_m_equal__String_strlit_r_bool;
    public delegate void Delegaterl_m_add__String_String_r_String(ref String.Content __result, ref String.Content self, ref String.Content other);
    public static Delegaterl_m_add__String_String_r_String rl_m_add__String_String_r_String;
    public delegate void Delegaterl_m_append_quoted__String_String(ref String.Content self, ref String.Content str);
    public static Delegaterl_m_append_quoted__String_String rl_m_append_quoted__String_String;
    public delegate void Delegaterl_m_append__String_String(ref String.Content self, ref String.Content str);
    public static Delegaterl_m_append__String_String rl_m_append__String_String;
    public delegate void Delegaterl_m_append__String_strlit(ref String.Content self, ref char* str);
    public static Delegaterl_m_append__String_strlit rl_m_append__String_strlit;
    public delegate void Delegaterl_m_count__String_int8_t_r_int64_t(ref long __result, ref String.Content self, ref sbyte b);
    public static Delegaterl_m_count__String_int8_t_r_int64_t rl_m_count__String_int8_t_r_int64_t;
    public delegate void Delegaterl_m_size__String_r_int64_t(ref long __result, ref String.Content self);
    public static Delegaterl_m_size__String_r_int64_t rl_m_size__String_r_int64_t;
    public delegate void Delegaterl_m_substring_matches__String_strlit_int64_t_r_bool(ref bool __result, ref String.Content self, ref char* lit, ref long pos);
    public static Delegaterl_m_substring_matches__String_strlit_int64_t_r_bool rl_m_substring_matches__String_strlit_int64_t_r_bool;
    public delegate void Delegaterl_m_get__String_int64_t_r_int8_tRef(ref sbyte* __result, ref String.Content self, ref long index);
    public static Delegaterl_m_get__String_int64_t_r_int8_tRef rl_m_get__String_int64_t_r_int8_tRef;
    public delegate void Delegaterl_m_append__String_int8_t(ref String.Content self, ref sbyte b);
    public static Delegaterl_m_append__String_int8_t rl_m_append__String_int8_t;
    public delegate void Delegaterl_m_init__String(ref String.Content self);
    public static Delegaterl_m_init__String rl_m_init__String;
    public delegate void Delegaterl_s__strlit_r_String(ref String.Content __result, ref char* literal);
    public static Delegaterl_s__strlit_r_String rl_s__strlit_r_String;
    public delegate void Delegaterl_append_to_string__strlit_String(ref char* x, ref String.Content output);
    public static Delegaterl_append_to_string__strlit_String rl_append_to_string__strlit_String;
    public delegate void Delegaterl_load_file__String_String_r_bool(ref bool __result, ref String.Content file_name, ref String.Content _out);
    public static Delegaterl_load_file__String_String_r_bool rl_load_file__String_String_r_bool;
    public delegate void Delegaterl_append_to_string__int64_t_String(ref long x, ref String.Content output);
    public static Delegaterl_append_to_string__int64_t_String rl_append_to_string__int64_t_String;
    public delegate void Delegaterl_append_to_string__int8_t_String(ref sbyte x, ref String.Content output);
    public static Delegaterl_append_to_string__int8_t_String rl_append_to_string__int8_t_String;
    public delegate void Delegaterl_append_to_string__double_String(ref double x, ref String.Content output);
    public static Delegaterl_append_to_string__double_String rl_append_to_string__double_String;
    public delegate void Delegaterl_append_to_string__String_String(ref String.Content x, ref String.Content output);
    public static Delegaterl_append_to_string__String_String rl_append_to_string__String_String;
    public delegate void Delegaterl_append_to_string__bool_String(ref bool x, ref String.Content output);
    public static Delegaterl_append_to_string__bool_String rl_append_to_string__bool_String;
    public delegate void Delegaterl_append_to_string__BIntT0T3T_9_String(ref BIntT0T3T_9.Content to_add, ref String.Content output);
    public static Delegaterl_append_to_string__BIntT0T3T_9_String rl_append_to_string__BIntT0T3T_9_String;
    public delegate void Delegaterl_to_string__AnyGameAction_r_String(ref String.Content __result, ref AnyGameAction.Content to_stringyfi);
    public static Delegaterl_to_string__AnyGameAction_r_String rl_to_string__AnyGameAction_r_String;
    public delegate void Delegaterl_to_string__Game_r_String(ref String.Content __result, ref Game.Content to_stringyfi);
    public static Delegaterl_to_string__Game_r_String rl_to_string__Game_r_String;
    public delegate void Delegaterl_is_space__int8_t_r_bool(ref bool __result, ref sbyte b);
    public static Delegaterl_is_space__int8_t_r_bool rl_is_space__int8_t_r_bool;
    public delegate void Delegaterl_is_alphanumeric__int8_t_r_bool(ref bool __result, ref sbyte b);
    public static Delegaterl_is_alphanumeric__int8_t_r_bool rl_is_alphanumeric__int8_t_r_bool;
    public delegate void Delegaterl_is_open_paren__int8_t_r_bool(ref bool __result, ref sbyte b);
    public static Delegaterl_is_open_paren__int8_t_r_bool rl_is_open_paren__int8_t_r_bool;
    public delegate void Delegaterl_is_close_paren__int8_t_r_bool(ref bool __result, ref sbyte b);
    public static Delegaterl_is_close_paren__int8_t_r_bool rl_is_close_paren__int8_t_r_bool;
    public delegate void Delegaterl_parse_string__int64_t_String_int64_t_r_bool(ref bool __result, ref long result, ref String.Content buffer, ref long index);
    public static Delegaterl_parse_string__int64_t_String_int64_t_r_bool rl_parse_string__int64_t_String_int64_t_r_bool;
    public delegate void Delegaterl_parse_string__int8_t_String_int64_t_r_bool(ref bool __result, ref sbyte result, ref String.Content buffer, ref long index);
    public static Delegaterl_parse_string__int8_t_String_int64_t_r_bool rl_parse_string__int8_t_String_int64_t_r_bool;
    public delegate void Delegaterl_parse_string__double_String_int64_t_r_bool(ref bool __result, ref double result, ref String.Content buffer, ref long index);
    public static Delegaterl_parse_string__double_String_int64_t_r_bool rl_parse_string__double_String_int64_t_r_bool;
    public delegate void Delegaterl_length__strlit_r_int64_t(ref long __result, ref char* literal);
    public static Delegaterl_length__strlit_r_int64_t rl_length__strlit_r_int64_t;
    public delegate void Delegaterl_parse_string__String_String_int64_t_r_bool(ref bool __result, ref String.Content result, ref String.Content buffer, ref long index);
    public static Delegaterl_parse_string__String_String_int64_t_r_bool rl_parse_string__String_String_int64_t_r_bool;
    public delegate void Delegaterl_parse_string__bool_String_int64_t_r_bool(ref bool __result, ref bool result, ref String.Content buffer, ref long index);
    public static Delegaterl_parse_string__bool_String_int64_t_r_bool rl_parse_string__bool_String_int64_t_r_bool;
    public delegate void Delegaterl_parse_string__BIntT0T3T_9_String_int64_t_r_bool(ref bool __result, ref BIntT0T3T_9.Content result, ref String.Content buffer, ref long index);
    public static Delegaterl_parse_string__BIntT0T3T_9_String_int64_t_r_bool rl_parse_string__BIntT0T3T_9_String_int64_t_r_bool;
    public delegate void Delegaterl_from_string__AnyGameAction_String_r_bool(ref bool __result, ref AnyGameAction.Content result, ref String.Content buffer);
    public static Delegaterl_from_string__AnyGameAction_String_r_bool rl_from_string__AnyGameAction_String_r_bool;
    public delegate void Delegaterl_from_string__Game_String_r_bool(ref bool __result, ref Game.Content result, ref String.Content buffer);
    public static Delegaterl_from_string__Game_String_r_bool rl_from_string__Game_String_r_bool;
    public delegate void Delegaterl_from_string__AnyGameAction_String_int64_t_r_bool(ref bool __result, ref AnyGameAction.Content result, ref String.Content buffer, ref long index);
    public static Delegaterl_from_string__AnyGameAction_String_int64_t_r_bool rl_from_string__AnyGameAction_String_int64_t_r_bool;
    public delegate void Delegaterl_m_init__BIntT0T3T(ref BIntT0T3T.Content self);
    public static Delegaterl_m_init__BIntT0T3T rl_m_init__BIntT0T3T;
    public delegate void Delegaterl_append_to_vector__BIntT0T3T_VectorTint8_tT(ref BIntT0T3T.Content to_add, ref VectorTint8_tT.Content output);
    public static Delegaterl_append_to_vector__BIntT0T3T_VectorTint8_tT rl_append_to_vector__BIntT0T3T_VectorTint8_tT;
    public delegate void Delegaterl_parse_from_vector__BIntT0T3T_VectorTint8_tT_int64_t_r_bool(ref bool __result, ref BIntT0T3T.Content to_add, ref VectorTint8_tT.Content output, ref long index);
    public static Delegaterl_parse_from_vector__BIntT0T3T_VectorTint8_tT_int64_t_r_bool rl_parse_from_vector__BIntT0T3T_VectorTint8_tT_int64_t_r_bool;
    public delegate void Delegaterl_append_to_string__BIntT0T3T_String(ref BIntT0T3T.Content to_add, ref String.Content output);
    public static Delegaterl_append_to_string__BIntT0T3T_String rl_append_to_string__BIntT0T3T_String;
    public delegate void Delegaterl_parse_string__BIntT0T3T_String_int64_t_r_bool(ref bool __result, ref BIntT0T3T.Content to_add, ref String.Content input, ref long index);
    public static Delegaterl_parse_string__BIntT0T3T_String_int64_t_r_bool rl_parse_string__BIntT0T3T_String_int64_t_r_bool;
    public delegate void Delegaterl_enumerate__BIntT0T3T_VectorTBIntT0T3TT(ref BIntT0T3T.Content to_add, ref VectorTBIntT0T3TT.Content output);
    public static Delegaterl_enumerate__BIntT0T3T_VectorTBIntT0T3TT rl_enumerate__BIntT0T3T_VectorTBIntT0T3TT;
    public delegate void Delegaterl_max__int64_t_int64_t_r_int64_t(ref long __result, ref long a, ref long b);
    public static Delegaterl_max__int64_t_int64_t_r_int64_t rl_max__int64_t_int64_t_r_int64_t;
    public delegate void Delegaterl_min__int64_t_int64_t_r_int64_t(ref long __result, ref long a, ref long b);
    public static Delegaterl_min__int64_t_int64_t_r_int64_t rl_min__int64_t_int64_t_r_int64_t;
    public delegate void Delegaterl_sqrt__double_r_double(ref double __result, ref double f);
    public static Delegaterl_sqrt__double_r_double rl_sqrt__double_r_double;
    public delegate void Delegaterl_abs__int64_t_r_int64_t(ref long __result, ref long a);
    public static Delegaterl_abs__int64_t_r_int64_t rl_abs__int64_t_r_int64_t;
    public delegate void Delegaterl_custom_equal__int64_t_int64_t_r_bool(ref bool __result, ref long lhs, ref long rhs);
    public static Delegaterl_custom_equal__int64_t_int64_t_r_bool rl_custom_equal__int64_t_int64_t_r_bool;
    public delegate void Delegaterl_custom_equal__bool_bool_r_bool(ref bool __result, ref bool lhs, ref bool rhs);
    public static Delegaterl_custom_equal__bool_bool_r_bool rl_custom_equal__bool_bool_r_bool;
    public delegate void Delegaterl_custom_equal__int8_t_int8_t_r_bool(ref bool __result, ref sbyte lhs, ref sbyte rhs);
    public static Delegaterl_custom_equal__int8_t_int8_t_r_bool rl_custom_equal__int8_t_int8_t_r_bool;
    public delegate void Delegaterl_custom_equal__double_double_r_bool(ref bool __result, ref double lhs, ref double rhs);
    public static Delegaterl_custom_equal__double_double_r_bool rl_custom_equal__double_double_r_bool;
    public delegate void Delegaterl_equal__AnyGameAction_AnyGameAction_r_bool(ref bool __result, ref AnyGameAction.Content lhs, ref AnyGameAction.Content rhs);
    public static Delegaterl_equal__AnyGameAction_AnyGameAction_r_bool rl_equal__AnyGameAction_AnyGameAction_r_bool;
    public delegate void Delegaterl_equal__GameMark_GameMark_r_bool(ref bool __result, ref GameMark.Content lhs, ref GameMark.Content rhs);
    public static Delegaterl_equal__GameMark_GameMark_r_bool rl_equal__GameMark_GameMark_r_bool;
    public delegate void Delegaterl_equal__BIntT0T3T_BIntT0T3T_r_bool(ref bool __result, ref BIntT0T3T.Content lhs, ref BIntT0T3T.Content rhs);
    public static Delegaterl_equal__BIntT0T3T_BIntT0T3T_r_bool rl_equal__BIntT0T3T_BIntT0T3T_r_bool;
    public delegate void Delegaterl_equal__int64_t_int64_t_r_bool(ref bool __result, ref long lhs, ref long rhs);
    public static Delegaterl_equal__int64_t_int64_t_r_bool rl_equal__int64_t_int64_t_r_bool;
    public delegate void Delegaterl_can_apply_impl__AnyGameAction_Game_r_bool(ref bool __result, ref AnyGameAction.Content action, ref Game.Content frame);
    public static Delegaterl_can_apply_impl__AnyGameAction_Game_r_bool rl_can_apply_impl__AnyGameAction_Game_r_bool;
    public delegate void Delegaterl_apply__AnyGameAction_Game(ref AnyGameAction.Content action, ref Game.Content frame);
    public static Delegaterl_apply__AnyGameAction_Game rl_apply__AnyGameAction_Game;
    public delegate void Delegaterl_can_apply__AnyGameAction_Game_r_bool(ref bool __result, ref AnyGameAction.Content action, ref Game.Content frame);
    public static Delegaterl_can_apply__AnyGameAction_Game_r_bool rl_can_apply__AnyGameAction_Game_r_bool;
    public delegate void Delegaterl_apply__VectorTAnyGameActionT_Game_r_bool(ref bool __result, ref VectorTAnyGameActionT.Content action, ref Game.Content frame);
    public static Delegaterl_apply__VectorTAnyGameActionT_Game_r_bool rl_apply__VectorTAnyGameActionT_Game_r_bool;
    public delegate void Delegaterl_parse_actions__AnyGameAction_VectorTint8_tT_int64_t_r_VectorTAnyGameActionT(ref VectorTAnyGameActionT.Content __result, ref AnyGameAction.Content variant, ref VectorTint8_tT.Content input, ref long read_bytes);
    public static Delegaterl_parse_actions__AnyGameAction_VectorTint8_tT_int64_t_r_VectorTAnyGameActionT rl_parse_actions__AnyGameAction_VectorTint8_tT_int64_t_r_VectorTAnyGameActionT;
    public delegate void Delegaterl_parse_actions__AnyGameAction_String_r_VectorTAnyGameActionT(ref VectorTAnyGameActionT.Content __result, ref AnyGameAction.Content variant, ref String.Content input);
    public static Delegaterl_parse_actions__AnyGameAction_String_r_VectorTAnyGameActionT rl_parse_actions__AnyGameAction_String_r_VectorTAnyGameActionT;
    public delegate void Delegaterl_parse_action_optimized__AnyGameAction_VectorTint8_tT_int64_t_r_bool(ref bool __result, ref AnyGameAction.Content variant, ref VectorTint8_tT.Content input, ref long read_bytes);
    public static Delegaterl_parse_action_optimized__AnyGameAction_VectorTint8_tT_int64_t_r_bool rl_parse_action_optimized__AnyGameAction_VectorTint8_tT_int64_t_r_bool;
    public delegate void Delegaterl_parse_actions__AnyGameAction_VectorTint8_tT_r_VectorTAnyGameActionT(ref VectorTAnyGameActionT.Content __result, ref AnyGameAction.Content variant, ref VectorTint8_tT.Content input);
    public static Delegaterl_parse_actions__AnyGameAction_VectorTint8_tT_r_VectorTAnyGameActionT rl_parse_actions__AnyGameAction_VectorTint8_tT_r_VectorTAnyGameActionT;
    public delegate void Delegaterl_make_valid_actions_vector__VectorTAnyGameActionT_Game_r_VectorTint8_tT(ref VectorTint8_tT.Content __result, ref VectorTAnyGameActionT.Content all_actions, ref Game.Content state);
    public static Delegaterl_make_valid_actions_vector__VectorTAnyGameActionT_Game_r_VectorTint8_tT rl_make_valid_actions_vector__VectorTAnyGameActionT_Game_r_VectorTint8_tT;
    public delegate void Delegaterl_get_valid_actions__VectorTint8_tT_VectorTAnyGameActionT_Game(ref VectorTint8_tT.Content valid_actions, ref VectorTAnyGameActionT.Content all_actions, ref Game.Content state);
    public static Delegaterl_get_valid_actions__VectorTint8_tT_VectorTAnyGameActionT_Game rl_get_valid_actions__VectorTint8_tT_VectorTAnyGameActionT_Game;
    public delegate void Delegaterl_gen_python_methods__Game_AnyGameAction(ref Game.Content state, ref AnyGameAction.Content variant);
    public static Delegaterl_gen_python_methods__Game_AnyGameAction rl_gen_python_methods__Game_AnyGameAction;
    public delegate void Delegaterl_load_action_vector_file__String_VectorTAnyGameActionT_r_bool(ref bool __result, ref String.Content file_name, ref VectorTAnyGameActionT.Content _out);
    public static Delegaterl_load_action_vector_file__String_VectorTAnyGameActionT_r_bool rl_load_action_vector_file__String_VectorTAnyGameActionT_r_bool;
    public delegate void Delegaterl_enumerate__bool_VectorTboolT(ref bool b, ref VectorTboolT.Content output);
    public static Delegaterl_enumerate__bool_VectorTboolT rl_enumerate__bool_VectorTboolT;
    public delegate void Delegaterl_enumeration_error__int64_t_String_VectorTStringT(ref long x, ref String.Content _out, ref VectorTStringT.Content context);
    public static Delegaterl_enumeration_error__int64_t_String_VectorTStringT rl_enumeration_error__int64_t_String_VectorTStringT;
    public delegate void Delegaterl_enumeration_error__double_String_VectorTStringT(ref double x, ref String.Content _out, ref VectorTStringT.Content context);
    public static Delegaterl_enumeration_error__double_String_VectorTStringT rl_enumeration_error__double_String_VectorTStringT;
    public delegate void Delegaterl_get_enumeration_errors_impl__AnyGameAction_String_VectorTStringT(ref AnyGameAction.Content obj, ref String.Content _out, ref VectorTStringT.Content context);
    public static Delegaterl_get_enumeration_errors_impl__AnyGameAction_String_VectorTStringT rl_get_enumeration_errors_impl__AnyGameAction_String_VectorTStringT;
    public delegate void Delegaterl_get_enumeration_errors_impl__GameMark_String_VectorTStringT(ref GameMark.Content obj, ref String.Content _out, ref VectorTStringT.Content context);
    public static Delegaterl_get_enumeration_errors_impl__GameMark_String_VectorTStringT rl_get_enumeration_errors_impl__GameMark_String_VectorTStringT;
    public delegate void Delegaterl_get_enumeration_errors_impl__BIntT0T3T_String_VectorTStringT(ref BIntT0T3T.Content obj, ref String.Content _out, ref VectorTStringT.Content context);
    public static Delegaterl_get_enumeration_errors_impl__BIntT0T3T_String_VectorTStringT rl_get_enumeration_errors_impl__BIntT0T3T_String_VectorTStringT;
    public delegate void Delegaterl_get_enumeration_errors_impl__int64_t_String_VectorTStringT(ref long obj, ref String.Content _out, ref VectorTStringT.Content context);
    public static Delegaterl_get_enumeration_errors_impl__int64_t_String_VectorTStringT rl_get_enumeration_errors_impl__int64_t_String_VectorTStringT;
    public delegate void Delegaterl_get_enumeration_errors__AnyGameAction_r_String(ref String.Content __result, ref AnyGameAction.Content obj);
    public static Delegaterl_get_enumeration_errors__AnyGameAction_r_String rl_get_enumeration_errors__AnyGameAction_r_String;
    public delegate void Delegaterl_print_enumeration_errors__AnyGameAction_r_bool(ref bool __result, ref AnyGameAction.Content obj);
    public static Delegaterl_print_enumeration_errors__AnyGameAction_r_bool rl_print_enumeration_errors__AnyGameAction_r_bool;
    public delegate void Delegaterl_enumerate__AnyGameAction_r_VectorTAnyGameActionT(ref VectorTAnyGameActionT.Content __result, ref AnyGameAction.Content obj);
    public static Delegaterl_enumerate__AnyGameAction_r_VectorTAnyGameActionT rl_enumerate__AnyGameAction_r_VectorTAnyGameActionT;
    public delegate void Delegaterl_enumerate__GameMark_r_VectorTGameMarkT(ref VectorTGameMarkT.Content __result, ref GameMark.Content obj);
    public static Delegaterl_enumerate__GameMark_r_VectorTGameMarkT rl_enumerate__GameMark_r_VectorTGameMarkT;
    public delegate void Delegaterl_enumerate__BIntT0T3T_r_VectorTBIntT0T3TT(ref VectorTBIntT0T3TT.Content __result, ref BIntT0T3T.Content obj);
    public static Delegaterl_enumerate__BIntT0T3T_r_VectorTBIntT0T3TT rl_enumerate__BIntT0T3T_r_VectorTBIntT0T3TT;
    public delegate void Delegaterl_write_in_observation_tensor__int64_t_int64_t_int64_t_VectorTdoubleT_int64_t(ref long value, ref long min, ref long max, ref VectorTdoubleT.Content output, ref long index);
    public static Delegaterl_write_in_observation_tensor__int64_t_int64_t_int64_t_VectorTdoubleT_int64_t rl_write_in_observation_tensor__int64_t_int64_t_int64_t_VectorTdoubleT_int64_t;
    public delegate void Delegaterl_write_in_observation_tensor__int64_t_int64_t_VectorTdoubleT_int64_t(ref long obj, ref long observer_id, ref VectorTdoubleT.Content output, ref long index);
    public static Delegaterl_write_in_observation_tensor__int64_t_int64_t_VectorTdoubleT_int64_t rl_write_in_observation_tensor__int64_t_int64_t_VectorTdoubleT_int64_t;
    public delegate void Delegaterl_size_as_observation_tensor__int64_t_r_int64_t(ref long __result, ref long obj);
    public static Delegaterl_size_as_observation_tensor__int64_t_r_int64_t rl_size_as_observation_tensor__int64_t_r_int64_t;
    public delegate void Delegaterl_write_in_observation_tensor__double_int64_t_VectorTdoubleT_int64_t(ref double obj, ref long observer_id, ref VectorTdoubleT.Content output, ref long index);
    public static Delegaterl_write_in_observation_tensor__double_int64_t_VectorTdoubleT_int64_t rl_write_in_observation_tensor__double_int64_t_VectorTdoubleT_int64_t;
    public delegate void Delegaterl_can_write_in_observation_tensor__double_int64_t_VectorTdoubleT_int64_t_r_bool(ref bool __result, ref double obj, ref long observer_id, ref VectorTdoubleT.Content output, ref long index);
    public static Delegaterl_can_write_in_observation_tensor__double_int64_t_VectorTdoubleT_int64_t_r_bool rl_can_write_in_observation_tensor__double_int64_t_VectorTdoubleT_int64_t_r_bool;
    public delegate void Delegaterl_size_as_observation_tensor__double_r_int64_t(ref long __result, ref double obj);
    public static Delegaterl_size_as_observation_tensor__double_r_int64_t rl_size_as_observation_tensor__double_r_int64_t;
    public delegate void Delegaterl_can_size_as_observation_tensor__double_r_bool(ref bool __result, ref double obj);
    public static Delegaterl_can_size_as_observation_tensor__double_r_bool rl_can_size_as_observation_tensor__double_r_bool;
    public delegate void Delegaterl_write_in_observation_tensor__bool_int64_t_VectorTdoubleT_int64_t(ref bool obj, ref long observer_id, ref VectorTdoubleT.Content output, ref long index);
    public static Delegaterl_write_in_observation_tensor__bool_int64_t_VectorTdoubleT_int64_t rl_write_in_observation_tensor__bool_int64_t_VectorTdoubleT_int64_t;
    public delegate void Delegaterl_size_as_observation_tensor__bool_r_int64_t(ref long __result, ref bool obj);
    public static Delegaterl_size_as_observation_tensor__bool_r_int64_t rl_size_as_observation_tensor__bool_r_int64_t;
    public delegate void Delegaterl_write_in_observation_tensor__int8_t_int64_t_VectorTdoubleT_int64_t(ref sbyte obj, ref long observer_id, ref VectorTdoubleT.Content output, ref long index);
    public static Delegaterl_write_in_observation_tensor__int8_t_int64_t_VectorTdoubleT_int64_t rl_write_in_observation_tensor__int8_t_int64_t_VectorTdoubleT_int64_t;
    public delegate void Delegaterl_size_as_observation_tensor__int8_t_r_int64_t(ref long __result, ref sbyte obj);
    public static Delegaterl_size_as_observation_tensor__int8_t_r_int64_t rl_size_as_observation_tensor__int8_t_r_int64_t;
    public delegate void Delegaterl_write_in_observation_tensor__BIntT0T3T_9_int64_t_VectorTdoubleT_int64_t(ref BIntT0T3T_9.Content obj, ref long observer_id, ref VectorTdoubleT.Content output, ref long index);
    public static Delegaterl_write_in_observation_tensor__BIntT0T3T_9_int64_t_VectorTdoubleT_int64_t rl_write_in_observation_tensor__BIntT0T3T_9_int64_t_VectorTdoubleT_int64_t;
    public delegate void Delegaterl_size_as_observation_tensor__BIntT0T3T_9_r_int64_t(ref long __result, ref BIntT0T3T_9.Content obj);
    public static Delegaterl_size_as_observation_tensor__BIntT0T3T_9_r_int64_t rl_size_as_observation_tensor__BIntT0T3T_9_r_int64_t;
    public delegate void Delegaterl_write_in_observation_tensor__BIntT0T3T_int64_t_VectorTdoubleT_int64_t(ref BIntT0T3T.Content obj, ref long observer_id, ref VectorTdoubleT.Content output, ref long index);
    public static Delegaterl_write_in_observation_tensor__BIntT0T3T_int64_t_VectorTdoubleT_int64_t rl_write_in_observation_tensor__BIntT0T3T_int64_t_VectorTdoubleT_int64_t;
    public delegate void Delegaterl_size_as_observation_tensor__BIntT0T3T_r_int64_t(ref long __result, ref BIntT0T3T.Content obj);
    public static Delegaterl_size_as_observation_tensor__BIntT0T3T_r_int64_t rl_size_as_observation_tensor__BIntT0T3T_r_int64_t;
    public delegate void Delegaterl_to_observation_tensor__Game_int64_t_VectorTdoubleT(ref Game.Content obj, ref long observer_id, ref VectorTdoubleT.Content output);
    public static Delegaterl_to_observation_tensor__Game_int64_t_VectorTdoubleT rl_to_observation_tensor__Game_int64_t_VectorTdoubleT;
    public delegate void Delegaterl_observation_tensor_size__Game_r_int64_t(ref long __result, ref Game.Content obj);
    public static Delegaterl_observation_tensor_size__Game_r_int64_t rl_observation_tensor_size__Game_r_int64_t;
    public delegate void Delegaterl_write_tensor_warning_context__String_VectorTStringT(ref String.Content _out, ref VectorTStringT.Content context);
    public static Delegaterl_write_tensor_warning_context__String_VectorTStringT rl_write_tensor_warning_context__String_VectorTStringT;
    public delegate void Delegaterl_tensorable_warning__int64_t_String_VectorTStringT(ref long x, ref String.Content _out, ref VectorTStringT.Content context);
    public static Delegaterl_tensorable_warning__int64_t_String_VectorTStringT rl_tensorable_warning__int64_t_String_VectorTStringT;
    public delegate void Delegaterl_tensorable_warning__double_String_VectorTStringT(ref double x, ref String.Content _out, ref VectorTStringT.Content context);
    public static Delegaterl_tensorable_warning__double_String_VectorTStringT rl_tensorable_warning__double_String_VectorTStringT;
    public delegate void Delegaterl_tensorable_warning__BIntT0T3T_9_String_VectorTStringT(ref BIntT0T3T_9.Content x, ref String.Content _out, ref VectorTStringT.Content context);
    public static Delegaterl_tensorable_warning__BIntT0T3T_9_String_VectorTStringT rl_tensorable_warning__BIntT0T3T_9_String_VectorTStringT;
    public delegate void Delegaterl_to_observation_tensor_warnings__Game_r_String(ref String.Content __result, ref Game.Content obj);
    public static Delegaterl_to_observation_tensor_warnings__Game_r_String rl_to_observation_tensor_warnings__Game_r_String;
    public delegate void Delegaterl_emit_observation_tensor_warnings__Game(ref Game.Content obj);
    public static Delegaterl_emit_observation_tensor_warnings__Game rl_emit_observation_tensor_warnings__Game;
    public delegate void Delegaterl_gen_printer_parser_();
    public static Delegaterl_gen_printer_parser_ rl_gen_printer_parser_;
    public delegate void Delegaterl_m_set_size__Range_int64_t(ref Range.Content self, ref long new_size);
    public static Delegaterl_m_set_size__Range_int64_t rl_m_set_size__Range_int64_t;
    public delegate void Delegaterl_m_size__Range_r_int64_t(ref long __result, ref Range.Content self);
    public static Delegaterl_m_size__Range_r_int64_t rl_m_size__Range_r_int64_t;
    public delegate void Delegaterl_m_get__Range_int64_t_r_int64_t(ref long __result, ref Range.Content self, ref long i);
    public static Delegaterl_m_get__Range_int64_t_r_int64_t rl_m_get__Range_int64_t_r_int64_t;
    public delegate void Delegaterl_range__int64_t_r_Range(ref Range.Content __result, ref long size);
    public static Delegaterl_range__int64_t_r_Range rl_range__int64_t_r_Range;
    public delegate void Delegaterl_fuzz__VectorTint8_tT(ref VectorTint8_tT.Content input);
    public static Delegaterl_fuzz__VectorTint8_tT rl_fuzz__VectorTint8_tT;
    public delegate void Delegaterl_m_next_turn__Board(ref Board.Content self);
    public static Delegaterl_m_next_turn__Board rl_m_next_turn__Board;
    public delegate void Delegaterl_m_current_player__Board_r_int64_t(ref long __result, ref Board.Content self);
    public static Delegaterl_m_current_player__Board_r_int64_t rl_m_current_player__Board_r_int64_t;
    public delegate void Delegaterl_m_three_in_a_line_player__Board_int64_t_r_bool(ref bool __result, ref Board.Content self, ref long player_id);
    public static Delegaterl_m_three_in_a_line_player__Board_int64_t_r_bool rl_m_three_in_a_line_player__Board_int64_t_r_bool;
    public delegate void Delegaterl_m_three_in_a_line_player_row__Board_int64_t_int64_t_r_bool(ref bool __result, ref Board.Content self, ref long player_id, ref long row);
    public static Delegaterl_m_three_in_a_line_player_row__Board_int64_t_int64_t_r_bool rl_m_three_in_a_line_player_row__Board_int64_t_int64_t_r_bool;
    public delegate void Delegaterl_m_full__Board_r_bool(ref bool __result, ref Board.Content self);
    public static Delegaterl_m_full__Board_r_bool rl_m_full__Board_r_bool;
    public delegate void Delegaterl_m_set__Board_int64_t_int64_t_int64_t(ref Board.Content self, ref long x, ref long y, ref long val);
    public static Delegaterl_m_set__Board_int64_t_int64_t_int64_t rl_m_set__Board_int64_t_int64_t_int64_t;
    public delegate void Delegaterl_m_get__Board_int64_t_int64_t_r_int64_t(ref long __result, ref Board.Content self, ref long x, ref long y);
    public static Delegaterl_m_get__Board_int64_t_int64_t_r_int64_t rl_m_get__Board_int64_t_int64_t_r_int64_t;
    public delegate void Delegaterl_apply__GameMark_Game(ref GameMark.Content self, ref Game.Content frame);
    public static Delegaterl_apply__GameMark_Game rl_apply__GameMark_Game;
    public delegate void Delegaterl_can_apply__GameMark_Game_r_bool(ref bool __result, ref GameMark.Content self, ref Game.Content frame);
    public static Delegaterl_can_apply__GameMark_Game_r_bool rl_can_apply__GameMark_Game_r_bool;
    public delegate void Delegaterl_get_type_name__GameMark_r_strlit(ref char* __result, ref GameMark.Content self);
    public static Delegaterl_get_type_name__GameMark_r_strlit rl_get_type_name__GameMark_r_strlit;
    public delegate void Delegaterl_play__r_Game(ref Game.Content __result);
    public static Delegaterl_play__r_Game rl_play__r_Game;
    public delegate void Delegaterl_can_play__r_bool(ref bool __result);
    public static Delegaterl_can_play__r_bool rl_can_play__r_bool;
    public delegate void Delegaterl_m_mark__Game_BIntT0T3T_BIntT0T3T(ref Game.Content self, ref BIntT0T3T.Content x, ref BIntT0T3T.Content y);
    public static Delegaterl_m_mark__Game_BIntT0T3T_BIntT0T3T rl_m_mark__Game_BIntT0T3T_BIntT0T3T;
    public delegate void Delegaterl_m_can_mark__Game_BIntT0T3T_BIntT0T3T_r_bool(ref bool __result, ref Game.Content self, ref BIntT0T3T.Content x, ref BIntT0T3T.Content y);
    public static Delegaterl_m_can_mark__Game_BIntT0T3T_BIntT0T3T_r_bool rl_m_can_mark__Game_BIntT0T3T_BIntT0T3T_r_bool;
    public delegate void Delegaterl_m_is_done__Game_r_bool(ref bool __result, ref Game.Content self);
    public static Delegaterl_m_is_done__Game_r_bool rl_m_is_done__Game_r_bool;
internal static string SharedLibExtension =>
 RuntimeInformation.IsOSPlatform(OSPlatform.Windows) ? ".dll" :
RuntimeInformation.IsOSPlatform(OSPlatform.OSX)     ? ".dylib" :
/* default to Linux */ ".so";
private static IntPtr _lib;
    public static void setup(string libName) {
    _lib = RLCNative.LoadLibrary(libName);if (_lib == IntPtr.Zero) throw new Exception("Could not find library " + libName );IntPtr rl_m_init__Range_ptr = GetProcAddress(_lib, "rl_m_init__Range");
        if (rl_m_init__Range_ptr == IntPtr.Zero) throw new Exception("Could not find symbol rl_m_init__Range");
        rl_m_init__Range = Marshal.GetDelegateForFunctionPointer<Delegaterl_m_init__Range>(rl_m_init__Range_ptr);
        IntPtr rl_m_init__AnyGameAction_ptr = GetProcAddress(_lib, "rl_m_init__AnyGameAction");
        if (rl_m_init__AnyGameAction_ptr == IntPtr.Zero) throw new Exception("Could not find symbol rl_m_init__AnyGameAction");
        rl_m_init__AnyGameAction = Marshal.GetDelegateForFunctionPointer<Delegaterl_m_init__AnyGameAction>(rl_m_init__AnyGameAction_ptr);
        IntPtr rl_m_init__Game_ptr = GetProcAddress(_lib, "rl_m_init__Game");
        if (rl_m_init__Game_ptr == IntPtr.Zero) throw new Exception("Could not find symbol rl_m_init__Game");
        rl_m_init__Game = Marshal.GetDelegateForFunctionPointer<Delegaterl_m_init__Game>(rl_m_init__Game_ptr);
        IntPtr rl_m_init__Board_ptr = GetProcAddress(_lib, "rl_m_init__Board");
        if (rl_m_init__Board_ptr == IntPtr.Zero) throw new Exception("Could not find symbol rl_m_init__Board");
        rl_m_init__Board = Marshal.GetDelegateForFunctionPointer<Delegaterl_m_init__Board>(rl_m_init__Board_ptr);
        IntPtr rl_m_init__BIntT0T3T_9_ptr = GetProcAddress(_lib, "rl_m_init__BIntT0T3T_9");
        if (rl_m_init__BIntT0T3T_9_ptr == IntPtr.Zero) throw new Exception("Could not find symbol rl_m_init__BIntT0T3T_9");
        rl_m_init__BIntT0T3T_9 = Marshal.GetDelegateForFunctionPointer<Delegaterl_m_init__BIntT0T3T_9>(rl_m_init__BIntT0T3T_9_ptr);
        IntPtr rl_m_init__strlit_ptr = GetProcAddress(_lib, "rl_m_init__strlit");
        if (rl_m_init__strlit_ptr == IntPtr.Zero) throw new Exception("Could not find symbol rl_m_init__strlit");
        rl_m_init__strlit = Marshal.GetDelegateForFunctionPointer<Delegaterl_m_init__strlit>(rl_m_init__strlit_ptr);
        IntPtr rl_m_init__int8_t_1_ptr = GetProcAddress(_lib, "rl_m_init__int8_t_1");
        if (rl_m_init__int8_t_1_ptr == IntPtr.Zero) throw new Exception("Could not find symbol rl_m_init__int8_t_1");
        rl_m_init__int8_t_1 = Marshal.GetDelegateForFunctionPointer<Delegaterl_m_init__int8_t_1>(rl_m_init__int8_t_1_ptr);
        IntPtr rl_m_init__int8_t_8_ptr = GetProcAddress(_lib, "rl_m_init__int8_t_8");
        if (rl_m_init__int8_t_8_ptr == IntPtr.Zero) throw new Exception("Could not find symbol rl_m_init__int8_t_8");
        rl_m_init__int8_t_8 = Marshal.GetDelegateForFunctionPointer<Delegaterl_m_init__int8_t_8>(rl_m_init__int8_t_8_ptr);
        IntPtr rl_m_init__GameMark_ptr = GetProcAddress(_lib, "rl_m_init__GameMark");
        if (rl_m_init__GameMark_ptr == IntPtr.Zero) throw new Exception("Could not find symbol rl_m_init__GameMark");
        rl_m_init__GameMark = Marshal.GetDelegateForFunctionPointer<Delegaterl_m_init__GameMark>(rl_m_init__GameMark_ptr);
        IntPtr rl_m_assign__Game_Game_ptr = GetProcAddress(_lib, "rl_m_assign__Game_Game");
        if (rl_m_assign__Game_Game_ptr == IntPtr.Zero) throw new Exception("Could not find symbol rl_m_assign__Game_Game");
        rl_m_assign__Game_Game = Marshal.GetDelegateForFunctionPointer<Delegaterl_m_assign__Game_Game>(rl_m_assign__Game_Game_ptr);
        IntPtr rl_m_assign__Board_Board_ptr = GetProcAddress(_lib, "rl_m_assign__Board_Board");
        if (rl_m_assign__Board_Board_ptr == IntPtr.Zero) throw new Exception("Could not find symbol rl_m_assign__Board_Board");
        rl_m_assign__Board_Board = Marshal.GetDelegateForFunctionPointer<Delegaterl_m_assign__Board_Board>(rl_m_assign__Board_Board_ptr);
        IntPtr rl_m_assign__BIntT0T3T_9_BIntT0T3T_9_ptr = GetProcAddress(_lib, "rl_m_assign__BIntT0T3T_9_BIntT0T3T_9");
        if (rl_m_assign__BIntT0T3T_9_BIntT0T3T_9_ptr == IntPtr.Zero) throw new Exception("Could not find symbol rl_m_assign__BIntT0T3T_9_BIntT0T3T_9");
        rl_m_assign__BIntT0T3T_9_BIntT0T3T_9 = Marshal.GetDelegateForFunctionPointer<Delegaterl_m_assign__BIntT0T3T_9_BIntT0T3T_9>(rl_m_assign__BIntT0T3T_9_BIntT0T3T_9_ptr);
        IntPtr rl_m_assign__strlit_strlit_ptr = GetProcAddress(_lib, "rl_m_assign__strlit_strlit");
        if (rl_m_assign__strlit_strlit_ptr == IntPtr.Zero) throw new Exception("Could not find symbol rl_m_assign__strlit_strlit");
        rl_m_assign__strlit_strlit = Marshal.GetDelegateForFunctionPointer<Delegaterl_m_assign__strlit_strlit>(rl_m_assign__strlit_strlit_ptr);
        IntPtr rl_m_assign__AnyGameAction_GameMark_ptr = GetProcAddress(_lib, "rl_m_assign__AnyGameAction_GameMark");
        if (rl_m_assign__AnyGameAction_GameMark_ptr == IntPtr.Zero) throw new Exception("Could not find symbol rl_m_assign__AnyGameAction_GameMark");
        rl_m_assign__AnyGameAction_GameMark = Marshal.GetDelegateForFunctionPointer<Delegaterl_m_assign__AnyGameAction_GameMark>(rl_m_assign__AnyGameAction_GameMark_ptr);
        IntPtr rl_m_assign__AnyGameAction_AnyGameAction_ptr = GetProcAddress(_lib, "rl_m_assign__AnyGameAction_AnyGameAction");
        if (rl_m_assign__AnyGameAction_AnyGameAction_ptr == IntPtr.Zero) throw new Exception("Could not find symbol rl_m_assign__AnyGameAction_AnyGameAction");
        rl_m_assign__AnyGameAction_AnyGameAction = Marshal.GetDelegateForFunctionPointer<Delegaterl_m_assign__AnyGameAction_AnyGameAction>(rl_m_assign__AnyGameAction_AnyGameAction_ptr);
        IntPtr rl_m_assign__GameMark_GameMark_ptr = GetProcAddress(_lib, "rl_m_assign__GameMark_GameMark");
        if (rl_m_assign__GameMark_GameMark_ptr == IntPtr.Zero) throw new Exception("Could not find symbol rl_m_assign__GameMark_GameMark");
        rl_m_assign__GameMark_GameMark = Marshal.GetDelegateForFunctionPointer<Delegaterl_m_assign__GameMark_GameMark>(rl_m_assign__GameMark_GameMark_ptr);
        IntPtr rl_m_assign__BIntT0T3T_BIntT0T3T_ptr = GetProcAddress(_lib, "rl_m_assign__BIntT0T3T_BIntT0T3T");
        if (rl_m_assign__BIntT0T3T_BIntT0T3T_ptr == IntPtr.Zero) throw new Exception("Could not find symbol rl_m_assign__BIntT0T3T_BIntT0T3T");
        rl_m_assign__BIntT0T3T_BIntT0T3T = Marshal.GetDelegateForFunctionPointer<Delegaterl_m_assign__BIntT0T3T_BIntT0T3T>(rl_m_assign__BIntT0T3T_BIntT0T3T_ptr);
        IntPtr rl_m_assign__Range_Range_ptr = GetProcAddress(_lib, "rl_m_assign__Range_Range");
        if (rl_m_assign__Range_Range_ptr == IntPtr.Zero) throw new Exception("Could not find symbol rl_m_assign__Range_Range");
        rl_m_assign__Range_Range = Marshal.GetDelegateForFunctionPointer<Delegaterl_m_assign__Range_Range>(rl_m_assign__Range_Range_ptr);
        IntPtr rl_m_assign__String_String_ptr = GetProcAddress(_lib, "rl_m_assign__String_String");
        if (rl_m_assign__String_String_ptr == IntPtr.Zero) throw new Exception("Could not find symbol rl_m_assign__String_String");
        rl_m_assign__String_String = Marshal.GetDelegateForFunctionPointer<Delegaterl_m_assign__String_String>(rl_m_assign__String_String_ptr);
        IntPtr rl_m_drop__String_ptr = GetProcAddress(_lib, "rl_m_drop__String");
        if (rl_m_drop__String_ptr == IntPtr.Zero) throw new Exception("Could not find symbol rl_m_drop__String");
        rl_m_drop__String = Marshal.GetDelegateForFunctionPointer<Delegaterl_m_drop__String>(rl_m_drop__String_ptr);
        IntPtr rl_print_string__String_ptr = GetProcAddress(_lib, "rl_print_string__String");
        if (rl_print_string__String_ptr == IntPtr.Zero) throw new Exception("Could not find symbol rl_print_string__String");
        rl_print_string__String = Marshal.GetDelegateForFunctionPointer<Delegaterl_print_string__String>(rl_print_string__String_ptr);
        IntPtr rl_print_string_lit__strlit_ptr = GetProcAddress(_lib, "rl_print_string_lit__strlit");
        if (rl_print_string_lit__strlit_ptr == IntPtr.Zero) throw new Exception("Could not find symbol rl_print_string_lit__strlit");
        rl_print_string_lit__strlit = Marshal.GetDelegateForFunctionPointer<Delegaterl_print_string_lit__strlit>(rl_print_string_lit__strlit_ptr);
        IntPtr rl_print__String_ptr = GetProcAddress(_lib, "rl_print__String");
        if (rl_print__String_ptr == IntPtr.Zero) throw new Exception("Could not find symbol rl_print__String");
        rl_print__String = Marshal.GetDelegateForFunctionPointer<Delegaterl_print__String>(rl_print__String_ptr);
        IntPtr rl_print__AnyGameAction_ptr = GetProcAddress(_lib, "rl_print__AnyGameAction");
        if (rl_print__AnyGameAction_ptr == IntPtr.Zero) throw new Exception("Could not find symbol rl_print__AnyGameAction");
        rl_print__AnyGameAction = Marshal.GetDelegateForFunctionPointer<Delegaterl_print__AnyGameAction>(rl_print__AnyGameAction_ptr);
        IntPtr rl_print__Game_ptr = GetProcAddress(_lib, "rl_print__Game");
        if (rl_print__Game_ptr == IntPtr.Zero) throw new Exception("Could not find symbol rl_print__Game");
        rl_print__Game = Marshal.GetDelegateForFunctionPointer<Delegaterl_print__Game>(rl_print__Game_ptr);
        IntPtr rl_append_to_vector__int64_t_VectorTint8_tT_ptr = GetProcAddress(_lib, "rl_append_to_vector__int64_t_VectorTint8_tT");
        if (rl_append_to_vector__int64_t_VectorTint8_tT_ptr == IntPtr.Zero) throw new Exception("Could not find symbol rl_append_to_vector__int64_t_VectorTint8_tT");
        rl_append_to_vector__int64_t_VectorTint8_tT = Marshal.GetDelegateForFunctionPointer<Delegaterl_append_to_vector__int64_t_VectorTint8_tT>(rl_append_to_vector__int64_t_VectorTint8_tT_ptr);
        IntPtr rl_append_to_vector__double_VectorTint8_tT_ptr = GetProcAddress(_lib, "rl_append_to_vector__double_VectorTint8_tT");
        if (rl_append_to_vector__double_VectorTint8_tT_ptr == IntPtr.Zero) throw new Exception("Could not find symbol rl_append_to_vector__double_VectorTint8_tT");
        rl_append_to_vector__double_VectorTint8_tT = Marshal.GetDelegateForFunctionPointer<Delegaterl_append_to_vector__double_VectorTint8_tT>(rl_append_to_vector__double_VectorTint8_tT_ptr);
        IntPtr rl_append_to_vector__bool_VectorTint8_tT_ptr = GetProcAddress(_lib, "rl_append_to_vector__bool_VectorTint8_tT");
        if (rl_append_to_vector__bool_VectorTint8_tT_ptr == IntPtr.Zero) throw new Exception("Could not find symbol rl_append_to_vector__bool_VectorTint8_tT");
        rl_append_to_vector__bool_VectorTint8_tT = Marshal.GetDelegateForFunctionPointer<Delegaterl_append_to_vector__bool_VectorTint8_tT>(rl_append_to_vector__bool_VectorTint8_tT_ptr);
        IntPtr rl_append_to_vector__int8_t_VectorTint8_tT_ptr = GetProcAddress(_lib, "rl_append_to_vector__int8_t_VectorTint8_tT");
        if (rl_append_to_vector__int8_t_VectorTint8_tT_ptr == IntPtr.Zero) throw new Exception("Could not find symbol rl_append_to_vector__int8_t_VectorTint8_tT");
        rl_append_to_vector__int8_t_VectorTint8_tT = Marshal.GetDelegateForFunctionPointer<Delegaterl_append_to_vector__int8_t_VectorTint8_tT>(rl_append_to_vector__int8_t_VectorTint8_tT_ptr);
        IntPtr rl_append_to_vector__BIntT0T3T_9_VectorTint8_tT_ptr = GetProcAddress(_lib, "rl_append_to_vector__BIntT0T3T_9_VectorTint8_tT");
        if (rl_append_to_vector__BIntT0T3T_9_VectorTint8_tT_ptr == IntPtr.Zero) throw new Exception("Could not find symbol rl_append_to_vector__BIntT0T3T_9_VectorTint8_tT");
        rl_append_to_vector__BIntT0T3T_9_VectorTint8_tT = Marshal.GetDelegateForFunctionPointer<Delegaterl_append_to_vector__BIntT0T3T_9_VectorTint8_tT>(rl_append_to_vector__BIntT0T3T_9_VectorTint8_tT_ptr);
        IntPtr rl_as_byte_vector__Game_r_VectorTint8_tT_ptr = GetProcAddress(_lib, "rl_as_byte_vector__Game_r_VectorTint8_tT");
        if (rl_as_byte_vector__Game_r_VectorTint8_tT_ptr == IntPtr.Zero) throw new Exception("Could not find symbol rl_as_byte_vector__Game_r_VectorTint8_tT");
        rl_as_byte_vector__Game_r_VectorTint8_tT = Marshal.GetDelegateForFunctionPointer<Delegaterl_as_byte_vector__Game_r_VectorTint8_tT>(rl_as_byte_vector__Game_r_VectorTint8_tT_ptr);
        IntPtr rl_parse_from_vector__int64_t_VectorTint8_tT_int64_t_r_bool_ptr = GetProcAddress(_lib, "rl_parse_from_vector__int64_t_VectorTint8_tT_int64_t_r_bool");
        if (rl_parse_from_vector__int64_t_VectorTint8_tT_int64_t_r_bool_ptr == IntPtr.Zero) throw new Exception("Could not find symbol rl_parse_from_vector__int64_t_VectorTint8_tT_int64_t_r_bool");
        rl_parse_from_vector__int64_t_VectorTint8_tT_int64_t_r_bool = Marshal.GetDelegateForFunctionPointer<Delegaterl_parse_from_vector__int64_t_VectorTint8_tT_int64_t_r_bool>(rl_parse_from_vector__int64_t_VectorTint8_tT_int64_t_r_bool_ptr);
        IntPtr rl_parse_from_vector__double_VectorTint8_tT_int64_t_r_bool_ptr = GetProcAddress(_lib, "rl_parse_from_vector__double_VectorTint8_tT_int64_t_r_bool");
        if (rl_parse_from_vector__double_VectorTint8_tT_int64_t_r_bool_ptr == IntPtr.Zero) throw new Exception("Could not find symbol rl_parse_from_vector__double_VectorTint8_tT_int64_t_r_bool");
        rl_parse_from_vector__double_VectorTint8_tT_int64_t_r_bool = Marshal.GetDelegateForFunctionPointer<Delegaterl_parse_from_vector__double_VectorTint8_tT_int64_t_r_bool>(rl_parse_from_vector__double_VectorTint8_tT_int64_t_r_bool_ptr);
        IntPtr rl_parse_from_vector__bool_VectorTint8_tT_int64_t_r_bool_ptr = GetProcAddress(_lib, "rl_parse_from_vector__bool_VectorTint8_tT_int64_t_r_bool");
        if (rl_parse_from_vector__bool_VectorTint8_tT_int64_t_r_bool_ptr == IntPtr.Zero) throw new Exception("Could not find symbol rl_parse_from_vector__bool_VectorTint8_tT_int64_t_r_bool");
        rl_parse_from_vector__bool_VectorTint8_tT_int64_t_r_bool = Marshal.GetDelegateForFunctionPointer<Delegaterl_parse_from_vector__bool_VectorTint8_tT_int64_t_r_bool>(rl_parse_from_vector__bool_VectorTint8_tT_int64_t_r_bool_ptr);
        IntPtr rl_parse_from_vector__int8_t_VectorTint8_tT_int64_t_r_bool_ptr = GetProcAddress(_lib, "rl_parse_from_vector__int8_t_VectorTint8_tT_int64_t_r_bool");
        if (rl_parse_from_vector__int8_t_VectorTint8_tT_int64_t_r_bool_ptr == IntPtr.Zero) throw new Exception("Could not find symbol rl_parse_from_vector__int8_t_VectorTint8_tT_int64_t_r_bool");
        rl_parse_from_vector__int8_t_VectorTint8_tT_int64_t_r_bool = Marshal.GetDelegateForFunctionPointer<Delegaterl_parse_from_vector__int8_t_VectorTint8_tT_int64_t_r_bool>(rl_parse_from_vector__int8_t_VectorTint8_tT_int64_t_r_bool_ptr);
        IntPtr rl_parse_from_vector__BIntT0T3T_9_VectorTint8_tT_int64_t_r_bool_ptr = GetProcAddress(_lib, "rl_parse_from_vector__BIntT0T3T_9_VectorTint8_tT_int64_t_r_bool");
        if (rl_parse_from_vector__BIntT0T3T_9_VectorTint8_tT_int64_t_r_bool_ptr == IntPtr.Zero) throw new Exception("Could not find symbol rl_parse_from_vector__BIntT0T3T_9_VectorTint8_tT_int64_t_r_bool");
        rl_parse_from_vector__BIntT0T3T_9_VectorTint8_tT_int64_t_r_bool = Marshal.GetDelegateForFunctionPointer<Delegaterl_parse_from_vector__BIntT0T3T_9_VectorTint8_tT_int64_t_r_bool>(rl_parse_from_vector__BIntT0T3T_9_VectorTint8_tT_int64_t_r_bool_ptr);
        IntPtr rl_from_byte_vector__Game_VectorTint8_tT_r_bool_ptr = GetProcAddress(_lib, "rl_from_byte_vector__Game_VectorTint8_tT_r_bool");
        if (rl_from_byte_vector__Game_VectorTint8_tT_r_bool_ptr == IntPtr.Zero) throw new Exception("Could not find symbol rl_from_byte_vector__Game_VectorTint8_tT_r_bool");
        rl_from_byte_vector__Game_VectorTint8_tT_r_bool = Marshal.GetDelegateForFunctionPointer<Delegaterl_from_byte_vector__Game_VectorTint8_tT_r_bool>(rl_from_byte_vector__Game_VectorTint8_tT_r_bool_ptr);
        IntPtr rl_from_byte_vector__AnyGameAction_VectorTint8_tT_r_bool_ptr = GetProcAddress(_lib, "rl_from_byte_vector__AnyGameAction_VectorTint8_tT_r_bool");
        if (rl_from_byte_vector__AnyGameAction_VectorTint8_tT_r_bool_ptr == IntPtr.Zero) throw new Exception("Could not find symbol rl_from_byte_vector__AnyGameAction_VectorTint8_tT_r_bool");
        rl_from_byte_vector__AnyGameAction_VectorTint8_tT_r_bool = Marshal.GetDelegateForFunctionPointer<Delegaterl_from_byte_vector__AnyGameAction_VectorTint8_tT_r_bool>(rl_from_byte_vector__AnyGameAction_VectorTint8_tT_r_bool_ptr);
        IntPtr rl_from_byte_vector__int8_t_VectorTint8_tT_int64_t_r_bool_ptr = GetProcAddress(_lib, "rl_from_byte_vector__int8_t_VectorTint8_tT_int64_t_r_bool");
        if (rl_from_byte_vector__int8_t_VectorTint8_tT_int64_t_r_bool_ptr == IntPtr.Zero) throw new Exception("Could not find symbol rl_from_byte_vector__int8_t_VectorTint8_tT_int64_t_r_bool");
        rl_from_byte_vector__int8_t_VectorTint8_tT_int64_t_r_bool = Marshal.GetDelegateForFunctionPointer<Delegaterl_from_byte_vector__int8_t_VectorTint8_tT_int64_t_r_bool>(rl_from_byte_vector__int8_t_VectorTint8_tT_int64_t_r_bool_ptr);
        IntPtr rl_from_byte_vector__int64_t_VectorTint8_tT_int64_t_r_bool_ptr = GetProcAddress(_lib, "rl_from_byte_vector__int64_t_VectorTint8_tT_int64_t_r_bool");
        if (rl_from_byte_vector__int64_t_VectorTint8_tT_int64_t_r_bool_ptr == IntPtr.Zero) throw new Exception("Could not find symbol rl_from_byte_vector__int64_t_VectorTint8_tT_int64_t_r_bool");
        rl_from_byte_vector__int64_t_VectorTint8_tT_int64_t_r_bool = Marshal.GetDelegateForFunctionPointer<Delegaterl_from_byte_vector__int64_t_VectorTint8_tT_int64_t_r_bool>(rl_from_byte_vector__int64_t_VectorTint8_tT_int64_t_r_bool_ptr);
        IntPtr rl_from_byte_vector__GameMark_VectorTint8_tT_int64_t_r_bool_ptr = GetProcAddress(_lib, "rl_from_byte_vector__GameMark_VectorTint8_tT_int64_t_r_bool");
        if (rl_from_byte_vector__GameMark_VectorTint8_tT_int64_t_r_bool_ptr == IntPtr.Zero) throw new Exception("Could not find symbol rl_from_byte_vector__GameMark_VectorTint8_tT_int64_t_r_bool");
        rl_from_byte_vector__GameMark_VectorTint8_tT_int64_t_r_bool = Marshal.GetDelegateForFunctionPointer<Delegaterl_from_byte_vector__GameMark_VectorTint8_tT_int64_t_r_bool>(rl_from_byte_vector__GameMark_VectorTint8_tT_int64_t_r_bool_ptr);
        IntPtr rl_from_byte_vector__AnyGameAction_VectorTint8_tT_int64_t_r_bool_ptr = GetProcAddress(_lib, "rl_from_byte_vector__AnyGameAction_VectorTint8_tT_int64_t_r_bool");
        if (rl_from_byte_vector__AnyGameAction_VectorTint8_tT_int64_t_r_bool_ptr == IntPtr.Zero) throw new Exception("Could not find symbol rl_from_byte_vector__AnyGameAction_VectorTint8_tT_int64_t_r_bool");
        rl_from_byte_vector__AnyGameAction_VectorTint8_tT_int64_t_r_bool = Marshal.GetDelegateForFunctionPointer<Delegaterl_from_byte_vector__AnyGameAction_VectorTint8_tT_int64_t_r_bool>(rl_from_byte_vector__AnyGameAction_VectorTint8_tT_int64_t_r_bool_ptr);
        IntPtr rl_m_size__VectorTint8_tT_r_int64_t_ptr = GetProcAddress(_lib, "rl_m_size__VectorTint8_tT_r_int64_t");
        if (rl_m_size__VectorTint8_tT_r_int64_t_ptr == IntPtr.Zero) throw new Exception("Could not find symbol rl_m_size__VectorTint8_tT_r_int64_t");
        rl_m_size__VectorTint8_tT_r_int64_t = Marshal.GetDelegateForFunctionPointer<Delegaterl_m_size__VectorTint8_tT_r_int64_t>(rl_m_size__VectorTint8_tT_r_int64_t_ptr);
        IntPtr rl_m_size__VectorTdoubleT_r_int64_t_ptr = GetProcAddress(_lib, "rl_m_size__VectorTdoubleT_r_int64_t");
        if (rl_m_size__VectorTdoubleT_r_int64_t_ptr == IntPtr.Zero) throw new Exception("Could not find symbol rl_m_size__VectorTdoubleT_r_int64_t");
        rl_m_size__VectorTdoubleT_r_int64_t = Marshal.GetDelegateForFunctionPointer<Delegaterl_m_size__VectorTdoubleT_r_int64_t>(rl_m_size__VectorTdoubleT_r_int64_t_ptr);
        IntPtr rl_m_size__VectorTStringT_r_int64_t_ptr = GetProcAddress(_lib, "rl_m_size__VectorTStringT_r_int64_t");
        if (rl_m_size__VectorTStringT_r_int64_t_ptr == IntPtr.Zero) throw new Exception("Could not find symbol rl_m_size__VectorTStringT_r_int64_t");
        rl_m_size__VectorTStringT_r_int64_t = Marshal.GetDelegateForFunctionPointer<Delegaterl_m_size__VectorTStringT_r_int64_t>(rl_m_size__VectorTStringT_r_int64_t_ptr);
        IntPtr rl_m_size__VectorTAnyGameActionT_r_int64_t_ptr = GetProcAddress(_lib, "rl_m_size__VectorTAnyGameActionT_r_int64_t");
        if (rl_m_size__VectorTAnyGameActionT_r_int64_t_ptr == IntPtr.Zero) throw new Exception("Could not find symbol rl_m_size__VectorTAnyGameActionT_r_int64_t");
        rl_m_size__VectorTAnyGameActionT_r_int64_t = Marshal.GetDelegateForFunctionPointer<Delegaterl_m_size__VectorTAnyGameActionT_r_int64_t>(rl_m_size__VectorTAnyGameActionT_r_int64_t_ptr);
        IntPtr rl_m_size__VectorTGameMarkT_r_int64_t_ptr = GetProcAddress(_lib, "rl_m_size__VectorTGameMarkT_r_int64_t");
        if (rl_m_size__VectorTGameMarkT_r_int64_t_ptr == IntPtr.Zero) throw new Exception("Could not find symbol rl_m_size__VectorTGameMarkT_r_int64_t");
        rl_m_size__VectorTGameMarkT_r_int64_t = Marshal.GetDelegateForFunctionPointer<Delegaterl_m_size__VectorTGameMarkT_r_int64_t>(rl_m_size__VectorTGameMarkT_r_int64_t_ptr);
        IntPtr rl_m_size__VectorTBIntT0T3TT_r_int64_t_ptr = GetProcAddress(_lib, "rl_m_size__VectorTBIntT0T3TT_r_int64_t");
        if (rl_m_size__VectorTBIntT0T3TT_r_int64_t_ptr == IntPtr.Zero) throw new Exception("Could not find symbol rl_m_size__VectorTBIntT0T3TT_r_int64_t");
        rl_m_size__VectorTBIntT0T3TT_r_int64_t = Marshal.GetDelegateForFunctionPointer<Delegaterl_m_size__VectorTBIntT0T3TT_r_int64_t>(rl_m_size__VectorTBIntT0T3TT_r_int64_t_ptr);
        IntPtr rl_m_drop_back__VectorTint8_tT_int64_t_ptr = GetProcAddress(_lib, "rl_m_drop_back__VectorTint8_tT_int64_t");
        if (rl_m_drop_back__VectorTint8_tT_int64_t_ptr == IntPtr.Zero) throw new Exception("Could not find symbol rl_m_drop_back__VectorTint8_tT_int64_t");
        rl_m_drop_back__VectorTint8_tT_int64_t = Marshal.GetDelegateForFunctionPointer<Delegaterl_m_drop_back__VectorTint8_tT_int64_t>(rl_m_drop_back__VectorTint8_tT_int64_t_ptr);
        IntPtr rl_m_pop__VectorTint8_tT_r_int8_t_ptr = GetProcAddress(_lib, "rl_m_pop__VectorTint8_tT_r_int8_t");
        if (rl_m_pop__VectorTint8_tT_r_int8_t_ptr == IntPtr.Zero) throw new Exception("Could not find symbol rl_m_pop__VectorTint8_tT_r_int8_t");
        rl_m_pop__VectorTint8_tT_r_int8_t = Marshal.GetDelegateForFunctionPointer<Delegaterl_m_pop__VectorTint8_tT_r_int8_t>(rl_m_pop__VectorTint8_tT_r_int8_t_ptr);
        IntPtr rl_m_pop__VectorTStringT_r_String_ptr = GetProcAddress(_lib, "rl_m_pop__VectorTStringT_r_String");
        if (rl_m_pop__VectorTStringT_r_String_ptr == IntPtr.Zero) throw new Exception("Could not find symbol rl_m_pop__VectorTStringT_r_String");
        rl_m_pop__VectorTStringT_r_String = Marshal.GetDelegateForFunctionPointer<Delegaterl_m_pop__VectorTStringT_r_String>(rl_m_pop__VectorTStringT_r_String_ptr);
        IntPtr rl_m_pop__VectorTdoubleT_r_double_ptr = GetProcAddress(_lib, "rl_m_pop__VectorTdoubleT_r_double");
        if (rl_m_pop__VectorTdoubleT_r_double_ptr == IntPtr.Zero) throw new Exception("Could not find symbol rl_m_pop__VectorTdoubleT_r_double");
        rl_m_pop__VectorTdoubleT_r_double = Marshal.GetDelegateForFunctionPointer<Delegaterl_m_pop__VectorTdoubleT_r_double>(rl_m_pop__VectorTdoubleT_r_double_ptr);
        IntPtr rl_m_append__VectorTint8_tT_int8_t_ptr = GetProcAddress(_lib, "rl_m_append__VectorTint8_tT_int8_t");
        if (rl_m_append__VectorTint8_tT_int8_t_ptr == IntPtr.Zero) throw new Exception("Could not find symbol rl_m_append__VectorTint8_tT_int8_t");
        rl_m_append__VectorTint8_tT_int8_t = Marshal.GetDelegateForFunctionPointer<Delegaterl_m_append__VectorTint8_tT_int8_t>(rl_m_append__VectorTint8_tT_int8_t_ptr);
        IntPtr rl_m_append__VectorTboolT_bool_ptr = GetProcAddress(_lib, "rl_m_append__VectorTboolT_bool");
        if (rl_m_append__VectorTboolT_bool_ptr == IntPtr.Zero) throw new Exception("Could not find symbol rl_m_append__VectorTboolT_bool");
        rl_m_append__VectorTboolT_bool = Marshal.GetDelegateForFunctionPointer<Delegaterl_m_append__VectorTboolT_bool>(rl_m_append__VectorTboolT_bool_ptr);
        IntPtr rl_m_append__VectorTStringT_String_ptr = GetProcAddress(_lib, "rl_m_append__VectorTStringT_String");
        if (rl_m_append__VectorTStringT_String_ptr == IntPtr.Zero) throw new Exception("Could not find symbol rl_m_append__VectorTStringT_String");
        rl_m_append__VectorTStringT_String = Marshal.GetDelegateForFunctionPointer<Delegaterl_m_append__VectorTStringT_String>(rl_m_append__VectorTStringT_String_ptr);
        IntPtr rl_m_append__VectorTdoubleT_double_ptr = GetProcAddress(_lib, "rl_m_append__VectorTdoubleT_double");
        if (rl_m_append__VectorTdoubleT_double_ptr == IntPtr.Zero) throw new Exception("Could not find symbol rl_m_append__VectorTdoubleT_double");
        rl_m_append__VectorTdoubleT_double = Marshal.GetDelegateForFunctionPointer<Delegaterl_m_append__VectorTdoubleT_double>(rl_m_append__VectorTdoubleT_double_ptr);
        IntPtr rl_m_append__VectorTAnyGameActionT_AnyGameAction_ptr = GetProcAddress(_lib, "rl_m_append__VectorTAnyGameActionT_AnyGameAction");
        if (rl_m_append__VectorTAnyGameActionT_AnyGameAction_ptr == IntPtr.Zero) throw new Exception("Could not find symbol rl_m_append__VectorTAnyGameActionT_AnyGameAction");
        rl_m_append__VectorTAnyGameActionT_AnyGameAction = Marshal.GetDelegateForFunctionPointer<Delegaterl_m_append__VectorTAnyGameActionT_AnyGameAction>(rl_m_append__VectorTAnyGameActionT_AnyGameAction_ptr);
        IntPtr rl_m_append__VectorTGameMarkT_GameMark_ptr = GetProcAddress(_lib, "rl_m_append__VectorTGameMarkT_GameMark");
        if (rl_m_append__VectorTGameMarkT_GameMark_ptr == IntPtr.Zero) throw new Exception("Could not find symbol rl_m_append__VectorTGameMarkT_GameMark");
        rl_m_append__VectorTGameMarkT_GameMark = Marshal.GetDelegateForFunctionPointer<Delegaterl_m_append__VectorTGameMarkT_GameMark>(rl_m_append__VectorTGameMarkT_GameMark_ptr);
        IntPtr rl_m_append__VectorTBIntT0T3TT_BIntT0T3T_ptr = GetProcAddress(_lib, "rl_m_append__VectorTBIntT0T3TT_BIntT0T3T");
        if (rl_m_append__VectorTBIntT0T3TT_BIntT0T3T_ptr == IntPtr.Zero) throw new Exception("Could not find symbol rl_m_append__VectorTBIntT0T3TT_BIntT0T3T");
        rl_m_append__VectorTBIntT0T3TT_BIntT0T3T = Marshal.GetDelegateForFunctionPointer<Delegaterl_m_append__VectorTBIntT0T3TT_BIntT0T3T>(rl_m_append__VectorTBIntT0T3TT_BIntT0T3T_ptr);
        IntPtr rl_m_get__VectorTint8_tT_int64_t_r_int8_tRef_ptr = GetProcAddress(_lib, "rl_m_get__VectorTint8_tT_int64_t_r_int8_tRef");
        if (rl_m_get__VectorTint8_tT_int64_t_r_int8_tRef_ptr == IntPtr.Zero) throw new Exception("Could not find symbol rl_m_get__VectorTint8_tT_int64_t_r_int8_tRef");
        rl_m_get__VectorTint8_tT_int64_t_r_int8_tRef = Marshal.GetDelegateForFunctionPointer<Delegaterl_m_get__VectorTint8_tT_int64_t_r_int8_tRef>(rl_m_get__VectorTint8_tT_int64_t_r_int8_tRef_ptr);
        IntPtr rl_m_get__VectorTdoubleT_int64_t_r_doubleRef_ptr = GetProcAddress(_lib, "rl_m_get__VectorTdoubleT_int64_t_r_doubleRef");
        if (rl_m_get__VectorTdoubleT_int64_t_r_doubleRef_ptr == IntPtr.Zero) throw new Exception("Could not find symbol rl_m_get__VectorTdoubleT_int64_t_r_doubleRef");
        rl_m_get__VectorTdoubleT_int64_t_r_doubleRef = Marshal.GetDelegateForFunctionPointer<Delegaterl_m_get__VectorTdoubleT_int64_t_r_doubleRef>(rl_m_get__VectorTdoubleT_int64_t_r_doubleRef_ptr);
        IntPtr rl_m_get__VectorTStringT_int64_t_r_StringRef_ptr = GetProcAddress(_lib, "rl_m_get__VectorTStringT_int64_t_r_StringRef");
        if (rl_m_get__VectorTStringT_int64_t_r_StringRef_ptr == IntPtr.Zero) throw new Exception("Could not find symbol rl_m_get__VectorTStringT_int64_t_r_StringRef");
        rl_m_get__VectorTStringT_int64_t_r_StringRef = Marshal.GetDelegateForFunctionPointer<Delegaterl_m_get__VectorTStringT_int64_t_r_StringRef>(rl_m_get__VectorTStringT_int64_t_r_StringRef_ptr);
        IntPtr rl_m_get__VectorTAnyGameActionT_int64_t_r_AnyGameActionRef_ptr = GetProcAddress(_lib, "rl_m_get__VectorTAnyGameActionT_int64_t_r_AnyGameActionRef");
        if (rl_m_get__VectorTAnyGameActionT_int64_t_r_AnyGameActionRef_ptr == IntPtr.Zero) throw new Exception("Could not find symbol rl_m_get__VectorTAnyGameActionT_int64_t_r_AnyGameActionRef");
        rl_m_get__VectorTAnyGameActionT_int64_t_r_AnyGameActionRef = Marshal.GetDelegateForFunctionPointer<Delegaterl_m_get__VectorTAnyGameActionT_int64_t_r_AnyGameActionRef>(rl_m_get__VectorTAnyGameActionT_int64_t_r_AnyGameActionRef_ptr);
        IntPtr rl_m_get__VectorTboolT_int64_t_r_boolRef_ptr = GetProcAddress(_lib, "rl_m_get__VectorTboolT_int64_t_r_boolRef");
        if (rl_m_get__VectorTboolT_int64_t_r_boolRef_ptr == IntPtr.Zero) throw new Exception("Could not find symbol rl_m_get__VectorTboolT_int64_t_r_boolRef");
        rl_m_get__VectorTboolT_int64_t_r_boolRef = Marshal.GetDelegateForFunctionPointer<Delegaterl_m_get__VectorTboolT_int64_t_r_boolRef>(rl_m_get__VectorTboolT_int64_t_r_boolRef_ptr);
        IntPtr rl_m_get__VectorTGameMarkT_int64_t_r_GameMarkRef_ptr = GetProcAddress(_lib, "rl_m_get__VectorTGameMarkT_int64_t_r_GameMarkRef");
        if (rl_m_get__VectorTGameMarkT_int64_t_r_GameMarkRef_ptr == IntPtr.Zero) throw new Exception("Could not find symbol rl_m_get__VectorTGameMarkT_int64_t_r_GameMarkRef");
        rl_m_get__VectorTGameMarkT_int64_t_r_GameMarkRef = Marshal.GetDelegateForFunctionPointer<Delegaterl_m_get__VectorTGameMarkT_int64_t_r_GameMarkRef>(rl_m_get__VectorTGameMarkT_int64_t_r_GameMarkRef_ptr);
        IntPtr rl_m_get__VectorTBIntT0T3TT_int64_t_r_BIntT0T3TRef_ptr = GetProcAddress(_lib, "rl_m_get__VectorTBIntT0T3TT_int64_t_r_BIntT0T3TRef");
        if (rl_m_get__VectorTBIntT0T3TT_int64_t_r_BIntT0T3TRef_ptr == IntPtr.Zero) throw new Exception("Could not find symbol rl_m_get__VectorTBIntT0T3TT_int64_t_r_BIntT0T3TRef");
        rl_m_get__VectorTBIntT0T3TT_int64_t_r_BIntT0T3TRef = Marshal.GetDelegateForFunctionPointer<Delegaterl_m_get__VectorTBIntT0T3TT_int64_t_r_BIntT0T3TRef>(rl_m_get__VectorTBIntT0T3TT_int64_t_r_BIntT0T3TRef_ptr);
        IntPtr rl_m_back__VectorTint8_tT_r_int8_tRef_ptr = GetProcAddress(_lib, "rl_m_back__VectorTint8_tT_r_int8_tRef");
        if (rl_m_back__VectorTint8_tT_r_int8_tRef_ptr == IntPtr.Zero) throw new Exception("Could not find symbol rl_m_back__VectorTint8_tT_r_int8_tRef");
        rl_m_back__VectorTint8_tT_r_int8_tRef = Marshal.GetDelegateForFunctionPointer<Delegaterl_m_back__VectorTint8_tT_r_int8_tRef>(rl_m_back__VectorTint8_tT_r_int8_tRef_ptr);
        IntPtr rl_m_resize__VectorTdoubleT_int64_t_ptr = GetProcAddress(_lib, "rl_m_resize__VectorTdoubleT_int64_t");
        if (rl_m_resize__VectorTdoubleT_int64_t_ptr == IntPtr.Zero) throw new Exception("Could not find symbol rl_m_resize__VectorTdoubleT_int64_t");
        rl_m_resize__VectorTdoubleT_int64_t = Marshal.GetDelegateForFunctionPointer<Delegaterl_m_resize__VectorTdoubleT_int64_t>(rl_m_resize__VectorTdoubleT_int64_t_ptr);
        IntPtr rl_m_assign__VectorTint8_tT_VectorTint8_tT_ptr = GetProcAddress(_lib, "rl_m_assign__VectorTint8_tT_VectorTint8_tT");
        if (rl_m_assign__VectorTint8_tT_VectorTint8_tT_ptr == IntPtr.Zero) throw new Exception("Could not find symbol rl_m_assign__VectorTint8_tT_VectorTint8_tT");
        rl_m_assign__VectorTint8_tT_VectorTint8_tT = Marshal.GetDelegateForFunctionPointer<Delegaterl_m_assign__VectorTint8_tT_VectorTint8_tT>(rl_m_assign__VectorTint8_tT_VectorTint8_tT_ptr);
        IntPtr rl_m_assign__VectorTStringT_VectorTStringT_ptr = GetProcAddress(_lib, "rl_m_assign__VectorTStringT_VectorTStringT");
        if (rl_m_assign__VectorTStringT_VectorTStringT_ptr == IntPtr.Zero) throw new Exception("Could not find symbol rl_m_assign__VectorTStringT_VectorTStringT");
        rl_m_assign__VectorTStringT_VectorTStringT = Marshal.GetDelegateForFunctionPointer<Delegaterl_m_assign__VectorTStringT_VectorTStringT>(rl_m_assign__VectorTStringT_VectorTStringT_ptr);
        IntPtr rl_m_assign__VectorTdoubleT_VectorTdoubleT_ptr = GetProcAddress(_lib, "rl_m_assign__VectorTdoubleT_VectorTdoubleT");
        if (rl_m_assign__VectorTdoubleT_VectorTdoubleT_ptr == IntPtr.Zero) throw new Exception("Could not find symbol rl_m_assign__VectorTdoubleT_VectorTdoubleT");
        rl_m_assign__VectorTdoubleT_VectorTdoubleT = Marshal.GetDelegateForFunctionPointer<Delegaterl_m_assign__VectorTdoubleT_VectorTdoubleT>(rl_m_assign__VectorTdoubleT_VectorTdoubleT_ptr);
        IntPtr rl_m_assign__VectorTboolT_VectorTboolT_ptr = GetProcAddress(_lib, "rl_m_assign__VectorTboolT_VectorTboolT");
        if (rl_m_assign__VectorTboolT_VectorTboolT_ptr == IntPtr.Zero) throw new Exception("Could not find symbol rl_m_assign__VectorTboolT_VectorTboolT");
        rl_m_assign__VectorTboolT_VectorTboolT = Marshal.GetDelegateForFunctionPointer<Delegaterl_m_assign__VectorTboolT_VectorTboolT>(rl_m_assign__VectorTboolT_VectorTboolT_ptr);
        IntPtr rl_m_assign__VectorTAnyGameActionT_VectorTAnyGameActionT_ptr = GetProcAddress(_lib, "rl_m_assign__VectorTAnyGameActionT_VectorTAnyGameActionT");
        if (rl_m_assign__VectorTAnyGameActionT_VectorTAnyGameActionT_ptr == IntPtr.Zero) throw new Exception("Could not find symbol rl_m_assign__VectorTAnyGameActionT_VectorTAnyGameActionT");
        rl_m_assign__VectorTAnyGameActionT_VectorTAnyGameActionT = Marshal.GetDelegateForFunctionPointer<Delegaterl_m_assign__VectorTAnyGameActionT_VectorTAnyGameActionT>(rl_m_assign__VectorTAnyGameActionT_VectorTAnyGameActionT_ptr);
        IntPtr rl_m_assign__VectorTGameMarkT_VectorTGameMarkT_ptr = GetProcAddress(_lib, "rl_m_assign__VectorTGameMarkT_VectorTGameMarkT");
        if (rl_m_assign__VectorTGameMarkT_VectorTGameMarkT_ptr == IntPtr.Zero) throw new Exception("Could not find symbol rl_m_assign__VectorTGameMarkT_VectorTGameMarkT");
        rl_m_assign__VectorTGameMarkT_VectorTGameMarkT = Marshal.GetDelegateForFunctionPointer<Delegaterl_m_assign__VectorTGameMarkT_VectorTGameMarkT>(rl_m_assign__VectorTGameMarkT_VectorTGameMarkT_ptr);
        IntPtr rl_m_assign__VectorTBIntT0T3TT_VectorTBIntT0T3TT_ptr = GetProcAddress(_lib, "rl_m_assign__VectorTBIntT0T3TT_VectorTBIntT0T3TT");
        if (rl_m_assign__VectorTBIntT0T3TT_VectorTBIntT0T3TT_ptr == IntPtr.Zero) throw new Exception("Could not find symbol rl_m_assign__VectorTBIntT0T3TT_VectorTBIntT0T3TT");
        rl_m_assign__VectorTBIntT0T3TT_VectorTBIntT0T3TT = Marshal.GetDelegateForFunctionPointer<Delegaterl_m_assign__VectorTBIntT0T3TT_VectorTBIntT0T3TT>(rl_m_assign__VectorTBIntT0T3TT_VectorTBIntT0T3TT_ptr);
        IntPtr rl_m_drop__VectorTint8_tT_ptr = GetProcAddress(_lib, "rl_m_drop__VectorTint8_tT");
        if (rl_m_drop__VectorTint8_tT_ptr == IntPtr.Zero) throw new Exception("Could not find symbol rl_m_drop__VectorTint8_tT");
        rl_m_drop__VectorTint8_tT = Marshal.GetDelegateForFunctionPointer<Delegaterl_m_drop__VectorTint8_tT>(rl_m_drop__VectorTint8_tT_ptr);
        IntPtr rl_m_drop__VectorTdoubleT_ptr = GetProcAddress(_lib, "rl_m_drop__VectorTdoubleT");
        if (rl_m_drop__VectorTdoubleT_ptr == IntPtr.Zero) throw new Exception("Could not find symbol rl_m_drop__VectorTdoubleT");
        rl_m_drop__VectorTdoubleT = Marshal.GetDelegateForFunctionPointer<Delegaterl_m_drop__VectorTdoubleT>(rl_m_drop__VectorTdoubleT_ptr);
        IntPtr rl_m_drop__VectorTStringT_ptr = GetProcAddress(_lib, "rl_m_drop__VectorTStringT");
        if (rl_m_drop__VectorTStringT_ptr == IntPtr.Zero) throw new Exception("Could not find symbol rl_m_drop__VectorTStringT");
        rl_m_drop__VectorTStringT = Marshal.GetDelegateForFunctionPointer<Delegaterl_m_drop__VectorTStringT>(rl_m_drop__VectorTStringT_ptr);
        IntPtr rl_m_drop__VectorTAnyGameActionT_ptr = GetProcAddress(_lib, "rl_m_drop__VectorTAnyGameActionT");
        if (rl_m_drop__VectorTAnyGameActionT_ptr == IntPtr.Zero) throw new Exception("Could not find symbol rl_m_drop__VectorTAnyGameActionT");
        rl_m_drop__VectorTAnyGameActionT = Marshal.GetDelegateForFunctionPointer<Delegaterl_m_drop__VectorTAnyGameActionT>(rl_m_drop__VectorTAnyGameActionT_ptr);
        IntPtr rl_m_drop__VectorTboolT_ptr = GetProcAddress(_lib, "rl_m_drop__VectorTboolT");
        if (rl_m_drop__VectorTboolT_ptr == IntPtr.Zero) throw new Exception("Could not find symbol rl_m_drop__VectorTboolT");
        rl_m_drop__VectorTboolT = Marshal.GetDelegateForFunctionPointer<Delegaterl_m_drop__VectorTboolT>(rl_m_drop__VectorTboolT_ptr);
        IntPtr rl_m_drop__VectorTGameMarkT_ptr = GetProcAddress(_lib, "rl_m_drop__VectorTGameMarkT");
        if (rl_m_drop__VectorTGameMarkT_ptr == IntPtr.Zero) throw new Exception("Could not find symbol rl_m_drop__VectorTGameMarkT");
        rl_m_drop__VectorTGameMarkT = Marshal.GetDelegateForFunctionPointer<Delegaterl_m_drop__VectorTGameMarkT>(rl_m_drop__VectorTGameMarkT_ptr);
        IntPtr rl_m_drop__VectorTBIntT0T3TT_ptr = GetProcAddress(_lib, "rl_m_drop__VectorTBIntT0T3TT");
        if (rl_m_drop__VectorTBIntT0T3TT_ptr == IntPtr.Zero) throw new Exception("Could not find symbol rl_m_drop__VectorTBIntT0T3TT");
        rl_m_drop__VectorTBIntT0T3TT = Marshal.GetDelegateForFunctionPointer<Delegaterl_m_drop__VectorTBIntT0T3TT>(rl_m_drop__VectorTBIntT0T3TT_ptr);
        IntPtr rl_m_init__VectorTint8_tT_ptr = GetProcAddress(_lib, "rl_m_init__VectorTint8_tT");
        if (rl_m_init__VectorTint8_tT_ptr == IntPtr.Zero) throw new Exception("Could not find symbol rl_m_init__VectorTint8_tT");
        rl_m_init__VectorTint8_tT = Marshal.GetDelegateForFunctionPointer<Delegaterl_m_init__VectorTint8_tT>(rl_m_init__VectorTint8_tT_ptr);
        IntPtr rl_m_init__VectorTdoubleT_ptr = GetProcAddress(_lib, "rl_m_init__VectorTdoubleT");
        if (rl_m_init__VectorTdoubleT_ptr == IntPtr.Zero) throw new Exception("Could not find symbol rl_m_init__VectorTdoubleT");
        rl_m_init__VectorTdoubleT = Marshal.GetDelegateForFunctionPointer<Delegaterl_m_init__VectorTdoubleT>(rl_m_init__VectorTdoubleT_ptr);
        IntPtr rl_m_init__VectorTStringT_ptr = GetProcAddress(_lib, "rl_m_init__VectorTStringT");
        if (rl_m_init__VectorTStringT_ptr == IntPtr.Zero) throw new Exception("Could not find symbol rl_m_init__VectorTStringT");
        rl_m_init__VectorTStringT = Marshal.GetDelegateForFunctionPointer<Delegaterl_m_init__VectorTStringT>(rl_m_init__VectorTStringT_ptr);
        IntPtr rl_m_init__VectorTAnyGameActionT_ptr = GetProcAddress(_lib, "rl_m_init__VectorTAnyGameActionT");
        if (rl_m_init__VectorTAnyGameActionT_ptr == IntPtr.Zero) throw new Exception("Could not find symbol rl_m_init__VectorTAnyGameActionT");
        rl_m_init__VectorTAnyGameActionT = Marshal.GetDelegateForFunctionPointer<Delegaterl_m_init__VectorTAnyGameActionT>(rl_m_init__VectorTAnyGameActionT_ptr);
        IntPtr rl_m_init__VectorTboolT_ptr = GetProcAddress(_lib, "rl_m_init__VectorTboolT");
        if (rl_m_init__VectorTboolT_ptr == IntPtr.Zero) throw new Exception("Could not find symbol rl_m_init__VectorTboolT");
        rl_m_init__VectorTboolT = Marshal.GetDelegateForFunctionPointer<Delegaterl_m_init__VectorTboolT>(rl_m_init__VectorTboolT_ptr);
        IntPtr rl_m_init__VectorTGameMarkT_ptr = GetProcAddress(_lib, "rl_m_init__VectorTGameMarkT");
        if (rl_m_init__VectorTGameMarkT_ptr == IntPtr.Zero) throw new Exception("Could not find symbol rl_m_init__VectorTGameMarkT");
        rl_m_init__VectorTGameMarkT = Marshal.GetDelegateForFunctionPointer<Delegaterl_m_init__VectorTGameMarkT>(rl_m_init__VectorTGameMarkT_ptr);
        IntPtr rl_m_init__VectorTBIntT0T3TT_ptr = GetProcAddress(_lib, "rl_m_init__VectorTBIntT0T3TT");
        if (rl_m_init__VectorTBIntT0T3TT_ptr == IntPtr.Zero) throw new Exception("Could not find symbol rl_m_init__VectorTBIntT0T3TT");
        rl_m_init__VectorTBIntT0T3TT = Marshal.GetDelegateForFunctionPointer<Delegaterl_m_init__VectorTBIntT0T3TT>(rl_m_init__VectorTBIntT0T3TT_ptr);
        IntPtr rl_m_to_indented_lines__String_r_String_ptr = GetProcAddress(_lib, "rl_m_to_indented_lines__String_r_String");
        if (rl_m_to_indented_lines__String_r_String_ptr == IntPtr.Zero) throw new Exception("Could not find symbol rl_m_to_indented_lines__String_r_String");
        rl_m_to_indented_lines__String_r_String = Marshal.GetDelegateForFunctionPointer<Delegaterl_m_to_indented_lines__String_r_String>(rl_m_to_indented_lines__String_r_String_ptr);
        IntPtr rl_m_reverse__String_ptr = GetProcAddress(_lib, "rl_m_reverse__String");
        if (rl_m_reverse__String_ptr == IntPtr.Zero) throw new Exception("Could not find symbol rl_m_reverse__String");
        rl_m_reverse__String = Marshal.GetDelegateForFunctionPointer<Delegaterl_m_reverse__String>(rl_m_reverse__String_ptr);
        IntPtr rl_m_back__String_r_int8_tRef_ptr = GetProcAddress(_lib, "rl_m_back__String_r_int8_tRef");
        if (rl_m_back__String_r_int8_tRef_ptr == IntPtr.Zero) throw new Exception("Could not find symbol rl_m_back__String_r_int8_tRef");
        rl_m_back__String_r_int8_tRef = Marshal.GetDelegateForFunctionPointer<Delegaterl_m_back__String_r_int8_tRef>(rl_m_back__String_r_int8_tRef_ptr);
        IntPtr rl_m_drop_back__String_int64_t_ptr = GetProcAddress(_lib, "rl_m_drop_back__String_int64_t");
        if (rl_m_drop_back__String_int64_t_ptr == IntPtr.Zero) throw new Exception("Could not find symbol rl_m_drop_back__String_int64_t");
        rl_m_drop_back__String_int64_t = Marshal.GetDelegateForFunctionPointer<Delegaterl_m_drop_back__String_int64_t>(rl_m_drop_back__String_int64_t_ptr);
        IntPtr rl_m_not_equal__String_strlit_r_bool_ptr = GetProcAddress(_lib, "rl_m_not_equal__String_strlit_r_bool");
        if (rl_m_not_equal__String_strlit_r_bool_ptr == IntPtr.Zero) throw new Exception("Could not find symbol rl_m_not_equal__String_strlit_r_bool");
        rl_m_not_equal__String_strlit_r_bool = Marshal.GetDelegateForFunctionPointer<Delegaterl_m_not_equal__String_strlit_r_bool>(rl_m_not_equal__String_strlit_r_bool_ptr);
        IntPtr rl_m_not_equal__String_String_r_bool_ptr = GetProcAddress(_lib, "rl_m_not_equal__String_String_r_bool");
        if (rl_m_not_equal__String_String_r_bool_ptr == IntPtr.Zero) throw new Exception("Could not find symbol rl_m_not_equal__String_String_r_bool");
        rl_m_not_equal__String_String_r_bool = Marshal.GetDelegateForFunctionPointer<Delegaterl_m_not_equal__String_String_r_bool>(rl_m_not_equal__String_String_r_bool_ptr);
        IntPtr rl_m_equal__String_String_r_bool_ptr = GetProcAddress(_lib, "rl_m_equal__String_String_r_bool");
        if (rl_m_equal__String_String_r_bool_ptr == IntPtr.Zero) throw new Exception("Could not find symbol rl_m_equal__String_String_r_bool");
        rl_m_equal__String_String_r_bool = Marshal.GetDelegateForFunctionPointer<Delegaterl_m_equal__String_String_r_bool>(rl_m_equal__String_String_r_bool_ptr);
        IntPtr rl_m_equal__String_strlit_r_bool_ptr = GetProcAddress(_lib, "rl_m_equal__String_strlit_r_bool");
        if (rl_m_equal__String_strlit_r_bool_ptr == IntPtr.Zero) throw new Exception("Could not find symbol rl_m_equal__String_strlit_r_bool");
        rl_m_equal__String_strlit_r_bool = Marshal.GetDelegateForFunctionPointer<Delegaterl_m_equal__String_strlit_r_bool>(rl_m_equal__String_strlit_r_bool_ptr);
        IntPtr rl_m_add__String_String_r_String_ptr = GetProcAddress(_lib, "rl_m_add__String_String_r_String");
        if (rl_m_add__String_String_r_String_ptr == IntPtr.Zero) throw new Exception("Could not find symbol rl_m_add__String_String_r_String");
        rl_m_add__String_String_r_String = Marshal.GetDelegateForFunctionPointer<Delegaterl_m_add__String_String_r_String>(rl_m_add__String_String_r_String_ptr);
        IntPtr rl_m_append_quoted__String_String_ptr = GetProcAddress(_lib, "rl_m_append_quoted__String_String");
        if (rl_m_append_quoted__String_String_ptr == IntPtr.Zero) throw new Exception("Could not find symbol rl_m_append_quoted__String_String");
        rl_m_append_quoted__String_String = Marshal.GetDelegateForFunctionPointer<Delegaterl_m_append_quoted__String_String>(rl_m_append_quoted__String_String_ptr);
        IntPtr rl_m_append__String_String_ptr = GetProcAddress(_lib, "rl_m_append__String_String");
        if (rl_m_append__String_String_ptr == IntPtr.Zero) throw new Exception("Could not find symbol rl_m_append__String_String");
        rl_m_append__String_String = Marshal.GetDelegateForFunctionPointer<Delegaterl_m_append__String_String>(rl_m_append__String_String_ptr);
        IntPtr rl_m_append__String_strlit_ptr = GetProcAddress(_lib, "rl_m_append__String_strlit");
        if (rl_m_append__String_strlit_ptr == IntPtr.Zero) throw new Exception("Could not find symbol rl_m_append__String_strlit");
        rl_m_append__String_strlit = Marshal.GetDelegateForFunctionPointer<Delegaterl_m_append__String_strlit>(rl_m_append__String_strlit_ptr);
        IntPtr rl_m_count__String_int8_t_r_int64_t_ptr = GetProcAddress(_lib, "rl_m_count__String_int8_t_r_int64_t");
        if (rl_m_count__String_int8_t_r_int64_t_ptr == IntPtr.Zero) throw new Exception("Could not find symbol rl_m_count__String_int8_t_r_int64_t");
        rl_m_count__String_int8_t_r_int64_t = Marshal.GetDelegateForFunctionPointer<Delegaterl_m_count__String_int8_t_r_int64_t>(rl_m_count__String_int8_t_r_int64_t_ptr);
        IntPtr rl_m_size__String_r_int64_t_ptr = GetProcAddress(_lib, "rl_m_size__String_r_int64_t");
        if (rl_m_size__String_r_int64_t_ptr == IntPtr.Zero) throw new Exception("Could not find symbol rl_m_size__String_r_int64_t");
        rl_m_size__String_r_int64_t = Marshal.GetDelegateForFunctionPointer<Delegaterl_m_size__String_r_int64_t>(rl_m_size__String_r_int64_t_ptr);
        IntPtr rl_m_substring_matches__String_strlit_int64_t_r_bool_ptr = GetProcAddress(_lib, "rl_m_substring_matches__String_strlit_int64_t_r_bool");
        if (rl_m_substring_matches__String_strlit_int64_t_r_bool_ptr == IntPtr.Zero) throw new Exception("Could not find symbol rl_m_substring_matches__String_strlit_int64_t_r_bool");
        rl_m_substring_matches__String_strlit_int64_t_r_bool = Marshal.GetDelegateForFunctionPointer<Delegaterl_m_substring_matches__String_strlit_int64_t_r_bool>(rl_m_substring_matches__String_strlit_int64_t_r_bool_ptr);
        IntPtr rl_m_get__String_int64_t_r_int8_tRef_ptr = GetProcAddress(_lib, "rl_m_get__String_int64_t_r_int8_tRef");
        if (rl_m_get__String_int64_t_r_int8_tRef_ptr == IntPtr.Zero) throw new Exception("Could not find symbol rl_m_get__String_int64_t_r_int8_tRef");
        rl_m_get__String_int64_t_r_int8_tRef = Marshal.GetDelegateForFunctionPointer<Delegaterl_m_get__String_int64_t_r_int8_tRef>(rl_m_get__String_int64_t_r_int8_tRef_ptr);
        IntPtr rl_m_append__String_int8_t_ptr = GetProcAddress(_lib, "rl_m_append__String_int8_t");
        if (rl_m_append__String_int8_t_ptr == IntPtr.Zero) throw new Exception("Could not find symbol rl_m_append__String_int8_t");
        rl_m_append__String_int8_t = Marshal.GetDelegateForFunctionPointer<Delegaterl_m_append__String_int8_t>(rl_m_append__String_int8_t_ptr);
        IntPtr rl_m_init__String_ptr = GetProcAddress(_lib, "rl_m_init__String");
        if (rl_m_init__String_ptr == IntPtr.Zero) throw new Exception("Could not find symbol rl_m_init__String");
        rl_m_init__String = Marshal.GetDelegateForFunctionPointer<Delegaterl_m_init__String>(rl_m_init__String_ptr);
        IntPtr rl_s__strlit_r_String_ptr = GetProcAddress(_lib, "rl_s__strlit_r_String");
        if (rl_s__strlit_r_String_ptr == IntPtr.Zero) throw new Exception("Could not find symbol rl_s__strlit_r_String");
        rl_s__strlit_r_String = Marshal.GetDelegateForFunctionPointer<Delegaterl_s__strlit_r_String>(rl_s__strlit_r_String_ptr);
        IntPtr rl_append_to_string__strlit_String_ptr = GetProcAddress(_lib, "rl_append_to_string__strlit_String");
        if (rl_append_to_string__strlit_String_ptr == IntPtr.Zero) throw new Exception("Could not find symbol rl_append_to_string__strlit_String");
        rl_append_to_string__strlit_String = Marshal.GetDelegateForFunctionPointer<Delegaterl_append_to_string__strlit_String>(rl_append_to_string__strlit_String_ptr);
        IntPtr rl_load_file__String_String_r_bool_ptr = GetProcAddress(_lib, "rl_load_file__String_String_r_bool");
        if (rl_load_file__String_String_r_bool_ptr == IntPtr.Zero) throw new Exception("Could not find symbol rl_load_file__String_String_r_bool");
        rl_load_file__String_String_r_bool = Marshal.GetDelegateForFunctionPointer<Delegaterl_load_file__String_String_r_bool>(rl_load_file__String_String_r_bool_ptr);
        IntPtr rl_append_to_string__int64_t_String_ptr = GetProcAddress(_lib, "rl_append_to_string__int64_t_String");
        if (rl_append_to_string__int64_t_String_ptr == IntPtr.Zero) throw new Exception("Could not find symbol rl_append_to_string__int64_t_String");
        rl_append_to_string__int64_t_String = Marshal.GetDelegateForFunctionPointer<Delegaterl_append_to_string__int64_t_String>(rl_append_to_string__int64_t_String_ptr);
        IntPtr rl_append_to_string__int8_t_String_ptr = GetProcAddress(_lib, "rl_append_to_string__int8_t_String");
        if (rl_append_to_string__int8_t_String_ptr == IntPtr.Zero) throw new Exception("Could not find symbol rl_append_to_string__int8_t_String");
        rl_append_to_string__int8_t_String = Marshal.GetDelegateForFunctionPointer<Delegaterl_append_to_string__int8_t_String>(rl_append_to_string__int8_t_String_ptr);
        IntPtr rl_append_to_string__double_String_ptr = GetProcAddress(_lib, "rl_append_to_string__double_String");
        if (rl_append_to_string__double_String_ptr == IntPtr.Zero) throw new Exception("Could not find symbol rl_append_to_string__double_String");
        rl_append_to_string__double_String = Marshal.GetDelegateForFunctionPointer<Delegaterl_append_to_string__double_String>(rl_append_to_string__double_String_ptr);
        IntPtr rl_append_to_string__String_String_ptr = GetProcAddress(_lib, "rl_append_to_string__String_String");
        if (rl_append_to_string__String_String_ptr == IntPtr.Zero) throw new Exception("Could not find symbol rl_append_to_string__String_String");
        rl_append_to_string__String_String = Marshal.GetDelegateForFunctionPointer<Delegaterl_append_to_string__String_String>(rl_append_to_string__String_String_ptr);
        IntPtr rl_append_to_string__bool_String_ptr = GetProcAddress(_lib, "rl_append_to_string__bool_String");
        if (rl_append_to_string__bool_String_ptr == IntPtr.Zero) throw new Exception("Could not find symbol rl_append_to_string__bool_String");
        rl_append_to_string__bool_String = Marshal.GetDelegateForFunctionPointer<Delegaterl_append_to_string__bool_String>(rl_append_to_string__bool_String_ptr);
        IntPtr rl_append_to_string__BIntT0T3T_9_String_ptr = GetProcAddress(_lib, "rl_append_to_string__BIntT0T3T_9_String");
        if (rl_append_to_string__BIntT0T3T_9_String_ptr == IntPtr.Zero) throw new Exception("Could not find symbol rl_append_to_string__BIntT0T3T_9_String");
        rl_append_to_string__BIntT0T3T_9_String = Marshal.GetDelegateForFunctionPointer<Delegaterl_append_to_string__BIntT0T3T_9_String>(rl_append_to_string__BIntT0T3T_9_String_ptr);
        IntPtr rl_to_string__AnyGameAction_r_String_ptr = GetProcAddress(_lib, "rl_to_string__AnyGameAction_r_String");
        if (rl_to_string__AnyGameAction_r_String_ptr == IntPtr.Zero) throw new Exception("Could not find symbol rl_to_string__AnyGameAction_r_String");
        rl_to_string__AnyGameAction_r_String = Marshal.GetDelegateForFunctionPointer<Delegaterl_to_string__AnyGameAction_r_String>(rl_to_string__AnyGameAction_r_String_ptr);
        IntPtr rl_to_string__Game_r_String_ptr = GetProcAddress(_lib, "rl_to_string__Game_r_String");
        if (rl_to_string__Game_r_String_ptr == IntPtr.Zero) throw new Exception("Could not find symbol rl_to_string__Game_r_String");
        rl_to_string__Game_r_String = Marshal.GetDelegateForFunctionPointer<Delegaterl_to_string__Game_r_String>(rl_to_string__Game_r_String_ptr);
        IntPtr rl_is_space__int8_t_r_bool_ptr = GetProcAddress(_lib, "rl_is_space__int8_t_r_bool");
        if (rl_is_space__int8_t_r_bool_ptr == IntPtr.Zero) throw new Exception("Could not find symbol rl_is_space__int8_t_r_bool");
        rl_is_space__int8_t_r_bool = Marshal.GetDelegateForFunctionPointer<Delegaterl_is_space__int8_t_r_bool>(rl_is_space__int8_t_r_bool_ptr);
        IntPtr rl_is_alphanumeric__int8_t_r_bool_ptr = GetProcAddress(_lib, "rl_is_alphanumeric__int8_t_r_bool");
        if (rl_is_alphanumeric__int8_t_r_bool_ptr == IntPtr.Zero) throw new Exception("Could not find symbol rl_is_alphanumeric__int8_t_r_bool");
        rl_is_alphanumeric__int8_t_r_bool = Marshal.GetDelegateForFunctionPointer<Delegaterl_is_alphanumeric__int8_t_r_bool>(rl_is_alphanumeric__int8_t_r_bool_ptr);
        IntPtr rl_is_open_paren__int8_t_r_bool_ptr = GetProcAddress(_lib, "rl_is_open_paren__int8_t_r_bool");
        if (rl_is_open_paren__int8_t_r_bool_ptr == IntPtr.Zero) throw new Exception("Could not find symbol rl_is_open_paren__int8_t_r_bool");
        rl_is_open_paren__int8_t_r_bool = Marshal.GetDelegateForFunctionPointer<Delegaterl_is_open_paren__int8_t_r_bool>(rl_is_open_paren__int8_t_r_bool_ptr);
        IntPtr rl_is_close_paren__int8_t_r_bool_ptr = GetProcAddress(_lib, "rl_is_close_paren__int8_t_r_bool");
        if (rl_is_close_paren__int8_t_r_bool_ptr == IntPtr.Zero) throw new Exception("Could not find symbol rl_is_close_paren__int8_t_r_bool");
        rl_is_close_paren__int8_t_r_bool = Marshal.GetDelegateForFunctionPointer<Delegaterl_is_close_paren__int8_t_r_bool>(rl_is_close_paren__int8_t_r_bool_ptr);
        IntPtr rl_parse_string__int64_t_String_int64_t_r_bool_ptr = GetProcAddress(_lib, "rl_parse_string__int64_t_String_int64_t_r_bool");
        if (rl_parse_string__int64_t_String_int64_t_r_bool_ptr == IntPtr.Zero) throw new Exception("Could not find symbol rl_parse_string__int64_t_String_int64_t_r_bool");
        rl_parse_string__int64_t_String_int64_t_r_bool = Marshal.GetDelegateForFunctionPointer<Delegaterl_parse_string__int64_t_String_int64_t_r_bool>(rl_parse_string__int64_t_String_int64_t_r_bool_ptr);
        IntPtr rl_parse_string__int8_t_String_int64_t_r_bool_ptr = GetProcAddress(_lib, "rl_parse_string__int8_t_String_int64_t_r_bool");
        if (rl_parse_string__int8_t_String_int64_t_r_bool_ptr == IntPtr.Zero) throw new Exception("Could not find symbol rl_parse_string__int8_t_String_int64_t_r_bool");
        rl_parse_string__int8_t_String_int64_t_r_bool = Marshal.GetDelegateForFunctionPointer<Delegaterl_parse_string__int8_t_String_int64_t_r_bool>(rl_parse_string__int8_t_String_int64_t_r_bool_ptr);
        IntPtr rl_parse_string__double_String_int64_t_r_bool_ptr = GetProcAddress(_lib, "rl_parse_string__double_String_int64_t_r_bool");
        if (rl_parse_string__double_String_int64_t_r_bool_ptr == IntPtr.Zero) throw new Exception("Could not find symbol rl_parse_string__double_String_int64_t_r_bool");
        rl_parse_string__double_String_int64_t_r_bool = Marshal.GetDelegateForFunctionPointer<Delegaterl_parse_string__double_String_int64_t_r_bool>(rl_parse_string__double_String_int64_t_r_bool_ptr);
        IntPtr rl_length__strlit_r_int64_t_ptr = GetProcAddress(_lib, "rl_length__strlit_r_int64_t");
        if (rl_length__strlit_r_int64_t_ptr == IntPtr.Zero) throw new Exception("Could not find symbol rl_length__strlit_r_int64_t");
        rl_length__strlit_r_int64_t = Marshal.GetDelegateForFunctionPointer<Delegaterl_length__strlit_r_int64_t>(rl_length__strlit_r_int64_t_ptr);
        IntPtr rl_parse_string__String_String_int64_t_r_bool_ptr = GetProcAddress(_lib, "rl_parse_string__String_String_int64_t_r_bool");
        if (rl_parse_string__String_String_int64_t_r_bool_ptr == IntPtr.Zero) throw new Exception("Could not find symbol rl_parse_string__String_String_int64_t_r_bool");
        rl_parse_string__String_String_int64_t_r_bool = Marshal.GetDelegateForFunctionPointer<Delegaterl_parse_string__String_String_int64_t_r_bool>(rl_parse_string__String_String_int64_t_r_bool_ptr);
        IntPtr rl_parse_string__bool_String_int64_t_r_bool_ptr = GetProcAddress(_lib, "rl_parse_string__bool_String_int64_t_r_bool");
        if (rl_parse_string__bool_String_int64_t_r_bool_ptr == IntPtr.Zero) throw new Exception("Could not find symbol rl_parse_string__bool_String_int64_t_r_bool");
        rl_parse_string__bool_String_int64_t_r_bool = Marshal.GetDelegateForFunctionPointer<Delegaterl_parse_string__bool_String_int64_t_r_bool>(rl_parse_string__bool_String_int64_t_r_bool_ptr);
        IntPtr rl_parse_string__BIntT0T3T_9_String_int64_t_r_bool_ptr = GetProcAddress(_lib, "rl_parse_string__BIntT0T3T_9_String_int64_t_r_bool");
        if (rl_parse_string__BIntT0T3T_9_String_int64_t_r_bool_ptr == IntPtr.Zero) throw new Exception("Could not find symbol rl_parse_string__BIntT0T3T_9_String_int64_t_r_bool");
        rl_parse_string__BIntT0T3T_9_String_int64_t_r_bool = Marshal.GetDelegateForFunctionPointer<Delegaterl_parse_string__BIntT0T3T_9_String_int64_t_r_bool>(rl_parse_string__BIntT0T3T_9_String_int64_t_r_bool_ptr);
        IntPtr rl_from_string__AnyGameAction_String_r_bool_ptr = GetProcAddress(_lib, "rl_from_string__AnyGameAction_String_r_bool");
        if (rl_from_string__AnyGameAction_String_r_bool_ptr == IntPtr.Zero) throw new Exception("Could not find symbol rl_from_string__AnyGameAction_String_r_bool");
        rl_from_string__AnyGameAction_String_r_bool = Marshal.GetDelegateForFunctionPointer<Delegaterl_from_string__AnyGameAction_String_r_bool>(rl_from_string__AnyGameAction_String_r_bool_ptr);
        IntPtr rl_from_string__Game_String_r_bool_ptr = GetProcAddress(_lib, "rl_from_string__Game_String_r_bool");
        if (rl_from_string__Game_String_r_bool_ptr == IntPtr.Zero) throw new Exception("Could not find symbol rl_from_string__Game_String_r_bool");
        rl_from_string__Game_String_r_bool = Marshal.GetDelegateForFunctionPointer<Delegaterl_from_string__Game_String_r_bool>(rl_from_string__Game_String_r_bool_ptr);
        IntPtr rl_from_string__AnyGameAction_String_int64_t_r_bool_ptr = GetProcAddress(_lib, "rl_from_string__AnyGameAction_String_int64_t_r_bool");
        if (rl_from_string__AnyGameAction_String_int64_t_r_bool_ptr == IntPtr.Zero) throw new Exception("Could not find symbol rl_from_string__AnyGameAction_String_int64_t_r_bool");
        rl_from_string__AnyGameAction_String_int64_t_r_bool = Marshal.GetDelegateForFunctionPointer<Delegaterl_from_string__AnyGameAction_String_int64_t_r_bool>(rl_from_string__AnyGameAction_String_int64_t_r_bool_ptr);
        IntPtr rl_m_init__BIntT0T3T_ptr = GetProcAddress(_lib, "rl_m_init__BIntT0T3T");
        if (rl_m_init__BIntT0T3T_ptr == IntPtr.Zero) throw new Exception("Could not find symbol rl_m_init__BIntT0T3T");
        rl_m_init__BIntT0T3T = Marshal.GetDelegateForFunctionPointer<Delegaterl_m_init__BIntT0T3T>(rl_m_init__BIntT0T3T_ptr);
        IntPtr rl_append_to_vector__BIntT0T3T_VectorTint8_tT_ptr = GetProcAddress(_lib, "rl_append_to_vector__BIntT0T3T_VectorTint8_tT");
        if (rl_append_to_vector__BIntT0T3T_VectorTint8_tT_ptr == IntPtr.Zero) throw new Exception("Could not find symbol rl_append_to_vector__BIntT0T3T_VectorTint8_tT");
        rl_append_to_vector__BIntT0T3T_VectorTint8_tT = Marshal.GetDelegateForFunctionPointer<Delegaterl_append_to_vector__BIntT0T3T_VectorTint8_tT>(rl_append_to_vector__BIntT0T3T_VectorTint8_tT_ptr);
        IntPtr rl_parse_from_vector__BIntT0T3T_VectorTint8_tT_int64_t_r_bool_ptr = GetProcAddress(_lib, "rl_parse_from_vector__BIntT0T3T_VectorTint8_tT_int64_t_r_bool");
        if (rl_parse_from_vector__BIntT0T3T_VectorTint8_tT_int64_t_r_bool_ptr == IntPtr.Zero) throw new Exception("Could not find symbol rl_parse_from_vector__BIntT0T3T_VectorTint8_tT_int64_t_r_bool");
        rl_parse_from_vector__BIntT0T3T_VectorTint8_tT_int64_t_r_bool = Marshal.GetDelegateForFunctionPointer<Delegaterl_parse_from_vector__BIntT0T3T_VectorTint8_tT_int64_t_r_bool>(rl_parse_from_vector__BIntT0T3T_VectorTint8_tT_int64_t_r_bool_ptr);
        IntPtr rl_append_to_string__BIntT0T3T_String_ptr = GetProcAddress(_lib, "rl_append_to_string__BIntT0T3T_String");
        if (rl_append_to_string__BIntT0T3T_String_ptr == IntPtr.Zero) throw new Exception("Could not find symbol rl_append_to_string__BIntT0T3T_String");
        rl_append_to_string__BIntT0T3T_String = Marshal.GetDelegateForFunctionPointer<Delegaterl_append_to_string__BIntT0T3T_String>(rl_append_to_string__BIntT0T3T_String_ptr);
        IntPtr rl_parse_string__BIntT0T3T_String_int64_t_r_bool_ptr = GetProcAddress(_lib, "rl_parse_string__BIntT0T3T_String_int64_t_r_bool");
        if (rl_parse_string__BIntT0T3T_String_int64_t_r_bool_ptr == IntPtr.Zero) throw new Exception("Could not find symbol rl_parse_string__BIntT0T3T_String_int64_t_r_bool");
        rl_parse_string__BIntT0T3T_String_int64_t_r_bool = Marshal.GetDelegateForFunctionPointer<Delegaterl_parse_string__BIntT0T3T_String_int64_t_r_bool>(rl_parse_string__BIntT0T3T_String_int64_t_r_bool_ptr);
        IntPtr rl_enumerate__BIntT0T3T_VectorTBIntT0T3TT_ptr = GetProcAddress(_lib, "rl_enumerate__BIntT0T3T_VectorTBIntT0T3TT");
        if (rl_enumerate__BIntT0T3T_VectorTBIntT0T3TT_ptr == IntPtr.Zero) throw new Exception("Could not find symbol rl_enumerate__BIntT0T3T_VectorTBIntT0T3TT");
        rl_enumerate__BIntT0T3T_VectorTBIntT0T3TT = Marshal.GetDelegateForFunctionPointer<Delegaterl_enumerate__BIntT0T3T_VectorTBIntT0T3TT>(rl_enumerate__BIntT0T3T_VectorTBIntT0T3TT_ptr);
        IntPtr rl_max__int64_t_int64_t_r_int64_t_ptr = GetProcAddress(_lib, "rl_max__int64_t_int64_t_r_int64_t");
        if (rl_max__int64_t_int64_t_r_int64_t_ptr == IntPtr.Zero) throw new Exception("Could not find symbol rl_max__int64_t_int64_t_r_int64_t");
        rl_max__int64_t_int64_t_r_int64_t = Marshal.GetDelegateForFunctionPointer<Delegaterl_max__int64_t_int64_t_r_int64_t>(rl_max__int64_t_int64_t_r_int64_t_ptr);
        IntPtr rl_min__int64_t_int64_t_r_int64_t_ptr = GetProcAddress(_lib, "rl_min__int64_t_int64_t_r_int64_t");
        if (rl_min__int64_t_int64_t_r_int64_t_ptr == IntPtr.Zero) throw new Exception("Could not find symbol rl_min__int64_t_int64_t_r_int64_t");
        rl_min__int64_t_int64_t_r_int64_t = Marshal.GetDelegateForFunctionPointer<Delegaterl_min__int64_t_int64_t_r_int64_t>(rl_min__int64_t_int64_t_r_int64_t_ptr);
        IntPtr rl_sqrt__double_r_double_ptr = GetProcAddress(_lib, "rl_sqrt__double_r_double");
        if (rl_sqrt__double_r_double_ptr == IntPtr.Zero) throw new Exception("Could not find symbol rl_sqrt__double_r_double");
        rl_sqrt__double_r_double = Marshal.GetDelegateForFunctionPointer<Delegaterl_sqrt__double_r_double>(rl_sqrt__double_r_double_ptr);
        IntPtr rl_abs__int64_t_r_int64_t_ptr = GetProcAddress(_lib, "rl_abs__int64_t_r_int64_t");
        if (rl_abs__int64_t_r_int64_t_ptr == IntPtr.Zero) throw new Exception("Could not find symbol rl_abs__int64_t_r_int64_t");
        rl_abs__int64_t_r_int64_t = Marshal.GetDelegateForFunctionPointer<Delegaterl_abs__int64_t_r_int64_t>(rl_abs__int64_t_r_int64_t_ptr);
        IntPtr rl_custom_equal__int64_t_int64_t_r_bool_ptr = GetProcAddress(_lib, "rl_custom_equal__int64_t_int64_t_r_bool");
        if (rl_custom_equal__int64_t_int64_t_r_bool_ptr == IntPtr.Zero) throw new Exception("Could not find symbol rl_custom_equal__int64_t_int64_t_r_bool");
        rl_custom_equal__int64_t_int64_t_r_bool = Marshal.GetDelegateForFunctionPointer<Delegaterl_custom_equal__int64_t_int64_t_r_bool>(rl_custom_equal__int64_t_int64_t_r_bool_ptr);
        IntPtr rl_custom_equal__bool_bool_r_bool_ptr = GetProcAddress(_lib, "rl_custom_equal__bool_bool_r_bool");
        if (rl_custom_equal__bool_bool_r_bool_ptr == IntPtr.Zero) throw new Exception("Could not find symbol rl_custom_equal__bool_bool_r_bool");
        rl_custom_equal__bool_bool_r_bool = Marshal.GetDelegateForFunctionPointer<Delegaterl_custom_equal__bool_bool_r_bool>(rl_custom_equal__bool_bool_r_bool_ptr);
        IntPtr rl_custom_equal__int8_t_int8_t_r_bool_ptr = GetProcAddress(_lib, "rl_custom_equal__int8_t_int8_t_r_bool");
        if (rl_custom_equal__int8_t_int8_t_r_bool_ptr == IntPtr.Zero) throw new Exception("Could not find symbol rl_custom_equal__int8_t_int8_t_r_bool");
        rl_custom_equal__int8_t_int8_t_r_bool = Marshal.GetDelegateForFunctionPointer<Delegaterl_custom_equal__int8_t_int8_t_r_bool>(rl_custom_equal__int8_t_int8_t_r_bool_ptr);
        IntPtr rl_custom_equal__double_double_r_bool_ptr = GetProcAddress(_lib, "rl_custom_equal__double_double_r_bool");
        if (rl_custom_equal__double_double_r_bool_ptr == IntPtr.Zero) throw new Exception("Could not find symbol rl_custom_equal__double_double_r_bool");
        rl_custom_equal__double_double_r_bool = Marshal.GetDelegateForFunctionPointer<Delegaterl_custom_equal__double_double_r_bool>(rl_custom_equal__double_double_r_bool_ptr);
        IntPtr rl_equal__AnyGameAction_AnyGameAction_r_bool_ptr = GetProcAddress(_lib, "rl_equal__AnyGameAction_AnyGameAction_r_bool");
        if (rl_equal__AnyGameAction_AnyGameAction_r_bool_ptr == IntPtr.Zero) throw new Exception("Could not find symbol rl_equal__AnyGameAction_AnyGameAction_r_bool");
        rl_equal__AnyGameAction_AnyGameAction_r_bool = Marshal.GetDelegateForFunctionPointer<Delegaterl_equal__AnyGameAction_AnyGameAction_r_bool>(rl_equal__AnyGameAction_AnyGameAction_r_bool_ptr);
        IntPtr rl_equal__GameMark_GameMark_r_bool_ptr = GetProcAddress(_lib, "rl_equal__GameMark_GameMark_r_bool");
        if (rl_equal__GameMark_GameMark_r_bool_ptr == IntPtr.Zero) throw new Exception("Could not find symbol rl_equal__GameMark_GameMark_r_bool");
        rl_equal__GameMark_GameMark_r_bool = Marshal.GetDelegateForFunctionPointer<Delegaterl_equal__GameMark_GameMark_r_bool>(rl_equal__GameMark_GameMark_r_bool_ptr);
        IntPtr rl_equal__BIntT0T3T_BIntT0T3T_r_bool_ptr = GetProcAddress(_lib, "rl_equal__BIntT0T3T_BIntT0T3T_r_bool");
        if (rl_equal__BIntT0T3T_BIntT0T3T_r_bool_ptr == IntPtr.Zero) throw new Exception("Could not find symbol rl_equal__BIntT0T3T_BIntT0T3T_r_bool");
        rl_equal__BIntT0T3T_BIntT0T3T_r_bool = Marshal.GetDelegateForFunctionPointer<Delegaterl_equal__BIntT0T3T_BIntT0T3T_r_bool>(rl_equal__BIntT0T3T_BIntT0T3T_r_bool_ptr);
        IntPtr rl_equal__int64_t_int64_t_r_bool_ptr = GetProcAddress(_lib, "rl_equal__int64_t_int64_t_r_bool");
        if (rl_equal__int64_t_int64_t_r_bool_ptr == IntPtr.Zero) throw new Exception("Could not find symbol rl_equal__int64_t_int64_t_r_bool");
        rl_equal__int64_t_int64_t_r_bool = Marshal.GetDelegateForFunctionPointer<Delegaterl_equal__int64_t_int64_t_r_bool>(rl_equal__int64_t_int64_t_r_bool_ptr);
        IntPtr rl_can_apply_impl__AnyGameAction_Game_r_bool_ptr = GetProcAddress(_lib, "rl_can_apply_impl__AnyGameAction_Game_r_bool");
        if (rl_can_apply_impl__AnyGameAction_Game_r_bool_ptr == IntPtr.Zero) throw new Exception("Could not find symbol rl_can_apply_impl__AnyGameAction_Game_r_bool");
        rl_can_apply_impl__AnyGameAction_Game_r_bool = Marshal.GetDelegateForFunctionPointer<Delegaterl_can_apply_impl__AnyGameAction_Game_r_bool>(rl_can_apply_impl__AnyGameAction_Game_r_bool_ptr);
        IntPtr rl_apply__AnyGameAction_Game_ptr = GetProcAddress(_lib, "rl_apply__AnyGameAction_Game");
        if (rl_apply__AnyGameAction_Game_ptr == IntPtr.Zero) throw new Exception("Could not find symbol rl_apply__AnyGameAction_Game");
        rl_apply__AnyGameAction_Game = Marshal.GetDelegateForFunctionPointer<Delegaterl_apply__AnyGameAction_Game>(rl_apply__AnyGameAction_Game_ptr);
        IntPtr rl_can_apply__AnyGameAction_Game_r_bool_ptr = GetProcAddress(_lib, "rl_can_apply__AnyGameAction_Game_r_bool");
        if (rl_can_apply__AnyGameAction_Game_r_bool_ptr == IntPtr.Zero) throw new Exception("Could not find symbol rl_can_apply__AnyGameAction_Game_r_bool");
        rl_can_apply__AnyGameAction_Game_r_bool = Marshal.GetDelegateForFunctionPointer<Delegaterl_can_apply__AnyGameAction_Game_r_bool>(rl_can_apply__AnyGameAction_Game_r_bool_ptr);
        IntPtr rl_apply__VectorTAnyGameActionT_Game_r_bool_ptr = GetProcAddress(_lib, "rl_apply__VectorTAnyGameActionT_Game_r_bool");
        if (rl_apply__VectorTAnyGameActionT_Game_r_bool_ptr == IntPtr.Zero) throw new Exception("Could not find symbol rl_apply__VectorTAnyGameActionT_Game_r_bool");
        rl_apply__VectorTAnyGameActionT_Game_r_bool = Marshal.GetDelegateForFunctionPointer<Delegaterl_apply__VectorTAnyGameActionT_Game_r_bool>(rl_apply__VectorTAnyGameActionT_Game_r_bool_ptr);
        IntPtr rl_parse_actions__AnyGameAction_VectorTint8_tT_int64_t_r_VectorTAnyGameActionT_ptr = GetProcAddress(_lib, "rl_parse_actions__AnyGameAction_VectorTint8_tT_int64_t_r_VectorTAnyGameActionT");
        if (rl_parse_actions__AnyGameAction_VectorTint8_tT_int64_t_r_VectorTAnyGameActionT_ptr == IntPtr.Zero) throw new Exception("Could not find symbol rl_parse_actions__AnyGameAction_VectorTint8_tT_int64_t_r_VectorTAnyGameActionT");
        rl_parse_actions__AnyGameAction_VectorTint8_tT_int64_t_r_VectorTAnyGameActionT = Marshal.GetDelegateForFunctionPointer<Delegaterl_parse_actions__AnyGameAction_VectorTint8_tT_int64_t_r_VectorTAnyGameActionT>(rl_parse_actions__AnyGameAction_VectorTint8_tT_int64_t_r_VectorTAnyGameActionT_ptr);
        IntPtr rl_parse_actions__AnyGameAction_String_r_VectorTAnyGameActionT_ptr = GetProcAddress(_lib, "rl_parse_actions__AnyGameAction_String_r_VectorTAnyGameActionT");
        if (rl_parse_actions__AnyGameAction_String_r_VectorTAnyGameActionT_ptr == IntPtr.Zero) throw new Exception("Could not find symbol rl_parse_actions__AnyGameAction_String_r_VectorTAnyGameActionT");
        rl_parse_actions__AnyGameAction_String_r_VectorTAnyGameActionT = Marshal.GetDelegateForFunctionPointer<Delegaterl_parse_actions__AnyGameAction_String_r_VectorTAnyGameActionT>(rl_parse_actions__AnyGameAction_String_r_VectorTAnyGameActionT_ptr);
        IntPtr rl_parse_action_optimized__AnyGameAction_VectorTint8_tT_int64_t_r_bool_ptr = GetProcAddress(_lib, "rl_parse_action_optimized__AnyGameAction_VectorTint8_tT_int64_t_r_bool");
        if (rl_parse_action_optimized__AnyGameAction_VectorTint8_tT_int64_t_r_bool_ptr == IntPtr.Zero) throw new Exception("Could not find symbol rl_parse_action_optimized__AnyGameAction_VectorTint8_tT_int64_t_r_bool");
        rl_parse_action_optimized__AnyGameAction_VectorTint8_tT_int64_t_r_bool = Marshal.GetDelegateForFunctionPointer<Delegaterl_parse_action_optimized__AnyGameAction_VectorTint8_tT_int64_t_r_bool>(rl_parse_action_optimized__AnyGameAction_VectorTint8_tT_int64_t_r_bool_ptr);
        IntPtr rl_parse_actions__AnyGameAction_VectorTint8_tT_r_VectorTAnyGameActionT_ptr = GetProcAddress(_lib, "rl_parse_actions__AnyGameAction_VectorTint8_tT_r_VectorTAnyGameActionT");
        if (rl_parse_actions__AnyGameAction_VectorTint8_tT_r_VectorTAnyGameActionT_ptr == IntPtr.Zero) throw new Exception("Could not find symbol rl_parse_actions__AnyGameAction_VectorTint8_tT_r_VectorTAnyGameActionT");
        rl_parse_actions__AnyGameAction_VectorTint8_tT_r_VectorTAnyGameActionT = Marshal.GetDelegateForFunctionPointer<Delegaterl_parse_actions__AnyGameAction_VectorTint8_tT_r_VectorTAnyGameActionT>(rl_parse_actions__AnyGameAction_VectorTint8_tT_r_VectorTAnyGameActionT_ptr);
        IntPtr rl_make_valid_actions_vector__VectorTAnyGameActionT_Game_r_VectorTint8_tT_ptr = GetProcAddress(_lib, "rl_make_valid_actions_vector__VectorTAnyGameActionT_Game_r_VectorTint8_tT");
        if (rl_make_valid_actions_vector__VectorTAnyGameActionT_Game_r_VectorTint8_tT_ptr == IntPtr.Zero) throw new Exception("Could not find symbol rl_make_valid_actions_vector__VectorTAnyGameActionT_Game_r_VectorTint8_tT");
        rl_make_valid_actions_vector__VectorTAnyGameActionT_Game_r_VectorTint8_tT = Marshal.GetDelegateForFunctionPointer<Delegaterl_make_valid_actions_vector__VectorTAnyGameActionT_Game_r_VectorTint8_tT>(rl_make_valid_actions_vector__VectorTAnyGameActionT_Game_r_VectorTint8_tT_ptr);
        IntPtr rl_get_valid_actions__VectorTint8_tT_VectorTAnyGameActionT_Game_ptr = GetProcAddress(_lib, "rl_get_valid_actions__VectorTint8_tT_VectorTAnyGameActionT_Game");
        if (rl_get_valid_actions__VectorTint8_tT_VectorTAnyGameActionT_Game_ptr == IntPtr.Zero) throw new Exception("Could not find symbol rl_get_valid_actions__VectorTint8_tT_VectorTAnyGameActionT_Game");
        rl_get_valid_actions__VectorTint8_tT_VectorTAnyGameActionT_Game = Marshal.GetDelegateForFunctionPointer<Delegaterl_get_valid_actions__VectorTint8_tT_VectorTAnyGameActionT_Game>(rl_get_valid_actions__VectorTint8_tT_VectorTAnyGameActionT_Game_ptr);
        IntPtr rl_gen_python_methods__Game_AnyGameAction_ptr = GetProcAddress(_lib, "rl_gen_python_methods__Game_AnyGameAction");
        if (rl_gen_python_methods__Game_AnyGameAction_ptr == IntPtr.Zero) throw new Exception("Could not find symbol rl_gen_python_methods__Game_AnyGameAction");
        rl_gen_python_methods__Game_AnyGameAction = Marshal.GetDelegateForFunctionPointer<Delegaterl_gen_python_methods__Game_AnyGameAction>(rl_gen_python_methods__Game_AnyGameAction_ptr);
        IntPtr rl_load_action_vector_file__String_VectorTAnyGameActionT_r_bool_ptr = GetProcAddress(_lib, "rl_load_action_vector_file__String_VectorTAnyGameActionT_r_bool");
        if (rl_load_action_vector_file__String_VectorTAnyGameActionT_r_bool_ptr == IntPtr.Zero) throw new Exception("Could not find symbol rl_load_action_vector_file__String_VectorTAnyGameActionT_r_bool");
        rl_load_action_vector_file__String_VectorTAnyGameActionT_r_bool = Marshal.GetDelegateForFunctionPointer<Delegaterl_load_action_vector_file__String_VectorTAnyGameActionT_r_bool>(rl_load_action_vector_file__String_VectorTAnyGameActionT_r_bool_ptr);
        IntPtr rl_enumerate__bool_VectorTboolT_ptr = GetProcAddress(_lib, "rl_enumerate__bool_VectorTboolT");
        if (rl_enumerate__bool_VectorTboolT_ptr == IntPtr.Zero) throw new Exception("Could not find symbol rl_enumerate__bool_VectorTboolT");
        rl_enumerate__bool_VectorTboolT = Marshal.GetDelegateForFunctionPointer<Delegaterl_enumerate__bool_VectorTboolT>(rl_enumerate__bool_VectorTboolT_ptr);
        IntPtr rl_enumeration_error__int64_t_String_VectorTStringT_ptr = GetProcAddress(_lib, "rl_enumeration_error__int64_t_String_VectorTStringT");
        if (rl_enumeration_error__int64_t_String_VectorTStringT_ptr == IntPtr.Zero) throw new Exception("Could not find symbol rl_enumeration_error__int64_t_String_VectorTStringT");
        rl_enumeration_error__int64_t_String_VectorTStringT = Marshal.GetDelegateForFunctionPointer<Delegaterl_enumeration_error__int64_t_String_VectorTStringT>(rl_enumeration_error__int64_t_String_VectorTStringT_ptr);
        IntPtr rl_enumeration_error__double_String_VectorTStringT_ptr = GetProcAddress(_lib, "rl_enumeration_error__double_String_VectorTStringT");
        if (rl_enumeration_error__double_String_VectorTStringT_ptr == IntPtr.Zero) throw new Exception("Could not find symbol rl_enumeration_error__double_String_VectorTStringT");
        rl_enumeration_error__double_String_VectorTStringT = Marshal.GetDelegateForFunctionPointer<Delegaterl_enumeration_error__double_String_VectorTStringT>(rl_enumeration_error__double_String_VectorTStringT_ptr);
        IntPtr rl_get_enumeration_errors_impl__AnyGameAction_String_VectorTStringT_ptr = GetProcAddress(_lib, "rl_get_enumeration_errors_impl__AnyGameAction_String_VectorTStringT");
        if (rl_get_enumeration_errors_impl__AnyGameAction_String_VectorTStringT_ptr == IntPtr.Zero) throw new Exception("Could not find symbol rl_get_enumeration_errors_impl__AnyGameAction_String_VectorTStringT");
        rl_get_enumeration_errors_impl__AnyGameAction_String_VectorTStringT = Marshal.GetDelegateForFunctionPointer<Delegaterl_get_enumeration_errors_impl__AnyGameAction_String_VectorTStringT>(rl_get_enumeration_errors_impl__AnyGameAction_String_VectorTStringT_ptr);
        IntPtr rl_get_enumeration_errors_impl__GameMark_String_VectorTStringT_ptr = GetProcAddress(_lib, "rl_get_enumeration_errors_impl__GameMark_String_VectorTStringT");
        if (rl_get_enumeration_errors_impl__GameMark_String_VectorTStringT_ptr == IntPtr.Zero) throw new Exception("Could not find symbol rl_get_enumeration_errors_impl__GameMark_String_VectorTStringT");
        rl_get_enumeration_errors_impl__GameMark_String_VectorTStringT = Marshal.GetDelegateForFunctionPointer<Delegaterl_get_enumeration_errors_impl__GameMark_String_VectorTStringT>(rl_get_enumeration_errors_impl__GameMark_String_VectorTStringT_ptr);
        IntPtr rl_get_enumeration_errors_impl__BIntT0T3T_String_VectorTStringT_ptr = GetProcAddress(_lib, "rl_get_enumeration_errors_impl__BIntT0T3T_String_VectorTStringT");
        if (rl_get_enumeration_errors_impl__BIntT0T3T_String_VectorTStringT_ptr == IntPtr.Zero) throw new Exception("Could not find symbol rl_get_enumeration_errors_impl__BIntT0T3T_String_VectorTStringT");
        rl_get_enumeration_errors_impl__BIntT0T3T_String_VectorTStringT = Marshal.GetDelegateForFunctionPointer<Delegaterl_get_enumeration_errors_impl__BIntT0T3T_String_VectorTStringT>(rl_get_enumeration_errors_impl__BIntT0T3T_String_VectorTStringT_ptr);
        IntPtr rl_get_enumeration_errors_impl__int64_t_String_VectorTStringT_ptr = GetProcAddress(_lib, "rl_get_enumeration_errors_impl__int64_t_String_VectorTStringT");
        if (rl_get_enumeration_errors_impl__int64_t_String_VectorTStringT_ptr == IntPtr.Zero) throw new Exception("Could not find symbol rl_get_enumeration_errors_impl__int64_t_String_VectorTStringT");
        rl_get_enumeration_errors_impl__int64_t_String_VectorTStringT = Marshal.GetDelegateForFunctionPointer<Delegaterl_get_enumeration_errors_impl__int64_t_String_VectorTStringT>(rl_get_enumeration_errors_impl__int64_t_String_VectorTStringT_ptr);
        IntPtr rl_get_enumeration_errors__AnyGameAction_r_String_ptr = GetProcAddress(_lib, "rl_get_enumeration_errors__AnyGameAction_r_String");
        if (rl_get_enumeration_errors__AnyGameAction_r_String_ptr == IntPtr.Zero) throw new Exception("Could not find symbol rl_get_enumeration_errors__AnyGameAction_r_String");
        rl_get_enumeration_errors__AnyGameAction_r_String = Marshal.GetDelegateForFunctionPointer<Delegaterl_get_enumeration_errors__AnyGameAction_r_String>(rl_get_enumeration_errors__AnyGameAction_r_String_ptr);
        IntPtr rl_print_enumeration_errors__AnyGameAction_r_bool_ptr = GetProcAddress(_lib, "rl_print_enumeration_errors__AnyGameAction_r_bool");
        if (rl_print_enumeration_errors__AnyGameAction_r_bool_ptr == IntPtr.Zero) throw new Exception("Could not find symbol rl_print_enumeration_errors__AnyGameAction_r_bool");
        rl_print_enumeration_errors__AnyGameAction_r_bool = Marshal.GetDelegateForFunctionPointer<Delegaterl_print_enumeration_errors__AnyGameAction_r_bool>(rl_print_enumeration_errors__AnyGameAction_r_bool_ptr);
        IntPtr rl_enumerate__AnyGameAction_r_VectorTAnyGameActionT_ptr = GetProcAddress(_lib, "rl_enumerate__AnyGameAction_r_VectorTAnyGameActionT");
        if (rl_enumerate__AnyGameAction_r_VectorTAnyGameActionT_ptr == IntPtr.Zero) throw new Exception("Could not find symbol rl_enumerate__AnyGameAction_r_VectorTAnyGameActionT");
        rl_enumerate__AnyGameAction_r_VectorTAnyGameActionT = Marshal.GetDelegateForFunctionPointer<Delegaterl_enumerate__AnyGameAction_r_VectorTAnyGameActionT>(rl_enumerate__AnyGameAction_r_VectorTAnyGameActionT_ptr);
        IntPtr rl_enumerate__GameMark_r_VectorTGameMarkT_ptr = GetProcAddress(_lib, "rl_enumerate__GameMark_r_VectorTGameMarkT");
        if (rl_enumerate__GameMark_r_VectorTGameMarkT_ptr == IntPtr.Zero) throw new Exception("Could not find symbol rl_enumerate__GameMark_r_VectorTGameMarkT");
        rl_enumerate__GameMark_r_VectorTGameMarkT = Marshal.GetDelegateForFunctionPointer<Delegaterl_enumerate__GameMark_r_VectorTGameMarkT>(rl_enumerate__GameMark_r_VectorTGameMarkT_ptr);
        IntPtr rl_enumerate__BIntT0T3T_r_VectorTBIntT0T3TT_ptr = GetProcAddress(_lib, "rl_enumerate__BIntT0T3T_r_VectorTBIntT0T3TT");
        if (rl_enumerate__BIntT0T3T_r_VectorTBIntT0T3TT_ptr == IntPtr.Zero) throw new Exception("Could not find symbol rl_enumerate__BIntT0T3T_r_VectorTBIntT0T3TT");
        rl_enumerate__BIntT0T3T_r_VectorTBIntT0T3TT = Marshal.GetDelegateForFunctionPointer<Delegaterl_enumerate__BIntT0T3T_r_VectorTBIntT0T3TT>(rl_enumerate__BIntT0T3T_r_VectorTBIntT0T3TT_ptr);
        IntPtr rl_write_in_observation_tensor__int64_t_int64_t_int64_t_VectorTdoubleT_int64_t_ptr = GetProcAddress(_lib, "rl_write_in_observation_tensor__int64_t_int64_t_int64_t_VectorTdoubleT_int64_t");
        if (rl_write_in_observation_tensor__int64_t_int64_t_int64_t_VectorTdoubleT_int64_t_ptr == IntPtr.Zero) throw new Exception("Could not find symbol rl_write_in_observation_tensor__int64_t_int64_t_int64_t_VectorTdoubleT_int64_t");
        rl_write_in_observation_tensor__int64_t_int64_t_int64_t_VectorTdoubleT_int64_t = Marshal.GetDelegateForFunctionPointer<Delegaterl_write_in_observation_tensor__int64_t_int64_t_int64_t_VectorTdoubleT_int64_t>(rl_write_in_observation_tensor__int64_t_int64_t_int64_t_VectorTdoubleT_int64_t_ptr);
        IntPtr rl_write_in_observation_tensor__int64_t_int64_t_VectorTdoubleT_int64_t_ptr = GetProcAddress(_lib, "rl_write_in_observation_tensor__int64_t_int64_t_VectorTdoubleT_int64_t");
        if (rl_write_in_observation_tensor__int64_t_int64_t_VectorTdoubleT_int64_t_ptr == IntPtr.Zero) throw new Exception("Could not find symbol rl_write_in_observation_tensor__int64_t_int64_t_VectorTdoubleT_int64_t");
        rl_write_in_observation_tensor__int64_t_int64_t_VectorTdoubleT_int64_t = Marshal.GetDelegateForFunctionPointer<Delegaterl_write_in_observation_tensor__int64_t_int64_t_VectorTdoubleT_int64_t>(rl_write_in_observation_tensor__int64_t_int64_t_VectorTdoubleT_int64_t_ptr);
        IntPtr rl_size_as_observation_tensor__int64_t_r_int64_t_ptr = GetProcAddress(_lib, "rl_size_as_observation_tensor__int64_t_r_int64_t");
        if (rl_size_as_observation_tensor__int64_t_r_int64_t_ptr == IntPtr.Zero) throw new Exception("Could not find symbol rl_size_as_observation_tensor__int64_t_r_int64_t");
        rl_size_as_observation_tensor__int64_t_r_int64_t = Marshal.GetDelegateForFunctionPointer<Delegaterl_size_as_observation_tensor__int64_t_r_int64_t>(rl_size_as_observation_tensor__int64_t_r_int64_t_ptr);
        IntPtr rl_write_in_observation_tensor__double_int64_t_VectorTdoubleT_int64_t_ptr = GetProcAddress(_lib, "rl_write_in_observation_tensor__double_int64_t_VectorTdoubleT_int64_t");
        if (rl_write_in_observation_tensor__double_int64_t_VectorTdoubleT_int64_t_ptr == IntPtr.Zero) throw new Exception("Could not find symbol rl_write_in_observation_tensor__double_int64_t_VectorTdoubleT_int64_t");
        rl_write_in_observation_tensor__double_int64_t_VectorTdoubleT_int64_t = Marshal.GetDelegateForFunctionPointer<Delegaterl_write_in_observation_tensor__double_int64_t_VectorTdoubleT_int64_t>(rl_write_in_observation_tensor__double_int64_t_VectorTdoubleT_int64_t_ptr);
        IntPtr rl_can_write_in_observation_tensor__double_int64_t_VectorTdoubleT_int64_t_r_bool_ptr = GetProcAddress(_lib, "rl_can_write_in_observation_tensor__double_int64_t_VectorTdoubleT_int64_t_r_bool");
        if (rl_can_write_in_observation_tensor__double_int64_t_VectorTdoubleT_int64_t_r_bool_ptr == IntPtr.Zero) throw new Exception("Could not find symbol rl_can_write_in_observation_tensor__double_int64_t_VectorTdoubleT_int64_t_r_bool");
        rl_can_write_in_observation_tensor__double_int64_t_VectorTdoubleT_int64_t_r_bool = Marshal.GetDelegateForFunctionPointer<Delegaterl_can_write_in_observation_tensor__double_int64_t_VectorTdoubleT_int64_t_r_bool>(rl_can_write_in_observation_tensor__double_int64_t_VectorTdoubleT_int64_t_r_bool_ptr);
        IntPtr rl_size_as_observation_tensor__double_r_int64_t_ptr = GetProcAddress(_lib, "rl_size_as_observation_tensor__double_r_int64_t");
        if (rl_size_as_observation_tensor__double_r_int64_t_ptr == IntPtr.Zero) throw new Exception("Could not find symbol rl_size_as_observation_tensor__double_r_int64_t");
        rl_size_as_observation_tensor__double_r_int64_t = Marshal.GetDelegateForFunctionPointer<Delegaterl_size_as_observation_tensor__double_r_int64_t>(rl_size_as_observation_tensor__double_r_int64_t_ptr);
        IntPtr rl_can_size_as_observation_tensor__double_r_bool_ptr = GetProcAddress(_lib, "rl_can_size_as_observation_tensor__double_r_bool");
        if (rl_can_size_as_observation_tensor__double_r_bool_ptr == IntPtr.Zero) throw new Exception("Could not find symbol rl_can_size_as_observation_tensor__double_r_bool");
        rl_can_size_as_observation_tensor__double_r_bool = Marshal.GetDelegateForFunctionPointer<Delegaterl_can_size_as_observation_tensor__double_r_bool>(rl_can_size_as_observation_tensor__double_r_bool_ptr);
        IntPtr rl_write_in_observation_tensor__bool_int64_t_VectorTdoubleT_int64_t_ptr = GetProcAddress(_lib, "rl_write_in_observation_tensor__bool_int64_t_VectorTdoubleT_int64_t");
        if (rl_write_in_observation_tensor__bool_int64_t_VectorTdoubleT_int64_t_ptr == IntPtr.Zero) throw new Exception("Could not find symbol rl_write_in_observation_tensor__bool_int64_t_VectorTdoubleT_int64_t");
        rl_write_in_observation_tensor__bool_int64_t_VectorTdoubleT_int64_t = Marshal.GetDelegateForFunctionPointer<Delegaterl_write_in_observation_tensor__bool_int64_t_VectorTdoubleT_int64_t>(rl_write_in_observation_tensor__bool_int64_t_VectorTdoubleT_int64_t_ptr);
        IntPtr rl_size_as_observation_tensor__bool_r_int64_t_ptr = GetProcAddress(_lib, "rl_size_as_observation_tensor__bool_r_int64_t");
        if (rl_size_as_observation_tensor__bool_r_int64_t_ptr == IntPtr.Zero) throw new Exception("Could not find symbol rl_size_as_observation_tensor__bool_r_int64_t");
        rl_size_as_observation_tensor__bool_r_int64_t = Marshal.GetDelegateForFunctionPointer<Delegaterl_size_as_observation_tensor__bool_r_int64_t>(rl_size_as_observation_tensor__bool_r_int64_t_ptr);
        IntPtr rl_write_in_observation_tensor__int8_t_int64_t_VectorTdoubleT_int64_t_ptr = GetProcAddress(_lib, "rl_write_in_observation_tensor__int8_t_int64_t_VectorTdoubleT_int64_t");
        if (rl_write_in_observation_tensor__int8_t_int64_t_VectorTdoubleT_int64_t_ptr == IntPtr.Zero) throw new Exception("Could not find symbol rl_write_in_observation_tensor__int8_t_int64_t_VectorTdoubleT_int64_t");
        rl_write_in_observation_tensor__int8_t_int64_t_VectorTdoubleT_int64_t = Marshal.GetDelegateForFunctionPointer<Delegaterl_write_in_observation_tensor__int8_t_int64_t_VectorTdoubleT_int64_t>(rl_write_in_observation_tensor__int8_t_int64_t_VectorTdoubleT_int64_t_ptr);
        IntPtr rl_size_as_observation_tensor__int8_t_r_int64_t_ptr = GetProcAddress(_lib, "rl_size_as_observation_tensor__int8_t_r_int64_t");
        if (rl_size_as_observation_tensor__int8_t_r_int64_t_ptr == IntPtr.Zero) throw new Exception("Could not find symbol rl_size_as_observation_tensor__int8_t_r_int64_t");
        rl_size_as_observation_tensor__int8_t_r_int64_t = Marshal.GetDelegateForFunctionPointer<Delegaterl_size_as_observation_tensor__int8_t_r_int64_t>(rl_size_as_observation_tensor__int8_t_r_int64_t_ptr);
        IntPtr rl_write_in_observation_tensor__BIntT0T3T_9_int64_t_VectorTdoubleT_int64_t_ptr = GetProcAddress(_lib, "rl_write_in_observation_tensor__BIntT0T3T_9_int64_t_VectorTdoubleT_int64_t");
        if (rl_write_in_observation_tensor__BIntT0T3T_9_int64_t_VectorTdoubleT_int64_t_ptr == IntPtr.Zero) throw new Exception("Could not find symbol rl_write_in_observation_tensor__BIntT0T3T_9_int64_t_VectorTdoubleT_int64_t");
        rl_write_in_observation_tensor__BIntT0T3T_9_int64_t_VectorTdoubleT_int64_t = Marshal.GetDelegateForFunctionPointer<Delegaterl_write_in_observation_tensor__BIntT0T3T_9_int64_t_VectorTdoubleT_int64_t>(rl_write_in_observation_tensor__BIntT0T3T_9_int64_t_VectorTdoubleT_int64_t_ptr);
        IntPtr rl_size_as_observation_tensor__BIntT0T3T_9_r_int64_t_ptr = GetProcAddress(_lib, "rl_size_as_observation_tensor__BIntT0T3T_9_r_int64_t");
        if (rl_size_as_observation_tensor__BIntT0T3T_9_r_int64_t_ptr == IntPtr.Zero) throw new Exception("Could not find symbol rl_size_as_observation_tensor__BIntT0T3T_9_r_int64_t");
        rl_size_as_observation_tensor__BIntT0T3T_9_r_int64_t = Marshal.GetDelegateForFunctionPointer<Delegaterl_size_as_observation_tensor__BIntT0T3T_9_r_int64_t>(rl_size_as_observation_tensor__BIntT0T3T_9_r_int64_t_ptr);
        IntPtr rl_write_in_observation_tensor__BIntT0T3T_int64_t_VectorTdoubleT_int64_t_ptr = GetProcAddress(_lib, "rl_write_in_observation_tensor__BIntT0T3T_int64_t_VectorTdoubleT_int64_t");
        if (rl_write_in_observation_tensor__BIntT0T3T_int64_t_VectorTdoubleT_int64_t_ptr == IntPtr.Zero) throw new Exception("Could not find symbol rl_write_in_observation_tensor__BIntT0T3T_int64_t_VectorTdoubleT_int64_t");
        rl_write_in_observation_tensor__BIntT0T3T_int64_t_VectorTdoubleT_int64_t = Marshal.GetDelegateForFunctionPointer<Delegaterl_write_in_observation_tensor__BIntT0T3T_int64_t_VectorTdoubleT_int64_t>(rl_write_in_observation_tensor__BIntT0T3T_int64_t_VectorTdoubleT_int64_t_ptr);
        IntPtr rl_size_as_observation_tensor__BIntT0T3T_r_int64_t_ptr = GetProcAddress(_lib, "rl_size_as_observation_tensor__BIntT0T3T_r_int64_t");
        if (rl_size_as_observation_tensor__BIntT0T3T_r_int64_t_ptr == IntPtr.Zero) throw new Exception("Could not find symbol rl_size_as_observation_tensor__BIntT0T3T_r_int64_t");
        rl_size_as_observation_tensor__BIntT0T3T_r_int64_t = Marshal.GetDelegateForFunctionPointer<Delegaterl_size_as_observation_tensor__BIntT0T3T_r_int64_t>(rl_size_as_observation_tensor__BIntT0T3T_r_int64_t_ptr);
        IntPtr rl_to_observation_tensor__Game_int64_t_VectorTdoubleT_ptr = GetProcAddress(_lib, "rl_to_observation_tensor__Game_int64_t_VectorTdoubleT");
        if (rl_to_observation_tensor__Game_int64_t_VectorTdoubleT_ptr == IntPtr.Zero) throw new Exception("Could not find symbol rl_to_observation_tensor__Game_int64_t_VectorTdoubleT");
        rl_to_observation_tensor__Game_int64_t_VectorTdoubleT = Marshal.GetDelegateForFunctionPointer<Delegaterl_to_observation_tensor__Game_int64_t_VectorTdoubleT>(rl_to_observation_tensor__Game_int64_t_VectorTdoubleT_ptr);
        IntPtr rl_observation_tensor_size__Game_r_int64_t_ptr = GetProcAddress(_lib, "rl_observation_tensor_size__Game_r_int64_t");
        if (rl_observation_tensor_size__Game_r_int64_t_ptr == IntPtr.Zero) throw new Exception("Could not find symbol rl_observation_tensor_size__Game_r_int64_t");
        rl_observation_tensor_size__Game_r_int64_t = Marshal.GetDelegateForFunctionPointer<Delegaterl_observation_tensor_size__Game_r_int64_t>(rl_observation_tensor_size__Game_r_int64_t_ptr);
        IntPtr rl_write_tensor_warning_context__String_VectorTStringT_ptr = GetProcAddress(_lib, "rl_write_tensor_warning_context__String_VectorTStringT");
        if (rl_write_tensor_warning_context__String_VectorTStringT_ptr == IntPtr.Zero) throw new Exception("Could not find symbol rl_write_tensor_warning_context__String_VectorTStringT");
        rl_write_tensor_warning_context__String_VectorTStringT = Marshal.GetDelegateForFunctionPointer<Delegaterl_write_tensor_warning_context__String_VectorTStringT>(rl_write_tensor_warning_context__String_VectorTStringT_ptr);
        IntPtr rl_tensorable_warning__int64_t_String_VectorTStringT_ptr = GetProcAddress(_lib, "rl_tensorable_warning__int64_t_String_VectorTStringT");
        if (rl_tensorable_warning__int64_t_String_VectorTStringT_ptr == IntPtr.Zero) throw new Exception("Could not find symbol rl_tensorable_warning__int64_t_String_VectorTStringT");
        rl_tensorable_warning__int64_t_String_VectorTStringT = Marshal.GetDelegateForFunctionPointer<Delegaterl_tensorable_warning__int64_t_String_VectorTStringT>(rl_tensorable_warning__int64_t_String_VectorTStringT_ptr);
        IntPtr rl_tensorable_warning__double_String_VectorTStringT_ptr = GetProcAddress(_lib, "rl_tensorable_warning__double_String_VectorTStringT");
        if (rl_tensorable_warning__double_String_VectorTStringT_ptr == IntPtr.Zero) throw new Exception("Could not find symbol rl_tensorable_warning__double_String_VectorTStringT");
        rl_tensorable_warning__double_String_VectorTStringT = Marshal.GetDelegateForFunctionPointer<Delegaterl_tensorable_warning__double_String_VectorTStringT>(rl_tensorable_warning__double_String_VectorTStringT_ptr);
        IntPtr rl_tensorable_warning__BIntT0T3T_9_String_VectorTStringT_ptr = GetProcAddress(_lib, "rl_tensorable_warning__BIntT0T3T_9_String_VectorTStringT");
        if (rl_tensorable_warning__BIntT0T3T_9_String_VectorTStringT_ptr == IntPtr.Zero) throw new Exception("Could not find symbol rl_tensorable_warning__BIntT0T3T_9_String_VectorTStringT");
        rl_tensorable_warning__BIntT0T3T_9_String_VectorTStringT = Marshal.GetDelegateForFunctionPointer<Delegaterl_tensorable_warning__BIntT0T3T_9_String_VectorTStringT>(rl_tensorable_warning__BIntT0T3T_9_String_VectorTStringT_ptr);
        IntPtr rl_to_observation_tensor_warnings__Game_r_String_ptr = GetProcAddress(_lib, "rl_to_observation_tensor_warnings__Game_r_String");
        if (rl_to_observation_tensor_warnings__Game_r_String_ptr == IntPtr.Zero) throw new Exception("Could not find symbol rl_to_observation_tensor_warnings__Game_r_String");
        rl_to_observation_tensor_warnings__Game_r_String = Marshal.GetDelegateForFunctionPointer<Delegaterl_to_observation_tensor_warnings__Game_r_String>(rl_to_observation_tensor_warnings__Game_r_String_ptr);
        IntPtr rl_emit_observation_tensor_warnings__Game_ptr = GetProcAddress(_lib, "rl_emit_observation_tensor_warnings__Game");
        if (rl_emit_observation_tensor_warnings__Game_ptr == IntPtr.Zero) throw new Exception("Could not find symbol rl_emit_observation_tensor_warnings__Game");
        rl_emit_observation_tensor_warnings__Game = Marshal.GetDelegateForFunctionPointer<Delegaterl_emit_observation_tensor_warnings__Game>(rl_emit_observation_tensor_warnings__Game_ptr);
        IntPtr rl_gen_printer_parser__ptr = GetProcAddress(_lib, "rl_gen_printer_parser_");
        if (rl_gen_printer_parser__ptr == IntPtr.Zero) throw new Exception("Could not find symbol rl_gen_printer_parser_");
        rl_gen_printer_parser_ = Marshal.GetDelegateForFunctionPointer<Delegaterl_gen_printer_parser_>(rl_gen_printer_parser__ptr);
        IntPtr rl_m_set_size__Range_int64_t_ptr = GetProcAddress(_lib, "rl_m_set_size__Range_int64_t");
        if (rl_m_set_size__Range_int64_t_ptr == IntPtr.Zero) throw new Exception("Could not find symbol rl_m_set_size__Range_int64_t");
        rl_m_set_size__Range_int64_t = Marshal.GetDelegateForFunctionPointer<Delegaterl_m_set_size__Range_int64_t>(rl_m_set_size__Range_int64_t_ptr);
        IntPtr rl_m_size__Range_r_int64_t_ptr = GetProcAddress(_lib, "rl_m_size__Range_r_int64_t");
        if (rl_m_size__Range_r_int64_t_ptr == IntPtr.Zero) throw new Exception("Could not find symbol rl_m_size__Range_r_int64_t");
        rl_m_size__Range_r_int64_t = Marshal.GetDelegateForFunctionPointer<Delegaterl_m_size__Range_r_int64_t>(rl_m_size__Range_r_int64_t_ptr);
        IntPtr rl_m_get__Range_int64_t_r_int64_t_ptr = GetProcAddress(_lib, "rl_m_get__Range_int64_t_r_int64_t");
        if (rl_m_get__Range_int64_t_r_int64_t_ptr == IntPtr.Zero) throw new Exception("Could not find symbol rl_m_get__Range_int64_t_r_int64_t");
        rl_m_get__Range_int64_t_r_int64_t = Marshal.GetDelegateForFunctionPointer<Delegaterl_m_get__Range_int64_t_r_int64_t>(rl_m_get__Range_int64_t_r_int64_t_ptr);
        IntPtr rl_range__int64_t_r_Range_ptr = GetProcAddress(_lib, "rl_range__int64_t_r_Range");
        if (rl_range__int64_t_r_Range_ptr == IntPtr.Zero) throw new Exception("Could not find symbol rl_range__int64_t_r_Range");
        rl_range__int64_t_r_Range = Marshal.GetDelegateForFunctionPointer<Delegaterl_range__int64_t_r_Range>(rl_range__int64_t_r_Range_ptr);
        IntPtr rl_fuzz__VectorTint8_tT_ptr = GetProcAddress(_lib, "rl_fuzz__VectorTint8_tT");
        if (rl_fuzz__VectorTint8_tT_ptr == IntPtr.Zero) throw new Exception("Could not find symbol rl_fuzz__VectorTint8_tT");
        rl_fuzz__VectorTint8_tT = Marshal.GetDelegateForFunctionPointer<Delegaterl_fuzz__VectorTint8_tT>(rl_fuzz__VectorTint8_tT_ptr);
        IntPtr rl_m_next_turn__Board_ptr = GetProcAddress(_lib, "rl_m_next_turn__Board");
        if (rl_m_next_turn__Board_ptr == IntPtr.Zero) throw new Exception("Could not find symbol rl_m_next_turn__Board");
        rl_m_next_turn__Board = Marshal.GetDelegateForFunctionPointer<Delegaterl_m_next_turn__Board>(rl_m_next_turn__Board_ptr);
        IntPtr rl_m_current_player__Board_r_int64_t_ptr = GetProcAddress(_lib, "rl_m_current_player__Board_r_int64_t");
        if (rl_m_current_player__Board_r_int64_t_ptr == IntPtr.Zero) throw new Exception("Could not find symbol rl_m_current_player__Board_r_int64_t");
        rl_m_current_player__Board_r_int64_t = Marshal.GetDelegateForFunctionPointer<Delegaterl_m_current_player__Board_r_int64_t>(rl_m_current_player__Board_r_int64_t_ptr);
        IntPtr rl_m_three_in_a_line_player__Board_int64_t_r_bool_ptr = GetProcAddress(_lib, "rl_m_three_in_a_line_player__Board_int64_t_r_bool");
        if (rl_m_three_in_a_line_player__Board_int64_t_r_bool_ptr == IntPtr.Zero) throw new Exception("Could not find symbol rl_m_three_in_a_line_player__Board_int64_t_r_bool");
        rl_m_three_in_a_line_player__Board_int64_t_r_bool = Marshal.GetDelegateForFunctionPointer<Delegaterl_m_three_in_a_line_player__Board_int64_t_r_bool>(rl_m_three_in_a_line_player__Board_int64_t_r_bool_ptr);
        IntPtr rl_m_three_in_a_line_player_row__Board_int64_t_int64_t_r_bool_ptr = GetProcAddress(_lib, "rl_m_three_in_a_line_player_row__Board_int64_t_int64_t_r_bool");
        if (rl_m_three_in_a_line_player_row__Board_int64_t_int64_t_r_bool_ptr == IntPtr.Zero) throw new Exception("Could not find symbol rl_m_three_in_a_line_player_row__Board_int64_t_int64_t_r_bool");
        rl_m_three_in_a_line_player_row__Board_int64_t_int64_t_r_bool = Marshal.GetDelegateForFunctionPointer<Delegaterl_m_three_in_a_line_player_row__Board_int64_t_int64_t_r_bool>(rl_m_three_in_a_line_player_row__Board_int64_t_int64_t_r_bool_ptr);
        IntPtr rl_m_full__Board_r_bool_ptr = GetProcAddress(_lib, "rl_m_full__Board_r_bool");
        if (rl_m_full__Board_r_bool_ptr == IntPtr.Zero) throw new Exception("Could not find symbol rl_m_full__Board_r_bool");
        rl_m_full__Board_r_bool = Marshal.GetDelegateForFunctionPointer<Delegaterl_m_full__Board_r_bool>(rl_m_full__Board_r_bool_ptr);
        IntPtr rl_m_set__Board_int64_t_int64_t_int64_t_ptr = GetProcAddress(_lib, "rl_m_set__Board_int64_t_int64_t_int64_t");
        if (rl_m_set__Board_int64_t_int64_t_int64_t_ptr == IntPtr.Zero) throw new Exception("Could not find symbol rl_m_set__Board_int64_t_int64_t_int64_t");
        rl_m_set__Board_int64_t_int64_t_int64_t = Marshal.GetDelegateForFunctionPointer<Delegaterl_m_set__Board_int64_t_int64_t_int64_t>(rl_m_set__Board_int64_t_int64_t_int64_t_ptr);
        IntPtr rl_m_get__Board_int64_t_int64_t_r_int64_t_ptr = GetProcAddress(_lib, "rl_m_get__Board_int64_t_int64_t_r_int64_t");
        if (rl_m_get__Board_int64_t_int64_t_r_int64_t_ptr == IntPtr.Zero) throw new Exception("Could not find symbol rl_m_get__Board_int64_t_int64_t_r_int64_t");
        rl_m_get__Board_int64_t_int64_t_r_int64_t = Marshal.GetDelegateForFunctionPointer<Delegaterl_m_get__Board_int64_t_int64_t_r_int64_t>(rl_m_get__Board_int64_t_int64_t_r_int64_t_ptr);
        IntPtr rl_apply__GameMark_Game_ptr = GetProcAddress(_lib, "rl_apply__GameMark_Game");
        if (rl_apply__GameMark_Game_ptr == IntPtr.Zero) throw new Exception("Could not find symbol rl_apply__GameMark_Game");
        rl_apply__GameMark_Game = Marshal.GetDelegateForFunctionPointer<Delegaterl_apply__GameMark_Game>(rl_apply__GameMark_Game_ptr);
        IntPtr rl_can_apply__GameMark_Game_r_bool_ptr = GetProcAddress(_lib, "rl_can_apply__GameMark_Game_r_bool");
        if (rl_can_apply__GameMark_Game_r_bool_ptr == IntPtr.Zero) throw new Exception("Could not find symbol rl_can_apply__GameMark_Game_r_bool");
        rl_can_apply__GameMark_Game_r_bool = Marshal.GetDelegateForFunctionPointer<Delegaterl_can_apply__GameMark_Game_r_bool>(rl_can_apply__GameMark_Game_r_bool_ptr);
        IntPtr rl_get_type_name__GameMark_r_strlit_ptr = GetProcAddress(_lib, "rl_get_type_name__GameMark_r_strlit");
        if (rl_get_type_name__GameMark_r_strlit_ptr == IntPtr.Zero) throw new Exception("Could not find symbol rl_get_type_name__GameMark_r_strlit");
        rl_get_type_name__GameMark_r_strlit = Marshal.GetDelegateForFunctionPointer<Delegaterl_get_type_name__GameMark_r_strlit>(rl_get_type_name__GameMark_r_strlit_ptr);
        IntPtr rl_play__r_Game_ptr = GetProcAddress(_lib, "rl_play__r_Game");
        if (rl_play__r_Game_ptr == IntPtr.Zero) throw new Exception("Could not find symbol rl_play__r_Game");
        rl_play__r_Game = Marshal.GetDelegateForFunctionPointer<Delegaterl_play__r_Game>(rl_play__r_Game_ptr);
        IntPtr rl_can_play__r_bool_ptr = GetProcAddress(_lib, "rl_can_play__r_bool");
        if (rl_can_play__r_bool_ptr == IntPtr.Zero) throw new Exception("Could not find symbol rl_can_play__r_bool");
        rl_can_play__r_bool = Marshal.GetDelegateForFunctionPointer<Delegaterl_can_play__r_bool>(rl_can_play__r_bool_ptr);
        IntPtr rl_m_mark__Game_BIntT0T3T_BIntT0T3T_ptr = GetProcAddress(_lib, "rl_m_mark__Game_BIntT0T3T_BIntT0T3T");
        if (rl_m_mark__Game_BIntT0T3T_BIntT0T3T_ptr == IntPtr.Zero) throw new Exception("Could not find symbol rl_m_mark__Game_BIntT0T3T_BIntT0T3T");
        rl_m_mark__Game_BIntT0T3T_BIntT0T3T = Marshal.GetDelegateForFunctionPointer<Delegaterl_m_mark__Game_BIntT0T3T_BIntT0T3T>(rl_m_mark__Game_BIntT0T3T_BIntT0T3T_ptr);
        IntPtr rl_m_can_mark__Game_BIntT0T3T_BIntT0T3T_r_bool_ptr = GetProcAddress(_lib, "rl_m_can_mark__Game_BIntT0T3T_BIntT0T3T_r_bool");
        if (rl_m_can_mark__Game_BIntT0T3T_BIntT0T3T_r_bool_ptr == IntPtr.Zero) throw new Exception("Could not find symbol rl_m_can_mark__Game_BIntT0T3T_BIntT0T3T_r_bool");
        rl_m_can_mark__Game_BIntT0T3T_BIntT0T3T_r_bool = Marshal.GetDelegateForFunctionPointer<Delegaterl_m_can_mark__Game_BIntT0T3T_BIntT0T3T_r_bool>(rl_m_can_mark__Game_BIntT0T3T_BIntT0T3T_r_bool_ptr);
        IntPtr rl_m_is_done__Game_r_bool_ptr = GetProcAddress(_lib, "rl_m_is_done__Game_r_bool");
        if (rl_m_is_done__Game_r_bool_ptr == IntPtr.Zero) throw new Exception("Could not find symbol rl_m_is_done__Game_r_bool");
        rl_m_is_done__Game_r_bool = Marshal.GetDelegateForFunctionPointer<Delegaterl_m_is_done__Game_r_bool>(rl_m_is_done__Game_r_bool_ptr);
    }

    public static void teardown() {
    if (_lib == IntPtr.Zero) return;
        rl_m_init__Range = null;
        rl_m_init__AnyGameAction = null;
        rl_m_init__Game = null;
        rl_m_init__Board = null;
        rl_m_init__BIntT0T3T_9 = null;
        rl_m_init__strlit = null;
        rl_m_init__int8_t_1 = null;
        rl_m_init__int8_t_8 = null;
        rl_m_init__GameMark = null;
        rl_m_assign__Game_Game = null;
        rl_m_assign__Board_Board = null;
        rl_m_assign__BIntT0T3T_9_BIntT0T3T_9 = null;
        rl_m_assign__strlit_strlit = null;
        rl_m_assign__AnyGameAction_GameMark = null;
        rl_m_assign__AnyGameAction_AnyGameAction = null;
        rl_m_assign__GameMark_GameMark = null;
        rl_m_assign__BIntT0T3T_BIntT0T3T = null;
        rl_m_assign__Range_Range = null;
        rl_m_assign__String_String = null;
        rl_m_drop__String = null;
        rl_print_string__String = null;
        rl_print_string_lit__strlit = null;
        rl_print__String = null;
        rl_print__AnyGameAction = null;
        rl_print__Game = null;
        rl_append_to_vector__int64_t_VectorTint8_tT = null;
        rl_append_to_vector__double_VectorTint8_tT = null;
        rl_append_to_vector__bool_VectorTint8_tT = null;
        rl_append_to_vector__int8_t_VectorTint8_tT = null;
        rl_append_to_vector__BIntT0T3T_9_VectorTint8_tT = null;
        rl_as_byte_vector__Game_r_VectorTint8_tT = null;
        rl_parse_from_vector__int64_t_VectorTint8_tT_int64_t_r_bool = null;
        rl_parse_from_vector__double_VectorTint8_tT_int64_t_r_bool = null;
        rl_parse_from_vector__bool_VectorTint8_tT_int64_t_r_bool = null;
        rl_parse_from_vector__int8_t_VectorTint8_tT_int64_t_r_bool = null;
        rl_parse_from_vector__BIntT0T3T_9_VectorTint8_tT_int64_t_r_bool = null;
        rl_from_byte_vector__Game_VectorTint8_tT_r_bool = null;
        rl_from_byte_vector__AnyGameAction_VectorTint8_tT_r_bool = null;
        rl_from_byte_vector__int8_t_VectorTint8_tT_int64_t_r_bool = null;
        rl_from_byte_vector__int64_t_VectorTint8_tT_int64_t_r_bool = null;
        rl_from_byte_vector__GameMark_VectorTint8_tT_int64_t_r_bool = null;
        rl_from_byte_vector__AnyGameAction_VectorTint8_tT_int64_t_r_bool = null;
        rl_m_size__VectorTint8_tT_r_int64_t = null;
        rl_m_size__VectorTdoubleT_r_int64_t = null;
        rl_m_size__VectorTStringT_r_int64_t = null;
        rl_m_size__VectorTAnyGameActionT_r_int64_t = null;
        rl_m_size__VectorTGameMarkT_r_int64_t = null;
        rl_m_size__VectorTBIntT0T3TT_r_int64_t = null;
        rl_m_drop_back__VectorTint8_tT_int64_t = null;
        rl_m_pop__VectorTint8_tT_r_int8_t = null;
        rl_m_pop__VectorTStringT_r_String = null;
        rl_m_pop__VectorTdoubleT_r_double = null;
        rl_m_append__VectorTint8_tT_int8_t = null;
        rl_m_append__VectorTboolT_bool = null;
        rl_m_append__VectorTStringT_String = null;
        rl_m_append__VectorTdoubleT_double = null;
        rl_m_append__VectorTAnyGameActionT_AnyGameAction = null;
        rl_m_append__VectorTGameMarkT_GameMark = null;
        rl_m_append__VectorTBIntT0T3TT_BIntT0T3T = null;
        rl_m_get__VectorTint8_tT_int64_t_r_int8_tRef = null;
        rl_m_get__VectorTdoubleT_int64_t_r_doubleRef = null;
        rl_m_get__VectorTStringT_int64_t_r_StringRef = null;
        rl_m_get__VectorTAnyGameActionT_int64_t_r_AnyGameActionRef = null;
        rl_m_get__VectorTboolT_int64_t_r_boolRef = null;
        rl_m_get__VectorTGameMarkT_int64_t_r_GameMarkRef = null;
        rl_m_get__VectorTBIntT0T3TT_int64_t_r_BIntT0T3TRef = null;
        rl_m_back__VectorTint8_tT_r_int8_tRef = null;
        rl_m_resize__VectorTdoubleT_int64_t = null;
        rl_m_assign__VectorTint8_tT_VectorTint8_tT = null;
        rl_m_assign__VectorTStringT_VectorTStringT = null;
        rl_m_assign__VectorTdoubleT_VectorTdoubleT = null;
        rl_m_assign__VectorTboolT_VectorTboolT = null;
        rl_m_assign__VectorTAnyGameActionT_VectorTAnyGameActionT = null;
        rl_m_assign__VectorTGameMarkT_VectorTGameMarkT = null;
        rl_m_assign__VectorTBIntT0T3TT_VectorTBIntT0T3TT = null;
        rl_m_drop__VectorTint8_tT = null;
        rl_m_drop__VectorTdoubleT = null;
        rl_m_drop__VectorTStringT = null;
        rl_m_drop__VectorTAnyGameActionT = null;
        rl_m_drop__VectorTboolT = null;
        rl_m_drop__VectorTGameMarkT = null;
        rl_m_drop__VectorTBIntT0T3TT = null;
        rl_m_init__VectorTint8_tT = null;
        rl_m_init__VectorTdoubleT = null;
        rl_m_init__VectorTStringT = null;
        rl_m_init__VectorTAnyGameActionT = null;
        rl_m_init__VectorTboolT = null;
        rl_m_init__VectorTGameMarkT = null;
        rl_m_init__VectorTBIntT0T3TT = null;
        rl_m_to_indented_lines__String_r_String = null;
        rl_m_reverse__String = null;
        rl_m_back__String_r_int8_tRef = null;
        rl_m_drop_back__String_int64_t = null;
        rl_m_not_equal__String_strlit_r_bool = null;
        rl_m_not_equal__String_String_r_bool = null;
        rl_m_equal__String_String_r_bool = null;
        rl_m_equal__String_strlit_r_bool = null;
        rl_m_add__String_String_r_String = null;
        rl_m_append_quoted__String_String = null;
        rl_m_append__String_String = null;
        rl_m_append__String_strlit = null;
        rl_m_count__String_int8_t_r_int64_t = null;
        rl_m_size__String_r_int64_t = null;
        rl_m_substring_matches__String_strlit_int64_t_r_bool = null;
        rl_m_get__String_int64_t_r_int8_tRef = null;
        rl_m_append__String_int8_t = null;
        rl_m_init__String = null;
        rl_s__strlit_r_String = null;
        rl_append_to_string__strlit_String = null;
        rl_load_file__String_String_r_bool = null;
        rl_append_to_string__int64_t_String = null;
        rl_append_to_string__int8_t_String = null;
        rl_append_to_string__double_String = null;
        rl_append_to_string__String_String = null;
        rl_append_to_string__bool_String = null;
        rl_append_to_string__BIntT0T3T_9_String = null;
        rl_to_string__AnyGameAction_r_String = null;
        rl_to_string__Game_r_String = null;
        rl_is_space__int8_t_r_bool = null;
        rl_is_alphanumeric__int8_t_r_bool = null;
        rl_is_open_paren__int8_t_r_bool = null;
        rl_is_close_paren__int8_t_r_bool = null;
        rl_parse_string__int64_t_String_int64_t_r_bool = null;
        rl_parse_string__int8_t_String_int64_t_r_bool = null;
        rl_parse_string__double_String_int64_t_r_bool = null;
        rl_length__strlit_r_int64_t = null;
        rl_parse_string__String_String_int64_t_r_bool = null;
        rl_parse_string__bool_String_int64_t_r_bool = null;
        rl_parse_string__BIntT0T3T_9_String_int64_t_r_bool = null;
        rl_from_string__AnyGameAction_String_r_bool = null;
        rl_from_string__Game_String_r_bool = null;
        rl_from_string__AnyGameAction_String_int64_t_r_bool = null;
        rl_m_init__BIntT0T3T = null;
        rl_append_to_vector__BIntT0T3T_VectorTint8_tT = null;
        rl_parse_from_vector__BIntT0T3T_VectorTint8_tT_int64_t_r_bool = null;
        rl_append_to_string__BIntT0T3T_String = null;
        rl_parse_string__BIntT0T3T_String_int64_t_r_bool = null;
        rl_enumerate__BIntT0T3T_VectorTBIntT0T3TT = null;
        rl_max__int64_t_int64_t_r_int64_t = null;
        rl_min__int64_t_int64_t_r_int64_t = null;
        rl_sqrt__double_r_double = null;
        rl_abs__int64_t_r_int64_t = null;
        rl_custom_equal__int64_t_int64_t_r_bool = null;
        rl_custom_equal__bool_bool_r_bool = null;
        rl_custom_equal__int8_t_int8_t_r_bool = null;
        rl_custom_equal__double_double_r_bool = null;
        rl_equal__AnyGameAction_AnyGameAction_r_bool = null;
        rl_equal__GameMark_GameMark_r_bool = null;
        rl_equal__BIntT0T3T_BIntT0T3T_r_bool = null;
        rl_equal__int64_t_int64_t_r_bool = null;
        rl_can_apply_impl__AnyGameAction_Game_r_bool = null;
        rl_apply__AnyGameAction_Game = null;
        rl_can_apply__AnyGameAction_Game_r_bool = null;
        rl_apply__VectorTAnyGameActionT_Game_r_bool = null;
        rl_parse_actions__AnyGameAction_VectorTint8_tT_int64_t_r_VectorTAnyGameActionT = null;
        rl_parse_actions__AnyGameAction_String_r_VectorTAnyGameActionT = null;
        rl_parse_action_optimized__AnyGameAction_VectorTint8_tT_int64_t_r_bool = null;
        rl_parse_actions__AnyGameAction_VectorTint8_tT_r_VectorTAnyGameActionT = null;
        rl_make_valid_actions_vector__VectorTAnyGameActionT_Game_r_VectorTint8_tT = null;
        rl_get_valid_actions__VectorTint8_tT_VectorTAnyGameActionT_Game = null;
        rl_gen_python_methods__Game_AnyGameAction = null;
        rl_load_action_vector_file__String_VectorTAnyGameActionT_r_bool = null;
        rl_enumerate__bool_VectorTboolT = null;
        rl_enumeration_error__int64_t_String_VectorTStringT = null;
        rl_enumeration_error__double_String_VectorTStringT = null;
        rl_get_enumeration_errors_impl__AnyGameAction_String_VectorTStringT = null;
        rl_get_enumeration_errors_impl__GameMark_String_VectorTStringT = null;
        rl_get_enumeration_errors_impl__BIntT0T3T_String_VectorTStringT = null;
        rl_get_enumeration_errors_impl__int64_t_String_VectorTStringT = null;
        rl_get_enumeration_errors__AnyGameAction_r_String = null;
        rl_print_enumeration_errors__AnyGameAction_r_bool = null;
        rl_enumerate__AnyGameAction_r_VectorTAnyGameActionT = null;
        rl_enumerate__GameMark_r_VectorTGameMarkT = null;
        rl_enumerate__BIntT0T3T_r_VectorTBIntT0T3TT = null;
        rl_write_in_observation_tensor__int64_t_int64_t_int64_t_VectorTdoubleT_int64_t = null;
        rl_write_in_observation_tensor__int64_t_int64_t_VectorTdoubleT_int64_t = null;
        rl_size_as_observation_tensor__int64_t_r_int64_t = null;
        rl_write_in_observation_tensor__double_int64_t_VectorTdoubleT_int64_t = null;
        rl_can_write_in_observation_tensor__double_int64_t_VectorTdoubleT_int64_t_r_bool = null;
        rl_size_as_observation_tensor__double_r_int64_t = null;
        rl_can_size_as_observation_tensor__double_r_bool = null;
        rl_write_in_observation_tensor__bool_int64_t_VectorTdoubleT_int64_t = null;
        rl_size_as_observation_tensor__bool_r_int64_t = null;
        rl_write_in_observation_tensor__int8_t_int64_t_VectorTdoubleT_int64_t = null;
        rl_size_as_observation_tensor__int8_t_r_int64_t = null;
        rl_write_in_observation_tensor__BIntT0T3T_9_int64_t_VectorTdoubleT_int64_t = null;
        rl_size_as_observation_tensor__BIntT0T3T_9_r_int64_t = null;
        rl_write_in_observation_tensor__BIntT0T3T_int64_t_VectorTdoubleT_int64_t = null;
        rl_size_as_observation_tensor__BIntT0T3T_r_int64_t = null;
        rl_to_observation_tensor__Game_int64_t_VectorTdoubleT = null;
        rl_observation_tensor_size__Game_r_int64_t = null;
        rl_write_tensor_warning_context__String_VectorTStringT = null;
        rl_tensorable_warning__int64_t_String_VectorTStringT = null;
        rl_tensorable_warning__double_String_VectorTStringT = null;
        rl_tensorable_warning__BIntT0T3T_9_String_VectorTStringT = null;
        rl_to_observation_tensor_warnings__Game_r_String = null;
        rl_emit_observation_tensor_warnings__Game = null;
        rl_gen_printer_parser_ = null;
        rl_m_set_size__Range_int64_t = null;
        rl_m_size__Range_r_int64_t = null;
        rl_m_get__Range_int64_t_r_int64_t = null;
        rl_range__int64_t_r_Range = null;
        rl_fuzz__VectorTint8_tT = null;
        rl_m_next_turn__Board = null;
        rl_m_current_player__Board_r_int64_t = null;
        rl_m_three_in_a_line_player__Board_int64_t_r_bool = null;
        rl_m_three_in_a_line_player_row__Board_int64_t_int64_t_r_bool = null;
        rl_m_full__Board_r_bool = null;
        rl_m_set__Board_int64_t_int64_t_int64_t = null;
        rl_m_get__Board_int64_t_int64_t_r_int64_t = null;
        rl_apply__GameMark_Game = null;
        rl_can_apply__GameMark_Game_r_bool = null;
        rl_get_type_name__GameMark_r_strlit = null;
        rl_play__r_Game = null;
        rl_can_play__r_bool = null;
        rl_m_mark__Game_BIntT0T3T_BIntT0T3T = null;
        rl_m_can_mark__Game_BIntT0T3T_BIntT0T3T_r_bool = null;
        rl_m_is_done__Game_r_bool = null;
        RLCNative.FreeLibrary(_lib);_lib = IntPtr.Zero;
    }

}

unsafe class RLC {
    public static void print_string(String s){
        RLCNative.rl_print_string__String(ref *s.__content);
    }

    public static void print_string_lit(char* s){
        RLCNative.rl_print_string_lit__strlit(ref s);
    }

    public static void print(String to_print){
        RLCNative.rl_print__String(ref *to_print.__content);
    }

    public static void print(AnyGameAction to_print){
        RLCNative.rl_print__AnyGameAction(ref *to_print.__content);
    }

    public static void print(Game to_print){
        RLCNative.rl_print__Game(ref *to_print.__content);
    }

    public static void append_to_vector(long to_add, VectorTint8_tT output){
        RLCNative.rl_append_to_vector__int64_t_VectorTint8_tT(ref to_add, ref *output.__content);
    }

    public static void append_to_vector(double to_add, VectorTint8_tT output){
        RLCNative.rl_append_to_vector__double_VectorTint8_tT(ref to_add, ref *output.__content);
    }

    public static void append_to_vector(bool to_add, VectorTint8_tT output){
        RLCNative.rl_append_to_vector__bool_VectorTint8_tT(ref to_add, ref *output.__content);
    }

    public static void append_to_vector(sbyte to_add, VectorTint8_tT output){
        RLCNative.rl_append_to_vector__int8_t_VectorTint8_tT(ref to_add, ref *output.__content);
    }

    public static void append_to_vector(BIntT0T3T_9 to_add, VectorTint8_tT output){
        RLCNative.rl_append_to_vector__BIntT0T3T_9_VectorTint8_tT(ref *to_add.__content, ref *output.__content);
    }

    public static VectorTint8_tT as_byte_vector(Game to_convert){
        VectorTint8_tT __result = new VectorTint8_tT();RLCNative.rl_as_byte_vector__Game_r_VectorTint8_tT(ref *__result.__content, ref *to_convert.__content);
        return __result;
    }

    public static bool parse_from_vector(long result, VectorTint8_tT input, long index){
        bool __result = false;
        RLCNative.rl_parse_from_vector__int64_t_VectorTint8_tT_int64_t_r_bool(ref __result, ref result, ref *input.__content, ref index);
        return __result;
    }

    public static bool parse_from_vector(double result, VectorTint8_tT input, long index){
        bool __result = false;
        RLCNative.rl_parse_from_vector__double_VectorTint8_tT_int64_t_r_bool(ref __result, ref result, ref *input.__content, ref index);
        return __result;
    }

    public static bool parse_from_vector(bool result, VectorTint8_tT input, long index){
        bool __result = false;
        RLCNative.rl_parse_from_vector__bool_VectorTint8_tT_int64_t_r_bool(ref __result, ref result, ref *input.__content, ref index);
        return __result;
    }

    public static bool parse_from_vector(sbyte result, VectorTint8_tT input, long index){
        bool __result = false;
        RLCNative.rl_parse_from_vector__int8_t_VectorTint8_tT_int64_t_r_bool(ref __result, ref result, ref *input.__content, ref index);
        return __result;
    }

    public static bool parse_from_vector(BIntT0T3T_9 to_add, VectorTint8_tT input, long index){
        bool __result = false;
        RLCNative.rl_parse_from_vector__BIntT0T3T_9_VectorTint8_tT_int64_t_r_bool(ref __result, ref *to_add.__content, ref *input.__content, ref index);
        return __result;
    }

    public static bool from_byte_vector(Game result, VectorTint8_tT input){
        bool __result = false;
        RLCNative.rl_from_byte_vector__Game_VectorTint8_tT_r_bool(ref __result, ref *result.__content, ref *input.__content);
        return __result;
    }

    public static bool from_byte_vector(AnyGameAction result, VectorTint8_tT input){
        bool __result = false;
        RLCNative.rl_from_byte_vector__AnyGameAction_VectorTint8_tT_r_bool(ref __result, ref *result.__content, ref *input.__content);
        return __result;
    }

    public static bool from_byte_vector(sbyte result, VectorTint8_tT input, long read_bytes){
        bool __result = false;
        RLCNative.rl_from_byte_vector__int8_t_VectorTint8_tT_int64_t_r_bool(ref __result, ref result, ref *input.__content, ref read_bytes);
        return __result;
    }

    public static bool from_byte_vector(long result, VectorTint8_tT input, long read_bytes){
        bool __result = false;
        RLCNative.rl_from_byte_vector__int64_t_VectorTint8_tT_int64_t_r_bool(ref __result, ref result, ref *input.__content, ref read_bytes);
        return __result;
    }

    public static bool from_byte_vector(GameMark result, VectorTint8_tT input, long read_bytes){
        bool __result = false;
        RLCNative.rl_from_byte_vector__GameMark_VectorTint8_tT_int64_t_r_bool(ref __result, ref *result.__content, ref *input.__content, ref read_bytes);
        return __result;
    }

    public static bool from_byte_vector(AnyGameAction result, VectorTint8_tT input, long read_bytes){
        bool __result = false;
        RLCNative.rl_from_byte_vector__AnyGameAction_VectorTint8_tT_int64_t_r_bool(ref __result, ref *result.__content, ref *input.__content, ref read_bytes);
        return __result;
    }

    public static String s(char* literal){
        String __result = new String();RLCNative.rl_s__strlit_r_String(ref *__result.__content, ref literal);
        return __result;
    }

    public static void append_to_string(char* x, String output){
        RLCNative.rl_append_to_string__strlit_String(ref x, ref *output.__content);
    }

    public static bool load_file(String file_name, String _out){
        bool __result = false;
        RLCNative.rl_load_file__String_String_r_bool(ref __result, ref *file_name.__content, ref *_out.__content);
        return __result;
    }

    public static void append_to_string(long x, String output){
        RLCNative.rl_append_to_string__int64_t_String(ref x, ref *output.__content);
    }

    public static void append_to_string(sbyte x, String output){
        RLCNative.rl_append_to_string__int8_t_String(ref x, ref *output.__content);
    }

    public static void append_to_string(double x, String output){
        RLCNative.rl_append_to_string__double_String(ref x, ref *output.__content);
    }

    public static void append_to_string(String x, String output){
        RLCNative.rl_append_to_string__String_String(ref *x.__content, ref *output.__content);
    }

    public static void append_to_string(bool x, String output){
        RLCNative.rl_append_to_string__bool_String(ref x, ref *output.__content);
    }

    public static void append_to_string(BIntT0T3T_9 to_add, String output){
        RLCNative.rl_append_to_string__BIntT0T3T_9_String(ref *to_add.__content, ref *output.__content);
    }

    public static String to_string(AnyGameAction to_stringyfi){
        String __result = new String();RLCNative.rl_to_string__AnyGameAction_r_String(ref *__result.__content, ref *to_stringyfi.__content);
        return __result;
    }

    public static String to_string(Game to_stringyfi){
        String __result = new String();RLCNative.rl_to_string__Game_r_String(ref *__result.__content, ref *to_stringyfi.__content);
        return __result;
    }

    public static bool is_space(sbyte b){
        bool __result = false;
        RLCNative.rl_is_space__int8_t_r_bool(ref __result, ref b);
        return __result;
    }

    public static bool is_alphanumeric(sbyte b){
        bool __result = false;
        RLCNative.rl_is_alphanumeric__int8_t_r_bool(ref __result, ref b);
        return __result;
    }

    public static bool is_open_paren(sbyte b){
        bool __result = false;
        RLCNative.rl_is_open_paren__int8_t_r_bool(ref __result, ref b);
        return __result;
    }

    public static bool is_close_paren(sbyte b){
        bool __result = false;
        RLCNative.rl_is_close_paren__int8_t_r_bool(ref __result, ref b);
        return __result;
    }

    public static bool parse_string(long result, String buffer, long index){
        bool __result = false;
        RLCNative.rl_parse_string__int64_t_String_int64_t_r_bool(ref __result, ref result, ref *buffer.__content, ref index);
        return __result;
    }

    public static bool parse_string(sbyte result, String buffer, long index){
        bool __result = false;
        RLCNative.rl_parse_string__int8_t_String_int64_t_r_bool(ref __result, ref result, ref *buffer.__content, ref index);
        return __result;
    }

    public static bool parse_string(double result, String buffer, long index){
        bool __result = false;
        RLCNative.rl_parse_string__double_String_int64_t_r_bool(ref __result, ref result, ref *buffer.__content, ref index);
        return __result;
    }

    public static long length(char* literal){
        long __result = 0;
        RLCNative.rl_length__strlit_r_int64_t(ref __result, ref literal);
        return __result;
    }

    public static bool parse_string(String result, String buffer, long index){
        bool __result = false;
        RLCNative.rl_parse_string__String_String_int64_t_r_bool(ref __result, ref *result.__content, ref *buffer.__content, ref index);
        return __result;
    }

    public static bool parse_string(bool result, String buffer, long index){
        bool __result = false;
        RLCNative.rl_parse_string__bool_String_int64_t_r_bool(ref __result, ref result, ref *buffer.__content, ref index);
        return __result;
    }

    public static bool parse_string(BIntT0T3T_9 result, String buffer, long index){
        bool __result = false;
        RLCNative.rl_parse_string__BIntT0T3T_9_String_int64_t_r_bool(ref __result, ref *result.__content, ref *buffer.__content, ref index);
        return __result;
    }

    public static bool from_string(AnyGameAction result, String buffer){
        bool __result = false;
        RLCNative.rl_from_string__AnyGameAction_String_r_bool(ref __result, ref *result.__content, ref *buffer.__content);
        return __result;
    }

    public static bool from_string(Game result, String buffer){
        bool __result = false;
        RLCNative.rl_from_string__Game_String_r_bool(ref __result, ref *result.__content, ref *buffer.__content);
        return __result;
    }

    public static bool from_string(AnyGameAction result, String buffer, long index){
        bool __result = false;
        RLCNative.rl_from_string__AnyGameAction_String_int64_t_r_bool(ref __result, ref *result.__content, ref *buffer.__content, ref index);
        return __result;
    }

    public static void append_to_vector(BIntT0T3T to_add, VectorTint8_tT output){
        RLCNative.rl_append_to_vector__BIntT0T3T_VectorTint8_tT(ref *to_add.__content, ref *output.__content);
    }

    public static bool parse_from_vector(BIntT0T3T to_add, VectorTint8_tT output, long index){
        bool __result = false;
        RLCNative.rl_parse_from_vector__BIntT0T3T_VectorTint8_tT_int64_t_r_bool(ref __result, ref *to_add.__content, ref *output.__content, ref index);
        return __result;
    }

    public static void append_to_string(BIntT0T3T to_add, String output){
        RLCNative.rl_append_to_string__BIntT0T3T_String(ref *to_add.__content, ref *output.__content);
    }

    public static bool parse_string(BIntT0T3T to_add, String input, long index){
        bool __result = false;
        RLCNative.rl_parse_string__BIntT0T3T_String_int64_t_r_bool(ref __result, ref *to_add.__content, ref *input.__content, ref index);
        return __result;
    }

    public static void enumerate(BIntT0T3T to_add, VectorTBIntT0T3TT output){
        RLCNative.rl_enumerate__BIntT0T3T_VectorTBIntT0T3TT(ref *to_add.__content, ref *output.__content);
    }

    public static long max(long a, long b){
        long __result = 0;
        RLCNative.rl_max__int64_t_int64_t_r_int64_t(ref __result, ref a, ref b);
        return __result;
    }

    public static long min(long a, long b){
        long __result = 0;
        RLCNative.rl_min__int64_t_int64_t_r_int64_t(ref __result, ref a, ref b);
        return __result;
    }

    public static double sqrt(double f){
        double __result = 0;
        RLCNative.rl_sqrt__double_r_double(ref __result, ref f);
        return __result;
    }

    public static long abs(long a){
        long __result = 0;
        RLCNative.rl_abs__int64_t_r_int64_t(ref __result, ref a);
        return __result;
    }

    public static bool custom_equal(long lhs, long rhs){
        bool __result = false;
        RLCNative.rl_custom_equal__int64_t_int64_t_r_bool(ref __result, ref lhs, ref rhs);
        return __result;
    }

    public static bool custom_equal(bool lhs, bool rhs){
        bool __result = false;
        RLCNative.rl_custom_equal__bool_bool_r_bool(ref __result, ref lhs, ref rhs);
        return __result;
    }

    public static bool custom_equal(sbyte lhs, sbyte rhs){
        bool __result = false;
        RLCNative.rl_custom_equal__int8_t_int8_t_r_bool(ref __result, ref lhs, ref rhs);
        return __result;
    }

    public static bool custom_equal(double lhs, double rhs){
        bool __result = false;
        RLCNative.rl_custom_equal__double_double_r_bool(ref __result, ref lhs, ref rhs);
        return __result;
    }

    public static bool equal(AnyGameAction lhs, AnyGameAction rhs){
        bool __result = false;
        RLCNative.rl_equal__AnyGameAction_AnyGameAction_r_bool(ref __result, ref *lhs.__content, ref *rhs.__content);
        return __result;
    }

    public static bool equal(GameMark lhs, GameMark rhs){
        bool __result = false;
        RLCNative.rl_equal__GameMark_GameMark_r_bool(ref __result, ref *lhs.__content, ref *rhs.__content);
        return __result;
    }

    public static bool equal(BIntT0T3T lhs, BIntT0T3T rhs){
        bool __result = false;
        RLCNative.rl_equal__BIntT0T3T_BIntT0T3T_r_bool(ref __result, ref *lhs.__content, ref *rhs.__content);
        return __result;
    }

    public static bool equal(long lhs, long rhs){
        bool __result = false;
        RLCNative.rl_equal__int64_t_int64_t_r_bool(ref __result, ref lhs, ref rhs);
        return __result;
    }

    public static bool can_apply_impl(AnyGameAction action, Game frame){
        bool __result = false;
        RLCNative.rl_can_apply_impl__AnyGameAction_Game_r_bool(ref __result, ref *action.__content, ref *frame.__content);
        return __result;
    }

    public static void apply(AnyGameAction action, Game frame){
        RLCNative.rl_apply__AnyGameAction_Game(ref *action.__content, ref *frame.__content);
    }

    public static bool can_apply(AnyGameAction action, Game frame){
        bool __result = false;
        RLCNative.rl_can_apply__AnyGameAction_Game_r_bool(ref __result, ref *action.__content, ref *frame.__content);
        return __result;
    }

    public static bool apply(VectorTAnyGameActionT action, Game frame){
        bool __result = false;
        RLCNative.rl_apply__VectorTAnyGameActionT_Game_r_bool(ref __result, ref *action.__content, ref *frame.__content);
        return __result;
    }

    public static VectorTAnyGameActionT parse_actions(AnyGameAction variant, VectorTint8_tT input, long read_bytes){
        VectorTAnyGameActionT __result = new VectorTAnyGameActionT();RLCNative.rl_parse_actions__AnyGameAction_VectorTint8_tT_int64_t_r_VectorTAnyGameActionT(ref *__result.__content, ref *variant.__content, ref *input.__content, ref read_bytes);
        return __result;
    }

    public static VectorTAnyGameActionT parse_actions(AnyGameAction variant, String input){
        VectorTAnyGameActionT __result = new VectorTAnyGameActionT();RLCNative.rl_parse_actions__AnyGameAction_String_r_VectorTAnyGameActionT(ref *__result.__content, ref *variant.__content, ref *input.__content);
        return __result;
    }

    public static bool parse_action_optimized(AnyGameAction variant, VectorTint8_tT input, long read_bytes){
        bool __result = false;
        RLCNative.rl_parse_action_optimized__AnyGameAction_VectorTint8_tT_int64_t_r_bool(ref __result, ref *variant.__content, ref *input.__content, ref read_bytes);
        return __result;
    }

    public static VectorTAnyGameActionT parse_actions(AnyGameAction variant, VectorTint8_tT input){
        VectorTAnyGameActionT __result = new VectorTAnyGameActionT();RLCNative.rl_parse_actions__AnyGameAction_VectorTint8_tT_r_VectorTAnyGameActionT(ref *__result.__content, ref *variant.__content, ref *input.__content);
        return __result;
    }

    public static VectorTint8_tT make_valid_actions_vector(VectorTAnyGameActionT all_actions, Game state){
        VectorTint8_tT __result = new VectorTint8_tT();RLCNative.rl_make_valid_actions_vector__VectorTAnyGameActionT_Game_r_VectorTint8_tT(ref *__result.__content, ref *all_actions.__content, ref *state.__content);
        return __result;
    }

    public static void get_valid_actions(VectorTint8_tT valid_actions, VectorTAnyGameActionT all_actions, Game state){
        RLCNative.rl_get_valid_actions__VectorTint8_tT_VectorTAnyGameActionT_Game(ref *valid_actions.__content, ref *all_actions.__content, ref *state.__content);
    }

    public static void gen_python_methods(Game state, AnyGameAction variant){
        RLCNative.rl_gen_python_methods__Game_AnyGameAction(ref *state.__content, ref *variant.__content);
    }

    public static bool load_action_vector_file(String file_name, VectorTAnyGameActionT _out){
        bool __result = false;
        RLCNative.rl_load_action_vector_file__String_VectorTAnyGameActionT_r_bool(ref __result, ref *file_name.__content, ref *_out.__content);
        return __result;
    }

    public static void enumerate(bool b, VectorTboolT output){
        RLCNative.rl_enumerate__bool_VectorTboolT(ref b, ref *output.__content);
    }

    public static void enumeration_error(long x, String _out, VectorTStringT context){
        RLCNative.rl_enumeration_error__int64_t_String_VectorTStringT(ref x, ref *_out.__content, ref *context.__content);
    }

    public static void enumeration_error(double x, String _out, VectorTStringT context){
        RLCNative.rl_enumeration_error__double_String_VectorTStringT(ref x, ref *_out.__content, ref *context.__content);
    }

    public static void get_enumeration_errors_impl(AnyGameAction obj, String _out, VectorTStringT context){
        RLCNative.rl_get_enumeration_errors_impl__AnyGameAction_String_VectorTStringT(ref *obj.__content, ref *_out.__content, ref *context.__content);
    }

    public static void get_enumeration_errors_impl(GameMark obj, String _out, VectorTStringT context){
        RLCNative.rl_get_enumeration_errors_impl__GameMark_String_VectorTStringT(ref *obj.__content, ref *_out.__content, ref *context.__content);
    }

    public static void get_enumeration_errors_impl(BIntT0T3T obj, String _out, VectorTStringT context){
        RLCNative.rl_get_enumeration_errors_impl__BIntT0T3T_String_VectorTStringT(ref *obj.__content, ref *_out.__content, ref *context.__content);
    }

    public static void get_enumeration_errors_impl(long obj, String _out, VectorTStringT context){
        RLCNative.rl_get_enumeration_errors_impl__int64_t_String_VectorTStringT(ref obj, ref *_out.__content, ref *context.__content);
    }

    public static String get_enumeration_errors(AnyGameAction obj){
        String __result = new String();RLCNative.rl_get_enumeration_errors__AnyGameAction_r_String(ref *__result.__content, ref *obj.__content);
        return __result;
    }

    public static bool print_enumeration_errors(AnyGameAction obj){
        bool __result = false;
        RLCNative.rl_print_enumeration_errors__AnyGameAction_r_bool(ref __result, ref *obj.__content);
        return __result;
    }

    public static VectorTAnyGameActionT enumerate(AnyGameAction obj){
        VectorTAnyGameActionT __result = new VectorTAnyGameActionT();RLCNative.rl_enumerate__AnyGameAction_r_VectorTAnyGameActionT(ref *__result.__content, ref *obj.__content);
        return __result;
    }

    public static VectorTGameMarkT enumerate(GameMark obj){
        VectorTGameMarkT __result = new VectorTGameMarkT();RLCNative.rl_enumerate__GameMark_r_VectorTGameMarkT(ref *__result.__content, ref *obj.__content);
        return __result;
    }

    public static VectorTBIntT0T3TT enumerate(BIntT0T3T obj){
        VectorTBIntT0T3TT __result = new VectorTBIntT0T3TT();RLCNative.rl_enumerate__BIntT0T3T_r_VectorTBIntT0T3TT(ref *__result.__content, ref *obj.__content);
        return __result;
    }

    public static void write_in_observation_tensor(long value, long min, long max, VectorTdoubleT output, long index){
        RLCNative.rl_write_in_observation_tensor__int64_t_int64_t_int64_t_VectorTdoubleT_int64_t(ref value, ref min, ref max, ref *output.__content, ref index);
    }

    public static void write_in_observation_tensor(long obj, long observer_id, VectorTdoubleT output, long index){
        RLCNative.rl_write_in_observation_tensor__int64_t_int64_t_VectorTdoubleT_int64_t(ref obj, ref observer_id, ref *output.__content, ref index);
    }

    public static long size_as_observation_tensor(long obj){
        long __result = 0;
        RLCNative.rl_size_as_observation_tensor__int64_t_r_int64_t(ref __result, ref obj);
        return __result;
    }

    public static void write_in_observation_tensor(double obj, long observer_id, VectorTdoubleT output, long index){
        RLCNative.rl_write_in_observation_tensor__double_int64_t_VectorTdoubleT_int64_t(ref obj, ref observer_id, ref *output.__content, ref index);
    }

    public static bool can_write_in_observation_tensor(double obj, long observer_id, VectorTdoubleT output, long index){
        bool __result = false;
        RLCNative.rl_can_write_in_observation_tensor__double_int64_t_VectorTdoubleT_int64_t_r_bool(ref __result, ref obj, ref observer_id, ref *output.__content, ref index);
        return __result;
    }

    public static long size_as_observation_tensor(double obj){
        long __result = 0;
        RLCNative.rl_size_as_observation_tensor__double_r_int64_t(ref __result, ref obj);
        return __result;
    }

    public static bool can_size_as_observation_tensor(double obj){
        bool __result = false;
        RLCNative.rl_can_size_as_observation_tensor__double_r_bool(ref __result, ref obj);
        return __result;
    }

    public static void write_in_observation_tensor(bool obj, long observer_id, VectorTdoubleT output, long index){
        RLCNative.rl_write_in_observation_tensor__bool_int64_t_VectorTdoubleT_int64_t(ref obj, ref observer_id, ref *output.__content, ref index);
    }

    public static long size_as_observation_tensor(bool obj){
        long __result = 0;
        RLCNative.rl_size_as_observation_tensor__bool_r_int64_t(ref __result, ref obj);
        return __result;
    }

    public static void write_in_observation_tensor(sbyte obj, long observer_id, VectorTdoubleT output, long index){
        RLCNative.rl_write_in_observation_tensor__int8_t_int64_t_VectorTdoubleT_int64_t(ref obj, ref observer_id, ref *output.__content, ref index);
    }

    public static long size_as_observation_tensor(sbyte obj){
        long __result = 0;
        RLCNative.rl_size_as_observation_tensor__int8_t_r_int64_t(ref __result, ref obj);
        return __result;
    }

    public static void write_in_observation_tensor(BIntT0T3T_9 obj, long observer_id, VectorTdoubleT output, long index){
        RLCNative.rl_write_in_observation_tensor__BIntT0T3T_9_int64_t_VectorTdoubleT_int64_t(ref *obj.__content, ref observer_id, ref *output.__content, ref index);
    }

    public static long size_as_observation_tensor(BIntT0T3T_9 obj){
        long __result = 0;
        RLCNative.rl_size_as_observation_tensor__BIntT0T3T_9_r_int64_t(ref __result, ref *obj.__content);
        return __result;
    }

    public static void write_in_observation_tensor(BIntT0T3T obj, long observer_id, VectorTdoubleT output, long index){
        RLCNative.rl_write_in_observation_tensor__BIntT0T3T_int64_t_VectorTdoubleT_int64_t(ref *obj.__content, ref observer_id, ref *output.__content, ref index);
    }

    public static long size_as_observation_tensor(BIntT0T3T obj){
        long __result = 0;
        RLCNative.rl_size_as_observation_tensor__BIntT0T3T_r_int64_t(ref __result, ref *obj.__content);
        return __result;
    }

    public static void to_observation_tensor(Game obj, long observer_id, VectorTdoubleT output){
        RLCNative.rl_to_observation_tensor__Game_int64_t_VectorTdoubleT(ref *obj.__content, ref observer_id, ref *output.__content);
    }

    public static long observation_tensor_size(Game obj){
        long __result = 0;
        RLCNative.rl_observation_tensor_size__Game_r_int64_t(ref __result, ref *obj.__content);
        return __result;
    }

    public static void write_tensor_warning_context(String _out, VectorTStringT context){
        RLCNative.rl_write_tensor_warning_context__String_VectorTStringT(ref *_out.__content, ref *context.__content);
    }

    public static void tensorable_warning(long x, String _out, VectorTStringT context){
        RLCNative.rl_tensorable_warning__int64_t_String_VectorTStringT(ref x, ref *_out.__content, ref *context.__content);
    }

    public static void tensorable_warning(double x, String _out, VectorTStringT context){
        RLCNative.rl_tensorable_warning__double_String_VectorTStringT(ref x, ref *_out.__content, ref *context.__content);
    }

    public static void tensorable_warning(BIntT0T3T_9 x, String _out, VectorTStringT context){
        RLCNative.rl_tensorable_warning__BIntT0T3T_9_String_VectorTStringT(ref *x.__content, ref *_out.__content, ref *context.__content);
    }

    public static String to_observation_tensor_warnings(Game obj){
        String __result = new String();RLCNative.rl_to_observation_tensor_warnings__Game_r_String(ref *__result.__content, ref *obj.__content);
        return __result;
    }

    public static void emit_observation_tensor_warnings(Game obj){
        RLCNative.rl_emit_observation_tensor_warnings__Game(ref *obj.__content);
    }

    public static void gen_printer_parser(){
        RLCNative.rl_gen_printer_parser_();
    }

    public static Range range(long size){
        Range __result = new Range();RLCNative.rl_range__int64_t_r_Range(ref *__result.__content, ref size);
        return __result;
    }

    public static void fuzz(VectorTint8_tT input){
        RLCNative.rl_fuzz__VectorTint8_tT(ref *input.__content);
    }

    public static void apply(GameMark self, Game frame){
        RLCNative.rl_apply__GameMark_Game(ref *self.__content, ref *frame.__content);
    }

    public static bool can_apply(GameMark self, Game frame){
        bool __result = false;
        RLCNative.rl_can_apply__GameMark_Game_r_bool(ref __result, ref *self.__content, ref *frame.__content);
        return __result;
    }

    public static char* get_type_name(GameMark self){
        char* __result = null;
        RLCNative.rl_get_type_name__GameMark_r_strlit(ref __result, ref *self.__content);
        return __result;
    }

    public static Game play(){
        Game __result = new Game();RLCNative.rl_play__r_Game(ref *__result.__content);
        return __result;
    }

    public static bool can_play(){
        bool __result = false;
        RLCNative.rl_can_play__r_bool(ref __result);
        return __result;
    }

}

unsafe public class VectorTint8_tT{
    public Content* __content;
    private bool owning;
    [StructLayout(LayoutKind.Sequential)]
    public struct Content {
        private sbyte* _data;
        private long _size;
        private long _capacity;
    }
    public VectorTint8_tT(VectorTint8_tT.Content* referred) {
        owning = false;
        __content = referred;
    }
    public VectorTint8_tT() {
        __content = (VectorTint8_tT.Content*) Marshal.AllocHGlobal(sizeof(VectorTint8_tT.Content));
        owning = true;
        RLCNative.rl_m_init__VectorTint8_tT(ref *this.__content);
    }
    ~VectorTint8_tT() {
        if (!owning)
            return;
            RLCNative.rl_m_drop__VectorTint8_tT(ref *this.__content);
    Marshal.FreeHGlobal((IntPtr)__content);
    }
    public void assign(VectorTint8_tT other) {    RLCNative.rl_m_assign__VectorTint8_tT_VectorTint8_tT(ref *this.__content, ref *other.__content);
    }

    public sbyte back(){
        sbyte* __result = null;
        RLCNative.rl_m_back__VectorTint8_tT_r_int8_tRef(ref __result, ref *this.__content);
        return * __result;
    }

    public void drop_back(long quantity){
        RLCNative.rl_m_drop_back__VectorTint8_tT_int64_t(ref *this.__content, ref quantity);
    }

    public sbyte get(long index){
        sbyte* __result = null;
        RLCNative.rl_m_get__VectorTint8_tT_int64_t_r_int8_tRef(ref __result, ref *this.__content, ref index);
        return * __result;
    }

    public long size(){
        long __result = 0;
        RLCNative.rl_m_size__VectorTint8_tT_r_int64_t(ref __result, ref *this.__content);
        return __result;
    }

    public void append(sbyte value){
        RLCNative.rl_m_append__VectorTint8_tT_int8_t(ref *this.__content, ref value);
    }

    public sbyte pop(){
        sbyte __result = 0;
        RLCNative.rl_m_pop__VectorTint8_tT_r_int8_t(ref __result, ref *this.__content);
        return __result;
    }

}

unsafe public class VectorTboolT{
    public Content* __content;
    private bool owning;
    [StructLayout(LayoutKind.Sequential)]
    public struct Content {
        private bool* _data;
        private long _size;
        private long _capacity;
    }
    public VectorTboolT(VectorTboolT.Content* referred) {
        owning = false;
        __content = referred;
    }
    public VectorTboolT() {
        __content = (VectorTboolT.Content*) Marshal.AllocHGlobal(sizeof(VectorTboolT.Content));
        owning = true;
        RLCNative.rl_m_init__VectorTboolT(ref *this.__content);
    }
    ~VectorTboolT() {
        if (!owning)
            return;
            RLCNative.rl_m_drop__VectorTboolT(ref *this.__content);
    Marshal.FreeHGlobal((IntPtr)__content);
    }
    public void assign(VectorTboolT other) {    RLCNative.rl_m_assign__VectorTboolT_VectorTboolT(ref *this.__content, ref *other.__content);
    }

    public void append(bool value){
        RLCNative.rl_m_append__VectorTboolT_bool(ref *this.__content, ref value);
    }

    public bool get(long index){
        bool* __result = null;
        RLCNative.rl_m_get__VectorTboolT_int64_t_r_boolRef(ref __result, ref *this.__content, ref index);
        return * __result;
    }

}

unsafe public class VectorTdoubleT{
    public Content* __content;
    private bool owning;
    [StructLayout(LayoutKind.Sequential)]
    public struct Content {
        private double* _data;
        private long _size;
        private long _capacity;
    }
    public VectorTdoubleT(VectorTdoubleT.Content* referred) {
        owning = false;
        __content = referred;
    }
    public VectorTdoubleT() {
        __content = (VectorTdoubleT.Content*) Marshal.AllocHGlobal(sizeof(VectorTdoubleT.Content));
        owning = true;
        RLCNative.rl_m_init__VectorTdoubleT(ref *this.__content);
    }
    ~VectorTdoubleT() {
        if (!owning)
            return;
            RLCNative.rl_m_drop__VectorTdoubleT(ref *this.__content);
    Marshal.FreeHGlobal((IntPtr)__content);
    }
    public void assign(VectorTdoubleT other) {    RLCNative.rl_m_assign__VectorTdoubleT_VectorTdoubleT(ref *this.__content, ref *other.__content);
    }

    public double pop(){
        double __result = 0;
        RLCNative.rl_m_pop__VectorTdoubleT_r_double(ref __result, ref *this.__content);
        return __result;
    }

    public double get(long index){
        double* __result = null;
        RLCNative.rl_m_get__VectorTdoubleT_int64_t_r_doubleRef(ref __result, ref *this.__content, ref index);
        return * __result;
    }

    public void resize(long new_size){
        RLCNative.rl_m_resize__VectorTdoubleT_int64_t(ref *this.__content, ref new_size);
    }

    public long size(){
        long __result = 0;
        RLCNative.rl_m_size__VectorTdoubleT_r_int64_t(ref __result, ref *this.__content);
        return __result;
    }

    public void append(double value){
        RLCNative.rl_m_append__VectorTdoubleT_double(ref *this.__content, ref value);
    }

}

unsafe public class String{
    public Content* __content;
    private bool owning;
    [StructLayout(LayoutKind.Sequential)]
    public struct Content {
        private VectorTint8_tT.Content _data;
    }
    public String(String.Content* referred) {
        owning = false;
        __content = referred;
    }
    public String() {
        __content = (String.Content*) Marshal.AllocHGlobal(sizeof(String.Content));
        owning = true;
        RLCNative.rl_m_init__String(ref *this.__content);
    }
    ~String() {
        if (!owning)
            return;
            RLCNative.rl_m_drop__String(ref *this.__content);
    Marshal.FreeHGlobal((IntPtr)__content);
    }
    public void assign(String other) {    RLCNative.rl_m_assign__String_String(ref *this.__content, ref *other.__content);
    }

    public void drop_back(long quantity){
        RLCNative.rl_m_drop_back__String_int64_t(ref *this.__content, ref quantity);
    }

    public bool equal(char* other){
        bool __result = false;
        RLCNative.rl_m_equal__String_strlit_r_bool(ref __result, ref *this.__content, ref other);
        return __result;
    }

    public bool not_equal(String other){
        bool __result = false;
        RLCNative.rl_m_not_equal__String_String_r_bool(ref __result, ref *this.__content, ref *other.__content);
        return __result;
    }

    public sbyte back(){
        sbyte* __result = null;
        RLCNative.rl_m_back__String_r_int8_tRef(ref __result, ref *this.__content);
        return * __result;
    }

    public sbyte get(long index){
        sbyte* __result = null;
        RLCNative.rl_m_get__String_int64_t_r_int8_tRef(ref __result, ref *this.__content, ref index);
        return * __result;
    }

    public String add(String other){
        String __result = new String();RLCNative.rl_m_add__String_String_r_String(ref *__result.__content, ref *this.__content, ref *other.__content);
        return __result;
    }

    public long count(sbyte b){
        long __result = 0;
        RLCNative.rl_m_count__String_int8_t_r_int64_t(ref __result, ref *this.__content, ref b);
        return __result;
    }

    public void append_quoted(String str){
        RLCNative.rl_m_append_quoted__String_String(ref *this.__content, ref *str.__content);
    }

    public void append(String str){
        RLCNative.rl_m_append__String_String(ref *this.__content, ref *str.__content);
    }

    public bool equal(String other){
        bool __result = false;
        RLCNative.rl_m_equal__String_String_r_bool(ref __result, ref *this.__content, ref *other.__content);
        return __result;
    }

    public void reverse(){
        RLCNative.rl_m_reverse__String(ref *this.__content);
    }

    public long size(){
        long __result = 0;
        RLCNative.rl_m_size__String_r_int64_t(ref __result, ref *this.__content);
        return __result;
    }

    public bool not_equal(char* other){
        bool __result = false;
        RLCNative.rl_m_not_equal__String_strlit_r_bool(ref __result, ref *this.__content, ref other);
        return __result;
    }

    public bool substring_matches(char* lit, long pos){
        bool __result = false;
        RLCNative.rl_m_substring_matches__String_strlit_int64_t_r_bool(ref __result, ref *this.__content, ref lit, ref pos);
        return __result;
    }

    public void append(char* str){
        RLCNative.rl_m_append__String_strlit(ref *this.__content, ref str);
    }

    public void append(sbyte b){
        RLCNative.rl_m_append__String_int8_t(ref *this.__content, ref b);
    }

    public String to_indented_lines(){
        String __result = new String();RLCNative.rl_m_to_indented_lines__String_r_String(ref *__result.__content, ref *this.__content);
        return __result;
    }

}

unsafe public class VectorTStringT{
    public Content* __content;
    private bool owning;
    [StructLayout(LayoutKind.Sequential)]
    public struct Content {
        private String.Content* _data;
        private long _size;
        private long _capacity;
    }
    public VectorTStringT(VectorTStringT.Content* referred) {
        owning = false;
        __content = referred;
    }
    public VectorTStringT() {
        __content = (VectorTStringT.Content*) Marshal.AllocHGlobal(sizeof(VectorTStringT.Content));
        owning = true;
        RLCNative.rl_m_init__VectorTStringT(ref *this.__content);
    }
    ~VectorTStringT() {
        if (!owning)
            return;
            RLCNative.rl_m_drop__VectorTStringT(ref *this.__content);
    Marshal.FreeHGlobal((IntPtr)__content);
    }
    public void assign(VectorTStringT other) {    RLCNative.rl_m_assign__VectorTStringT_VectorTStringT(ref *this.__content, ref *other.__content);
    }

    public void append(String value){
        RLCNative.rl_m_append__VectorTStringT_String(ref *this.__content, ref *value.__content);
    }

    public String pop(){
        String __result = new String();RLCNative.rl_m_pop__VectorTStringT_r_String(ref *__result.__content, ref *this.__content);
        return __result;
    }

    public String get(long index){
        String.Content* __result = null;
        RLCNative.rl_m_get__VectorTStringT_int64_t_r_StringRef(ref __result, ref *this.__content, ref index);
        return new String(__result);
    }

    public long size(){
        long __result = 0;
        RLCNative.rl_m_size__VectorTStringT_r_int64_t(ref __result, ref *this.__content);
        return __result;
    }

}

unsafe public class BIntT0T3T{
    public Content* __content;
    private bool owning;
    [StructLayout(LayoutKind.Sequential)]
    public struct Content {
        public long value;
    }
    public long value { get => __content->value; set => __content->value = value;}

    public BIntT0T3T(BIntT0T3T.Content* referred) {
        owning = false;
        __content = referred;
    }
    public BIntT0T3T() {
        __content = (BIntT0T3T.Content*) Marshal.AllocHGlobal(sizeof(BIntT0T3T.Content));
        owning = true;
        RLCNative.rl_m_init__BIntT0T3T(ref *this.__content);
    }
    ~BIntT0T3T() {
        if (!owning)
            return;
        Marshal.FreeHGlobal((IntPtr)__content);
    }
    public void assign(BIntT0T3T other) {    RLCNative.rl_m_assign__BIntT0T3T_BIntT0T3T(ref *this.__content, ref *other.__content);
    }

}

unsafe public class GameMark{
    public Content* __content;
    private bool owning;
    [StructLayout(LayoutKind.Sequential)]
    public struct Content {
        public BIntT0T3T.Content x;
        public BIntT0T3T.Content y;
    }
    public BIntT0T3T x { get => new BIntT0T3T(&__content->x); set => __content->x = *value.__content;}

    public BIntT0T3T y { get => new BIntT0T3T(&__content->y); set => __content->y = *value.__content;}

    public GameMark(GameMark.Content* referred) {
        owning = false;
        __content = referred;
    }
    public GameMark() {
        __content = (GameMark.Content*) Marshal.AllocHGlobal(sizeof(GameMark.Content));
        owning = true;
        RLCNative.rl_m_init__GameMark(ref *this.__content);
    }
    ~GameMark() {
        if (!owning)
            return;
        Marshal.FreeHGlobal((IntPtr)__content);
    }
    public void assign(GameMark other) {    RLCNative.rl_m_assign__GameMark_GameMark(ref *this.__content, ref *other.__content);
    }

}

unsafe public class AnyGameAction{
    public Content* __content;
    private bool owning;
    [StructLayout(LayoutKind.Explicit)]
    public struct Alternatives {
        [FieldOffset(0)]public GameMark.Content arg0;
    }
    [StructLayout(LayoutKind.Sequential)]
    public struct Content {
    public Alternatives __alternatives;
    public long __active_index;
    }
    public GameMark get_GameMark { get => __content->__active_index== 0 ? new GameMark(&(__content->__alternatives.arg0)) : null;}

    public void assign(GameMark other){
        RLCNative.rl_m_assign__AnyGameAction_GameMark(ref *this.__content, ref *other.__content);
    }

    public AnyGameAction(AnyGameAction.Content* referred) {
        owning = false;
        __content = referred;
    }
    public AnyGameAction() {
        __content = (AnyGameAction.Content*) Marshal.AllocHGlobal(sizeof(AnyGameAction.Content));
        owning = true;
        RLCNative.rl_m_init__AnyGameAction(ref *this.__content);
    }
    ~AnyGameAction() {
        if (!owning)
            return;
        Marshal.FreeHGlobal((IntPtr)__content);
    }
    public void assign(AnyGameAction other) {    RLCNative.rl_m_assign__AnyGameAction_AnyGameAction(ref *this.__content, ref *other.__content);
    }

}

unsafe public class VectorTAnyGameActionT{
    public Content* __content;
    private bool owning;
    [StructLayout(LayoutKind.Sequential)]
    public struct Content {
        private AnyGameAction.Content* _data;
        private long _size;
        private long _capacity;
    }
    public VectorTAnyGameActionT(VectorTAnyGameActionT.Content* referred) {
        owning = false;
        __content = referred;
    }
    public VectorTAnyGameActionT() {
        __content = (VectorTAnyGameActionT.Content*) Marshal.AllocHGlobal(sizeof(VectorTAnyGameActionT.Content));
        owning = true;
        RLCNative.rl_m_init__VectorTAnyGameActionT(ref *this.__content);
    }
    ~VectorTAnyGameActionT() {
        if (!owning)
            return;
            RLCNative.rl_m_drop__VectorTAnyGameActionT(ref *this.__content);
    Marshal.FreeHGlobal((IntPtr)__content);
    }
    public void assign(VectorTAnyGameActionT other) {    RLCNative.rl_m_assign__VectorTAnyGameActionT_VectorTAnyGameActionT(ref *this.__content, ref *other.__content);
    }

    public AnyGameAction get(long index){
        AnyGameAction.Content* __result = null;
        RLCNative.rl_m_get__VectorTAnyGameActionT_int64_t_r_AnyGameActionRef(ref __result, ref *this.__content, ref index);
        return new AnyGameAction(__result);
    }

    public void append(AnyGameAction value){
        RLCNative.rl_m_append__VectorTAnyGameActionT_AnyGameAction(ref *this.__content, ref *value.__content);
    }

    public long size(){
        long __result = 0;
        RLCNative.rl_m_size__VectorTAnyGameActionT_r_int64_t(ref __result, ref *this.__content);
        return __result;
    }

}

unsafe public class VectorTGameMarkT{
    public Content* __content;
    private bool owning;
    [StructLayout(LayoutKind.Sequential)]
    public struct Content {
        private GameMark.Content* _data;
        private long _size;
        private long _capacity;
    }
    public VectorTGameMarkT(VectorTGameMarkT.Content* referred) {
        owning = false;
        __content = referred;
    }
    public VectorTGameMarkT() {
        __content = (VectorTGameMarkT.Content*) Marshal.AllocHGlobal(sizeof(VectorTGameMarkT.Content));
        owning = true;
        RLCNative.rl_m_init__VectorTGameMarkT(ref *this.__content);
    }
    ~VectorTGameMarkT() {
        if (!owning)
            return;
            RLCNative.rl_m_drop__VectorTGameMarkT(ref *this.__content);
    Marshal.FreeHGlobal((IntPtr)__content);
    }
    public void assign(VectorTGameMarkT other) {    RLCNative.rl_m_assign__VectorTGameMarkT_VectorTGameMarkT(ref *this.__content, ref *other.__content);
    }

    public void append(GameMark value){
        RLCNative.rl_m_append__VectorTGameMarkT_GameMark(ref *this.__content, ref *value.__content);
    }

    public long size(){
        long __result = 0;
        RLCNative.rl_m_size__VectorTGameMarkT_r_int64_t(ref __result, ref *this.__content);
        return __result;
    }

    public GameMark get(long index){
        GameMark.Content* __result = null;
        RLCNative.rl_m_get__VectorTGameMarkT_int64_t_r_GameMarkRef(ref __result, ref *this.__content, ref index);
        return new GameMark(__result);
    }

}

unsafe public class VectorTBIntT0T3TT{
    public Content* __content;
    private bool owning;
    [StructLayout(LayoutKind.Sequential)]
    public struct Content {
        private BIntT0T3T.Content* _data;
        private long _size;
        private long _capacity;
    }
    public VectorTBIntT0T3TT(VectorTBIntT0T3TT.Content* referred) {
        owning = false;
        __content = referred;
    }
    public VectorTBIntT0T3TT() {
        __content = (VectorTBIntT0T3TT.Content*) Marshal.AllocHGlobal(sizeof(VectorTBIntT0T3TT.Content));
        owning = true;
        RLCNative.rl_m_init__VectorTBIntT0T3TT(ref *this.__content);
    }
    ~VectorTBIntT0T3TT() {
        if (!owning)
            return;
            RLCNative.rl_m_drop__VectorTBIntT0T3TT(ref *this.__content);
    Marshal.FreeHGlobal((IntPtr)__content);
    }
    public void assign(VectorTBIntT0T3TT other) {    RLCNative.rl_m_assign__VectorTBIntT0T3TT_VectorTBIntT0T3TT(ref *this.__content, ref *other.__content);
    }

    public BIntT0T3T get(long index){
        BIntT0T3T.Content* __result = null;
        RLCNative.rl_m_get__VectorTBIntT0T3TT_int64_t_r_BIntT0T3TRef(ref __result, ref *this.__content, ref index);
        return new BIntT0T3T(__result);
    }

    public void append(BIntT0T3T value){
        RLCNative.rl_m_append__VectorTBIntT0T3TT_BIntT0T3T(ref *this.__content, ref *value.__content);
    }

    public long size(){
        long __result = 0;
        RLCNative.rl_m_size__VectorTBIntT0T3TT_r_int64_t(ref __result, ref *this.__content);
        return __result;
    }

}

unsafe public class Range{
    public Content* __content;
    private bool owning;
    [StructLayout(LayoutKind.Sequential)]
    public struct Content {
        private long _size;
    }
    public Range(Range.Content* referred) {
        owning = false;
        __content = referred;
    }
    public Range() {
        __content = (Range.Content*) Marshal.AllocHGlobal(sizeof(Range.Content));
        owning = true;
        RLCNative.rl_m_init__Range(ref *this.__content);
    }
    ~Range() {
        if (!owning)
            return;
        Marshal.FreeHGlobal((IntPtr)__content);
    }
    public void assign(Range other) {    RLCNative.rl_m_assign__Range_Range(ref *this.__content, ref *other.__content);
    }

    public long size(){
        long __result = 0;
        RLCNative.rl_m_size__Range_r_int64_t(ref __result, ref *this.__content);
        return __result;
    }

    public void set_size(long new_size){
        RLCNative.rl_m_set_size__Range_int64_t(ref *this.__content, ref new_size);
    }

    public long get(long i){
        long __result = 0;
        RLCNative.rl_m_get__Range_int64_t_r_int64_t(ref __result, ref *this.__content, ref i);
        return __result;
    }

}

public unsafe class BIntT0T3T_9{
    public Content* __content;
    private bool owning;
    [StructLayout(LayoutKind.Sequential)]
    public struct Content {
        public fixed byte __content[72];
        }

        public BIntT0T3T this [int index] {
        get {
        if ((((uint) index) >= 9)) throw new ArgumentOutOfRangeException(nameof(index));
        return 
        new BIntT0T3T((((BIntT0T3T.Content*) __content) + index));}
        }
        public BIntT0T3T_9(BIntT0T3T_9.Content* referred) {
            owning = false;
            __content = referred;
        }
        public BIntT0T3T_9() {
            __content = (BIntT0T3T_9.Content*) Marshal.AllocHGlobal(sizeof(BIntT0T3T_9.Content));
            owning = true;
            }
        ~BIntT0T3T_9() {
            if (!owning)
                return;
            Marshal.FreeHGlobal((IntPtr)__content);
        }
    }

unsafe public class Board{
    public Content* __content;
    private bool owning;
    [StructLayout(LayoutKind.Sequential)]
    public struct Content {
        public BIntT0T3T_9.Content slots;
        public bool player_turn;
    }
    public BIntT0T3T_9 slots { get => new BIntT0T3T_9(&__content->slots); set => __content->slots = *value.__content;}

    public bool player_turn { get => __content->player_turn; set => __content->player_turn = value;}

    public Board(Board.Content* referred) {
        owning = false;
        __content = referred;
    }
    public Board() {
        __content = (Board.Content*) Marshal.AllocHGlobal(sizeof(Board.Content));
        owning = true;
        RLCNative.rl_m_init__Board(ref *this.__content);
    }
    ~Board() {
        if (!owning)
            return;
        Marshal.FreeHGlobal((IntPtr)__content);
    }
    public void assign(Board other) {    RLCNative.rl_m_assign__Board_Board(ref *this.__content, ref *other.__content);
    }

    public bool three_in_a_line_player(long player_id){
        bool __result = false;
        RLCNative.rl_m_three_in_a_line_player__Board_int64_t_r_bool(ref __result, ref *this.__content, ref player_id);
        return __result;
    }

    public bool three_in_a_line_player_row(long player_id, long row){
        bool __result = false;
        RLCNative.rl_m_three_in_a_line_player_row__Board_int64_t_int64_t_r_bool(ref __result, ref *this.__content, ref player_id, ref row);
        return __result;
    }

    public bool full(){
        bool __result = false;
        RLCNative.rl_m_full__Board_r_bool(ref __result, ref *this.__content);
        return __result;
    }

    public long current_player(){
        long __result = 0;
        RLCNative.rl_m_current_player__Board_r_int64_t(ref __result, ref *this.__content);
        return __result;
    }

    public void set(long x, long y, long val){
        RLCNative.rl_m_set__Board_int64_t_int64_t_int64_t(ref *this.__content, ref x, ref y, ref val);
    }

    public void next_turn(){
        RLCNative.rl_m_next_turn__Board(ref *this.__content);
    }

    public long get(long x, long y){
        long __result = 0;
        RLCNative.rl_m_get__Board_int64_t_int64_t_r_int64_t(ref __result, ref *this.__content, ref x, ref y);
        return __result;
    }

}

unsafe public class Game{
    public Content* __content;
    private bool owning;
    [StructLayout(LayoutKind.Sequential)]
    public struct Content {
        public long resume_index;
        public Board.Content board;
    }
    public long resume_index { get => __content->resume_index; set => __content->resume_index = value;}

    public Board board { get => new Board(&__content->board); set => __content->board = *value.__content;}

    public Game(Game.Content* referred) {
        owning = false;
        __content = referred;
    }
    public Game() {
        __content = (Game.Content*) Marshal.AllocHGlobal(sizeof(Game.Content));
        owning = true;
        RLCNative.rl_m_init__Game(ref *this.__content);
    }
    ~Game() {
        if (!owning)
            return;
        Marshal.FreeHGlobal((IntPtr)__content);
    }
    public void assign(Game other) {    RLCNative.rl_m_assign__Game_Game(ref *this.__content, ref *other.__content);
    }

    public void mark(BIntT0T3T x, BIntT0T3T y){
        RLCNative.rl_m_mark__Game_BIntT0T3T_BIntT0T3T(ref *this.__content, ref *x.__content, ref *y.__content);
    }

    public bool can_mark(BIntT0T3T x, BIntT0T3T y){
        bool __result = false;
        RLCNative.rl_m_can_mark__Game_BIntT0T3T_BIntT0T3T_r_bool(ref __result, ref *this.__content, ref *x.__content, ref *y.__content);
        return __result;
    }

    public bool is_done(){
        bool __result = false;
        RLCNative.rl_m_is_done__Game_r_bool(ref __result, ref *this.__content);
        return __result;
    }

    }

public unsafe class int8_t_1{
    public Content* __content;
    private bool owning;
    [StructLayout(LayoutKind.Sequential)]
    public struct Content {
        public fixed byte __content[1];
        }

        public ref sbyte this [int index] {
        get {
        if ((((uint) index) >= 1)) throw new ArgumentOutOfRangeException(nameof(index));
        return 
        ref (*(((sbyte*) __content) + index));}
        }
        public int8_t_1(int8_t_1.Content* referred) {
            owning = false;
            __content = referred;
        }
        public int8_t_1() {
            __content = (int8_t_1.Content*) Marshal.AllocHGlobal(sizeof(int8_t_1.Content));
            owning = true;
            }
        ~int8_t_1() {
            if (!owning)
                return;
            Marshal.FreeHGlobal((IntPtr)__content);
        }
    }

public unsafe class int8_t_8{
    public Content* __content;
    private bool owning;
    [StructLayout(LayoutKind.Sequential)]
    public struct Content {
        public fixed byte __content[8];
        }

        public ref sbyte this [int index] {
        get {
        if ((((uint) index) >= 8)) throw new ArgumentOutOfRangeException(nameof(index));
        return 
        ref (*(((sbyte*) __content) + index));}
        }
        public int8_t_8(int8_t_8.Content* referred) {
            owning = false;
            __content = referred;
        }
        public int8_t_8() {
            __content = (int8_t_8.Content*) Marshal.AllocHGlobal(sizeof(int8_t_8.Content));
            owning = true;
            }
        ~int8_t_8() {
            if (!owning)
                return;
            Marshal.FreeHGlobal((IntPtr)__content);
        }
    }

