#if defined(__arm__)
.text
	.align 3
methods:
	.space 16
	.align 2
Lm_0:
m_Door__ctor:
_m_0:

	.byte 13,192,160,225,128,64,45,233,13,112,160,225,0,89,45,233,8,208,77,226,13,176,160,225,0,0,139,229,0,0,155,229
bl p_1

	.byte 8,208,139,226,0,9,189,232,8,112,157,229,0,160,157,232

Lme_0:
	.align 2
Lm_1:
m_Door_Start:
_m_1:

	.byte 13,192,160,225,128,64,45,233,13,112,160,225,0,89,45,233,96,208,77,226,13,176,160,225,76,0,139,229,76,0,155,229
bl p_2

	.byte 80,0,139,229
bl p_3

	.byte 88,0,139,229,0,74,159,237,0,0,0,234,0,0,0,63,196,74,183,238,0,58,159,237,0,0,0,234,0,0,0,0
	.byte 195,58,183,238,0,42,159,237,0,0,0,234,0,0,48,65,194,42,183,238,0,0,160,227,16,0,139,229,0,0,160,227
	.byte 20,0,139,229,0,0,160,227,24,0,139,229,16,0,139,226,196,11,183,238,2,10,13,237,8,16,29,229,195,11,183,238
	.byte 2,10,13,237,8,32,29,229,194,11,183,238,2,10,13,237,8,48,29,229
bl p_4

	.byte 88,192,155,229,16,0,155,229,52,0,139,229,20,0,155,229,56,0,139,229,24,0,155,229,60,0,139,229,64,0,139,226
	.byte 84,0,139,229,12,16,160,225,52,32,155,229,56,48,155,229,60,0,155,229,0,0,141,229,84,0,155,229,0,224,156,229
bl p_5

	.byte 80,192,155,229,12,0,160,225,64,16,155,229,68,32,155,229,72,48,155,229,0,224,156,229
bl p_6

	.byte 96,208,139,226,0,9,189,232,8,112,157,229,0,160,157,232

Lme_1:
	.align 2
Lm_2:
m_Door_OnTriggerEnter2D_UnityEngine_Collider2D:
_m_2:

	.byte 13,192,160,225,128,64,45,233,13,112,160,225,0,89,45,233,8,208,77,226,13,176,160,225,0,0,139,229,4,16,139,229
	.byte 0,0,159,229,0,0,0,234
	.long mono_aot_Assembly_CSharp_got - . -4
	.byte 0,0,159,231
bl p_7

	.byte 8,208,139,226,0,9,189,232,8,112,157,229,0,160,157,232

Lme_2:
	.align 2
Lm_3:
m_Door_OnTriggerExit2D_UnityEngine_Collider2D:
_m_3:

	.byte 13,192,160,225,128,64,45,233,13,112,160,225,0,89,45,233,8,208,77,226,13,176,160,225,0,0,139,229,4,16,139,229
	.byte 0,0,159,229,0,0,0,234
	.long mono_aot_Assembly_CSharp_got - .
	.byte 0,0,159,231
bl p_7

	.byte 8,208,139,226,0,9,189,232,8,112,157,229,0,160,157,232

Lme_3:
	.align 2
Lm_4:
m_HomeController__ctor:
_m_4:

	.byte 13,192,160,225,128,64,45,233,13,112,160,225,0,89,45,233,8,208,77,226,13,176,160,225,0,0,139,229,0,0,159,229
	.byte 0,0,0,234
	.long mono_aot_Assembly_CSharp_got - . + 4
	.byte 0,0,159,231,0,16,144,229,0,0,155,229,20,16,128,229
bl p_1

	.byte 8,208,139,226,0,9,189,232,8,112,157,229,0,160,157,232

Lme_4:
	.align 2
Lm_5:
m_HomeController_Start:
_m_5:

	.byte 13,192,160,225,128,64,45,233,13,112,160,225,0,89,45,233,8,208,77,226,13,176,160,225,0,0,139,229,0,0,159,229
	.byte 0,0,0,234
	.long mono_aot_Assembly_CSharp_got - . + 8
	.byte 0,0,159,231
bl p_8

	.byte 0,0,80,227,21,0,0,10,0,0,159,229,0,0,0,234
	.long mono_aot_Assembly_CSharp_got - . + 8
	.byte 0,0,159,231
bl p_9

	.byte 0,16,160,225,0,0,159,229,0,0,0,234
	.long mono_aot_Assembly_CSharp_got - . + 12
	.byte 0,0,159,231,0,16,128,229,0,0,159,229,0,0,0,234
	.long mono_aot_Assembly_CSharp_got - . + 16
	.byte 0,0,159,231
bl p_10

	.byte 0,0,159,229,0,0,0,234
	.long mono_aot_Assembly_CSharp_got - . + 20
	.byte 0,0,159,231
bl p_7

	.byte 4,0,0,234,0,0,159,229,0,0,0,234
	.long mono_aot_Assembly_CSharp_got - . + 24
	.byte 0,0,159,231
bl p_7

	.byte 8,208,139,226,0,9,189,232,8,112,157,229,0,160,157,232

Lme_5:
	.align 2
Lm_6:
m_HomeController_Update:
_m_6:

	.byte 13,192,160,225,128,64,45,233,13,112,160,225,0,89,45,233,8,208,77,226,13,176,160,225,0,0,139,229,8,208,139,226
	.byte 0,9,189,232,8,112,157,229,0,160,157,232

Lme_6:
	.align 2
Lm_7:
m_HomeController_OnGUI:
_m_7:

	.byte 13,192,160,225,128,64,45,233,13,112,160,225,0,93,45,233,65,223,77,226,13,176,160,225,0,160,160,225
bl p_11

	.byte 0,16,160,225,0,224,145,229,32,16,144,229,1,0,160,225,0,224,145,229
bl p_12

	.byte 252,0,139,229,112,0,139,226
bl p_13

	.byte 252,192,155,229,12,0,160,225,248,0,139,229,112,16,155,229,116,32,155,229,120,48,155,229,124,0,155,229,0,0,141,229
	.byte 248,0,155,229,0,224,156,229
bl p_14
bl p_11

	.byte 0,16,160,225,0,224,145,229,32,32,144,229,2,0,160,225,1,16,160,227,0,224,146,229
bl p_15
bl p_11

	.byte 0,16,160,225,0,224,145,229,36,32,144,229,2,0,160,225,1,16,160,227,0,224,146,229
bl p_16
bl p_11

	.byte 0,16,160,225,0,224,145,229,32,16,144,229,1,0,160,225,0,224,145,229
bl p_12

	.byte 244,0,139,229,128,0,139,226
bl p_13

	.byte 244,192,155,229,12,0,160,225,240,0,139,229,128,16,155,229,132,32,155,229,136,48,155,229,140,0,155,229,0,0,141,229
	.byte 240,0,155,229,0,224,156,229
bl p_14
bl p_11

	.byte 0,16,160,225,0,224,145,229,32,16,144,229,1,0,160,225,0,224,145,229
bl p_17

	.byte 236,0,139,229,144,0,139,226
bl p_18

	.byte 236,192,155,229,12,0,160,225,232,0,139,229,144,16,155,229,148,32,155,229,152,48,155,229,156,0,155,229,0,0,141,229
	.byte 232,0,155,229,0,224,156,229
bl p_14
bl p_19

	.byte 2,16,160,227
bl p_20

	.byte 100,0,64,226,16,10,0,238,192,10,184,238,192,42,183,238,56,43,139,237
bl p_21

	.byte 2,16,160,227
bl p_20

	.byte 56,91,155,237,16,10,0,238,192,10,184,238,192,74,183,238,0,58,159,237,0,0,0,234,0,0,190,66,195,58,183,238
	.byte 0,42,159,237,0,0,0,234,0,0,240,65,194,42,183,238,0,0,160,227,64,0,139,229,0,0,160,227,68,0,139,229
	.byte 0,0,160,227,72,0,139,229,0,0,160,227,76,0,139,229,64,0,139,226,197,11,183,238,0,10,141,237,0,16,157,229
	.byte 196,11,183,238,0,10,141,237,0,32,157,229,195,11,183,238,0,10,141,237,0,48,157,229,194,11,183,238,0,10,141,237
bl p_22

	.byte 64,0,155,229,160,0,139,229,68,0,155,229,164,0,139,229,72,0,155,229,168,0,139,229,76,0,155,229,172,0,139,229
	.byte 0,192,159,229,0,0,0,234
	.long mono_aot_Assembly_CSharp_got - . + 28
	.byte 12,192,159,231,160,0,155,229,164,16,155,229,168,32,155,229,172,48,155,229,0,192,141,229
bl p_23
bl p_19

	.byte 2,16,160,227
bl p_20

	.byte 16,10,0,238,192,10,184,238,192,42,183,238,54,43,139,237
bl p_21

	.byte 2,16,160,227
bl p_20

	.byte 54,91,155,237,16,10,0,238,192,10,184,238,192,74,183,238,0,58,159,237,0,0,0,234,0,0,72,67,195,58,183,238
	.byte 0,42,159,237,0,0,0,234,0,0,200,65,194,42,183,238,0,0,160,227,80,0,139,229,0,0,160,227,84,0,139,229
	.byte 0,0,160,227,88,0,139,229,0,0,160,227,92,0,139,229,80,0,139,226,197,11,183,238,0,10,141,237,0,16,157,229
	.byte 196,11,183,238,0,10,141,237,0,32,157,229,195,11,183,238,0,10,141,237,0,48,157,229,194,11,183,238,0,10,141,237
bl p_22

	.byte 80,0,155,229,176,0,139,229,84,0,155,229,180,0,139,229,88,0,155,229,184,0,139,229,92,0,155,229,188,0,139,229
	.byte 20,192,154,229,176,0,155,229,180,16,155,229,184,32,155,229,188,48,155,229,0,192,141,229,50,192,160,227,4,192,141,229
bl p_24

	.byte 20,0,138,229
bl p_19

	.byte 2,16,160,227
bl p_20

	.byte 210,0,128,226,16,10,0,238,192,10,184,238,192,42,183,238,52,43,139,237
bl p_21

	.byte 2,16,160,227
bl p_20

	.byte 52,91,155,237,16,10,0,238,192,10,184,238,192,74,183,238,0,58,159,237,0,0,0,234,0,0,72,66,195,58,183,238
	.byte 0,42,159,237,0,0,0,234,0,0,240,65,194,42,183,238,0,0,160,227,96,0,139,229,0,0,160,227,100,0,139,229
	.byte 0,0,160,227,104,0,139,229,0,0,160,227,108,0,139,229,96,0,139,226,197,11,183,238,0,10,141,237,0,16,157,229
	.byte 196,11,183,238,0,10,141,237,0,32,157,229,195,11,183,238,0,10,141,237,0,48,157,229,194,11,183,238,0,10,141,237
bl p_22

	.byte 96,0,155,229,192,0,139,229,100,0,155,229,196,0,139,229,104,0,155,229,200,0,139,229,108,0,155,229,204,0,139,229
	.byte 0,192,159,229,0,0,0,234
	.long mono_aot_Assembly_CSharp_got - . + 32
	.byte 12,192,159,231,192,0,155,229,196,16,155,229,200,32,155,229,204,48,155,229,0,192,141,229
bl p_25

	.byte 0,0,80,227,1,0,0,10,10,0,160,225
bl p_26

	.byte 65,223,139,226,0,13,189,232,8,112,157,229,0,160,157,232

Lme_7:
	.align 2
Lm_8:
m_HomeController_GoPressed:
_m_8:

	.byte 13,192,160,225,128,64,45,233,13,112,160,225,0,93,45,233,4,208,77,226,13,176,160,225,0,160,160,225,20,16,154,229
	.byte 10,0,160,225
bl _m_9

	.byte 0,0,80,227,12,0,0,10,20,0,154,229
bl p_27

	.byte 20,16,154,229,0,0,159,229,0,0,0,234
	.long mono_aot_Assembly_CSharp_got - . + 12
	.byte 0,0,159,231,0,16,128,229,0,0,159,229,0,0,0,234
	.long mono_aot_Assembly_CSharp_got - . + 16
	.byte 0,0,159,231
bl p_10

	.byte 4,208,139,226,0,13,189,232,8,112,157,229,0,160,157,232

Lme_8:
	.align 2
Lm_9:
m_HomeController_isEmailValid_string:
_m_9:

	.byte 13,192,160,225,128,64,45,233,13,112,160,225,0,89,45,233,32,208,77,226,13,176,160,225,24,0,139,229,28,16,139,229
	.byte 0,0,160,227,0,0,203,229,1,0,160,227,0,0,203,229,9,0,0,234,4,0,155,229,0,0,160,227,0,0,203,229
bl p_28

	.byte 20,0,139,229,0,0,80,227,1,0,0,10,20,0,155,229
bl p_29

	.byte 255,255,255,234,0,0,219,229,255,255,255,234,32,208,139,226,0,9,189,232,8,112,157,229,0,160,157,232

Lme_9:
	.align 2
Lm_a:
m_Trash__ctor:
_m_a:

	.byte 13,192,160,225,128,64,45,233,13,112,160,225,0,89,45,233,8,208,77,226,13,176,160,225,0,0,139,229,0,0,155,229
bl p_1

	.byte 8,208,139,226,0,9,189,232,8,112,157,229,0,160,157,232

Lme_a:
	.align 2
Lm_b:
m_Trash_Start:
_m_b:

	.byte 13,192,160,225,128,64,45,233,13,112,160,225,0,89,45,233,8,208,77,226,13,176,160,225,0,0,139,229,8,208,139,226
	.byte 0,9,189,232,8,112,157,229,0,160,157,232

Lme_b:
	.align 2
Lm_c:
m_Trash_Update:
_m_c:

	.byte 13,192,160,225,128,64,45,233,13,112,160,225,0,89,45,233,8,208,77,226,13,176,160,225,0,0,139,229,8,208,139,226
	.byte 0,9,189,232,8,112,157,229,0,160,157,232

Lme_c:
	.align 2
Lm_d:
m_Trash_OnTriggerEnter2D_UnityEngine_Collider2D:
_m_d:

	.byte 13,192,160,225,128,64,45,233,13,112,160,225,0,93,45,233,12,208,77,226,13,176,160,225,4,0,139,229,1,160,160,225
	.byte 10,0,160,225,0,224,154,229
bl p_30

	.byte 0,16,159,229,0,0,0,234
	.long mono_aot_Assembly_CSharp_got - . + 36
	.byte 1,16,159,231,0,224,144,229,1,128,160,225
bl p_31

	.byte 28,0,144,229
bl p_32

	.byte 0,0,159,229,0,0,0,234
	.long mono_aot_Assembly_CSharp_got - . + 40
	.byte 0,0,159,231
bl p_7

	.byte 12,208,139,226,0,13,189,232,8,112,157,229,0,160,157,232

Lme_d:
	.align 2
Lm_f:
m_wrapper_managed_to_native_System_Array_GetGenericValueImpl_int_object_:
_m_f:

	.byte 13,192,160,225,240,95,45,233,120,208,77,226,13,176,160,225,0,0,139,229,4,16,139,229,8,32,139,229
bl p_33

	.byte 16,16,141,226,4,0,129,229,0,32,144,229,0,32,129,229,0,16,128,229,16,208,129,229,15,32,160,225,20,32,129,229
	.byte 0,0,155,229,0,0,80,227,16,0,0,10,0,0,155,229,4,16,155,229,8,32,155,229
bl p_34

	.byte 0,0,159,229,0,0,0,234
	.long mono_aot_Assembly_CSharp_got - . + 44
	.byte 0,0,159,231,0,0,144,229,0,0,80,227,10,0,0,26,16,32,139,226,0,192,146,229,4,224,146,229,0,192,142,229
	.byte 104,208,130,226,240,175,157,232,150,0,160,227,6,12,128,226,2,4,128,226
bl p_35
bl p_29
bl p_36

	.byte 242,255,255,234

Lme_f:
.text
	.align 3
methods_end:
.data
	.align 3
method_addresses:
	.align 2
	.long _m_0
	.align 2
	.long _m_1
	.align 2
	.long _m_2
	.align 2
	.long _m_3
	.align 2
	.long _m_4
	.align 2
	.long _m_5
	.align 2
	.long _m_6
	.align 2
	.long _m_7
	.align 2
	.long _m_8
	.align 2
	.long _m_9
	.align 2
	.long _m_a
	.align 2
	.long _m_b
	.align 2
	.long _m_c
	.align 2
	.long _m_d
	.align 2
	.long 0
	.align 2
	.long _m_f
.text
	.align 3
method_offsets:

	.long Lm_0 - methods,Lm_1 - methods,Lm_2 - methods,Lm_3 - methods,Lm_4 - methods,Lm_5 - methods,Lm_6 - methods,Lm_7 - methods
	.long Lm_8 - methods,Lm_9 - methods,Lm_a - methods,Lm_b - methods,Lm_c - methods,Lm_d - methods,-1,Lm_f - methods

.text
	.align 3
method_info:
mi:
Lm_0_p:

	.byte 0,0
Lm_1_p:

	.byte 0,0
Lm_2_p:

	.byte 0,1,2
Lm_3_p:

	.byte 0,1,3
Lm_4_p:

	.byte 0,1,4
Lm_5_p:

	.byte 0,6,5,5,6,7,8,9
Lm_6_p:

	.byte 0,0
Lm_7_p:

	.byte 0,2,10,11
Lm_8_p:

	.byte 0,2,6,7
Lm_9_p:

	.byte 0,0
Lm_a_p:

	.byte 0,0
Lm_b_p:

	.byte 0,0
Lm_c_p:

	.byte 0,0
Lm_d_p:

	.byte 0,2,12,13
Lm_f_p:

	.byte 0,1,14
.text
	.align 3
method_info_offsets:

	.long Lm_0_p - mi,Lm_1_p - mi,Lm_2_p - mi,Lm_3_p - mi,Lm_4_p - mi,Lm_5_p - mi,Lm_6_p - mi,Lm_7_p - mi
	.long Lm_8_p - mi,Lm_9_p - mi,Lm_a_p - mi,Lm_b_p - mi,Lm_c_p - mi,Lm_d_p - mi,0,Lm_f_p - mi

.text
	.align 3
extra_method_info:

	.byte 0,1,6,83,121,115,116,101,109,46,65,114,114,97,121,58,71,101,116,71,101,110,101,114,105,99,86,97,108,117,101,73
	.byte 109,112,108,32,40,105,110,116,44,111,98,106,101,99,116,38,41,0

.text
	.align 3
extra_method_table:

	.long 11,0,0,0,1,15,0,0
	.long 0,0,0,0,0,0,0,0
	.long 0,0,0,0,0,0,0,0
	.long 0,0,0,0,0,0,0,0
	.long 0,0
.text
	.align 3
extra_method_info_offsets:

	.long 1,15,1
.text
	.align 3
method_order:

	.long 0,16777215,0,1,2,3,4,5
	.long 6,7,8,9,10,11,12,13
	.long 15

.text
method_order_end:
.text
	.align 3
class_name_table:

	.short 11, 1, 0, 2, 11, 3, 0, 0
	.short 0, 0, 0, 0, 0, 0, 0, 0
	.short 0, 0, 0, 0, 0, 0, 0, 4
	.short 0
.text
	.align 3
got_info:

	.byte 12,0,39,17,0,1,17,0,43,16,28,1,42,17,0,83,16,6,2,39,17,0,97,17,0,107,17,0,128,143,17,0
	.byte 128,187,17,0,128,213,34,255,255,0,0,0,0,255,43,0,0,1,17,0,128,219,33,3,195,0,23,185,3,195,0,24
	.byte 92,3,195,0,23,68,3,195,0,18,214,3,195,0,23,56,3,195,0,24,190,3,195,0,23,142,3,195,0,25,69,3
	.byte 195,0,25,68,3,195,0,22,165,3,195,0,14,239,3,195,0,17,93,3,195,0,19,33,3,195,0,17,61,3,195,0
	.byte 17,155,3,195,0,17,146,3,195,0,17,95,3,195,0,19,37,3,195,0,13,161,7,14,95,95,101,109,117,108,95,111
	.byte 112,95,105,100,105,118,0,3,195,0,13,162,3,195,0,19,121,3,195,0,15,12,3,195,0,15,52,3,195,0,15,36
	.byte 3,9,3,194,0,0,44,7,36,109,111,110,111,95,116,104,114,101,97,100,95,103,101,116,95,117,110,100,101,110,105,97
	.byte 98,108,101,95,101,120,99,101,112,116,105,111,110,0,7,25,109,111,110,111,95,97,114,99,104,95,116,104,114,111,119,95
	.byte 101,120,99,101,112,116,105,111,110,0,3,195,0,24,111,3,255,255,0,0,0,0,255,43,0,0,1,3,195,0,24,70
	.byte 7,17,109,111,110,111,95,103,101,116,95,108,109,102,95,97,100,100,114,0,31,255,254,0,0,0,41,1,1,198,0,4
	.byte 3,0,1,1,2,1,7,30,109,111,110,111,95,99,114,101,97,116,101,95,99,111,114,108,105,98,95,101,120,99,101,112
	.byte 116,105,111,110,95,48,0,7,35,109,111,110,111,95,116,104,114,101,97,100,95,105,110,116,101,114,114,117,112,116,105,111
	.byte 110,95,99,104,101,99,107,112,111,105,110,116,0
.text
	.align 3
got_info_offsets:

	.long 0,2,3,6,9,13,16,20
	.long 23,26,30,34,38,50,54
.text
	.align 3
ex_info:
ex:
Le_0_p:

	.byte 52,2,0,0
Le_1_p:

	.byte 129,20,2,26,0
Le_2_p:

	.byte 68,2,0,0
Le_3_p:

	.byte 68,2,0,0
Le_4_p:

	.byte 76,2,0,0
Le_5_p:

	.byte 128,180,2,0,0
Le_6_p:

	.byte 44,2,0,0
Le_7_p:

	.byte 132,92,2,52,0
Le_8_p:

	.byte 116,2,81,0
Le_9_p:

	.byte 116,6,109,1,0,4,1,134,109,1,40,52,52,0
Le_a_p:

	.byte 52,2,0,0
Le_b_p:

	.byte 44,2,0,0
Le_c_p:

	.byte 44,2,0,0
Le_d_p:

	.byte 116,2,128,135,0
Le_f_p:

	.byte 128,172,2,128,163,0
.text
	.align 3
ex_info_offsets:

	.long Le_0_p - ex,Le_1_p - ex,Le_2_p - ex,Le_3_p - ex,Le_4_p - ex,Le_5_p - ex,Le_6_p - ex,Le_7_p - ex
	.long Le_8_p - ex,Le_9_p - ex,Le_a_p - ex,Le_b_p - ex,Le_c_p - ex,Le_d_p - ex,0,Le_f_p - ex

.text
	.align 3
unwind_info:

	.byte 25,12,13,0,76,14,8,135,2,68,14,24,136,6,139,5,140,4,142,3,68,14,32,68,13,11,25,12,13,0,76,14
	.byte 8,135,2,68,14,24,136,6,139,5,140,4,142,3,68,14,120,68,13,11,28,12,13,0,76,14,8,135,2,68,14,28
	.byte 136,7,138,6,139,5,140,4,142,3,68,14,160,2,68,13,11,27,12,13,0,76,14,8,135,2,68,14,28,136,7,138
	.byte 6,139,5,140,4,142,3,68,14,32,68,13,11,25,12,13,0,76,14,8,135,2,68,14,24,136,6,139,5,140,4,142
	.byte 3,68,14,56,68,13,11,27,12,13,0,76,14,8,135,2,68,14,28,136,7,138,6,139,5,140,4,142,3,68,14,40
	.byte 68,13,11,33,12,13,0,72,14,40,132,10,133,9,134,8,135,7,136,6,137,5,138,4,139,3,140,2,142,1,68,14
	.byte 160,1,68,13,11
.text
	.align 3
class_info:
LK_I_0:

	.byte 0,128,144,8,0,0,1
LK_I_1:

	.byte 4,128,144,16,0,0,4,195,0,24,87,195,0,24,59,193,0,0,4,195,0,24,58
LK_I_2:

	.byte 4,128,160,24,0,0,4,195,0,24,87,195,0,24,59,193,0,0,4,195,0,24,58
LK_I_3:

	.byte 4,128,144,16,0,0,4,195,0,24,87,195,0,24,59,193,0,0,4,195,0,24,58
.text
	.align 3
class_info_offsets:

	.long LK_I_0 - class_info,LK_I_1 - class_info,LK_I_2 - class_info,LK_I_3 - class_info


.text
	.align 4
plt:
mono_aot_Assembly_CSharp_plt:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_Assembly_CSharp_got - . + 56,0
p_1:
plt_UnityEngine_MonoBehaviour__ctor:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_Assembly_CSharp_got - . + 60,55
p_2:
plt_UnityEngine_Component_get_transform:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_Assembly_CSharp_got - . + 64,60
p_3:
plt_UnityEngine_Camera_get_main:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_Assembly_CSharp_got - . + 68,65
p_4:
plt_UnityEngine_Vector3__ctor_single_single_single:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_Assembly_CSharp_got - . + 72,70
p_5:
plt_UnityEngine_Camera_ViewportToWorldPoint_UnityEngine_Vector3:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_Assembly_CSharp_got - . + 76,75
p_6:
plt_UnityEngine_Transform_set_position_UnityEngine_Vector3:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_Assembly_CSharp_got - . + 80,80
p_7:
plt_UnityEngine_Debug_Log_object:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_Assembly_CSharp_got - . + 84,85
p_8:
plt_UnityEngine_PlayerPrefs_HasKey_string:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_Assembly_CSharp_got - . + 88,90
p_9:
plt_UnityEngine_PlayerPrefs_GetString_string:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_Assembly_CSharp_got - . + 92,95
p_10:
plt_UnityEngine_Application_LoadLevel_string:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_Assembly_CSharp_got - . + 96,100
p_11:
plt_UnityEngine_GUI_get_skin:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_Assembly_CSharp_got - . + 100,105
p_12:
plt_UnityEngine_GUIStyle_get_normal:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_Assembly_CSharp_got - . + 104,110
p_13:
plt_UnityEngine_Color_get_black:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_Assembly_CSharp_got - . + 108,115
p_14:
plt_UnityEngine_GUIStyleState_set_textColor_UnityEngine_Color:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_Assembly_CSharp_got - . + 112,120
p_15:
plt_UnityEngine_GUIStyle_set_fontStyle_UnityEngine_FontStyle:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_Assembly_CSharp_got - . + 116,125
p_16:
plt_UnityEngine_GUIStyle_set_stretchHeight_bool:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_Assembly_CSharp_got - . + 120,130
p_17:
plt_UnityEngine_GUIStyle_get_hover:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_Assembly_CSharp_got - . + 124,135
p_18:
plt_UnityEngine_Color_get_gray:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_Assembly_CSharp_got - . + 128,140
p_19:
plt_UnityEngine_Screen_get_width:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_Assembly_CSharp_got - . + 132,145
p_20:
plt__jit_icall___emul_op_idiv:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_Assembly_CSharp_got - . + 136,150
p_21:
plt_UnityEngine_Screen_get_height:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_Assembly_CSharp_got - . + 140,167
p_22:
plt_UnityEngine_Rect__ctor_single_single_single_single:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_Assembly_CSharp_got - . + 144,172
p_23:
plt_UnityEngine_GUI_Label_UnityEngine_Rect_string:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_Assembly_CSharp_got - . + 148,177
p_24:
plt_UnityEngine_GUI_TextField_UnityEngine_Rect_string_int:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_Assembly_CSharp_got - . + 152,182
p_25:
plt_UnityEngine_GUI_Button_UnityEngine_Rect_string:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_Assembly_CSharp_got - . + 156,187
p_26:
plt_HomeController_GoPressed:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_Assembly_CSharp_got - . + 160,192
p_27:
plt_Cloud_createUser_string:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_Assembly_CSharp_got - . + 164,194
p_28:
plt__jit_icall_mono_thread_get_undeniable_exception:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_Assembly_CSharp_got - . + 168,199
p_29:
plt__jit_icall_mono_arch_throw_exception:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_Assembly_CSharp_got - . + 172,238
p_30:
plt_UnityEngine_Component_get_gameObject:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_Assembly_CSharp_got - . + 176,266
p_31:
plt_UnityEngine_GameObject_GetComponent_Drag:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_Assembly_CSharp_got - . + 180,271
p_32:
plt_UnityEngine_Object_Destroy_UnityEngine_Object:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_Assembly_CSharp_got - . + 184,283
p_33:
plt__jit_icall_mono_get_lmf_addr:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_Assembly_CSharp_got - . + 188,288
p_34:
plt__icall_native_System_Array_GetGenericValueImpl_object_int_object_:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_Assembly_CSharp_got - . + 192,308
p_35:
plt__jit_icall_mono_create_corlib_exception_0:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_Assembly_CSharp_got - . + 196,326
p_36:
plt__jit_icall_mono_thread_interruption_checkpoint:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_Assembly_CSharp_got - . + 200,359
plt_end:
.text
	.align 3
mono_image_table:

	.long 4
	.asciz "Assembly-CSharp"
	.asciz "4A5CB500-4A1F-49C6-8152-A7CC7AA09AE5"
	.asciz ""
	.asciz ""
	.align 3

	.long 0,0,0,0,0
	.asciz "mscorlib"
	.asciz "F7DE7BB6-83A9-4F92-BD7A-366EC18B3DE9"
	.asciz ""
	.asciz "7cec85d7bea7798e"
	.align 3

	.long 1,2,0,5,0
	.asciz "Assembly-CSharp-firstpass"
	.asciz "A6993DF2-5BCF-47F3-8FC3-774569756F02"
	.asciz ""
	.asciz ""
	.align 3

	.long 0,0,0,0,0
	.asciz "UnityEngine"
	.asciz "59A9B842-1C4D-4240-B57A-EBDA35250FA7"
	.asciz ""
	.asciz ""
	.align 3

	.long 0,0,0,0,0
.data
	.align 3
mono_aot_Assembly_CSharp_got:
	.space 208
got_end:
.data
	.align 3
mono_aot_got_addr:
	.align 2
	.long mono_aot_Assembly_CSharp_got
.data
	.align 3
mono_aot_file_info:

	.long 15,208,37,16,1024,1024,128,0
	.long 0,0,0,0,0
.text
	.align 2
mono_assembly_guid:
	.asciz "4A5CB500-4A1F-49C6-8152-A7CC7AA09AE5"
.text
	.align 2
mono_aot_version:
	.asciz "66"
.text
	.align 2
mono_aot_opt_flags:
	.asciz "55650815"
.text
	.align 2
mono_aot_full_aot:
	.asciz "TRUE"
.text
	.align 2
mono_runtime_version:
	.asciz ""
.text
	.align 2
mono_aot_assembly_name:
	.asciz "Assembly-CSharp"
.text
	.align 3
Lglobals_hash:

	.short 73, 27, 0, 0, 0, 0, 0, 0
	.short 0, 15, 0, 19, 0, 0, 0, 0
	.short 0, 6, 0, 0, 0, 3, 0, 0
	.short 0, 0, 0, 0, 0, 0, 0, 29
	.short 0, 13, 0, 5, 0, 0, 0, 0
	.short 0, 4, 0, 28, 0, 0, 0, 9
	.short 0, 0, 0, 0, 0, 0, 0, 14
	.short 0, 1, 0, 0, 0, 0, 0, 12
	.short 74, 0, 0, 0, 0, 0, 0, 30
	.short 0, 2, 75, 0, 0, 0, 0, 0
	.short 0, 0, 0, 0, 0, 0, 0, 0
	.short 0, 22, 0, 0, 0, 0, 0, 0
	.short 0, 11, 0, 17, 0, 8, 0, 0
	.short 0, 0, 0, 0, 0, 0, 0, 0
	.short 0, 0, 0, 0, 0, 0, 0, 0
	.short 0, 0, 0, 0, 0, 16, 0, 20
	.short 0, 7, 73, 24, 0, 10, 0, 0
	.short 0, 0, 0, 0, 0, 0, 0, 0
	.short 0, 21, 0, 18, 76, 23, 0, 25
	.short 0, 26, 0
.text
	.align 2
name_0:
	.asciz "methods"
.text
	.align 2
name_1:
	.asciz "methods_end"
.text
	.align 2
name_2:
	.asciz "method_addresses"
.text
	.align 2
name_3:
	.asciz "method_offsets"
.text
	.align 2
name_4:
	.asciz "method_info"
.text
	.align 2
name_5:
	.asciz "method_info_offsets"
.text
	.align 2
name_6:
	.asciz "extra_method_info"
.text
	.align 2
name_7:
	.asciz "extra_method_table"
.text
	.align 2
name_8:
	.asciz "extra_method_info_offsets"
.text
	.align 2
name_9:
	.asciz "method_order"
.text
	.align 2
name_10:
	.asciz "method_order_end"
.text
	.align 2
name_11:
	.asciz "class_name_table"
.text
	.align 2
name_12:
	.asciz "got_info"
.text
	.align 2
name_13:
	.asciz "got_info_offsets"
.text
	.align 2
name_14:
	.asciz "ex_info"
.text
	.align 2
name_15:
	.asciz "ex_info_offsets"
.text
	.align 2
name_16:
	.asciz "unwind_info"
.text
	.align 2
name_17:
	.asciz "class_info"
.text
	.align 2
name_18:
	.asciz "class_info_offsets"
.text
	.align 2
name_19:
	.asciz "plt"
.text
	.align 2
name_20:
	.asciz "plt_end"
.text
	.align 2
name_21:
	.asciz "mono_image_table"
.text
	.align 2
name_22:
	.asciz "mono_aot_got_addr"
.text
	.align 2
name_23:
	.asciz "mono_aot_file_info"
.text
	.align 2
name_24:
	.asciz "mono_assembly_guid"
.text
	.align 2
name_25:
	.asciz "mono_aot_version"
.text
	.align 2
name_26:
	.asciz "mono_aot_opt_flags"
.text
	.align 2
name_27:
	.asciz "mono_aot_full_aot"
.text
	.align 2
name_28:
	.asciz "mono_runtime_version"
.text
	.align 2
name_29:
	.asciz "mono_aot_assembly_name"
.data
	.align 3
Lglobals:
	.align 2
	.long Lglobals_hash
	.align 2
	.long name_0
	.align 2
	.long methods
	.align 2
	.long name_1
	.align 2
	.long methods_end
	.align 2
	.long name_2
	.align 2
	.long method_addresses
	.align 2
	.long name_3
	.align 2
	.long method_offsets
	.align 2
	.long name_4
	.align 2
	.long method_info
	.align 2
	.long name_5
	.align 2
	.long method_info_offsets
	.align 2
	.long name_6
	.align 2
	.long extra_method_info
	.align 2
	.long name_7
	.align 2
	.long extra_method_table
	.align 2
	.long name_8
	.align 2
	.long extra_method_info_offsets
	.align 2
	.long name_9
	.align 2
	.long method_order
	.align 2
	.long name_10
	.align 2
	.long method_order_end
	.align 2
	.long name_11
	.align 2
	.long class_name_table
	.align 2
	.long name_12
	.align 2
	.long got_info
	.align 2
	.long name_13
	.align 2
	.long got_info_offsets
	.align 2
	.long name_14
	.align 2
	.long ex_info
	.align 2
	.long name_15
	.align 2
	.long ex_info_offsets
	.align 2
	.long name_16
	.align 2
	.long unwind_info
	.align 2
	.long name_17
	.align 2
	.long class_info
	.align 2
	.long name_18
	.align 2
	.long class_info_offsets
	.align 2
	.long name_19
	.align 2
	.long plt
	.align 2
	.long name_20
	.align 2
	.long plt_end
	.align 2
	.long name_21
	.align 2
	.long mono_image_table
	.align 2
	.long name_22
	.align 2
	.long mono_aot_got_addr
	.align 2
	.long name_23
	.align 2
	.long mono_aot_file_info
	.align 2
	.long name_24
	.align 2
	.long mono_assembly_guid
	.align 2
	.long name_25
	.align 2
	.long mono_aot_version
	.align 2
	.long name_26
	.align 2
	.long mono_aot_opt_flags
	.align 2
	.long name_27
	.align 2
	.long mono_aot_full_aot
	.align 2
	.long name_28
	.align 2
	.long mono_runtime_version
	.align 2
	.long name_29
	.align 2
	.long mono_aot_assembly_name

	.long 0,0
	.globl _mono_aot_module_Assembly_CSharp_info
	.align 3
_mono_aot_module_Assembly_CSharp_info:
	.align 2
	.long Lglobals
.text
	.align 3
mem_end:
#endif
