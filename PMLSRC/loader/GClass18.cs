using System;
using System.Collections.Generic;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Threading;

// Token: 0x02000043 RID: 67
public class GClass18
{
	// Token: 0x06000132 RID: 306 RVA: 0x000035D0 File Offset: 0x000017D0
	public GClass18()
	{
		uint num;
		for (;;)
		{
			IL_00:
			Dictionary<uint, GClass18.Delegate32> dictionary = new Dictionary<uint, GClass18.Delegate32>();
			num = 5U;
			this.dictionary_0 = dictionary;
			for (;;)
			{
				IL_8CE:
				RuntimeTypeHandle handle = typeof(GClass18).TypeHandle;
				num = 930958059U / num;
				Type typeFromHandle = Type.GetTypeFromHandle(handle);
				num *= 1311716096U;
				Module module = typeFromHandle.Module;
				num |= 1543994039U;
				this.module_0 = module;
				num = 1161041413U % num;
				for (;;)
				{
					IL_8B1:
					num = (1607889668U ^ num);
					Stack<GClass18.Class8> stack = new Stack<GClass18.Class8>();
					num += 8803441U;
					this.stack_0 = stack;
					for (;;)
					{
						this.list_0 = new List<GClass18.Class7>();
						num = 1707112681U % num;
						for (;;)
						{
							num |= 1355955600U;
							this.list_1 = new List<GClass18.Class37>();
							num = 901278190U + num;
							this.stack_1 = new Stack<GClass18.Class37>();
							num -= 1517643410U;
							num = (6620546U & num);
							Stack<int> stack2 = new Stack<int>();
							num = (1045965728U & num);
							this.stack_2 = stack2;
							num = (63381241U | num);
							if (num < 6367301U)
							{
								goto IL_8CE;
							}
							num = (1227425519U | num);
							List<IntPtr> list = new List<IntPtr>();
							num &= 456669441U;
							this.list_2 = list;
							if (873427296U < num)
							{
								goto IL_00;
							}
							num >>= 19;
							base..ctor();
							num = 527723431U / num;
							if (2086228109U * num == 0U)
							{
								goto IL_00;
							}
							num &= 1488278187U;
							IntPtr hinstance = Marshal.GetHINSTANCE(this.module_0);
							num = 1395731517U - num;
							this.long_0 = hinstance.ToInt64();
							if (2070510283U < num)
							{
								goto IL_00;
							}
							num = 654119397U >> (int)num;
							Dictionary<uint, GClass18.Delegate32> dictionary2 = this.dictionary_0;
							uint key = num ^ 311U;
							num = (85470295U ^ num);
							GClass18.Delegate32 value = new GClass18.Delegate32(this.method_36);
							num = 1358319263U * num;
							dictionary2[key] = value;
							Dictionary<uint, GClass18.Delegate32> dictionary3 = this.dictionary_0;
							uint key2 = num ^ 571960993U;
							num = 750848607U >> (int)num;
							IntPtr intptr_ = ldftn(method_38);
							num = (812521833U & num);
							dictionary3[key2] = new GClass18.Delegate32(this, intptr_);
							num &= 611976150U;
							Dictionary<uint, GClass18.Delegate32> dictionary4 = this.dictionary_0;
							num = 178812800U % num;
							uint key3 = num - 178812798U;
							num /= 2139566793U;
							IntPtr intptr_2 = ldftn(method_69);
							num = 214000175U << (int)num;
							GClass18.Delegate32 value2 = new GClass18.Delegate32(this, intptr_2);
							num &= 1464360477U;
							dictionary4[key3] = value2;
							if (num * 974455187U == 0U)
							{
								goto IL_8CE;
							}
							Dictionary<uint, GClass18.Delegate32> dictionary5 = this.dictionary_0;
							num = 1805394967U - num;
							dictionary5[num ^ 1734074889U] = new GClass18.Delegate32(this.method_66);
							Dictionary<uint, GClass18.Delegate32> dictionary6 = this.dictionary_0;
							num = 310060097U << (int)num;
							uint key4 = num - 3968926716U;
							num = 55803134U * num;
							num -= 1770657827U;
							dictionary6[key4] = new GClass18.Delegate32(this.method_99);
							num = 1696942257U / num;
							num %= 2001158369U;
							Dictionary<uint, GClass18.Delegate32> dictionary7 = this.dictionary_0;
							uint key5 = num ^ 5U;
							num = (653552316U ^ num);
							IntPtr intptr_3 = ldftn(method_42);
							num = (229843269U & num);
							dictionary7[key5] = new GClass18.Delegate32(this, intptr_3);
							if (407927344U < num)
							{
								break;
							}
							num -= 1509645617U;
							Dictionary<uint, GClass18.Delegate32> dictionary8 = this.dictionary_0;
							num = 941690187U + num;
							uint key6 = num ^ 3805663256U;
							IntPtr intptr_4 = ldftn(method_37);
							num -= 1192233172U;
							dictionary8[key6] = new GClass18.Delegate32(this, intptr_4);
							Dictionary<uint, GClass18.Delegate32> dictionary9 = this.dictionary_0;
							uint key7 = num ^ 2613430093U;
							num = 315129221U * num;
							GClass18.Delegate32 value3 = new GClass18.Delegate32(this.method_104);
							num ^= 308565480U;
							dictionary9[key7] = value3;
							num += 319118709U;
							Dictionary<uint, GClass18.Delegate32> dictionary10 = this.dictionary_0;
							uint key8 = num + 1967039481U;
							num = (1331364497U | num);
							num *= 257780557U;
							GClass18.Delegate32 value4 = new GClass18.Delegate32(this.method_54);
							num = 478491340U - num;
							dictionary10[key8] = value4;
							num |= 154539975U;
							num = 1495223774U >> (int)num;
							Dictionary<uint, GClass18.Delegate32> dictionary11 = this.dictionary_0;
							num >>= 1;
							uint key9 = num - 4294967287U;
							num = 1342639049U + num;
							dictionary11[key9] = new GClass18.Delegate32(this.method_87);
							num += 749868632U;
							num = 90844987U - num;
							Dictionary<uint, GClass18.Delegate32> dictionary12 = this.dictionary_0;
							uint key10 = num ^ 2293304592U;
							num = 1807304988U + num;
							dictionary12[key10] = new GClass18.Delegate32(this.method_53);
							num = 1037258588U << (int)num;
							if (num - 1236106380U == 0U)
							{
								break;
							}
							num = (980361240U | num);
							Dictionary<uint, GClass18.Delegate32> dictionary13 = this.dictionary_0;
							uint key11 = num ^ 4285472787U;
							num <<= 2;
							GClass18.Delegate32 value5 = new GClass18.Delegate32(this.method_95);
							num = (1218340359U & num);
							dictionary13[key11] = value5;
							Dictionary<uint, GClass18.Delegate32> dictionary14 = this.dictionary_0;
							uint key12 = num + 3076784140U;
							num += 564003244U;
							num /= 551111504U;
							GClass18.Delegate32 value6 = new GClass18.Delegate32(this.method_56);
							num = 2061903581U << (int)num;
							dictionary14[key12] = value6;
							num <<= 24;
							Dictionary<uint, GClass18.Delegate32> dictionary15 = this.dictionary_0;
							num %= 915425284U;
							uint key13 = num ^ 230612989U;
							num -= 673989568U;
							IntPtr intptr_5 = ldftn(method_105);
							num = 1799502318U % num;
							GClass18.Delegate32 value7 = new GClass18.Delegate32(this, intptr_5);
							num = 951583888U - num;
							dictionary15[key13] = value7;
							num = 1090673588U << (int)num;
							Dictionary<uint, GClass18.Delegate32> dictionary16 = this.dictionary_0;
							uint key14 = num - 67727042U;
							num |= 486679201U;
							IntPtr intptr_6 = ldftn(method_57);
							num *= 1124224414U;
							dictionary16[key14] = new GClass18.Delegate32(this, intptr_6);
							Dictionary<uint, GClass18.Delegate32> dictionary17 = this.dictionary_0;
							uint key15 = num + 2981169745U;
							num = 8218445U / num;
							GClass18.Delegate32 value8 = new GClass18.Delegate32(this.method_45);
							num = 1519664219U + num;
							dictionary17[key15] = value8;
							if (num < 54006738U)
							{
								goto IL_00;
							}
							Dictionary<uint, GClass18.Delegate32> dictionary18 = this.dictionary_0;
							num = 1936280503U - num;
							uint key16 = num + 3878351028U;
							num = 1985351880U >> (int)num;
							IntPtr intptr_7 = ldftn(method_102);
							num = 839086708U >> (int)num;
							GClass18.Delegate32 value9 = new GClass18.Delegate32(this, intptr_7);
							num = 1390574411U / num;
							dictionary18[key16] = value9;
							num = 401281245U << (int)num;
							Dictionary<uint, GClass18.Delegate32> dictionary19 = this.dictionary_0;
							num = 181040905U / num;
							uint key17 = num ^ 17U;
							num = 1656514306U >> (int)num;
							num += 787429816U;
							IntPtr intptr_8 = ldftn(method_94);
							num >>= 18;
							GClass18.Delegate32 value10 = new GClass18.Delegate32(this, intptr_8);
							num = (1833833927U | num);
							dictionary19[key17] = value10;
							Dictionary<uint, GClass18.Delegate32> dictionary20 = this.dictionary_0;
							uint key18 = num ^ 1833842173U;
							num += 1146030587U;
							GClass18.Delegate32 value11 = new GClass18.Delegate32(this.method_59);
							num = 383463473U * num;
							dictionary20[key18] = value11;
							num -= 1586769721U;
							if (661473955U > num)
							{
								goto IL_8B1;
							}
							num = 1615752040U - num;
							Dictionary<uint, GClass18.Delegate32> dictionary21 = this.dictionary_0;
							num %= 1653346524U;
							uint key19 = num ^ 403926504U;
							num -= 330048031U;
							IntPtr intptr_9 = ldftn(method_60);
							num = 1805593550U % num;
							GClass18.Delegate32 value12 = new GClass18.Delegate32(this, intptr_9);
							num = 1216096992U + num;
							dictionary21[key19] = value12;
							num /= 1822978728U;
							Dictionary<uint, GClass18.Delegate32> dictionary22 = this.dictionary_0;
							uint key20 = num ^ 20U;
							GClass18.Delegate32 value13 = new GClass18.Delegate32(this.method_74);
							num %= 1983718836U;
							dictionary22[key20] = value13;
							num = 1508709084U >> (int)num;
							if (num == 1435989767U)
							{
								goto IL_00;
							}
							Dictionary<uint, GClass18.Delegate32> dictionary23 = this.dictionary_0;
							uint key21 = num ^ 1508709065U;
							GClass18.Delegate32 value14 = new GClass18.Delegate32(this.method_50);
							num = (89019360U | num);
							dictionary23[key21] = value14;
							Dictionary<uint, GClass18.Delegate32> dictionary24 = this.dictionary_0;
							num /= 1267489232U;
							uint key22 = num ^ 23U;
							num = 1574270214U * num;
							IntPtr intptr_10 = ldftn(method_67);
							num = 1468151147U << (int)num;
							dictionary24[key22] = new GClass18.Delegate32(this, intptr_10);
							num >>= 8;
							if (628169780U <= num)
							{
								goto IL_8B1;
							}
							num = (1099826532U ^ num);
							Dictionary<uint, GClass18.Delegate32> dictionary25 = this.dictionary_0;
							uint key23 = num + 3197204441U;
							num = (734662059U | num);
							dictionary25[key23] = new GClass18.Delegate32(this.method_65);
							num += 1956005997U;
							Dictionary<uint, GClass18.Delegate32> dictionary26 = this.dictionary_0;
							num /= 306139879U;
							uint key24 = num - 4294967284U;
							num = (190140942U ^ num);
							num = (966419743U ^ num);
							IntPtr intptr_11 = ldftn(method_47);
							num = 530710745U << (int)num;
							GClass18.Delegate32 value15 = new GClass18.Delegate32(this, intptr_11);
							num <<= 1;
							dictionary26[key24] = value15;
							Dictionary<uint, GClass18.Delegate32> dictionary27 = this.dictionary_0;
							num = (75913291U ^ num);
							uint key25 = num + 3145312206U;
							num = 1115308683U * num;
							IntPtr intptr_12 = ldftn(method_41);
							num += 953824425U;
							GClass18.Delegate32 value16 = new GClass18.Delegate32(this, intptr_12);
							num = 1144796902U / num;
							dictionary27[key25] = value16;
							num >>= 13;
							num *= 1761179868U;
							Dictionary<uint, GClass18.Delegate32> dictionary28 = this.dictionary_0;
							uint key26 = num - 4294967270U;
							num += 1743462451U;
							GClass18.Delegate32 value17 = new GClass18.Delegate32(this.method_9);
							num = 332466446U % num;
							dictionary28[key26] = value17;
							Dictionary<uint, GClass18.Delegate32> dictionary29 = this.dictionary_0;
							uint key27 = num ^ 332466453U;
							IntPtr intptr_13 = ldftn(method_109);
							num = 1261400617U >> (int)num;
							GClass18.Delegate32 value18 = new GClass18.Delegate32(this, intptr_13);
							num = 1002837386U >> (int)num;
							dictionary29[key27] = value18;
							num = (1731227796U ^ num);
							num = 577969849U / num;
							Dictionary<uint, GClass18.Delegate32> dictionary30 = this.dictionary_0;
							num = 1024941023U * num;
							dictionary30[num ^ 28U] = new GClass18.Delegate32(this.method_100);
							num = 2047367806U << (int)num;
							num = (1400126202U & num);
							Dictionary<uint, GClass18.Delegate32> dictionary31 = this.dictionary_0;
							uint key28 = num ^ 1375738471U;
							num = (1716538303U & num);
							dictionary31[key28] = new GClass18.Delegate32(this.method_107);
							num = (977945011U & num);
							num ^= 235681438U;
							Dictionary<uint, GClass18.Delegate32> dictionary32 = this.dictionary_0;
							num *= 380635270U;
							dictionary32[num - 240778730U] = new GClass18.Delegate32(this.method_49);
							num = 193347792U + num;
							if (992370916U >= num)
							{
								goto IL_905;
							}
						}
					}
				}
			}
			IL_905:
			num += 351547937U;
			Dictionary<uint, GClass18.Delegate32> dictionary33 = this.dictionary_0;
			num %= 476334521U;
			uint key29 = num ^ 309339999U;
			num -= 1622964127U;
			num %= 1128930915U;
			GClass18.Delegate32 value19 = new GClass18.Delegate32(this.method_97);
			num = (1778470669U & num);
			dictionary33[key29] = value19;
			num = 1018125328U << (int)num;
			Dictionary<uint, GClass18.Delegate32> dictionary34 = this.dictionary_0;
			uint key30 = num + 2705842208U;
			num = 1350569951U / num;
			dictionary34[key30] = new GClass18.Delegate32(this.method_73);
			Dictionary<uint, GClass18.Delegate32> dictionary35 = this.dictionary_0;
			num /= 875386923U;
			uint key31 = num - 4294967263U;
			num = 1252212216U << (int)num;
			GClass18.Delegate32 value20 = new GClass18.Delegate32(this.method_68);
			num = 1582891158U % num;
			dictionary35[key31] = value20;
			num = (2001615021U ^ num);
			if (num >= 1662678417U)
			{
				Dictionary<uint, GClass18.Delegate32> dictionary36 = this.dictionary_0;
				uint key32 = num - 1694235153U;
				num = (809450759U ^ num);
				num >>= 18;
				GClass18.Delegate32 value21 = new GClass18.Delegate32(this.method_78);
				num &= 1252921571U;
				dictionary36[key32] = value21;
				if (1881287238U >= num)
				{
					Dictionary<uint, GClass18.Delegate32> dictionary37 = this.dictionary_0;
					num = 1699634014U >> (int)num;
					uint key33 = num - 849816972U;
					num /= 740493182U;
					dictionary37[key33] = new GClass18.Delegate32(this.method_81);
					Dictionary<uint, GClass18.Delegate32> dictionary38 = this.dictionary_0;
					num = 748179805U * num;
					uint key34 = num - 748179769U;
					num |= 309211096U;
					dictionary38[key34] = new GClass18.Delegate32(this.method_75);
					if (num * 766659717U != 0U)
					{
						break;
					}
				}
			}
		}
		Dictionary<uint, GClass18.Delegate32> dictionary39 = this.dictionary_0;
		uint key35 = num + 3238101064U;
		num -= 155999249U;
		num &= 1792217677U;
		IntPtr intptr_14 = ldftn(method_86);
		num >>= 0;
		GClass18.Delegate32 value22 = new GClass18.Delegate32(this, intptr_14);
		num <<= 17;
		dictionary39[key35] = value22;
		num = (810163690U & num);
		this.dictionary_0[num - 524250U] = new GClass18.Delegate32(this.method_106);
		num = (1845249170U ^ num);
		Dictionary<uint, GClass18.Delegate32> dictionary40 = this.dictionary_0;
		num >>= 2;
		uint key36 = num ^ 461181187U;
		num = (601626597U | num);
		IntPtr intptr_15 = ldftn(method_88);
		num += 508829548U;
		GClass18.Delegate32 value23 = new GClass18.Delegate32(this, intptr_15);
		num -= 10697676U;
		dictionary40[key36] = value23;
		num = 202662590U << (int)num;
		Dictionary<uint, GClass18.Delegate32> dictionary41 = this.dictionary_0;
		num -= 789529U;
		uint key37 = num ^ 2189446031U;
		num |= 984103380U;
		num = (415238112U | num);
		GClass18.Delegate32 value24 = new GClass18.Delegate32(this.method_83);
		num &= 1189562668U;
		dictionary41[key37] = value24;
		num /= 1069618576U;
		num <<= 25;
		Dictionary<uint, GClass18.Delegate32> dictionary42 = this.dictionary_0;
		uint key38 = num ^ 41U;
		num >>= 30;
		IntPtr intptr_16 = ldftn(method_91);
		num >>= 4;
		dictionary42[key38] = new GClass18.Delegate32(this, intptr_16);
		this.dictionary_0[42U] = new GClass18.Delegate32(this.method_80);
		this.dictionary_0[43U] = new GClass18.Delegate32(this.method_70);
		this.dictionary_0[44U] = new GClass18.Delegate32(this.method_72);
		this.dictionary_0[45U] = new GClass18.Delegate32(this.method_98);
		this.dictionary_0[46U] = new GClass18.Delegate32(this.method_96);
		this.dictionary_0[47U] = new GClass18.Delegate32(this.method_79);
		this.dictionary_0[48U] = new GClass18.Delegate32(this.method_64);
		this.dictionary_0[49U] = new GClass18.Delegate32(this.method_90);
		this.dictionary_0[50U] = new GClass18.Delegate32(this.method_40);
		this.dictionary_0[51U] = new GClass18.Delegate32(this.method_62);
		this.dictionary_0[52U] = new GClass18.Delegate32(this.method_108);
		this.dictionary_0[53U] = new GClass18.Delegate32(this.method_39);
		this.dictionary_0[54U] = new GClass18.Delegate32(this.method_48);
		this.dictionary_0[55U] = new GClass18.Delegate32(this.method_77);
		this.dictionary_0[56U] = new GClass18.Delegate32(this.method_84);
		this.dictionary_0[57U] = new GClass18.Delegate32(this.method_52);
		this.dictionary_0[58U] = new GClass18.Delegate32(this.method_58);
		this.dictionary_0[59U] = new GClass18.Delegate32(this.method_110);
		this.dictionary_0[60U] = new GClass18.Delegate32(this.method_101);
		this.dictionary_0[61U] = new GClass18.Delegate32(this.method_51);
		this.dictionary_0[62U] = new GClass18.Delegate32(this.method_76);
		this.dictionary_0[63U] = new GClass18.Delegate32(this.method_43);
		this.dictionary_0[64U] = new GClass18.Delegate32(this.method_35);
		this.dictionary_0[65U] = new GClass18.Delegate32(this.method_46);
		this.dictionary_0[66U] = new GClass18.Delegate32(this.method_93);
		this.dictionary_0[67U] = new GClass18.Delegate32(this.method_103);
		this.dictionary_0[68U] = new GClass18.Delegate32(this.method_85);
		this.dictionary_0[69U] = new GClass18.Delegate32(this.method_55);
		this.dictionary_0[70U] = new GClass18.Delegate32(this.method_82);
		this.dictionary_0[71U] = new GClass18.Delegate32(this.method_61);
		this.dictionary_0[72U] = new GClass18.Delegate32(this.method_92);
		this.dictionary_0[73U] = new GClass18.Delegate32(this.method_63);
		this.dictionary_0[74U] = new GClass18.Delegate32(this.method_71);
		this.dictionary_0[75U] = new GClass18.Delegate32(this.method_89);
		this.dictionary_0[76U] = new GClass18.Delegate32(this.method_44);
		this.dictionary_0[77U] = new GClass18.Delegate32(this.method_87);
		this.dictionary_0[78U] = new GClass18.Delegate32(this.method_84);
		this.dictionary_0[79U] = new GClass18.Delegate32(this.method_71);
		this.dictionary_0[80U] = new GClass18.Delegate32(this.method_101);
		this.dictionary_0[81U] = new GClass18.Delegate32(this.method_96);
		this.dictionary_0[82U] = new GClass18.Delegate32(this.method_60);
		this.dictionary_0[83U] = new GClass18.Delegate32(this.method_104);
		this.dictionary_0[84U] = new GClass18.Delegate32(this.method_106);
		this.dictionary_0[85U] = new GClass18.Delegate32(this.method_54);
		this.dictionary_0[86U] = new GClass18.Delegate32(this.method_90);
		this.dictionary_0[87U] = new GClass18.Delegate32(this.method_85);
		this.dictionary_0[88U] = new GClass18.Delegate32(this.method_96);
		this.dictionary_0[89U] = new GClass18.Delegate32(this.method_54);
		this.dictionary_0[90U] = new GClass18.Delegate32(this.method_87);
		this.dictionary_0[91U] = new GClass18.Delegate32(this.method_89);
		this.dictionary_0[92U] = new GClass18.Delegate32(this.method_95);
		this.dictionary_0[93U] = new GClass18.Delegate32(this.method_105);
		this.dictionary_0[94U] = new GClass18.Delegate32(this.method_105);
		this.dictionary_0[95U] = new GClass18.Delegate32(this.method_58);
		this.dictionary_0[96U] = new GClass18.Delegate32(this.method_89);
		this.dictionary_0[97U] = new GClass18.Delegate32(this.method_60);
		this.dictionary_0[98U] = new GClass18.Delegate32(this.method_81);
		this.dictionary_0[99U] = new GClass18.Delegate32(this.method_99);
		this.dictionary_0[100U] = new GClass18.Delegate32(this.method_84);
		this.dictionary_0[101U] = new GClass18.Delegate32(this.method_82);
		this.dictionary_0[102U] = new GClass18.Delegate32(this.method_43);
		this.dictionary_0[103U] = new GClass18.Delegate32(this.method_74);
		this.dictionary_0[104U] = new GClass18.Delegate32(this.method_97);
		this.dictionary_0[105U] = new GClass18.Delegate32(this.method_57);
		this.dictionary_0[106U] = new GClass18.Delegate32(this.method_81);
		this.dictionary_0[107U] = new GClass18.Delegate32(this.method_91);
		this.dictionary_0[108U] = new GClass18.Delegate32(this.method_82);
		this.dictionary_0[109U] = new GClass18.Delegate32(this.method_52);
		this.dictionary_0[110U] = new GClass18.Delegate32(this.method_81);
		this.dictionary_0[111U] = new GClass18.Delegate32(this.method_96);
		this.dictionary_0[112U] = new GClass18.Delegate32(this.method_66);
		this.dictionary_0[113U] = new GClass18.Delegate32(this.method_42);
		this.dictionary_0[114U] = new GClass18.Delegate32(this.method_60);
		this.dictionary_0[115U] = new GClass18.Delegate32(this.method_40);
		this.dictionary_0[116U] = new GClass18.Delegate32(this.method_35);
		this.dictionary_0[117U] = new GClass18.Delegate32(this.method_110);
		this.dictionary_0[118U] = new GClass18.Delegate32(this.method_98);
		this.dictionary_0[119U] = new GClass18.Delegate32(this.method_60);
		this.dictionary_0[120U] = new GClass18.Delegate32(this.method_106);
		this.dictionary_0[121U] = new GClass18.Delegate32(this.method_83);
		this.dictionary_0[122U] = new GClass18.Delegate32(this.method_66);
		this.dictionary_0[123U] = new GClass18.Delegate32(this.method_98);
		this.dictionary_0[124U] = new GClass18.Delegate32(this.method_9);
		this.dictionary_0[125U] = new GClass18.Delegate32(this.method_69);
		this.dictionary_0[126U] = new GClass18.Delegate32(this.method_9);
		this.dictionary_0[127U] = new GClass18.Delegate32(this.method_36);
		this.dictionary_0[128U] = new GClass18.Delegate32(this.method_46);
		this.dictionary_0[129U] = new GClass18.Delegate32(this.method_45);
		this.dictionary_0[130U] = new GClass18.Delegate32(this.method_89);
		this.dictionary_0[131U] = new GClass18.Delegate32(this.method_104);
		this.dictionary_0[132U] = new GClass18.Delegate32(this.method_45);
		this.dictionary_0[133U] = new GClass18.Delegate32(this.method_81);
		this.dictionary_0[134U] = new GClass18.Delegate32(this.method_105);
		this.dictionary_0[135U] = new GClass18.Delegate32(this.method_61);
		this.dictionary_0[136U] = new GClass18.Delegate32(this.method_96);
		this.dictionary_0[137U] = new GClass18.Delegate32(this.method_103);
		this.dictionary_0[138U] = new GClass18.Delegate32(this.method_65);
		this.dictionary_0[139U] = new GClass18.Delegate32(this.method_96);
		this.dictionary_0[140U] = new GClass18.Delegate32(this.method_110);
		this.dictionary_0[141U] = new GClass18.Delegate32(this.method_9);
		this.dictionary_0[142U] = new GClass18.Delegate32(this.method_42);
		this.dictionary_0[143U] = new GClass18.Delegate32(this.method_105);
		this.dictionary_0[144U] = new GClass18.Delegate32(this.method_38);
		this.dictionary_0[145U] = new GClass18.Delegate32(this.method_60);
		this.dictionary_0[146U] = new GClass18.Delegate32(this.method_40);
		this.dictionary_0[147U] = new GClass18.Delegate32(this.method_89);
		this.dictionary_0[148U] = new GClass18.Delegate32(this.method_38);
		this.dictionary_0[149U] = new GClass18.Delegate32(this.method_103);
		this.dictionary_0[150U] = new GClass18.Delegate32(this.method_91);
		this.dictionary_0[151U] = new GClass18.Delegate32(this.method_103);
		this.dictionary_0[152U] = new GClass18.Delegate32(this.method_84);
		this.dictionary_0[153U] = new GClass18.Delegate32(this.method_103);
		this.dictionary_0[154U] = new GClass18.Delegate32(this.method_46);
		this.dictionary_0[155U] = new GClass18.Delegate32(this.method_107);
		this.dictionary_0[156U] = new GClass18.Delegate32(this.method_37);
		this.dictionary_0[157U] = new GClass18.Delegate32(this.method_107);
		this.dictionary_0[158U] = new GClass18.Delegate32(this.method_105);
		this.dictionary_0[159U] = new GClass18.Delegate32(this.method_45);
		this.dictionary_0[160U] = new GClass18.Delegate32(this.method_60);
		this.dictionary_0[161U] = new GClass18.Delegate32(this.method_51);
		this.dictionary_0[162U] = new GClass18.Delegate32(this.method_84);
		this.dictionary_0[163U] = new GClass18.Delegate32(this.method_47);
		this.dictionary_0[164U] = new GClass18.Delegate32(this.method_96);
		this.dictionary_0[165U] = new GClass18.Delegate32(this.method_110);
		this.dictionary_0[166U] = new GClass18.Delegate32(this.method_91);
		this.dictionary_0[167U] = new GClass18.Delegate32(this.method_82);
		this.dictionary_0[168U] = new GClass18.Delegate32(this.method_87);
		this.dictionary_0[169U] = new GClass18.Delegate32(this.method_101);
		this.dictionary_0[170U] = new GClass18.Delegate32(this.method_62);
		this.dictionary_0[171U] = new GClass18.Delegate32(this.method_82);
		this.dictionary_0[172U] = new GClass18.Delegate32(this.method_91);
		this.dictionary_0[173U] = new GClass18.Delegate32(this.method_82);
		this.dictionary_0[174U] = new GClass18.Delegate32(this.method_83);
		this.dictionary_0[175U] = new GClass18.Delegate32(this.method_82);
		this.dictionary_0[176U] = new GClass18.Delegate32(this.method_96);
		this.dictionary_0[177U] = new GClass18.Delegate32(this.method_96);
		this.dictionary_0[178U] = new GClass18.Delegate32(this.method_9);
		this.dictionary_0[179U] = new GClass18.Delegate32(this.method_51);
		this.dictionary_0[180U] = new GClass18.Delegate32(this.method_103);
		this.dictionary_0[181U] = new GClass18.Delegate32(this.method_62);
		this.dictionary_0[182U] = new GClass18.Delegate32(this.method_43);
		this.dictionary_0[183U] = new GClass18.Delegate32(this.method_51);
		this.dictionary_0[184U] = new GClass18.Delegate32(this.method_81);
		this.dictionary_0[185U] = new GClass18.Delegate32(this.method_56);
		this.dictionary_0[186U] = new GClass18.Delegate32(this.method_65);
		this.dictionary_0[187U] = new GClass18.Delegate32(this.method_110);
		this.dictionary_0[188U] = new GClass18.Delegate32(this.method_105);
		this.dictionary_0[189U] = new GClass18.Delegate32(this.method_94);
		this.dictionary_0[190U] = new GClass18.Delegate32(this.method_57);
		this.dictionary_0[191U] = new GClass18.Delegate32(this.method_87);
		this.dictionary_0[192U] = new GClass18.Delegate32(this.method_90);
		this.dictionary_0[193U] = new GClass18.Delegate32(this.method_103);
		this.dictionary_0[194U] = new GClass18.Delegate32(this.method_38);
		this.dictionary_0[195U] = new GClass18.Delegate32(this.method_90);
		this.dictionary_0[196U] = new GClass18.Delegate32(this.method_78);
		this.dictionary_0[197U] = new GClass18.Delegate32(this.method_9);
		this.dictionary_0[198U] = new GClass18.Delegate32(this.method_46);
		this.dictionary_0[199U] = new GClass18.Delegate32(this.method_54);
		this.dictionary_0[200U] = new GClass18.Delegate32(this.method_46);
		this.dictionary_0[201U] = new GClass18.Delegate32(this.method_95);
		this.dictionary_0[202U] = new GClass18.Delegate32(this.method_57);
		this.dictionary_0[203U] = new GClass18.Delegate32(this.method_98);
		this.dictionary_0[204U] = new GClass18.Delegate32(this.method_65);
		this.dictionary_0[205U] = new GClass18.Delegate32(this.method_104);
		this.dictionary_0[206U] = new GClass18.Delegate32(this.method_38);
		this.dictionary_0[207U] = new GClass18.Delegate32(this.method_52);
		this.dictionary_0[208U] = new GClass18.Delegate32(this.method_104);
		this.dictionary_0[209U] = new GClass18.Delegate32(this.method_62);
		this.dictionary_0[210U] = new GClass18.Delegate32(this.method_81);
		this.dictionary_0[211U] = new GClass18.Delegate32(this.method_57);
		this.dictionary_0[212U] = new GClass18.Delegate32(this.method_103);
		this.dictionary_0[213U] = new GClass18.Delegate32(this.method_82);
		this.dictionary_0[214U] = new GClass18.Delegate32(this.method_47);
		this.dictionary_0[215U] = new GClass18.Delegate32(this.method_71);
		this.dictionary_0[216U] = new GClass18.Delegate32(this.method_65);
		this.dictionary_0[217U] = new GClass18.Delegate32(this.method_65);
		this.dictionary_0[218U] = new GClass18.Delegate32(this.method_103);
		this.dictionary_0[219U] = new GClass18.Delegate32(this.method_90);
		this.dictionary_0[220U] = new GClass18.Delegate32(this.method_60);
		this.dictionary_0[221U] = new GClass18.Delegate32(this.method_59);
		this.dictionary_0[222U] = new GClass18.Delegate32(this.method_47);
		this.dictionary_0[223U] = new GClass18.Delegate32(this.method_73);
		this.dictionary_0[224U] = new GClass18.Delegate32(this.method_82);
		this.dictionary_0[225U] = new GClass18.Delegate32(this.method_73);
		this.dictionary_0[226U] = new GClass18.Delegate32(this.method_84);
		this.dictionary_0[227U] = new GClass18.Delegate32(this.method_87);
		this.dictionary_0[228U] = new GClass18.Delegate32(this.method_91);
		this.dictionary_0[229U] = new GClass18.Delegate32(this.method_9);
		this.dictionary_0[230U] = new GClass18.Delegate32(this.method_61);
		this.dictionary_0[231U] = new GClass18.Delegate32(this.method_9);
		this.dictionary_0[232U] = new GClass18.Delegate32(this.method_96);
		this.dictionary_0[233U] = new GClass18.Delegate32(this.method_38);
		this.dictionary_0[234U] = new GClass18.Delegate32(this.method_63);
		this.dictionary_0[235U] = new GClass18.Delegate32(this.method_82);
		this.dictionary_0[236U] = new GClass18.Delegate32(this.method_103);
		this.dictionary_0[237U] = new GClass18.Delegate32(this.method_42);
		this.dictionary_0[238U] = new GClass18.Delegate32(this.method_82);
		this.dictionary_0[239U] = new GClass18.Delegate32(this.method_40);
		this.dictionary_0[240U] = new GClass18.Delegate32(this.method_88);
		this.dictionary_0[241U] = new GClass18.Delegate32(this.method_47);
		this.dictionary_0[242U] = new GClass18.Delegate32(this.method_84);
		this.dictionary_0[243U] = new GClass18.Delegate32(this.method_40);
		this.dictionary_0[244U] = new GClass18.Delegate32(this.method_60);
		this.dictionary_0[245U] = new GClass18.Delegate32(this.method_54);
		this.dictionary_0[246U] = new GClass18.Delegate32(this.method_103);
		this.dictionary_0[247U] = new GClass18.Delegate32(this.method_35);
		this.dictionary_0[248U] = new GClass18.Delegate32(this.method_60);
		this.dictionary_0[249U] = new GClass18.Delegate32(this.method_81);
		this.dictionary_0[250U] = new GClass18.Delegate32(this.method_38);
		this.dictionary_0[251U] = new GClass18.Delegate32(this.method_75);
		this.dictionary_0[252U] = new GClass18.Delegate32(this.method_60);
		this.dictionary_0[253U] = new GClass18.Delegate32(this.method_99);
		this.dictionary_0[254U] = new GClass18.Delegate32(this.method_49);
		this.dictionary_0[255U] = new GClass18.Delegate32(this.method_60);
	}

	// Token: 0x06000133 RID: 307 RVA: 0x000067A0 File Offset: 0x000049A0
	private void method_0(GClass18.Class7 class7_0)
	{
		this.stack_0.Push(class7_0.vmethod_4());
	}

	// Token: 0x06000134 RID: 308 RVA: 0x000067C0 File Offset: 0x000049C0
	private GClass18.Class7 method_1()
	{
		return this.stack_0.Pop();
	}

	// Token: 0x06000135 RID: 309 RVA: 0x000067D8 File Offset: 0x000049D8
	private GClass18.Class7 method_2()
	{
		return this.stack_0.Peek();
	}

	// Token: 0x06000136 RID: 310 RVA: 0x000067F0 File Offset: 0x000049F0
	private byte method_3()
	{
		byte result = Marshal.ReadByte(new IntPtr(this.long_0 + (long)this.int_0));
		this.int_0++;
		return result;
	}

	// Token: 0x06000137 RID: 311 RVA: 0x00006824 File Offset: 0x00004A24
	private short method_4()
	{
		short result = Marshal.ReadInt16(new IntPtr(this.long_0 + (long)this.int_0));
		this.int_0 += 2;
		return result;
	}

	// Token: 0x06000138 RID: 312 RVA: 0x00006858 File Offset: 0x00004A58
	private int method_5()
	{
		int result = Marshal.ReadInt32(new IntPtr(this.long_0 + (long)this.int_0));
		this.int_0 += 4;
		return result;
	}

	// Token: 0x06000139 RID: 313 RVA: 0x0000688C File Offset: 0x00004A8C
	private long method_6()
	{
		long result = Marshal.ReadInt64(new IntPtr(this.long_0 + (long)this.int_0));
		this.int_0 += 8;
		return result;
	}

	// Token: 0x0600013A RID: 314 RVA: 0x000068C0 File Offset: 0x00004AC0
	private float method_7()
	{
		return BitConverter.ToSingle(BitConverter.GetBytes(this.method_5()), 0);
	}

	// Token: 0x0600013B RID: 315 RVA: 0x000068E0 File Offset: 0x00004AE0
	private double method_8()
	{
		return BitConverter.ToDouble(BitConverter.GetBytes(this.method_6()), 0);
	}

	// Token: 0x0600013C RID: 316 RVA: 0x00006900 File Offset: 0x00004B00
	private void method_9()
	{
		uint num = 1574653214U;
		byte b2;
		int num6;
		int num8;
		GClass18.Class37 class2;
		for (;;)
		{
			IL_3AE:
			byte b = this.method_3();
			num |= 1096633703U;
			b2 = b;
			for (;;)
			{
				IL_39C:
				int num2 = this.method_5();
				if ((26367261U ^ num) == 0U)
				{
					break;
				}
				for (;;)
				{
					IL_373:
					num = 1473137382U * num;
					int num3 = this.method_5();
					num |= 1583298226U;
					int num4 = num3;
					if (2119915052U + num == 0U)
					{
						break;
					}
					int num5 = this.method_5();
					num = (1483365890U | num);
					num6 = num5;
					num += 132336398U;
					if (607404627U * num == 0U)
					{
						break;
					}
					for (;;)
					{
						num = (1235690686U | num);
						int num7 = this.method_5();
						num = 1273197484U % num;
						num8 = num7;
						if (num < 1243361337U)
						{
							goto IL_3AE;
						}
						bool flag2;
						int num17;
						for (;;)
						{
							IL_1D8:
							GClass18.Class37 @class = null;
							num |= 1238960072U;
							class2 = @class;
							int num9 = (int)(num ^ 1274771436U);
							num = (487157132U & num);
							int num10 = num9;
							for (;;)
							{
								num = 259018845U << (int)num;
								if (2067282510U / num == 0U)
								{
									goto IL_3AE;
								}
								int num11 = num10;
								num = 1629386617U >> (int)num;
								num |= 1416254354U;
								if (num11 >= this.list_1.Count)
								{
									goto IL_120;
								}
								GClass18.Class37 class3 = this.list_1[num10];
								int num12 = class3.method_0();
								num = 407569873U;
								if (num12 == num2)
								{
									int num13 = class3.method_1();
									num += 2092196502U;
									int num14 = num4;
									num += 2202770794U;
									if (num13 == num14)
									{
										goto Block_4;
									}
								}
								if ((num ^ 1637952967U) == 0U)
								{
									goto IL_1D8;
								}
								int num15 = num10;
								num = 421010963U * num;
								int num16 = num15 + (int)(num ^ 2362961026U);
								num = 1386874999U >> (int)num;
								num10 = num16;
								num += 4273218686U;
							}
							IL_155:
							num = (1065622349U ^ num);
							if (1969183434U < num)
							{
								goto IL_3AE;
							}
							bool flag = class2 != null;
							num = (1284401599U | num);
							if (flag)
							{
								goto IL_340;
							}
							flag2 = (num + 2432798785U != 0U);
							num >>= 15;
							if (num > 560142752U)
							{
								goto IL_3AE;
							}
							int int_ = num2;
							num = 904752771U - num;
							GClass18.Class37 class4 = new GClass18.Class37(int_, num4);
							num = 1907496929U + num;
							class2 = class4;
							num -= 949757534U;
							num17 = (int)(num + 2432531958U);
							if (num <= 1554467424U)
							{
								continue;
							}
							break;
							Block_4:
							num = 2036341647U + num;
							if (281873098U != num)
							{
								GClass18.Class37 class3;
								GClass18.Class37 class5 = class3;
								num = 494149096U << (int)num;
								class2 = class5;
								goto IL_155;
							}
							goto IL_373;
							IL_120:
							num ^= 1745512979U;
							goto IL_155;
						}
						while (680159141 << (int)num != 0)
						{
							int num18 = num17;
							List<GClass18.Class37> list = this.list_1;
							num <<= 18;
							if (num18 < list.Count)
							{
								GClass18.Class37 class37_ = this.list_1[num17];
								int num19 = class2.method_2(class37_);
								int num20 = 0;
								num = 537988125U;
								if (num19 >= num20)
								{
									int num21 = num17;
									num &= 405340582U;
									int num22 = (int)(num ^ 65541U);
									num *= 88567324U;
									int num23 = num21 + num22;
									num %= 1211185364U;
									num17 = num23;
									num ^= 1410006422U;
									continue;
								}
								num >>= 15;
								num *= 1427974190U;
								List<GClass18.Class37> list2 = this.list_1;
								num *= 2132095317U;
								int index = num17;
								num = 179403234U >> (int)num;
								GClass18.Class37 item = class2;
								num &= 263332627U;
								list2.Insert(index, item);
								flag2 = (num - 8978U != 0U);
							}
							else
							{
								num += 4158137107U;
							}
							num = 1194218470U / num;
							if (1699812308U < num)
							{
								goto IL_39C;
							}
							bool flag3 = flag2;
							num = (1901231519U ^ num);
							num ^= 531502505U;
							if (!flag3)
							{
								this.list_1.Add(class2);
								num ^= 0U;
								goto IL_340;
							}
							goto IL_340;
						}
						goto IL_3AE;
						IL_340:
						if (85608174U < num)
						{
							goto IL_3C1;
						}
					}
				}
			}
		}
		IL_3C1:
		GClass18.Class37 class6 = class2;
		byte byte_ = b2;
		num = 994533962U + num;
		int int_2 = num6;
		num *= 359812055U;
		int int_3 = num8;
		num ^= 233722373U;
		class6.method_3(byte_, int_2, int_3);
	}

	// Token: 0x0600013D RID: 317 RVA: 0x00006CF8 File Offset: 0x00004EF8
	private TypeCode method_10(GClass18.Class7 class7_0, GClass18.Class7 class7_1)
	{
		uint num = 473200840U;
		TypeCode typeCode2;
		TypeCode typeCode4;
		for (;;)
		{
			IL_25F:
			TypeCode typeCode = class7_0.vmethod_7();
			num = (1370694833U & num);
			typeCode2 = typeCode;
			if (num % 1285294665U == 0U)
			{
				goto IL_386;
			}
			for (;;)
			{
				IL_F3:
				num = 1912625988U * num;
				TypeCode typeCode3 = class7_1.vmethod_7();
				num = 1313694730U + num;
				typeCode4 = typeCode3;
				if (typeCode2 == TypeCode.Empty)
				{
					goto IL_386;
				}
				for (;;)
				{
					TypeCode typeCode5 = typeCode2;
					uint num2 = num ^ 3064169995U;
					num = (287727205U & num);
					num ^= 2793504778U;
					if (typeCode5 == num2)
					{
						goto IL_386;
					}
					num &= 1915625409U;
					bool flag = typeCode4 != TypeCode.Empty;
					num ^= 2223079434U;
					if (!flag)
					{
						goto IL_386;
					}
					if ((810835789U ^ num) == 0U)
					{
						goto IL_25F;
					}
					TypeCode typeCode6 = typeCode4;
					num <<= 29;
					uint num3 = num ^ 1073741825U;
					num -= 1466984860U;
					if (typeCode6 == num3)
					{
						goto Block_3;
					}
					TypeCode typeCode7 = typeCode2;
					uint num4 = num ^ 3901724270U;
					num >>= 25;
					if (typeCode7 == num4)
					{
						goto Block_4;
					}
					num = 1976252341U + num;
					if (1654596909U % num == 0U)
					{
						goto IL_F3;
					}
					if (typeCode4 == (TypeCode)(num - 1976252447U))
					{
						break;
					}
					if (2056002001U == num)
					{
						goto IL_F3;
					}
					if (typeCode2 == (TypeCode)(num ^ 1976252453U))
					{
						goto Block_8;
					}
					if (840328502U / num != 0U)
					{
						goto IL_F3;
					}
					uint num5 = (uint)typeCode4;
					num <<= 4;
					if (num5 == num + 2739699068U)
					{
						goto Block_10;
					}
					if (358361201U < num)
					{
						goto IL_1AB;
					}
				}
				if (1476407330U >> (int)num != 0U)
				{
					goto IL_142;
				}
			}
			Block_4:
			uint num6 = (uint)typeCode4;
			num = 649465413U - num;
			if (num6 != (num ^ 649465304U))
			{
				goto Block_13;
			}
			num = 259337752U - num;
			if ((num ^ 210843008U) != 0U)
			{
				return typeCode2;
			}
			continue;
			IL_142:
			if (typeCode2 != (TypeCode)(num - 1976252448U))
			{
				goto Block_15;
			}
			num = 1259368939U / num;
			if (num / 1595878389U == 0U)
			{
				return typeCode4;
			}
			continue;
			Block_8:
			num >>= 23;
			TypeCode typeCode8 = typeCode4;
			uint num7 = num ^ 226U;
			num ^= 1379542296U;
			if (typeCode8 != num7)
			{
				TypeCode typeCode9 = typeCode4;
				uint num8 = num ^ 1379542520U;
				num ^= 0U;
				if (typeCode9 != num8)
				{
					goto Block_18;
				}
			}
			if (1585920955U != num)
			{
				return typeCode2;
			}
			continue;
			IL_1AB:
			TypeCode typeCode10 = typeCode2;
			num = 2080799196U + num;
			uint num9 = num - 3636067422U;
			num /= 1112219694U;
			if (typeCode10 == num9)
			{
				goto IL_376;
			}
			num <<= 25;
			if (1073379762U / num != 0U)
			{
				uint num10 = (uint)typeCode4;
				num = (1737115883U ^ num);
				if (num10 == num - 1636452573U)
				{
					goto Block_22;
				}
				num = 230769811U + num;
				TypeCode typeCode11 = typeCode2;
				num = 187975366U * num;
				uint num11 = num - 3837256551U;
				num <<= 30;
				if (typeCode11 == num11)
				{
					goto IL_36E;
				}
				num = 1794005438U + num;
				uint num12 = (uint)typeCode4;
				num += 146830561U;
				if (num12 == num + 2354131310U)
				{
					goto Block_24;
				}
				if (1178629030U < num)
				{
					TypeCode typeCode12 = typeCode2;
					uint num13 = num - 1940835988U;
					num *= 74873629U;
					if (typeCode12 == num13)
					{
						goto IL_366;
					}
					if (num > 796344051U)
					{
						goto IL_332;
					}
				}
			}
		}
		Block_3:
		num ^= 1579946094U;
		goto IL_386;
		Block_10:
		num %= 1948020439U;
		TypeCode typeCode13 = typeCode2;
		num += 154871239U;
		uint num14 = num - 1710139470U;
		num >>= 8;
		if (typeCode13 != num14)
		{
			num = 1639910881U - num;
			TypeCode typeCode14 = typeCode2;
			num -= 70213353U;
			uint num15 = num ^ 1563017307U;
			num %= 1768696463U;
			num += 2738630232U;
			if (typeCode14 != num15)
			{
				num = 2022911202U >> (int)num;
				return (TypeCode)(num - 7901996U);
			}
		}
		return typeCode2;
		Block_13:
		return (TypeCode)(num - 649465297U);
		Block_15:
		num += 1952272395U;
		return (TypeCode)(num ^ 3928524852U);
		Block_18:
		num = 269953840U + num;
		return (TypeCode)(num ^ 1649496355U);
		Block_22:
		num ^= 1636452584U;
		goto IL_376;
		Block_24:
		num += 2354131297U;
		goto IL_36E;
		IL_332:
		TypeCode typeCode15 = typeCode4;
		num += 789675521U;
		uint num16 = num ^ 7293711U;
		num -= 762271836U;
		if (typeCode15 != num16)
		{
			num = 645615868U + num;
			return (TypeCode)(num ^ 4185605037U);
		}
		num ^= 60964779U;
		IL_366:
		return (TypeCode)(num ^ 3512585480U);
		IL_36E:
		return (TypeCode)(num ^ 13U);
		IL_376:
		num -= 769551932U;
		return (TypeCode)(num ^ 3525415369U);
		IL_386:
		num = 721714434U >> (int)num;
		return (TypeCode)(num - 704799U);
	}

	// Token: 0x0600013E RID: 318 RVA: 0x000070A0 File Offset: 0x000052A0
	private unsafe GClass18.Class7 method_11(GClass18.Class7 class7_0, GClass18.Class7 class7_1, bool bool_0, bool bool_1)
	{
		uint num = 847909835U;
		ulong num12;
		float num15;
		float num16;
		ulong num18;
		GClass18.Class15 class4;
		IntPtr intPtr2;
		long num28;
		long num30;
		long value2;
		int num44;
		double num46;
		double num47;
		do
		{
			IL_7D4:
			num /= 79630928U;
			TypeCode typeCode = this.method_10(class7_0, class7_1);
			num -= 721104844U;
			if (num >= 2119327465U)
			{
				int value;
				long num13;
				long num14;
				for (;;)
				{
					TypeCode typeCode2 = typeCode;
					uint num2 = num - 3573862453U;
					num *= 2014776430U;
					switch (typeCode2 - num2)
					{
					case 0:
					{
						num = 647710480U << (int)num;
						if (bool_1)
						{
							goto IL_306;
						}
						num = 1739926359U << (int)num;
						int num3 = class7_0.DE119705();
						num *= 1317428992U;
						int num4 = num3;
						num = (1974539037U & num);
						num |= 412838916U;
						int num5 = class7_1.DE119705();
						num = (672365499U & num);
						if (num >= 1222923616U)
						{
							continue;
						}
						goto IL_322;
					}
					case 1:
					{
						num = 1742491615U + num;
						if ((1729520533U ^ num) == 0U)
						{
							goto IL_7D4;
						}
						if (!bool_1)
						{
							goto IL_368;
						}
						num = 1108609443U << (int)num;
						if (538142437U <= num)
						{
							goto IL_6B5;
						}
						num += 176370202U;
						uint num6 = class7_0.vmethod_10();
						num = 641746778U / num;
						uint num7 = num6;
						if ((1981883902U ^ num) == 0U)
						{
							continue;
						}
						uint num8 = class7_1.vmethod_10();
						num = 879756527U / num;
						uint num9 = num8;
						num *= 1741836263U;
						int num10;
						if (!bool_0)
						{
							num = (2036220826U | num);
							num10 = (int)(num7 + num9);
						}
						else
						{
							if ((num & 854617752U) == 0U)
							{
								goto IL_7D4;
							}
							int num11 = (int)num7;
							num = 1845363460U / num;
							num10 = checked(num11 + (int)num9);
							num ^= 2147383231U;
						}
						value = num10;
						if ((num & 248933055U) != 0U)
						{
							goto Block_25;
						}
						continue;
					}
					case 2:
						num -= 6317989U;
						if (!bool_1)
						{
							goto IL_53D;
						}
						if (num < 1698109758U)
						{
							continue;
						}
						num12 = class7_0.vmethod_11();
						num = 661085733U >> (int)num;
						if (647758242U >= num)
						{
							goto Block_18;
						}
						continue;
					case 3:
						num ^= 1267152003U;
						if (1909673436U >= num)
						{
							goto IL_7D4;
						}
						num = 1255176318U - num;
						if (bool_1)
						{
							goto IL_596;
						}
						if (num >> 4 == 0U)
						{
							goto IL_67B;
						}
						num13 = class7_0.E9C7AF34();
						if (1120691237U % num == 0U)
						{
							continue;
						}
						num14 = class7_1.E9C7AF34();
						if (1026042551U == num)
						{
							continue;
						}
						if (bool_0)
						{
							goto IL_61C;
						}
						num -= 959860755U;
						if (1953174654U >= num)
						{
							goto Block_15;
						}
						continue;
					case 4:
					{
						if (1351107758U * num == 0U)
						{
							goto IL_67B;
						}
						num = 553156598U - num;
						GClass18.Class7 @class;
						if (!bool_1)
						{
							num = 1784415431U - num;
							@class = class7_0;
						}
						else
						{
							if (num <= 456600410U)
							{
								goto IL_7D4;
							}
							@class = class7_0.vmethod_5();
							num ^= 1230764583U;
						}
						num15 = @class.vmethod_12();
						num -= 164580806U;
						GClass18.Class7 class2;
						if (!bool_1)
						{
							class2 = class7_1;
						}
						else
						{
							if (1023437814U + num == 0U)
							{
								goto IL_7D4;
							}
							class2 = class7_1.vmethod_5();
							num ^= 0U;
						}
						num16 = class2.vmethod_12();
						num /= 410410753U;
						if (bool_0)
						{
							goto IL_97B;
						}
						if (1092118604U >= num)
						{
							goto Block_8;
						}
						continue;
					}
					case 5:
						goto IL_716;
					}
					goto Block_27;
				}
				Block_18:
				ulong num17 = class7_1.vmethod_11();
				num -= 9832493U;
				num18 = num17;
				num %= 962216886U;
				if (2122468531U == num)
				{
					goto IL_0C;
				}
				if (!bool_0)
				{
					goto IL_85B;
				}
				num = 797524953U % num;
				if ((1046299234U & num) != 0U)
				{
					goto Block_42;
				}
				continue;
				Block_27:
				if (1957905719 << (int)num != 0)
				{
					goto IL_0C;
				}
				continue;
				IL_306:
				num |= 526021589U;
				if (num - 392823201U != 0U)
				{
					goto IL_67B;
				}
				continue;
				IL_368:
				if (863844087U == num)
				{
					goto IL_67B;
				}
				int num19 = class7_0.DE119705();
				num = 361918683U % num;
				int num20 = num19;
				int num21 = class7_1.DE119705();
				num += 19998449U;
				int num22 = num21;
				if (num + 174400594U == 0U)
				{
					continue;
				}
				int num25;
				if (!bool_0)
				{
					if (1707415950U % num == 0U)
					{
						continue;
					}
					int num23 = num20;
					num &= 620509262U;
					int num24 = num22;
					num = 2088646870U >> (int)num;
					num25 = num23 + num24;
				}
				else
				{
					num = 1895256038U - num;
					if (620713300U >> (int)num == 0U)
					{
						goto IL_6B5;
					}
					int num26 = num20;
					num >>= 28;
					num25 = checked(num26 + num22);
					num += 509918U;
				}
				num /= 2117807038U;
				value = num25;
				num += 2147383227U;
				IL_422:
				num = 1049306962U / num;
				if (num >= 1629646731U)
				{
					continue;
				}
				num = (1753512165U & num);
				TypeCode typeCode3 = class7_0.vmethod_7();
				num = 144393517U >> (int)num;
				TypeCode typeCode4 = typeCode;
				num &= 814635761U;
				GClass18.Class15 class3;
				if (typeCode3 != typeCode4)
				{
					num &= 1978472967U;
					num = 560614580U - num;
					class3 = (GClass18.Class15)class7_1;
				}
				else
				{
					if (num == 1466907172U)
					{
						continue;
					}
					num = 570518405U >> (int)num;
					class3 = (GClass18.Class15)class7_0;
					num += 266442481U;
				}
				num *= 1690398610U;
				class4 = class3;
				num |= 2115518002U;
				IntPtr intPtr = new IntPtr(value);
				num <<= 4;
				intPtr2 = intPtr;
				num += 2026585480U;
				if ((1700623314U ^ num) != 0U)
				{
					goto Block_39;
				}
				continue;
				Block_25:
				goto IL_422;
				IL_53D:
				num &= 715919127U;
				long num27 = class7_0.E9C7AF34();
				num /= 114510774U;
				num28 = num27;
				long num29 = class7_1.E9C7AF34();
				num = (1159075424U & num);
				num30 = num29;
				num = (185629173U | num);
				if (!bool_0)
				{
					goto IL_87F;
				}
				num %= 1007842893U;
				if (1521965061U >= num)
				{
					goto Block_44;
				}
				continue;
				IL_596:
				num = (1642750903U ^ num);
				num |= 172716672U;
				ulong num31 = class7_0.vmethod_11();
				ulong num32 = class7_1.vmethod_11();
				num /= 1006662476U;
				if (622800489U == num)
				{
					continue;
				}
				long num35;
				if (!bool_0)
				{
					if (num > 1315529359U)
					{
						goto IL_0C;
					}
					long num33 = (long)num31;
					num = 266610799U - num;
					long num34 = (long)num32;
					num /= 1233923359U;
					num35 = num33 + num34;
				}
				else
				{
					num35 = (long)(checked(num31 + num32));
					num ^= 0U;
				}
				value2 = num35;
				if (35272215U != num)
				{
					goto IL_64C;
				}
				continue;
				IL_61C:
				long num36;
				if (num != 851074808U)
				{
					num36 = checked(num13 + num14);
					num += 3335106541U;
					goto IL_636;
				}
				continue;
				IL_64C:
				TypeCode typeCode5 = class7_0.vmethod_7();
				num = 159861851U << (int)num;
				if (typeCode5 == typeCode)
				{
					goto IL_8E3;
				}
				if (num * 758515878U != 0U)
				{
					goto Block_51;
				}
				continue;
				IL_636:
				num *= 1939747506U;
				value2 = num36;
				num ^= 864779080U;
				goto IL_64C;
				Block_15:
				num36 = num13 + num14;
				goto IL_636;
				IL_67B:
				num = (1041053625U ^ num);
				uint num37 = class7_0.vmethod_10();
				num |= 688994617U;
				uint num38 = num37;
				uint num39 = class7_1.vmethod_10();
				num = (554856788U & num);
				if (1765562242U / num == 0U)
				{
					continue;
				}
				IL_6B5:
				int num42;
				if (!bool_0)
				{
					int num40 = (int)num38;
					int num41 = (int)num39;
					num >>= 28;
					num42 = num40 + num41;
				}
				else
				{
					if (1398621458U == num)
					{
						continue;
					}
					int num43 = (int)num38;
					num = (1224557903U | num);
					num42 = checked(num43 + (int)num39);
					num ^= 1778349405U;
				}
				num44 = num42;
				if (1949786174U == num)
				{
					continue;
				}
				IL_6FA:
				num = 335494261U - num;
				if (453256439U / num != 0U)
				{
					goto Block_54;
				}
				continue;
				IL_322:
				num &= 789589390U;
				int num45;
				if (!bool_0)
				{
					num &= 757230769U;
					int num4;
					int num5;
					num45 = num4 + num5;
				}
				else
				{
					num = (1919176715U & num);
					int num4;
					int num5;
					num45 = checked(num4 + num5);
					num ^= 134227968U;
				}
				num44 = num45;
				num ^= 671098882U;
				goto IL_6FA;
				IL_716:
				if (num / 1678277471U == 0U)
				{
					continue;
				}
				GClass18.Class7 class5;
				if (!bool_1)
				{
					num += 940720635U;
					class5 = class7_0;
				}
				else
				{
					if (97082956U > num)
					{
						continue;
					}
					class5 = class7_0.vmethod_5();
					num ^= 941540923U;
				}
				num46 = class5.BF7BF7B8();
				num = (1982742832U ^ num);
				GClass18.Class7 class6;
				if (!bool_1)
				{
					class6 = class7_1;
				}
				else
				{
					num %= 1383611982U;
					class6 = class7_1.vmethod_5();
					num ^= 3979381948U;
				}
				num = 1621057222U % num;
				num47 = class6.BF7BF7B8();
				num = 1140610106U * num;
				if (909787261U <= num)
				{
					if (!bool_0)
					{
						if ((num & 1403215450U) != 0U)
						{
							goto Block_61;
						}
					}
					else
					{
						num += 231112274U;
						if (num < 792986642U)
						{
							continue;
						}
						goto IL_9C3;
					}
				}
			}
			IL_0C:
			num |= 1929976749U;
		}
		while (2133615891U > num);
		throw new InvalidOperationException();
		Block_8:
		float num48 = num15;
		num = 265558555U * num;
		float float_ = num48 + num16;
		goto IL_9A4;
		Block_39:
		void* ptr = intPtr2.ToPointer();
		num += 2072590221U;
		GClass18.Class7 class7 = class4;
		num |= 179196738U;
		Type type = class7.vmethod_6();
		num = 993141487U << (int)num;
		object object_ = Pointer.Box(ptr, type);
		GClass18.Class7 class8 = class4;
		num = (422589224U & num);
		Type type_ = class8.vmethod_6();
		num = 1849827304U - num;
		return new GClass18.Class15(object_, type_);
		Block_42:
		long num49 = (long)(checked(num12 + num18));
		num += 4235701684U;
		goto IL_87B;
		Block_44:
		long num50 = num28;
		num -= 353062120U;
		long num51 = checked(num50 + num30);
		num += 1435979498U;
		goto IL_8A9;
		Block_51:
		GClass18.Class15 class9 = (GClass18.Class15)class7_1;
		goto IL_90D;
		Block_54:
		int int_ = num44;
		num *= 1725505118U;
		return new GClass18.Class9(int_);
		Block_61:
		double double_ = num46 + num47;
		goto IL_9E4;
		IL_85B:
		num = (855777174U & num);
		num49 = (long)(num12 + num18);
		IL_87B:
		long num52 = num49;
		goto IL_8BF;
		IL_87F:
		long num53 = num28;
		long num54 = num30;
		num = (1099725655U | num);
		num51 = num53 + num54;
		IL_8A9:
		num %= 1579165296U;
		num52 = num51;
		num += 3328412827U;
		IL_8BF:
		num = (2122913010U | num);
		long long_ = num52;
		num = 2103848855U + num;
		return new GClass18.Class10(long_);
		IL_8E3:
		num = 79052464U << (int)num;
		num %= 180562990U;
		class9 = (GClass18.Class15)class7_0;
		num += 4293538389U;
		IL_90D:
		num = (1761900355U & num);
		GClass18.Class15 class10 = class9;
		num %= 1335304445U;
		intPtr2 = new IntPtr(value2);
		num = (190454534U ^ num);
		void* ptr2 = intPtr2.ToPointer();
		Type type2 = class10.vmethod_6();
		num /= 1514605598U;
		object object_2 = Pointer.Box(ptr2, type2);
		GClass18.Class7 class11 = class10;
		num <<= 25;
		return new GClass18.Class15(object_2, class11.vmethod_6());
		IL_97B:
		num = 2145522220U >> (int)num;
		float num55 = num15;
		float num56 = num16;
		num |= 1162675958U;
		float_ = num55 + num56;
		num ^= 1004484142U;
		IL_9A4:
		return new GClass18.Class11(float_);
		IL_9C3:
		double num57 = num46;
		double num58 = num47;
		num = (118645648U | num);
		double_ = num57 + num58;
		num += 3962143006U;
		IL_9E4:
		num ^= 1528118161U;
		return new GClass18.Class12(double_);
	}

	// Token: 0x0600013F RID: 319 RVA: 0x00007AA0 File Offset: 0x00005CA0
	private unsafe GClass18.Class7 method_12(GClass18.Class7 class7_0, GClass18.Class7 class7_1, bool bool_0, bool bool_1)
	{
		uint num;
		int value;
		long num20;
		long num31;
		GClass18.Class15 class2;
		double num39;
		double num40;
		int num42;
		int num43;
		int int_;
		for (;;)
		{
			IL_00:
			TypeCode typeCode = this.method_10(class7_0, class7_1);
			num = 52U;
			int num10;
			int num11;
			for (;;)
			{
				switch (typeCode - (TypeCode)(num ^ 61U))
				{
				case 0:
					break;
				case 1:
					if (bool_1)
					{
						uint num2 = class7_0.vmethod_10();
						num = (969281346U ^ num);
						uint num3 = num2;
						if (num == 1965045104U)
						{
							goto IL_00;
						}
						num = (1989746920U ^ num);
						uint num4 = class7_1.vmethod_10();
						if ((num ^ 701523652U) == 0U)
						{
							goto IL_00;
						}
						int num7;
						if (!bool_0)
						{
							num ^= 1748901401U;
							int num5 = (int)num3;
							int num6 = (int)num4;
							num = 804468517U % num;
							num7 = num5 - num6;
						}
						else
						{
							int num8 = (int)num3;
							num *= 1010057417U;
							int num9 = (int)num4;
							num %= 1308560558U;
							num7 = checked(num8 - num9);
							num += 3537124332U;
						}
						num >>= 21;
						value = num7;
						if (1791376430U - num != 0U)
						{
							goto Block_43;
						}
						continue;
					}
					else
					{
						num = 431498976U + num;
						num10 = class7_0.DE119705();
						num %= 401347782U;
						num11 = class7_1.DE119705();
						num /= 302988574U;
						if (1016209682U <= num)
						{
							continue;
						}
						num >>= 8;
						if (!bool_0)
						{
							if (num != 1474973611U)
							{
								goto Block_46;
							}
							continue;
						}
						else
						{
							num = (699884014U & num);
							if (1402476692U - num == 0U)
							{
								continue;
							}
							goto IL_662;
						}
					}
					break;
				case 2:
					num ^= 1193738741U;
					if (bool_1)
					{
						if ((674324310U ^ num) == 0U)
						{
							goto IL_188;
						}
						num &= 1044412087U;
						ulong num12 = class7_0.vmethod_11();
						num %= 472209460U;
						ulong num13 = num12;
						num = 337145193U - num;
						num = 1949712004U * num;
						ulong num14 = class7_1.vmethod_11();
						num = 417085674U * num;
						ulong num15 = num14;
						long num18;
						if (!bool_0)
						{
							if (num << 16 == 0U)
							{
								goto IL_00;
							}
							long num16 = (long)num13;
							num = 140784686U * num;
							long num17 = (long)num15;
							num = 964194168U * num;
							num18 = num16 - num17;
						}
						else
						{
							long num19 = (long)num13;
							num = 2072867067U % num;
							num18 = checked(num19 - (long)num15);
							num ^= 3446805755U;
						}
						num20 = num18;
						if (num < 555752090U)
						{
							continue;
						}
					}
					else
					{
						num = (932332430U & num);
						if (num - 1203703941U == 0U)
						{
							goto IL_00;
						}
						num = 1437934003U + num;
						long num21 = class7_0.E9C7AF34();
						if ((num & 22248217U) == 0U)
						{
							goto IL_00;
						}
						num ^= 1721065507U;
						long num22 = class7_1.E9C7AF34();
						if (908467375U >= num)
						{
							break;
						}
						long num24;
						if (!bool_0)
						{
							num = 1591823733U + num;
							if (822555389U >= num)
							{
								goto IL_00;
							}
							long num23 = num21;
							num *= 1162231839U;
							num24 = num23 - num22;
						}
						else
						{
							num *= 1464497123U;
							long num25 = num21;
							num <<= 25;
							num24 = checked(num25 - num22);
							num += 1760411675U;
						}
						num20 = num24;
						num += 3994133477U;
					}
					if (2079537721U >> (int)num != 0U)
					{
						goto Block_38;
					}
					break;
				case 3:
				{
					num = 793267721U / num;
					if (bool_1)
					{
						num %= 1285111359U;
						if (937960204 << (int)num == 0)
						{
							goto IL_00;
						}
						ulong num26 = class7_0.vmethod_11();
						num = 24454349U % num;
						if (num > 1499270000U)
						{
							goto IL_00;
						}
						ulong num27 = class7_1.vmethod_11();
						num = 1923494507U << (int)num;
						ulong num28 = num27;
						num = 1396728463U >> (int)num;
						num += 846213363U;
						long num29;
						if (!bool_0)
						{
							num = 609093584U * num;
							num29 = (long)(num26 - num28);
						}
						else
						{
							long num30 = (long)num26;
							num = 1480589597U >> (int)num;
							num29 = checked(num30 - (long)num28);
							num += 63476451U;
						}
						num31 = num29;
						if (2134774569U < num)
						{
							goto IL_00;
						}
					}
					else
					{
						if (num == 2004633472U)
						{
							continue;
						}
						long num32 = class7_0.E9C7AF34();
						num = 844193342U + num;
						long num33 = num32;
						if (85948983U == num)
						{
							goto IL_00;
						}
						long num34 = class7_1.E9C7AF34();
						num = 1546138072U - num;
						long num36;
						if (!bool_0)
						{
							if (681840577U > num)
							{
								continue;
							}
							long num35 = num33;
							num = 1296727458U >> (int)num;
							num36 = num35 - num34;
						}
						else
						{
							num = 1465338739U + num;
							long num37 = num33;
							long num38 = num34;
							num -= 340094543U;
							num36 = checked(num37 - num38);
							num ^= 1811865467U;
						}
						num31 = num36;
						num += 1543986903U;
					}
					if (num >= 1824092054U)
					{
						goto IL_00;
					}
					TypeCode typeCode2 = class7_0.vmethod_7();
					num |= 1217545672U;
					TypeCode typeCode3 = typeCode;
					num += 1321472999U;
					GClass18.Class15 @class;
					if (typeCode2 != typeCode3)
					{
						num /= 930555465U;
						if (num >= 1403482942U)
						{
							continue;
						}
						@class = (GClass18.Class15)class7_1;
					}
					else
					{
						num = (1093209100U ^ num);
						@class = (GClass18.Class15)class7_0;
						num ^= 3933726112U;
					}
					class2 = @class;
					num = (1865034066U | num);
					if (746129038U >> (int)num != 0U)
					{
						goto Block_27;
					}
					continue;
				}
				case 4:
					if (2010527826U - num == 0U)
					{
						goto IL_188;
					}
					if (bool_1)
					{
						goto IL_6B2;
					}
					if (num < 970094476U)
					{
						goto Block_14;
					}
					continue;
				case 5:
				{
					num = 1105941558U << (int)num;
					GClass18.Class7 class3;
					if (!bool_1)
					{
						num = 622937250U - num;
						if (num == 1993697158U)
						{
							goto IL_00;
						}
						class3 = class7_0;
					}
					else
					{
						num |= 1336049557U;
						class3 = class7_0.vmethod_5();
						num += 2447295757U;
					}
					num39 = class3.BF7BF7B8();
					num = 1392593045U - num;
					if (num < 708398130U)
					{
						goto IL_00;
					}
					num += 1798067179U;
					GClass18.Class7 class4;
					if (!bool_1)
					{
						if (1341807849U >= num)
						{
							goto IL_188;
						}
						class4 = class7_1;
					}
					else
					{
						num <<= 5;
						num ^= 37487286U;
						class4 = class7_1.vmethod_5();
						num ^= 1406840488U;
					}
					num = 1910706758U + num;
					num40 = class4.BF7BF7B8();
					num = (1923355817U ^ num);
					if (num - 600968856U != 0U)
					{
						goto Block_5;
					}
					goto IL_188;
				}
				default:
					goto IL_188;
				}
				IL_103:
				while (bool_1)
				{
					num &= 1588818075U;
					if (num < 158484150U)
					{
						goto IL_70A;
					}
				}
				if (num == 784677062U)
				{
					goto IL_00;
				}
				num &= 286341723U;
				int num41 = class7_0.DE119705();
				num = 1848014086U % num;
				num42 = num41;
				if (1356223291U + num == 0U)
				{
					continue;
				}
				num *= 414612921U;
				num43 = class7_1.DE119705();
				num ^= 598744643U;
				if (num / 1398218201U == 0U)
				{
					continue;
				}
				num >>= 28;
				if (!bool_0)
				{
					goto IL_78C;
				}
				if (1725432496U >> (int)num != 0U)
				{
					goto IL_9AB;
				}
				IL_188:
				num = 1132944434U >> (int)num;
				if (294926441U > num)
				{
					goto Block_11;
				}
				goto IL_103;
			}
			IL_67C:
			num |= 1340687445U;
			num = 453058721U / num;
			if (class7_0.vmethod_7() == typeCode)
			{
				goto IL_7BA;
			}
			if ((num & 1047607642U) == 0U)
			{
				goto Block_49;
			}
			continue;
			IL_670:
			int num44;
			value = num44;
			num += 68U;
			goto IL_67C;
			IL_662:
			num44 = checked(num10 - num11);
			num ^= 0U;
			goto IL_670;
			Block_46:
			int num45 = num10;
			num %= 900030990U;
			int num46 = num11;
			num = (1509757173U & num);
			num44 = num45 - num46;
			goto IL_670;
			Block_43:
			goto IL_67C;
			IL_6CC:
			num /= 1055221457U;
			GClass18.Class7 class5;
			float num47 = class5.vmethod_12();
			num >>= 20;
			num += 126575693U;
			if (bool_1)
			{
				goto IL_8C7;
			}
			if (num >> 22 != 0U)
			{
				goto Block_51;
			}
			continue;
			IL_6B2:
			num ^= 1420297590U;
			class5 = class7_0.vmethod_5();
			num += 2874669810U;
			goto IL_6CC;
			Block_14:
			class5 = class7_0;
			goto IL_6CC;
			IL_70A:
			uint num48 = class7_0.vmethod_10();
			num = (483469023U | num);
			num %= 1121602846U;
			uint num49 = class7_1.vmethod_10();
			num <<= 17;
			uint num50 = num49;
			num ^= 1302418149U;
			int num52;
			if (!bool_0)
			{
				num = 1555529582U - num;
				int num51 = (int)num48;
				num = 1570464465U + num;
				num52 = num51 - (int)num50;
			}
			else
			{
				int num53 = (int)num48;
				int num54 = (int)num50;
				num -= 176714223U;
				num52 = checked(num53 - num54);
				num ^= 1336242092U;
			}
			int_ = num52;
			if (388197765U < num)
			{
				goto Block_53;
			}
			continue;
			IL_78C:
			num %= 983849425U;
			if (num - 104166263U != 0U)
			{
				goto Block_54;
			}
		}
		Block_5:
		double double_;
		if (!bool_0)
		{
			double num55 = num39;
			num ^= 1251026138U;
			double_ = num55 - num40;
		}
		else
		{
			num = (375718206U & num);
			double num56 = num39;
			num = 960262430U * num;
			double_ = num56 - num40;
			num += 2470907119U;
		}
		num = 883715783U + num;
		return new GClass18.Class12(double_);
		Block_11:
		throw new InvalidOperationException();
		Block_27:
		long value2 = num31;
		num *= 1963743497U;
		IntPtr intPtr = new IntPtr(value2);
		num += 706618976U;
		IntPtr intPtr2 = intPtr;
		num += 1566390033U;
		num <<= 11;
		void* ptr = intPtr2.ToPointer();
		num += 1251301364U;
		object object_ = Pointer.Box(ptr, class2.vmethod_6());
		num <<= 26;
		return new GClass18.Class15(object_, class2.vmethod_6());
		Block_38:
		long long_ = num20;
		num = 420239111U * num;
		return new GClass18.Class10(long_);
		Block_49:
		num += 930642504U;
		GClass18.Class15 class6 = (GClass18.Class15)class7_1;
		goto IL_7F0;
		Block_51:
		GClass18.Class7 class7 = class7_1;
		goto IL_8E1;
		Block_53:
		goto IL_9E4;
		Block_54:
		int num57 = num42;
		int num58 = num43;
		num *= 1591370321U;
		int num59 = num57 - num58;
		goto IL_9CE;
		IL_7BA:
		num = 1451636299U >> (int)num;
		if (num == 860968476U)
		{
			goto IL_9E4;
		}
		num ^= 1390047896U;
		class6 = (GClass18.Class15)class7_0;
		num += 857486709U;
		IL_7F0:
		GClass18.Class15 class8 = class6;
		num = 1936537492U / num;
		IntPtr intPtr3 = new IntPtr(value);
		num >>= 27;
		intPtr2 = intPtr3;
		num ^= 2090470837U;
		object object_2 = Pointer.Box(intPtr2.ToPointer(), class8.vmethod_6());
		num %= 1152743367U;
		GClass18.Class7 class9 = class8;
		num %= 1304316949U;
		return new GClass18.Class15(object_2, class9.vmethod_6());
		IL_8C7:
		num = 216015613U + num;
		class7 = class7_1.vmethod_5();
		num ^= 333505287U;
		IL_8E1:
		num = (880440306U ^ num);
		float num60 = class7.vmethod_12();
		num <<= 22;
		float float_;
		if (!bool_0)
		{
			num = (1433806171U | num);
			float num47;
			float num61 = num47;
			float num62 = num60;
			num &= 36439126U;
			float_ = num61 - num62;
		}
		else
		{
			num &= 1714622478U;
			float num47;
			float num63 = num47;
			num ^= 325479475U;
			float_ = num63 - num60;
			num ^= 2000840801U;
		}
		num -= 1239112038U;
		return new GClass18.Class11(float_);
		IL_9AB:
		int num64 = num42;
		num = 783551002U % num;
		int num65 = num43;
		num = 935862989U % num;
		num59 = checked(num64 - num65);
		num += 325204345U;
		IL_9CE:
		num -= 764882794U;
		int_ = num59;
		num += 3563619657U;
		IL_9E4:
		return new GClass18.Class9(int_);
	}

	// Token: 0x06000140 RID: 320 RVA: 0x00008498 File Offset: 0x00006698
	private GClass18.Class7 method_13(GClass18.Class7 class7_0, GClass18.Class7 class7_1, bool bool_0, bool bool_1)
	{
		uint num = 1600551621U;
		long num3;
		long num4;
		double num8;
		double num9;
		int int_;
		long long_;
		for (;;)
		{
			IL_3E8:
			num |= 259918789U;
			TypeCode typeCode = this.method_10(class7_0, class7_1);
			for (;;)
			{
				uint num2 = (uint)typeCode;
				num &= 1443702791U;
				switch (num2 - (num - 1443637244U))
				{
				case 0U:
					break;
				case 1U:
				case 3U:
					goto IL_3AF;
				case 2U:
					num += 898530885U;
					if (345903174U > num)
					{
						goto IL_3E8;
					}
					if (bool_1)
					{
						goto IL_30B;
					}
					num3 = class7_0.E9C7AF34();
					num4 = class7_1.E9C7AF34();
					if ((num & 758479485U) != 0U)
					{
						goto Block_25;
					}
					break;
				case 4U:
				{
					if (num << 19 == 0U)
					{
						continue;
					}
					num = 1697326675U - num;
					GClass18.Class7 @class;
					if (!bool_1)
					{
						num = (1471168818U | num);
						@class = class7_0;
					}
					else
					{
						if (num % 1207175407U == 0U)
						{
							goto IL_3E8;
						}
						@class = class7_0.vmethod_5();
						num += 1352663344U;
					}
					float num5 = @class.vmethod_12();
					num = 518157652U - num;
					float num6 = num5;
					num ^= 82854938U;
					num %= 987512954U;
					if (!bool_1)
					{
						if (1677753866U > num)
						{
							goto IL_3AC;
						}
					}
					else
					{
						if (1187936442U != num)
						{
							goto Block_22;
						}
						continue;
					}
					break;
				}
				case 5U:
				{
					num = 1490292787U >> (int)num;
					if (num - 2028093518U == 0U)
					{
						goto IL_3E8;
					}
					GClass18.Class7 class2;
					if (!bool_1)
					{
						if ((1072574246U ^ num) == 0U)
						{
							goto IL_3E8;
						}
						class2 = class7_0;
					}
					else
					{
						num = (1058685115U & num);
						if (83230986U <= num)
						{
							continue;
						}
						class2 = class7_0.vmethod_5();
						num ^= 12886016U;
					}
					double num7 = class2.BF7BF7B8();
					num = (486106386U | num);
					num8 = num7;
					num = (1470260273U & num);
					GClass18.Class7 class3;
					if (!bool_1)
					{
						class3 = class7_1;
					}
					else
					{
						num <<= 13;
						class3 = class7_1.vmethod_5();
						num ^= 1512064017U;
					}
					num = 1102905359U % num;
					num9 = class3.BF7BF7B8();
					num = 2049069216U + num;
					if (bool_0)
					{
						goto IL_475;
					}
					if (1095266154U <= num)
					{
						goto Block_7;
					}
					continue;
				}
				default:
					if ((1269396450U & num) != 0U)
					{
						goto Block_26;
					}
					break;
				}
				num = 1636526755U + num;
				if ((1385779202U ^ num) == 0U)
				{
					goto IL_3AF;
				}
				num >>= 31;
				if (bool_1)
				{
					num += 1387223452U;
				}
				else
				{
					num |= 283784154U;
					if (309399218 << (int)num == 0)
					{
						goto IL_3E8;
					}
					int num10 = class7_0.DE119705();
					num = 1336818124U + num;
					int num11 = num10;
					num &= 1118897253U;
					if (num >> 22 == 0U)
					{
						continue;
					}
					int num12 = class7_1.DE119705();
					if ((num ^ 1942566073U) != 0U)
					{
						num = 391788540U / num;
						int num14;
						if (!bool_0)
						{
							num &= 229665017U;
							int num13 = num11;
							num >>= 30;
							num14 = num13 * num12;
						}
						else
						{
							num &= 2078954509U;
							int num15 = num11;
							num = (21365632U ^ num);
							int num16 = num12;
							num ^= 400522497U;
							num14 = checked(num15 * num16);
							num ^= 379158145U;
						}
						int_ = num14;
						num += 2021092087U;
						goto IL_266;
					}
					goto IL_3E8;
				}
				IL_1F9:
				uint num17 = class7_0.vmethod_10();
				num = 403375612U - num;
				if (num % 773394556U == 0U)
				{
					continue;
				}
				uint num18 = class7_1.vmethod_10();
				int num20;
				if (!bool_0)
				{
					num -= 1292518281U;
					if (1712478296U == num)
					{
						goto IL_3E8;
					}
					int num19 = (int)num17;
					num >>= 0;
					num20 = num19 * (int)num18;
				}
				else
				{
					num += 1968247951U;
					int num21 = (int)num17;
					int num22 = (int)num18;
					num &= 1300513412U;
					num20 = checked(num21 * num22);
					num += 1875716178U;
				}
				num = (1751542321U | num);
				int_ = num20;
				IL_266:
				num += 1347292014U;
				if (2030326826U < num)
				{
					goto Block_21;
				}
				goto IL_1F9;
			}
			IL_30B:
			num = 725689974U - num;
			num = 1471102594U >> (int)num;
			ulong num23 = class7_0.vmethod_11();
			ulong num24 = class7_1.vmethod_11();
			num /= 508639598U;
			ulong num25 = num24;
			num <<= 23;
			num &= 669396517U;
			long num27;
			if (!bool_0)
			{
				num = (1513774172U & num);
				long num26 = (long)num23;
				num ^= 1400394104U;
				num27 = num26 * (long)num25;
			}
			else
			{
				long num28 = (long)num23;
				num = (1769627144U ^ num);
				long num29 = (long)num25;
				num -= 1764430262U;
				num27 = checked(num28 * num29);
				num ^= 1396120874U;
			}
			long_ = num27;
			if (93194329 << (int)num != 0)
			{
				goto Block_29;
			}
			continue;
			Block_25:
			num = 2021857817U + num;
			if (!bool_0)
			{
				goto IL_3FF;
			}
			if (1302419190U / num != 0U)
			{
				goto Block_31;
			}
			continue;
			IL_3AF:
			if (1645949801U != num)
			{
				goto Block_32;
			}
			continue;
			Block_26:
			num += 0U;
			goto IL_3AF;
			IL_3C7:
			num %= 2147183787U;
			GClass18.Class7 class4;
			float num30 = class4.vmethod_12();
			num = 1817252987U - num;
			if (949886351U != num)
			{
				goto Block_33;
			}
			continue;
			IL_3AC:
			class4 = class7_1;
			goto IL_3C7;
			Block_22:
			class4 = class7_1.vmethod_5();
			num += 0U;
			goto IL_3C7;
		}
		Block_7:
		double num31 = num8;
		num %= 362705737U;
		double double_ = num31 * num9;
		goto IL_489;
		Block_21:
		return new GClass18.Class9(int_);
		Block_29:
		goto IL_41B;
		Block_31:
		long num32 = checked(num3 * num4);
		num += 0U;
		goto IL_411;
		Block_32:
		throw new InvalidOperationException();
		Block_33:
		double num34;
		if (!bool_0)
		{
			num = (1107915618U & num);
			float num6;
			double num33 = (double)num6;
			num = (817243862U | num);
			float num30;
			num34 = num33 * (double)num30;
		}
		else
		{
			num >>= 22;
			float num6;
			float num30;
			num34 = (double)(num6 * num30);
			num ^= 1890985810U;
		}
		return new GClass18.Class12(num34);
		IL_3FF:
		num32 = num3 * num4;
		IL_411:
		long_ = num32;
		num += 1331335445U;
		IL_41B:
		return new GClass18.Class10(long_);
		IL_475:
		double num35 = num8;
		double num36 = num9;
		num = (1366896345U & num);
		double_ = num35 * num36;
		num ^= 217832542U;
		IL_489:
		return new GClass18.Class12(double_);
	}

	// Token: 0x06000141 RID: 321 RVA: 0x00008934 File Offset: 0x00006B34
	private GClass18.Class7 method_14(GClass18.Class7 class7_0, GClass18.Class7 class7_1, bool bool_0)
	{
		uint num;
		long long_;
		int int_;
		for (;;)
		{
			TypeCode typeCode = this.method_10(class7_0, class7_1);
			TypeCode typeCode2 = typeCode;
			num = 1U;
			switch (typeCode2)
			{
			case 9:
				goto IL_1A6;
			case 10:
			case 12:
				break;
			case 11:
				num ^= 929920835U;
				if (bool_0)
				{
					num <<= 10;
					num = 765093004U / num;
					long num2 = (long)class7_0.vmethod_11();
					num = (249723746U ^ num);
					ulong num3 = class7_1.vmethod_11();
					num = (581703246U ^ num);
					ulong num4 = num3;
					num |= 1621457023U;
					long_ = num2 / (long)num4;
				}
				else
				{
					num = 1716134727U * num;
					num = 197817184U << (int)num;
					long num5 = class7_0.E9C7AF34();
					num %= 1881280197U;
					num = (784219058U & num);
					long num6 = class7_1.E9C7AF34();
					num = 700333127U >> (int)num;
					long num7 = num6;
					num = 1316356359U / num;
					long num8 = num7;
					num &= 703556441U;
					long_ = num5 / num8;
					num += 1827175551U;
				}
				if (num <= 381749563U)
				{
					goto IL_18A;
				}
				goto IL_265;
			case 13:
				num &= 1671765104U;
				num = (1024730239U ^ num);
				if (!bool_0)
				{
					goto IL_274;
				}
				num /= 1753679597U;
				if ((num & 281892553U) == 0U)
				{
					goto Block_6;
				}
				continue;
			case 14:
				num = 490615322U * num;
				if (336622661U / num != 0U)
				{
					continue;
				}
				if (!bool_0)
				{
					if (num < 605249219U)
					{
						goto Block_3;
					}
					continue;
				}
				else
				{
					num = 776749500U + num;
					if (num + 252860798U != 0U)
					{
						goto IL_319;
					}
				}
				break;
			default:
				if (2069103472U % num != 0U)
				{
					goto IL_1A6;
				}
				num += 0U;
				break;
			}
			if (num / 648282675U == 0U)
			{
				goto Block_4;
			}
			continue;
			IL_18A:
			num = 1294546556U - num;
			if ((num & 1302674072U) != 0U)
			{
				goto Block_8;
			}
			continue;
			IL_1A6:
			num = 677848076U + num;
			num |= 666969079U;
			if (!bool_0)
			{
				num &= 2055759785U;
				if (num + 1116082900U != 0U)
				{
					int num9 = class7_0.DE119705();
					num = 1022582208U + num;
					int num10 = class7_1.DE119705();
					int num11 = num10;
					num = 203305321U * num;
					int_ = num9 / num11;
					num += 1716149402U;
					goto IL_18A;
				}
			}
			int num12 = (int)class7_0.vmethod_10();
			num &= 1110507774U;
			uint num13 = class7_1.vmethod_10();
			num = 1939031838U >> (int)num;
			uint num14 = num13;
			int num15 = (int)num14;
			num *= 2139303339U;
			int_ = num12 / num15;
			if (num * 1220765103U != 0U)
			{
				goto IL_18A;
			}
		}
		Block_3:
		GClass18.Class7 @class = class7_0;
		goto IL_333;
		Block_4:
		throw new InvalidOperationException();
		Block_6:
		num = (1429700018U ^ num);
		GClass18.Class7 class2 = class7_0.vmethod_5();
		num ^= 1680300486U;
		goto IL_29B;
		Block_8:
		return new GClass18.Class9(int_);
		IL_265:
		return new GClass18.Class10(long_);
		IL_274:
		num = (859340788U & num);
		class2 = class7_0;
		IL_29B:
		num = (1448810963U ^ num);
		float num16 = class2.vmethod_12();
		GClass18.Class7 class3;
		if (!bool_0)
		{
			class3 = class7_1;
		}
		else
		{
			num >>= 6;
			num &= 639456032U;
			class3 = class7_1.vmethod_5();
			num += 1731083655U;
		}
		num = 506616674U / num;
		float num17 = class3.vmethod_12();
		num += 707422102U;
		float num18 = num17;
		num = 1735148705U % num;
		float num19 = num18;
		num |= 644744606U;
		float float_ = num16 / num19;
		num = 406678507U + num;
		return new GClass18.Class11(float_);
		IL_319:
		num |= 1021137420U;
		@class = class7_0.vmethod_5();
		num ^= 1658929604U;
		IL_333:
		num = 1612911449U << (int)num;
		double num20 = @class.BF7BF7B8();
		GClass18.Class7 class4;
		if (!bool_0)
		{
			class4 = class7_1;
		}
		else
		{
			num *= 429158548U;
			class4 = class7_1.vmethod_5();
			num += 2483027968U;
		}
		double num21 = class4.BF7BF7B8();
		num = (556348318U | num);
		double num22 = num21;
		double num23 = num22;
		num |= 550851328U;
		double double_ = num20 / num23;
		num = 1253460088U >> (int)num;
		return new GClass18.Class12(double_);
	}

	// Token: 0x06000142 RID: 322 RVA: 0x00008CE4 File Offset: 0x00006EE4
	private GClass18.Class7 method_15(GClass18.Class7 class7_0, GClass18.Class7 class7_1, bool bool_0)
	{
		uint num = 616181997U;
		for (;;)
		{
			num <<= 9;
			TypeCode typeCode = class7_0.vmethod_7();
			num = (1277241123U & num);
			TypeCode typeCode2 = typeCode;
			num = 1254363599U % num;
			while (typeCode2 == (int)num + (TypeCode)(-111349702))
			{
				num /= 1257249110U;
				if (!bool_0)
				{
					goto IL_16C;
				}
				num = 1177180460U - num;
				if ((num ^ 1332091689U) != 0U)
				{
					goto IL_133;
				}
			}
			num *= 685966972U;
			TypeCode typeCode3 = typeCode2;
			num = 2036404052U % num;
			uint num2 = num + 3968234235U;
			num |= 1443849024U;
			if (typeCode3 != num2)
			{
				break;
			}
			if (num % 938430892U == 0U)
			{
				goto IL_133;
			}
			num = (581710813U | num);
			if (bool_0)
			{
				goto IL_D5;
			}
			num %= 939595081U;
			if (num != 949027568U)
			{
				goto Block_6;
			}
		}
		if ((num ^ 2065782591U) != 0U)
		{
			throw new InvalidOperationException();
		}
		goto IL_16C;
		Block_6:
		num = 1474036762U << (int)num;
		long num3 = class7_0.E9C7AF34();
		long num4 = class7_1.E9C7AF34();
		long num5 = num4;
		num *= 1065323U;
		return new GClass18.Class10(num3 % num5);
		IL_D5:
		long num6 = (long)class7_0.vmethod_11();
		num ^= 957025831U;
		ulong num7 = class7_1.vmethod_11();
		num = 1851328039U >> (int)num;
		ulong num8 = num7;
		return new GClass18.Class10(num6 % (long)num8);
		IL_133:
		int num9 = (int)class7_0.vmethod_10();
		uint num10 = class7_1.vmethod_10();
		num = 1332639330U >> (int)num;
		int num11 = (int)num10;
		num /= 153748326U;
		int int_ = num9 % num11;
		num &= 83180657U;
		return new GClass18.Class9(int_);
		IL_16C:
		num /= 344615075U;
		int num12 = class7_0.DE119705();
		num <<= 20;
		int num13 = class7_1.DE119705();
		num >>= 21;
		return new GClass18.Class9(num12 % num13);
	}

	// Token: 0x06000143 RID: 323 RVA: 0x00008E94 File Offset: 0x00007094
	private GClass18.Class7 method_16(GClass18.Class7 class7_0, GClass18.Class7 class7_1)
	{
		TypeCode typeCode = this.method_10(class7_0, class7_1);
		uint num = 672667985U;
		do
		{
			uint num2 = (uint)typeCode;
			num *= 1242381066U;
			uint num3 = num2 - (num ^ 3521357859U);
			num <<= 25;
			switch (num3)
			{
			case 0:
				goto IL_86;
			case 1:
			case 3:
				break;
			case 2:
				goto IL_C3;
			case 4:
				num = 225591272U + num;
				if ((1272732787U & num) != 0U)
				{
					goto IL_FE;
				}
				break;
			case 5:
				goto IL_144;
			default:
				num += 0U;
				break;
			}
		}
		while (1329412165U == num);
		throw new InvalidOperationException();
		IL_86:
		num &= 1422725730U;
		num = 825642483U * num;
		int num4 = class7_0.DE119705();
		num <<= 4;
		num &= 1880766671U;
		int num5 = class7_1.DE119705();
		int num6 = num5;
		num = 1196891051U - num;
		return new GClass18.Class9(num4 ^ num6);
		IL_C3:
		num = (1419457720U & num);
		long num7 = class7_0.E9C7AF34();
		num -= 1733980633U;
		long num8 = class7_1.E9C7AF34();
		long num9 = num8;
		num *= 160964282U;
		long long_ = num7 ^ num9;
		num = 2006931604U << (int)num;
		return new GClass18.Class10(long_);
		IL_FE:
		float float_;
		if (IntPtr.Size != (int)(num - 1634877412U))
		{
			num /= 21838794U;
			float_ = 0f;
		}
		else
		{
			num = (1532000226U & num);
			float_ = float.NaN;
			num += 3199191146U;
		}
		num += 25502910U;
		return new GClass18.Class11(float_);
		IL_144:
		uint size = (uint)IntPtr.Size;
		num = 1215391196U / num;
		double double_;
		if (size != (num ^ 4U))
		{
			double_ = 0.0;
		}
		else
		{
			num &= 685194787U;
			double_ = double.NaN;
			num += 0U;
		}
		num &= 258743725U;
		return new GClass18.Class12(double_);
	}

	// Token: 0x06000144 RID: 324 RVA: 0x0000902C File Offset: 0x0000722C
	private GClass18.Class7 method_17(GClass18.Class7 class7_0, GClass18.Class7 class7_1)
	{
		uint num = 867522757U;
		for (;;)
		{
			num = (644431245U | num);
			num %= 171973938U;
			TypeCode typeCode = this.method_10(class7_0, class7_1);
			num <<= 2;
			TypeCode typeCode2 = typeCode;
			if (1201560554U / num != 0U)
			{
				for (;;)
				{
					switch (typeCode2 - (TypeCode)(num ^ 317960005U))
					{
					case 0:
						goto IL_8A;
					case 1:
					case 3:
						goto IL_9D;
					case 2:
						goto IL_12C;
					case 4:
						num &= 1929655118U;
						if (1243765521U <= num)
						{
							continue;
						}
						goto IL_15F;
					case 5:
						if (IntPtr.Size == (int)(num ^ 317960008U))
						{
							goto IL_AA;
						}
						num = 1481795411U >> (int)num;
						if (1289122290U >> (int)num != 0U)
						{
							goto Block_2;
						}
						continue;
					}
					goto Block_3;
				}
				IL_8A:
				num ^= 448150691U;
				if (208633610U % num != 0U)
				{
					goto Block_5;
				}
				continue;
				IL_9D:
				if (2005935655U != num)
				{
					goto Block_6;
				}
				continue;
				IL_AA:
				if (686437580 << (int)num == 0)
				{
					continue;
				}
				goto IL_1AA;
				Block_3:
				if (num + 1508335890U != 0U)
				{
					num ^= 0U;
					goto IL_9D;
				}
				goto IL_8A;
			}
		}
		Block_2:
		double double_ = 0.0;
		goto IL_1BB;
		Block_5:
		num = 1612274635U >> (int)num;
		int num2 = class7_0.DE119705();
		num = 1190992610U << (int)num;
		num >>= 16;
		int num3 = class7_1.DE119705();
		int int_ = num2 | num3;
		num *= 554841368U;
		return new GClass18.Class9(int_);
		Block_6:
		throw new InvalidOperationException();
		IL_12C:
		long num4 = class7_0.E9C7AF34();
		long num5 = class7_1.E9C7AF34();
		num = 1462119280U % num;
		long num6 = num5;
		num %= 1939418922U;
		long long_ = num4 | num6;
		num |= 1109292949U;
		return new GClass18.Class10(long_);
		IL_15F:
		uint size = (uint)IntPtr.Size;
		num /= 1554604823U;
		float float_;
		if (size != (num ^ 4U))
		{
			float_ = 0f;
		}
		else
		{
			num = (1413447674U | num);
			float_ = float.NaN;
			num ^= 1413447674U;
		}
		num &= 1087141709U;
		return new GClass18.Class11(float_);
		IL_1AA:
		double_ = double.NaN;
		num += 3977369050U;
		IL_1BB:
		num = 272567363U * num;
		return new GClass18.Class12(double_);
	}

	// Token: 0x06000145 RID: 325 RVA: 0x00009204 File Offset: 0x00007404
	private GClass18.Class7 method_18(GClass18.Class7 class7_0, GClass18.Class7 class7_1)
	{
		uint num = 913660035U;
		for (;;)
		{
			num = 806686272U / num;
			num = (1148658888U ^ num);
			TypeCode typeCode = this.method_10(class7_0, class7_1);
			num = 647981380U - num;
			for (;;)
			{
				uint num2 = (uint)typeCode;
				num /= 1311206547U;
				uint num3 = num2 - (num ^ 11U);
				num = 1024140269U - num;
				switch (num3)
				{
				case 0:
					goto IL_81;
				case 1:
				case 3:
					break;
				case 2:
					goto IL_14F;
				case 4:
					goto IL_8F;
				case 5:
					num = 1092318191U / num;
					if ((num ^ 2044606385U) != 0U)
					{
						goto Block_1;
					}
					continue;
				default:
					if (num >> 1 == 0U)
					{
						continue;
					}
					num ^= 0U;
					break;
				}
				num /= 1195793869U;
				if (num != 1077819168U)
				{
					goto Block_2;
				}
			}
			IL_81:
			if ((num ^ 1538009774U) != 0U)
			{
				goto Block_5;
			}
			continue;
			IL_8F:
			num = (804203931U & num);
			uint size = (uint)IntPtr.Size;
			num -= 1909927846U;
			if (size != num + 1154223647U)
			{
				goto Block_6;
			}
			num = (300027812U ^ num);
			if (1595370899U <= num)
			{
				goto Block_7;
			}
			continue;
			Block_1:
			uint size2 = (uint)IntPtr.Size;
			num %= 46745848U;
			if (size2 != num + 3U)
			{
				goto Block_8;
			}
			if (1405381528U >> (int)num != 0U)
			{
				goto IL_1CD;
			}
		}
		Block_2:
		throw new InvalidOperationException();
		Block_5:
		num = 2091661848U * num;
		int num4 = class7_0.DE119705();
		num = (934374045U | num);
		int num5 = class7_1.DE119705();
		num = 621110631U / num;
		int num6 = num5;
		num ^= 2082766364U;
		return new GClass18.Class9(num4 & num6);
		Block_6:
		float float_ = 0f;
		goto IL_1AC;
		Block_7:
		float_ = float.NaN;
		num ^= 300027812U;
		goto IL_1AC;
		Block_8:
		num *= 373516925U;
		double double_ = 0.0;
		goto IL_1DE;
		IL_14F:
		num = 704405283U << (int)num;
		long num7 = class7_0.E9C7AF34();
		num *= 700930236U;
		long num8 = class7_1.E9C7AF34();
		num = (1568097620U | num);
		long num9 = num8;
		long num10 = num9;
		num ^= 1387543235U;
		long long_ = num7 & num10;
		num += 2115327669U;
		return new GClass18.Class10(long_);
		IL_1AC:
		num *= 401022229U;
		return new GClass18.Class11(float_);
		IL_1CD:
		double_ = double.NaN;
		num += 373516924U;
		IL_1DE:
		return new GClass18.Class12(double_);
	}

	// Token: 0x06000146 RID: 326 RVA: 0x000093F4 File Offset: 0x000075F4
	private int method_19(GClass18.Class7 class7_0, GClass18.Class7 class7_1, bool bool_0, int int_1)
	{
		uint num;
		int num2;
		object obj2;
		for (;;)
		{
			IL_00:
			num = 1829118010U;
			num2 = int_1;
			for (;;)
			{
				IL_1AC:
				TypeCode typeCode = class7_0.vmethod_7();
				num /= 2011452901U;
				TypeCode typeCode2 = typeCode;
				num = (1348947126U ^ num);
				if (num == 1441404412U)
				{
					goto IL_00;
				}
				TypeCode typeCode4;
				for (;;)
				{
					IL_149:
					num = 1298011489U % num;
					TypeCode typeCode3 = class7_1.vmethod_7();
					num = 888300914U * num;
					typeCode4 = typeCode3;
					if (1266830731U >= num)
					{
						goto IL_00;
					}
					if (typeCode2 != (TypeCode)(num ^ 2080819763U))
					{
						if (num <= 1352559526U)
						{
							goto IL_1AC;
						}
						for (;;)
						{
							TypeCode typeCode5 = typeCode4;
							uint num3 = num ^ 2080819763U;
							num = 1647640686U << (int)num;
							if (typeCode5 == num3)
							{
								break;
							}
							uint num4 = (uint)typeCode2;
							num = 645362732U % num;
							if (num4 == (num ^ 10974242U))
							{
								goto IL_3B3;
							}
							uint num5 = (uint)typeCode4;
							num *= 779041746U;
							if (num5 == num - 1748463626U)
							{
								goto Block_3;
							}
							if (533206634U * num == 0U)
							{
								goto IL_149;
							}
							if (typeCode2 == (TypeCode)(num ^ 1748463637U))
							{
								goto IL_353;
							}
							if (1004480209U >= num)
							{
								goto IL_00;
							}
							TypeCode typeCode6 = typeCode4;
							num = (1643254359U & num);
							uint num6 = num ^ 1613893661U;
							num |= 1270311567U;
							if (typeCode6 == num6)
							{
								goto Block_7;
							}
							if (typeCode2 == (TypeCode)(num ^ 1807186580U))
							{
								goto IL_2B5;
							}
							num = 1412826422U % num;
							uint num7 = (uint)typeCode4;
							num = (1186018086U ^ num);
							if (num7 == (num ^ 310851099U))
							{
								goto Block_9;
							}
							num = 194466429U << (int)num;
							if (typeCode2 == (int)num + (TypeCode)(-1383923703))
							{
								goto IL_1A3;
							}
							if (num >= 236136141U)
							{
								goto IL_176;
							}
						}
						num ^= 2109655602U;
					}
					num = 2003123093U * num;
					if (num != 119603954U)
					{
						goto Block_12;
					}
				}
				IL_1A3:
				if (num < 886836249U)
				{
					continue;
				}
				break;
				IL_176:
				TypeCode typeCode7 = typeCode4;
				num = (302139707U & num);
				uint num8 = num + 3992977417U;
				num ^= 301989888U;
				if (typeCode7 == num8)
				{
					num += 1383923712U;
					goto IL_1A3;
				}
				goto IL_3EE;
			}
			int num11;
			if (!bool_0)
			{
				if ((1924885251U ^ num) == 0U)
				{
					continue;
				}
				int num9 = class7_0.DE119705();
				num |= 201216877U;
				int num10 = num9;
				num /= 1691426291U;
				if (1456291265U * num != 0U)
				{
					continue;
				}
				num = (1047884936U ^ num);
				int value = class7_1.DE119705();
				num = 1833185852U << (int)num;
				num11 = num10.CompareTo(value);
			}
			else
			{
				uint num12 = class7_0.vmethod_10();
				num = 1155626435U + num;
				uint num13 = num12;
				num += 1770814127U;
				uint value2 = class7_1.vmethod_10();
				num -= 473001611U;
				num11 = num13.CompareTo(value2);
				num ^= 2693512679U;
			}
			num2 = num11;
			num += 3150824448U;
			goto IL_3EE;
			IL_2B5:
			int num16;
			if (!bool_0)
			{
				num = 1471751128U / num;
				long num14 = class7_0.E9C7AF34();
				num = (1385972715U ^ num);
				long num15 = num14;
				num = (332142589U | num);
				num16 = num15.CompareTo(class7_1.E9C7AF34());
			}
			else
			{
				if (num / 1300522699U == 0U)
				{
					continue;
				}
				ulong num17 = class7_0.vmethod_11();
				num = 1581776990U * num;
				num = (13707627U ^ num);
				num16 = num17.CompareTo(class7_1.vmethod_11());
				num += 3876989174U;
			}
			num <<= 4;
			num2 = num16;
			if (212229751U < num)
			{
				num ^= 1036353520U;
				goto IL_3EE;
			}
			continue;
			Block_9:
			num += 1496335503U;
			goto IL_2B5;
			IL_353:
			num = (880415490U ^ num);
			float num18 = class7_0.vmethod_12();
			num ^= 1389567259U;
			float num19 = num18;
			num = (158621118U | num);
			num ^= 1499167934U;
			int num20 = num19.CompareTo(class7_1.vmethod_12());
			num >>= 2;
			num2 = num20;
			if (num < 1480879635U)
			{
				num ^= 363413696U;
				goto IL_3EE;
			}
			continue;
			Block_7:
			num += 4236244345U;
			goto IL_353;
			IL_3EE:
			if (num << 10 != 0U)
			{
				continue;
			}
			int num21 = num2;
			num /= 1327584857U;
			uint num22 = num ^ 0U;
			num = 1498615693U + num;
			if (num21 < num22)
			{
				num >>= 13;
				num2 = (int)(num - 182937U);
			}
			else
			{
				int num23 = num2;
				num = 992104503U + num;
				uint num24 = num - 2490720196U;
				num += 1804430036U;
				if (num23 > num24)
				{
					num >>= 23;
					num2 = (int)(num + 1U);
					num += 182936U;
				}
			}
			if ((num ^ 2064935549U) != 0U)
			{
				break;
			}
			continue;
			IL_3B3:
			num = 1500917662U << (int)num;
			num = 827009946U / num;
			double num25 = class7_0.BF7BF7B8();
			num %= 564806841U;
			num2 = num25.CompareTo(class7_1.BF7BF7B8());
			goto IL_3EE;
			Block_3:
			num ^= 1754268724U;
			goto IL_3B3;
			Block_12:
			object obj = class7_0.vmethod_1();
			num %= 2017885244U;
			obj2 = class7_1.vmethod_1();
			if (obj == obj2)
			{
				goto Block_27;
			}
			if (1996112335U != num)
			{
				goto Block_28;
			}
		}
		return num2;
		Block_27:
		return (int)(num - 1275115742U);
		Block_28:
		bool flag = obj2 != null;
		num = 342035562U << (int)num;
		if (flag)
		{
			num = 1560946192U >> (int)num;
			return (int)(num - 1560946193U);
		}
		return (int)(num + 2147483649U);
	}

	// Token: 0x06000147 RID: 327 RVA: 0x000098EC File Offset: 0x00007AEC
	private GClass18.Class7 method_20(GClass18.Class7 class7_0)
	{
		uint num2;
		for (;;)
		{
			TypeCode typeCode = class7_0.vmethod_7();
			TypeCode typeCode2 = typeCode;
			int num = 9;
			num2 = 1369208146U;
			if (typeCode2 == num || 560293762U == num2)
			{
				goto IL_8C;
			}
			do
			{
				uint num3 = (uint)typeCode;
				num2 = (1419865780U & num2);
				if (num3 == (num2 ^ 1350591515U))
				{
					goto IL_45;
				}
			}
			while ((num2 ^ 1365656395U) == 0U);
			IL_57:
			num2 = (1163741801U | num2);
			if (num2 >= 563372743U)
			{
				goto Block_4;
			}
			continue;
			IL_45:
			num2 *= 829713410U;
			if (num2 != 1978678729U)
			{
				break;
			}
			goto IL_57;
		}
		num2 = 1201761250U - num2;
		long num4 = class7_0.E9C7AF34();
		num2 = 45628896U % num2;
		return new GClass18.Class10(~num4);
		Block_4:
		throw new InvalidOperationException();
		IL_8C:
		num2 >>= 8;
		num2 -= 1483031713U;
		return new GClass18.Class9(~class7_0.DE119705());
	}

	// Token: 0x06000148 RID: 328 RVA: 0x000099A4 File Offset: 0x00007BA4
	private GClass18.Class7 method_21(GClass18.Class7 class7_0)
	{
		uint num = 434005968U;
		for (;;)
		{
			num = (50801078U | num);
			TypeCode typeCode = class7_0.vmethod_7();
			num += 703212832U;
			TypeCode typeCode2 = typeCode;
			num = 1890719869U * num;
			switch (typeCode2 - (TypeCode)(num ^ 3547841463U))
			{
			case 0:
				goto IL_63;
			case 1:
			case 3:
				goto IL_95;
			case 2:
				goto IL_88;
			case 4:
				goto IL_9B;
			case 5:
				goto IL_C0;
			default:
				if (1984172243U != num)
				{
					goto Block_1;
				}
				break;
			}
		}
		Block_1:
		num ^= 0U;
		goto IL_95;
		IL_63:
		num = 915418325U / num;
		int num2 = class7_0.DE119705();
		num |= 631789814U;
		int int_ = -num2;
		num = (1642362750U ^ num);
		return new GClass18.Class9(int_);
		IL_88:
		return new GClass18.Class10(-class7_0.E9C7AF34());
		IL_95:
		throw new InvalidOperationException();
		IL_9B:
		num <<= 5;
		float num3 = class7_0.vmethod_12();
		num = 652037455U - num;
		float float_ = -num3;
		num >>= 20;
		return new GClass18.Class11(float_);
		IL_C0:
		num = 525863089U / num;
		num = (1198984235U & num);
		return new GClass18.Class12(-class7_0.BF7BF7B8());
	}

	// Token: 0x06000149 RID: 329 RVA: 0x00009A90 File Offset: 0x00007C90
	private GClass18.Class7 method_22(GClass18.Class7 class7_0, GClass18.Class7 class7_1, bool bool_0)
	{
		uint num = 1443129340U;
		for (;;)
		{
			TypeCode typeCode = class7_0.vmethod_7();
			num = (682834700U ^ num);
			TypeCode typeCode2 = typeCode;
			if ((210577404U ^ num) == 0U)
			{
				goto IL_30;
			}
			for (;;)
			{
				IL_14:
				TypeCode typeCode3 = typeCode2;
				num = 1055335510U / num;
				uint num2 = num - 4294967287U;
				num += 205204899U;
				if (typeCode3 == num2)
				{
					break;
				}
				if ((2101828972U ^ num) != 0U)
				{
					goto IL_64;
				}
			}
			IL_30:
			if (274928653U / num == 0U)
			{
				goto IL_14;
			}
			num |= 291899579U;
			if (bool_0)
			{
				if (num < 1746796614U)
				{
					break;
				}
			}
			else
			{
				num = 543361964U / num;
				if (num << 3 != 0U)
				{
					goto Block_5;
				}
				continue;
			}
			IL_64:
			uint num3 = (uint)typeCode2;
			num %= 2135380970U;
			if (num3 != (num ^ 205204904U))
			{
				if (num >= 1793221862U)
				{
					break;
				}
				num <<= 14;
				if (num >= 1112159900U)
				{
					goto Block_8;
				}
			}
			else
			{
				if (!bool_0)
				{
					goto IL_187;
				}
				if (num != 743901195U)
				{
					goto Block_10;
				}
			}
		}
		goto IL_109;
		Block_5:
		int num4 = class7_0.DE119705();
		int num5 = class7_1.DE119705();
		num |= 2059297254U;
		int num6 = num5;
		int num7 = (int)(num ^ 2059297272U);
		num = 1003888832U - num;
		int num8 = num6 & num7;
		num = (833489074U & num);
		int int_ = num4 >> num8;
		num /= 2006601996U;
		return new GClass18.Class9(int_);
		Block_8:
		throw new InvalidOperationException();
		Block_10:
		ulong num9 = class7_0.vmethod_11();
		num *= 1148412652U;
		num /= 1563829908U;
		int num10 = class7_1.DE119705();
		int num11 = num10;
		num *= 586288747U;
		long long_ = num9 >> (num11 & (int)(num + 3708678612U));
		num /= 999635225U;
		return new GClass18.Class10(long_);
		IL_109:
		uint num12 = class7_0.vmethod_10();
		num ^= 1613648436U;
		int num13 = class7_1.DE119705();
		num %= 785531337U;
		int num14 = num13;
		num &= 1483358936U;
		int num15 = (int)(num ^ 405291719U);
		num *= 1962557747U;
		return new GClass18.Class9(num12 >> (num14 & num15));
		IL_187:
		num &= 239341429U;
		num &= 2039945390U;
		long num16 = class7_0.E9C7AF34();
		num = (1541820983U & num);
		num &= 473724273U;
		int num17 = class7_1.DE119705();
		num = (2084912083U | num);
		int num18 = num17;
		return new GClass18.Class10(num16 >> (num18 & 63));
	}

	// Token: 0x0600014A RID: 330 RVA: 0x00009C6C File Offset: 0x00007E6C
	private GClass18.Class7 method_23(GClass18.Class7 class7_0, GClass18.Class7 class7_1)
	{
		uint num;
		for (;;)
		{
			TypeCode typeCode = class7_0.vmethod_7();
			num = 1143632384U;
			while (typeCode == (int)num + (TypeCode)(-1143632375))
			{
				num = 1668040033U / num;
				if (895102212U != num)
				{
					goto Block_0;
				}
			}
			num = (927928522U | num);
			if (typeCode != (int)num + (TypeCode)(-2003792575))
			{
				goto Block_2;
			}
			num = 407656107U / num;
			if (num < 2042239430U)
			{
				goto Block_3;
			}
		}
		Block_0:
		num = 289750141U >> (int)num;
		int num2 = class7_0.DE119705();
		num = 1509048542U % num;
		int num3 = class7_1.DE119705();
		num *= 2132299751U;
		int num4 = num3;
		int num5 = num4;
		int num6 = (int)(num ^ 1956238017U);
		num /= 837623045U;
		int num7 = num5 & num6;
		num <<= 3;
		int int_ = num2 << num7;
		num += 1613181829U;
		return new GClass18.Class9(int_);
		Block_2:
		throw new InvalidOperationException();
		Block_3:
		num = 319181705U + num;
		long num8 = class7_0.E9C7AF34();
		num %= 857670951U;
		int num9 = class7_1.DE119705();
		num = (1452224910U & num);
		int num10 = num9;
		num = (793869568U & num);
		int num11 = num10 & (int)(num + 4261408575U);
		num = 741607471U / num;
		long long_ = num8 << num11;
		num = (107485210U | num);
		return new GClass18.Class10(long_);
	}

	// Token: 0x0600014B RID: 331 RVA: 0x00009D78 File Offset: 0x00007F78
	private unsafe GClass18.Class7 method_24(object object_0, Type type_1)
	{
		GClass18.Class7 @class;
		uint num;
		for (;;)
		{
			IL_00:
			@class = (object_0 as GClass18.Class7);
			num = 1135494188U;
			for (;;)
			{
				bool isEnum = type_1.IsEnum;
				num ^= 1640788045U;
				if (isEnum)
				{
					goto Block_28;
				}
				num = 324411953U * num;
				TypeCode typeCode = Type.GetTypeCode(type_1);
				num -= 714492125U;
				TypeCode typeCode2 = typeCode;
				num *= 1423511015U;
				if ((258408883U & num) == 0U)
				{
					goto IL_00;
				}
				uint num2 = (uint)typeCode2;
				num = 745434594U - num;
				uint num3 = num2 - (num ^ 2263756405U);
				num -= 1404639086U;
				switch (num3)
				{
				case 0:
				{
					if (num - 1859082207U == 0U)
					{
						goto IL_00;
					}
					bool flag = @class != null;
					num = 182277807U << (int)num;
					if (!flag)
					{
						goto IL_50F;
					}
					if ((1752241130U ^ num) != 0U)
					{
						goto Block_5;
					}
					continue;
				}
				case 1:
					goto IL_543;
				case 2:
					goto IL_596;
				case 3:
					goto IL_274;
				case 4:
					goto IL_2A6;
				case 5:
				{
					bool flag2 = @class != null;
					num = (1605384095U & num);
					if (flag2)
					{
						goto IL_2C4;
					}
					if (1012336541U - num != 0U)
					{
						goto Block_7;
					}
					continue;
				}
				case 6:
					goto IL_2D5;
				case 7:
					if (num >= 1165587226U)
					{
						goto IL_00;
					}
					if (@class == null)
					{
						goto IL_678;
					}
					num = 1640574478U - num;
					if (1951755128U >= num)
					{
						goto Block_10;
					}
					continue;
				case 8:
					goto IL_302;
				case 9:
					goto IL_33C;
				case 10:
					goto IL_366;
				case 11:
					goto IL_734;
				case 12:
				case 13:
				case 14:
					break;
				case 15:
					goto IL_929;
				default:
					if (324825388U == num)
					{
						goto IL_00;
					}
					num ^= 0U;
					break;
				}
				num <<= 0;
				if (num < 178928894U)
				{
					goto IL_00;
				}
				num <<= 28;
				RuntimeTypeHandle handle = typeof(IntPtr).TypeHandle;
				num |= 195043135U;
				Type typeFromHandle = Type.GetTypeFromHandle(handle);
				num = 906764880U * num;
				if (type_1 == typeFromHandle)
				{
					break;
				}
				num %= 1581059333U;
				if (num / 502543547U == 0U)
				{
					goto IL_00;
				}
				RuntimeTypeHandle handle2 = typeof(UIntPtr).TypeHandle;
				num = 2009420602U * num;
				if (type_1 == Type.GetTypeFromHandle(handle2))
				{
					num <<= 16;
					if (@class != null)
					{
						goto IL_3E8;
					}
					if (object_0 != null)
					{
						goto IL_7C3;
					}
					if (968561384U > num)
					{
						goto Block_17;
					}
				}
				else if (type_1.IsValueType)
				{
					if (@class == null)
					{
						goto IL_7FB;
					}
					num = (1779595323U & num);
					if (num / 1919379761U == 0U)
					{
						goto Block_20;
					}
				}
				else if (1814984814U % num != 0U)
				{
					bool isArray = type_1.IsArray;
					num += 599796125U;
					if (isArray)
					{
						if (1827694772U != num)
						{
							goto Block_23;
						}
					}
					else
					{
						num += 1103522550U;
						if (num > 1433628811U)
						{
							goto IL_00;
						}
						bool isPointer = type_1.IsPointer;
						num %= 1886914365U;
						if (!isPointer)
						{
							goto IL_416;
						}
						num = 26427392U - num;
						bool flag3 = @class != null;
						num = 67389746U << (int)num;
						if (flag3)
						{
							goto IL_86A;
						}
						num = 898921170U % num;
						if (2111143196U != num)
						{
							goto Block_27;
						}
					}
				}
			}
			if (num * 135537511U == 0U)
			{
				continue;
			}
			bool flag4 = @class != null;
			num = 1708202076U / num;
			if (flag4)
			{
				num >>= 2;
				if (num << 2 == 0U)
				{
					goto Block_47;
				}
				continue;
			}
			else
			{
				num = (1224282546U & num);
				if (object_0 == null)
				{
					num %= 1682006799U;
					if (num != 227305393U)
					{
						goto Block_49;
					}
					continue;
				}
				else
				{
					if (num < 1984775136U)
					{
						goto Block_50;
					}
					continue;
				}
			}
			IL_2A6:
			bool flag5 = @class != null;
			num ^= 865287777U;
			if (!flag5)
			{
				goto IL_5F1;
			}
			if (num != 965876545U)
			{
				goto Block_33;
			}
			continue;
			IL_2C4:
			if (num % 1955480113U != 0U)
			{
				goto Block_34;
			}
			continue;
			IL_302:
			num = 511002668U >> (int)num;
			if (@class == null)
			{
				num <<= 22;
				if (371937367U / num == 0U)
				{
					goto Block_38;
				}
				continue;
			}
			else
			{
				if (622135177U > num)
				{
					goto Block_39;
				}
				continue;
			}
			IL_33C:
			num = (221139462U & num);
			if (1461986753U + num == 0U)
			{
				goto IL_4F7;
			}
			if (@class != null)
			{
				goto IL_6E4;
			}
			if (766199047U > num)
			{
				goto Block_42;
			}
			continue;
			IL_366:
			if (@class == null)
			{
				goto IL_708;
			}
			num = 1368732797U / num;
			if (num - 1891203123U != 0U)
			{
				goto Block_44;
			}
			continue;
			Block_23:
			bool flag6 = @class != null;
			num |= 1836061717U;
			if (!flag6)
			{
				goto IL_839;
			}
			if (num > 761418097U)
			{
				goto Block_53;
			}
			continue;
			IL_416:
			if (978656719U < num)
			{
				continue;
			}
			bool flag7 = @class != null;
			num += 1845305479U;
			if (flag7)
			{
				goto IL_905;
			}
			num = 1295283979U + num;
			if (1744313178U / num != 0U)
			{
				goto IL_443;
			}
			goto IL_8D9;
			IL_45B:
			num = 456866682U << (int)num;
			if (object_0 != null)
			{
				num = 1729638359U - num;
				if (num + 1892307911U == 0U)
				{
					goto IL_4F7;
				}
				bool flag8 = object_0 is Enum;
				num = 1657236762U >> (int)num;
				num += 706578769U;
				if (!flag8)
				{
					num = (1100877863U & num);
					num ^= 2076445257U;
					object value = object_0;
					num ^= 747772189U;
					object_0 = Enum.ToObject(type_1, value);
					num += 3744887684U;
				}
			}
			num /= 1976054923U;
			if (object_0 != null)
			{
				num /= 1326390051U;
				if ((1167084924U ^ num) != 0U)
				{
					goto Block_57;
				}
			}
			else
			{
				if (1291483596U >= num)
				{
					goto Block_61;
				}
				continue;
			}
			IL_4F7:
			if (@class != null)
			{
				num >>= 14;
				goto IL_443;
			}
			goto IL_45B;
			IL_3E8:
			if (num <= 544211458U)
			{
				goto Block_51;
			}
			goto IL_4F7;
			IL_2D5:
			num = 1809191454U << (int)num;
			if (@class != null)
			{
				goto IL_651;
			}
			num /= 2032417438U;
			if (num / 1723925727U == 0U)
			{
				goto Block_36;
			}
			goto IL_4F7;
			IL_274:
			num ^= 1102004879U;
			if (284390763U / num == 0U)
			{
				if (@class == null)
				{
					goto IL_5B5;
				}
				num = 1295535401U - num;
				if (324500082U != num)
				{
					goto Block_31;
				}
				goto IL_443;
			}
			Block_28:
			goto IL_4F7;
			IL_443:
			object obj = @class.vmethod_1();
			num = 1102992065U / num;
			object_0 = obj;
			num ^= 576867902U;
			goto IL_45B;
		}
		Block_5:
		GClass18.Class7 class2 = @class;
		num -= 1485326904U;
		bool bool_ = class2.A0715E7F();
		num ^= 3498993096U;
		goto IL_53D;
		Block_7:
		ushort ushort_ = Convert.ToUInt16(object_0);
		goto IL_63B;
		Block_10:
		GClass18.Class7 class3 = @class;
		num = 1848903243U % num;
		uint uint_ = class3.vmethod_10();
		num += 573128393U;
		goto IL_696;
		Block_17:
		UIntPtr uintptr_ = UIntPtr.Zero;
		goto IL_7D9;
		Block_20:
		object object_ = @class.vmethod_1();
		num |= 1203467360U;
		return new GClass18.Class16(object_);
		Block_27:
		bool flag9 = object_0 != null;
		num <<= 18;
		void* ptr;
		if (!flag9)
		{
			ptr = num + 884473856U;
		}
		else
		{
			num = 1364530454U << (int)num;
			ptr = Pointer.Unbox(object_0);
			num ^= 2585597206U;
		}
		num -= 915492944U;
		return new GClass18.Class15(Pointer.Box(ptr, type_1), type_1);
		Block_31:
		GClass18.Class7 class4 = @class;
		num %= 1991585983U;
		byte byte_ = class4.vmethod_9();
		num += 3666981267U;
		goto IL_5E3;
		Block_33:
		short short_ = @class.DAAA832C();
		num += 4284077765U;
		goto IL_60F;
		Block_34:
		GClass18.Class7 class5 = @class;
		num = (1187859510U & num);
		ushort_ = class5.E1B55196();
		num ^= 288363272U;
		goto IL_63B;
		Block_36:
		object value2 = object_0;
		num |= 924672128U;
		int int_ = Convert.ToInt32(value2);
		goto IL_66A;
		Block_38:
		long long_ = Convert.ToInt64(object_0);
		goto IL_6C0;
		Block_39:
		GClass18.Class7 class6 = @class;
		num = 644167685U << (int)num;
		long_ = class6.E9C7AF34();
		num ^= 926418176U;
		goto IL_6C0;
		Block_42:
		object value3 = object_0;
		num = 172032260U << (int)num;
		ulong ulong_ = Convert.ToUInt64(value3);
		goto IL_6FA;
		Block_44:
		float float_ = @class.vmethod_12();
		num += 2749344911U;
		goto IL_72E;
		Block_47:
		return new GClass18.Class25(@class.vmethod_13());
		Block_49:
		IntPtr intptr_ = IntPtr.Zero;
		goto IL_79A;
		Block_50:
		intptr_ = (IntPtr)object_0;
		num ^= 0U;
		goto IL_79A;
		Block_51:
		UIntPtr uintptr_2 = @class.vmethod_14();
		num = 827072639U * num;
		return new GClass18.Class26(uintptr_2);
		Block_53:
		object obj2 = @class.vmethod_1();
		num = (762787343U & num);
		Array array_ = (Array)obj2;
		num += 3532319731U;
		goto IL_864;
		Block_57:
		goto IL_8DC;
		Block_61:
		Enum enum_ = (Enum)Activator.CreateInstance(type_1);
		num ^= 0U;
		goto IL_8FF;
		IL_50F:
		num &= 2128772463U;
		object value4 = object_0;
		num = (1985495825U & num);
		bool_ = Convert.ToBoolean(value4);
		IL_53D:
		return new GClass18.Class30(bool_);
		IL_543:
		num = 2037190227U << (int)num;
		bool flag10 = @class != null;
		num %= 1394698240U;
		char char_;
		if (!flag10)
		{
			object value5 = object_0;
			num = 1727880613U >> (int)num;
			char_ = Convert.ToChar(value5);
		}
		else
		{
			num |= 2096044929U;
			GClass18.Class7 class7 = @class;
			num ^= 2110792002U;
			char_ = class7.C075F08B();
			num ^= 1724024678U;
		}
		return new GClass18.Class31(char_);
		IL_596:
		sbyte sbyte_;
		if (@class == null)
		{
			sbyte_ = Convert.ToSByte(object_0);
		}
		else
		{
			sbyte_ = @class.vmethod_8();
			num ^= 0U;
		}
		return new GClass18.Class33(sbyte_);
		IL_5B5:
		num &= 104011798U;
		object value6 = object_0;
		num *= 486560105U;
		byte_ = Convert.ToByte(value6);
		IL_5E3:
		num &= 1285432138U;
		return new GClass18.Class32(byte_);
		IL_5F1:
		object value7 = object_0;
		num = 501487769U / num;
		short_ = Convert.ToInt16(value7);
		IL_60F:
		num *= 795629904U;
		return new GClass18.Class28(short_);
		IL_63B:
		return new GClass18.Class29(ushort_);
		IL_651:
		if (num <= 203243727U)
		{
			goto IL_8DC;
		}
		int_ = @class.DE119705();
		num ^= 3775889025U;
		IL_66A:
		num = 1624053049U * num;
		return new GClass18.Class9(int_);
		IL_678:
		uint_ = Convert.ToUInt32(object_0);
		IL_696:
		return new GClass18.Class34(uint_);
		IL_6C0:
		num ^= 52042764U;
		return new GClass18.Class10(long_);
		IL_6E4:
		GClass18.Class7 class8 = @class;
		num <<= 21;
		ulong_ = class8.vmethod_11();
		num += 3393257732U;
		IL_6FA:
		num = 1479812598U / num;
		return new GClass18.Class35(ulong_);
		IL_708:
		num ^= 292432916U;
		object value8 = object_0;
		num = 483026876U * num;
		float_ = Convert.ToSingle(value8);
		IL_72E:
		return new GClass18.Class11(float_);
		IL_734:
		double double_;
		if (@class == null)
		{
			num = 1528829711U - num;
			object value9 = object_0;
			num = 1586430308U / num;
			double_ = Convert.ToDouble(value9);
		}
		else
		{
			num = 1597402872U << (int)num;
			double_ = @class.BF7BF7B8();
			num += 3381725186U;
		}
		num = 622466725U + num;
		return new GClass18.Class12(double_);
		IL_79A:
		num = 1331177791U * num;
		return new GClass18.Class25(intptr_);
		IL_7C3:
		num = (333843328U | num);
		uintptr_ = (UIntPtr)object_0;
		num ^= 4197248U;
		IL_7D9:
		num <<= 9;
		return new GClass18.Class26(uintptr_);
		IL_7FB:
		num *= 272504312U;
		object object_2;
		if (object_0 != null)
		{
			object_2 = object_0;
		}
		else
		{
			num = 697460582U >> (int)num;
			object_2 = Activator.CreateInstance(type_1);
			num += 462761086U;
		}
		num = 181221935U >> (int)num;
		return new GClass18.Class16(object_2);
		IL_839:
		num /= 1494162347U;
		array_ = (Array)object_0;
		IL_864:
		return new GClass18.Class17(array_);
		IL_86A:
		void* ptr2 = @class.vmethod_15();
		num = 136710612U % num;
		object object_3 = Pointer.Box(ptr2, type_1);
		num = 1146178699U << (int)num;
		return new GClass18.Class15(object_3, type_1);
		IL_8D9:
		object object_4 = object_0;
		goto IL_91B;
		IL_8DC:
		object obj3 = object_0;
		num = (549598639U & num);
		enum_ = (Enum)obj3;
		IL_8FF:
		return new GClass18.Class27(enum_);
		IL_905:
		GClass18.Class7 class9 = @class;
		num = (1539917133U ^ num);
		object_4 = class9.vmethod_1();
		num ^= 113039990U;
		IL_91B:
		num %= 1245460064U;
		return new GClass18.Class14(object_4);
		IL_929:
		num = 1063862126U / num;
		bool flag11 = @class != null;
		num = 926507560U << (int)num;
		string string_;
		if (!flag11)
		{
			string_ = (string)object_0;
		}
		else
		{
			num &= 617376476U;
			string_ = @class.ToString();
			num ^= 1244824576U;
		}
		num -= 3107540U;
		return new GClass18.Class13(string_);
	}

	// Token: 0x0600014C RID: 332 RVA: 0x0000A6F4 File Offset: 0x000088F4
	private string method_25(int int_1)
	{
		Dictionary<int, object> dictionary = GClass18.dictionary_1;
		uint num = 824775116U;
		Dictionary<int, object> obj = dictionary;
		string result;
		lock (obj)
		{
			object obj2;
			string text;
			do
			{
				Dictionary<int, object> dictionary2 = GClass18.dictionary_1;
				num /= 2135440243U;
				bool flag = dictionary2.TryGetValue(int_1, out obj2);
				num %= 1619143596U;
				if (flag)
				{
					goto IL_60;
				}
				num = (367725505U & num);
				Module module = this.module_0;
				num = 1244622748U + num;
				text = module.ResolveString(int_1);
				num = (2061109912U | num);
			}
			while (1951429733U >= num);
			Dictionary<int, object> dictionary3 = GClass18.dictionary_1;
			num %= 457060885U;
			object value = text;
			num <<= 21;
			dictionary3.Add(int_1, value);
			num = 2112380461U * num;
			result = text;
			if (246811495U != num)
			{
				return result;
			}
			goto IL_A3;
			IL_60:
			num = (1077439157U ^ num);
			if (527307174U + num == 0U)
			{
				goto IL_B9;
			}
			IL_A3:
			object obj3 = obj2;
			num = 925127990U << (int)num;
			result = (string)obj3;
			IL_B9:;
		}
		return result;
	}

	// Token: 0x0600014D RID: 333 RVA: 0x0000A7DC File Offset: 0x000089DC
	private Type method_26(int int_1)
	{
		Dictionary<int, object> obj = GClass18.dictionary_1;
		uint num = 3183895668U;
		Type result;
		lock (obj)
		{
			num = 393246748U << (int)num;
			if (1098736871U * num != 0U)
			{
				Dictionary<int, object> dictionary = GClass18.dictionary_1;
				num *= 1925603095U;
				object obj2;
				bool flag = dictionary.TryGetValue(int_1, out obj2);
				num = (1193745341U ^ num);
				if (!flag)
				{
					goto IL_68;
				}
				num = 530926315U << (int)num;
				if ((num ^ 525229542U) == 0U)
				{
					goto IL_68;
				}
				for (;;)
				{
					IL_D0:
					object obj3 = obj2;
					num += 1059218032U;
					Type type = (Type)obj3;
					num = 1381120819U - num;
					result = type;
					if (num >= 2071742298U)
					{
						goto IL_F0;
					}
				}
				IL_68:
				num %= 302924921U;
				num *= 625691076U;
				Module module = this.module_0;
				num = (1633027449U ^ num);
				num = 264459100U * num;
				Type type2 = module.ResolveType(int_1);
				num = 31082515U % num;
				Type type3 = type2;
				Dictionary<int, object> dictionary2 = GClass18.dictionary_1;
				num *= 2026205795U;
				dictionary2.Add(int_1, type3);
				if (1547635609U / num != 0U)
				{
					Type type4 = type3;
					num = 1012143998U % num;
					result = type4;
					if (num + 261774271U == 0U)
					{
						goto IL_D0;
					}
				}
			}
			IL_F0:;
		}
		return result;
	}

	// Token: 0x0600014E RID: 334 RVA: 0x0000A8FC File Offset: 0x00008AFC
	private MethodBase method_27(int int_1)
	{
		Dictionary<int, object> dictionary = GClass18.dictionary_1;
		uint num = 268435456U;
		Dictionary<int, object> obj = dictionary;
		MethodBase result;
		lock (obj)
		{
			num = 1763129928U / num;
			object obj2;
			if (num < 1938427814U)
			{
				Dictionary<int, object> dictionary2 = GClass18.dictionary_1;
				num %= 1424568112U;
				if (dictionary2.TryGetValue(int_1, out obj2))
				{
					num = 171787039U << (int)num;
				}
				else
				{
					Module module = this.module_0;
					num <<= 3;
					num -= 985154215U;
					MethodBase methodBase = module.ResolveMethod(int_1);
					num = 1319833493U + num;
					Dictionary<int, object> dictionary3 = GClass18.dictionary_1;
					num |= 835804772U;
					dictionary3.Add(int_1, methodBase);
					num >>= 30;
					result = methodBase;
					if (1590691987U > num)
					{
						return result;
					}
				}
			}
			object obj3 = obj2;
			num <<= 16;
			result = (MethodBase)obj3;
		}
		return result;
	}

	// Token: 0x0600014F RID: 335 RVA: 0x0000A9F8 File Offset: 0x00008BF8
	private FieldInfo method_28(int int_1)
	{
		Dictionary<int, object> dictionary = GClass18.dictionary_1;
		object obj = dictionary;
		uint num = 1100U;
		Monitor.Enter(obj);
		FieldInfo result;
		try
		{
			num = 577189740U % num;
			if (num < 2115448146U)
			{
				FieldInfo fieldInfo3;
				for (;;)
				{
					Dictionary<int, object> dictionary2 = GClass18.dictionary_1;
					num = 75050989U >> (int)num;
					num = 129901022U / num;
					num |= 1083404902U;
					object obj2;
					bool flag = dictionary2.TryGetValue(int_1, out obj2);
					num >>= 24;
					if (flag)
					{
						num = 200560156U / num;
						if (num == 722231937U)
						{
							break;
						}
						object obj3 = obj2;
						num = (621558863U & num);
						FieldInfo fieldInfo = (FieldInfo)obj3;
						num /= 492706824U;
						result = fieldInfo;
						if (242054245U > num)
						{
							goto IL_12E;
						}
					}
					else
					{
						num = 972710721U % num;
						if (1772172163 << (int)num == 0)
						{
							break;
						}
						FieldInfo fieldInfo2 = this.module_0.ResolveField(int_1);
						num = 1158825919U << (int)num;
						fieldInfo3 = fieldInfo2;
						num = 2098143481U - num;
						if (num > 1453854164U)
						{
							GClass18.dictionary_1.Add(int_1, fieldInfo3);
							if ((361451221U & num) != 0U)
							{
								break;
							}
						}
					}
				}
				FieldInfo fieldInfo4 = fieldInfo3;
				num = 1918838616U << (int)num;
				result = fieldInfo4;
			}
			IL_12E:;
		}
		finally
		{
			Monitor.Exit(dictionary);
		}
		return result;
	}

	// Token: 0x06000150 RID: 336 RVA: 0x0000AB68 File Offset: 0x00008D68
	private GClass18.Class7 method_29(MethodBase methodBase_0)
	{
		uint num = 2062778216U;
		Dictionary<int, GClass18.Class7> dictionary;
		object[] array;
		object object_;
		for (;;)
		{
			IL_1A9:
			ParameterInfo[] parameters = methodBase_0.GetParameters();
			num += 1658022254U;
			if (2059890816U - num != 0U)
			{
				for (;;)
				{
					IL_18A:
					dictionary = new Dictionary<int, GClass18.Class7>();
					num = (385506280U | num);
					if (num > 296304798U)
					{
						goto IL_59;
					}
					IL_15A:
					int num3;
					while (num % 1031687616U != 0U)
					{
						uint num2 = (uint)num3;
						num = 894455090U >> (int)num;
						if (num2 < (num ^ 223613772U))
						{
							if (597653236U < num)
							{
								goto IL_59;
							}
							object_ = ((ConstructorInfo)methodBase_0).Invoke(array);
							if (120878731 << (int)num == 0)
							{
								goto IL_18A;
							}
							goto IL_1C6;
						}
						else
						{
							num = 5U;
							GClass18.Class7 @class = this.method_1();
							if (@class.vmethod_3())
							{
								if (227021086U == num)
								{
									goto IL_1A9;
								}
								Dictionary<int, GClass18.Class7> dictionary2 = dictionary;
								num += 1751541182U;
								int key = num3;
								num /= 350313786U;
								GClass18.Class7 value = @class;
								num = 330583554U - num;
								dictionary2[key] = value;
								num ^= 330583547U;
							}
							object[] array2 = array;
							num <<= 19;
							int num4 = num3;
							object object_2 = @class;
							num -= 1552240705U;
							ParameterInfo[] array3 = parameters;
							num >>= 15;
							int num5 = num3;
							num = 738549096U >> (int)num;
							GClass18.Class7 class2 = this.method_24(object_2, array3[num5].ParameterType);
							num |= 607980639U;
							object obj = class2.vmethod_1();
							num = 2019914185U / num;
							array2[num4] = obj;
							num <<= 11;
							int num6 = num3;
							int num7 = (int)(num ^ 6145U);
							num = 836135814U - num;
							int num8 = num6 - num7;
							num *= 1402406255U;
							num3 = num8;
							num ^= 4064682680U;
						}
					}
					IL_0C:
					int num9 = parameters.Length;
					num <<= 8;
					int num10 = (int)(num ^ 1344181249U);
					num |= 1674011554U;
					num3 = num9 - num10;
					goto IL_15A;
					IL_59:
					ParameterInfo[] array4 = parameters;
					num = 391790260U % num;
					object[] array5 = new object[array4.Length];
					num &= 1632640981U;
					array = array5;
					goto IL_0C;
				}
			}
		}
		IL_1C6:
		using (Dictionary<int, GClass18.Class7>.Enumerator enumerator = dictionary.GetEnumerator())
		{
			do
			{
				for (;;)
				{
					num = 1609631103U >> (int)num;
					if (115106489U - num != 0U)
					{
						if (!enumerator.MoveNext())
						{
							break;
						}
						KeyValuePair<int, GClass18.Class7> keyValuePair = enumerator.Current;
						keyValuePair.Value.vmethod_2(array[keyValuePair.Key]);
						num = 223613772U;
					}
				}
			}
			while (1629449208U == num);
		}
		return this.method_24(object_, methodBase_0.DeclaringType);
	}

	// Token: 0x06000151 RID: 337 RVA: 0x0000AE10 File Offset: 0x00009010
	private bool method_30(MethodBase methodBase_0, object object_0, ref object object_1, object[] object_2)
	{
		uint num = 1380608927U;
		for (;;)
		{
			IL_169:
			Type declaringType = methodBase_0.DeclaringType;
			num ^= 449076961U;
			Type type = declaringType;
			num /= 1810717571U;
			while (type != null)
			{
				if (1544424041U <= num)
				{
					break;
				}
				Type type2 = type;
				num = (1767967751U ^ num);
				if (!type2.IsGenericType)
				{
					goto IL_220;
				}
				for (;;)
				{
					Type genericTypeDefinition = type.GetGenericTypeDefinition();
					Type typeFromHandle = typeof(Nullable<>);
					num += 0U;
					if (genericTypeDefinition != typeFromHandle)
					{
						goto IL_220;
					}
					num &= 1252539835U;
					if ((1726175884U & num) == 0U)
					{
						goto IL_230;
					}
					num >>= 24;
					string name = methodBase_0.Name;
					string b = "get_HasValue";
					StringComparison comparisonType = (int)num + (StringComparison)(-68);
					num >>= 27;
					bool flag = string.Equals(name, b, comparisonType);
					num = 0U;
					if (flag)
					{
						goto IL_182;
					}
					string name2 = methodBase_0.Name;
					num = 1722515086U << (int)num;
					bool flag2 = string.Equals(name2, "get_Value", (StringComparison)(num ^ 1722515082U));
					num = (1332024552U | num);
					if (flag2)
					{
						break;
					}
					if (num < 942026027U)
					{
						goto IL_230;
					}
					string name3 = methodBase_0.Name;
					num = (583739704U | num);
					string value = "GetValueOrDefault";
					num &= 989938883U;
					bool flag3 = name3.Equals(value, (int)num + (StringComparison)(-721503422));
					num %= 1394301559U;
					num += 3573463870U;
					if (!flag3)
					{
						goto IL_218;
					}
					num >>= 9;
					if (517298688U > num)
					{
						goto IL_148;
					}
				}
				bool flag4 = object_0 != null;
				num = 1567373173U % num;
				if (!flag4)
				{
					goto IL_1C3;
				}
				num /= 1102999049U;
				if ((677065453U ^ num) == 0U)
				{
					goto IL_169;
				}
				object_1 = object_0;
				if (num * 432110684U != 0U)
				{
					goto Block_11;
				}
				continue;
				IL_148:
				if (object_0 != null)
				{
					goto IL_1FD;
				}
				num = (744972196U & num);
				if (num <= 548931690U)
				{
					goto IL_1DB;
				}
			}
			goto Block_13;
		}
		Block_11:
		num ^= 1U;
		goto IL_218;
		Block_13:
		goto IL_230;
		IL_182:
		num &= 1040650876U;
		num = 1342116949U << (int)num;
		object obj = object_0;
		num ^= 732901016U;
		object obj2 = null;
		num = 1773733856U << (int)num;
		bool flag5 = obj > obj2;
		num /= 825518954U;
		object_1 = flag5;
		goto IL_218;
		IL_1C3:
		num |= 1407473145U;
		throw new InvalidOperationException();
		IL_1DB:
		object obj3 = Activator.CreateInstance(Nullable.GetUnderlyingType(methodBase_0.DeclaringType));
		num /= 544160049U;
		object_0 = obj3;
		num ^= 0U;
		IL_1FD:
		num = 1723553896U + num;
		num |= 1768385722U;
		object_1 = object_0;
		num ^= 1879014650U;
		IL_218:
		return (num ^ 1U) != 0U;
		IL_220:
		num ^= 1805152642U;
		return num + 4245062267U != 0U;
		IL_230:
		num ^= 1480603703U;
		return num - 1480603703U != 0U;
	}

	// Token: 0x06000152 RID: 338 RVA: 0x0000B05C File Offset: 0x0000925C
	private GClass18.Class7 method_31(MethodBase methodBase_0, bool bool_0)
	{
		MethodInfo methodInfo;
		uint num;
		Dictionary<int, GClass18.Class7> dictionary;
		object[] array;
		object obj4;
		object obj6;
		object[] array5;
		Dictionary<MethodBase, DynamicMethod> dictionary4;
		for (;;)
		{
			IL_00:
			methodInfo = (methodBase_0 as MethodInfo);
			GClass18.Class7 @class;
			for (;;)
			{
				IL_3CD:
				ParameterInfo[] parameters = methodBase_0.GetParameters();
				num = 981669939U;
				for (;;)
				{
					IL_2D1:
					dictionary = new Dictionary<int, GClass18.Class7>();
					if (731151598U >> (int)num != 0U)
					{
						object obj3;
						for (;;)
						{
							int num2 = parameters.Length;
							num /= 208810585U;
							array = new object[num2];
							ParameterInfo[] array2 = parameters;
							num /= 2098662540U;
							int num3 = array2.Length;
							int num4 = (int)(num ^ 1U);
							num = (1192588542U & num);
							int num5 = num3 - num4;
							if (787240760U < num)
							{
								goto IL_3CD;
							}
							for (;;)
							{
								num ^= 1532978799U;
								if (1763588646U <= num)
								{
									goto IL_00;
								}
								uint num6 = (uint)num5;
								num = (405889960U ^ num);
								if (num6 < num - 1131283911U)
								{
									break;
								}
								@class = this.method_1();
								bool flag = @class.vmethod_3();
								num = 1547483520U;
								if (flag)
								{
									Dictionary<int, GClass18.Class7> dictionary2 = dictionary;
									int key = num5;
									num = 1467420889U - num;
									dictionary2[key] = @class;
									num += 1627546151U;
								}
								num = (1476538189U | num);
								object[] array3 = array;
								int num7 = num5;
								num = 1583249480U >> (int)num;
								object object_ = @class;
								num |= 882928178U;
								ParameterInfo[] array4 = parameters;
								num = 2043704436U << (int)num;
								ParameterInfo parameterInfo = array4[num5];
								num = 2143375788U - num;
								GClass18.Class7 class2 = this.method_24(object_, parameterInfo.ParameterType);
								num *= 795632209U;
								object obj = class2.vmethod_1();
								num = 1082675577U + num;
								array3[num7] = obj;
								int num8 = num5 - (int)(num - 2967929060U);
								num <<= 5;
								num5 = num8;
								num ^= 484449440U;
							}
							num /= 1165518980U;
							num = 644116008U - num;
							bool isStatic = methodBase_0.IsStatic;
							num -= 617112055U;
							GClass18.Class7 class3;
							if (!isStatic)
							{
								num <<= 17;
								class3 = this.method_1();
							}
							else
							{
								num = 2036270166U << (int)num;
								class3 = null;
								num ^= 281935872U;
							}
							num = 1213743570U * num;
							@class = class3;
							num = 119421037U - num;
							if (num <= 63921981U)
							{
								goto IL_00;
							}
							object obj2;
							if (@class == null)
							{
								if (991251825U == num)
								{
									goto IL_2D1;
								}
								obj2 = null;
							}
							else
							{
								num %= 1157267413U;
								if (num >= 951862776U)
								{
									goto IL_00;
								}
								GClass18.Class7 class4 = @class;
								num *= 1530489899U;
								obj2 = class4.vmethod_1();
								num ^= 786452002U;
							}
							num &= 1759055914U;
							bool flag2 = (obj3 = obj2) != null;
							num = 153236481U % num;
							if (flag2)
							{
								break;
							}
							num %= 849771278U;
							if (num != 954036993U)
							{
								goto Block_9;
							}
						}
						IL_252:
						num -= 368137420U;
						obj4 = obj3;
						num = (1109740418U & num);
						if (num > 1994090562U)
						{
							goto IL_00;
						}
						num /= 1125714453U;
						if (bool_0)
						{
							num = (1653564526U ^ num);
							bool flag3 = obj4 != null;
							num /= 1450915543U;
							num += uint.MaxValue;
							if (!flag3)
							{
								goto IL_613;
							}
						}
						num += 546854167U;
						object obj5 = null;
						num = 1546085100U * num;
						obj6 = obj5;
						num <<= 22;
						if (num / 2111782622U == 0U)
						{
							continue;
						}
						break;
						Block_9:
						obj3 = null;
						num ^= 0U;
						goto IL_252;
					}
					goto IL_3CD;
				}
				if (methodBase_0.IsConstructor)
				{
					num = 1244534781U / num;
					if (num > 1692940552U)
					{
						continue;
					}
					num <<= 4;
					Type declaringType = methodBase_0.DeclaringType;
					num = 1463839958U - num;
					bool isValueType = declaringType.IsValueType;
					num -= 1691561962U;
					num ^= 1064123628U;
					if (isValueType)
					{
						break;
					}
				}
				num = (772824305U ^ num);
				if (521144642U != num)
				{
					num >>= 27;
					object object_2 = obj4;
					num %= 1077871294U;
					num /= 240713850U;
					object[] object_3 = array;
					num = 1779254093U - num;
					bool flag4 = this.method_30(methodBase_0, object_2, ref obj6, object_3);
					num ^= 1870301901U;
					if (flag4)
					{
						goto IL_A81;
					}
					num = 2102867260U << (int)num;
					if (1257310472U / num != 0U)
					{
						goto IL_00;
					}
					if (bool_0)
					{
						goto IL_A5E;
					}
					if (num - 1908084628U != 0U)
					{
						goto IL_4A7;
					}
				}
			}
			num <<= 14;
			if (num > 816394034U)
			{
				continue;
			}
			object obj7 = Activator.CreateInstance(methodBase_0.DeclaringType, array);
			num = 902711242U << (int)num;
			obj4 = obj7;
			bool flag5 = @class != null;
			num -= 810974794U;
			if (!flag5)
			{
				break;
			}
			bool flag6 = @class.vmethod_3();
			num ^= 0U;
			if (!flag6)
			{
				break;
			}
			num /= 260913500U;
			if (num > 1542021396U)
			{
				continue;
			}
			GClass18.Class7 class5 = @class;
			num &= 203439525U;
			object object_4 = obj4;
			num ^= 937712879U;
			object object_5 = this.method_24(object_4, methodBase_0.DeclaringType).vmethod_1();
			num <<= 20;
			class5.vmethod_2(object_5);
			if (340220819U <= num)
			{
				goto Block_24;
			}
			continue;
			IL_4A7:
			num *= 1366237100U;
			bool isVirtual = methodBase_0.IsVirtual;
			num += 2789813484U;
			if (!isVirtual)
			{
				goto IL_A5E;
			}
			num = 1545017788U % num;
			if (num != 1335323424U)
			{
				bool isFinal = methodBase_0.IsFinal;
				num ^= 557853824U;
				if (isFinal)
				{
					goto IL_A5E;
				}
				ParameterInfo[] parameters;
				int num9 = parameters.Length;
				num *= 89481510U;
				int num10 = num9;
				num = 1015114282U * num;
				int num11 = num10 + (int)(num - 1274071567U);
				num = 737624248U + num;
				array5 = new object[num11];
				object[] array6 = array5;
				int num12 = (int)(num - 2011695816U);
				num = 370961181U + num;
				object obj8 = obj4;
				num = 1317961586U % num;
				array6[num12] = obj8;
				num -= 300701699U;
				int num13 = (int)(num ^ 1017259887U);
				for (;;)
				{
					int num14 = num13;
					num = (561840331U & num);
					ParameterInfo[] array7 = parameters;
					num %= 1366690084U;
					int num15 = array7.Length;
					num -= 99880146U;
					int num16 = num15;
					num /= 778637309U;
					if (num14 >= num16)
					{
						break;
					}
					array5[num13 + 1] = array[num13];
					num13++;
					num = 1017259887U;
				}
				num = (931999490U ^ num);
				if (2044285681U + num != 0U)
				{
					Dictionary<MethodBase, DynamicMethod> dictionary3 = GClass18.dictionary_2;
					num = 1579945616U >> (int)num;
					dictionary4 = dictionary3;
					num = 2035750900U - num;
					if (num != 502169306U)
					{
						goto Block_30;
					}
				}
			}
		}
		IL_A81:
		while (num == 1492270002U)
		{
		}
		Dictionary<int, GClass18.Class7>.Enumerator enumerator = dictionary.GetEnumerator();
		num = (1297178231U & num);
		using (Dictionary<int, GClass18.Class7>.Enumerator enumerator2 = enumerator)
		{
			if (1759188854 << (int)num == 0)
			{
				goto IL_ACA;
			}
			IL_AAD:
			num |= 1423127081U;
			bool flag7 = enumerator2.MoveNext();
			num += 1464630769U;
			if (!flag7)
			{
				goto IL_B83;
			}
			IL_ACA:
			KeyValuePair<int, GClass18.Class7> keyValuePair = enumerator2.Current;
			keyValuePair.Value.vmethod_2(array[keyValuePair.Key]);
			num = 89212928U;
			goto IL_AAD;
		}
		IL_B2C:
		num %= 675356814U;
		MethodInfo methodInfo2 = methodInfo;
		num &= 1098396483U;
		Type returnType = methodInfo2.ReturnType;
		RuntimeTypeHandle handle = typeof(void).TypeHandle;
		num += 1335374703U;
		Type typeFromHandle = Type.GetTypeFromHandle(handle);
		num = 277948992U * num;
		if (returnType == typeFromHandle)
		{
			num ^= 1705028442U;
			goto IL_BC0;
		}
		num = (1857235882U | num);
		if (685061273 << (int)num != 0)
		{
			num >>= 2;
			object object_6 = obj6;
			MethodInfo methodInfo3 = methodInfo;
			num &= 1472360569U;
			return this.method_24(object_6, methodInfo3.ReturnType);
		}
		IL_B83:
		bool flag8 = methodInfo != null;
		num = 2018188570U;
		if (flag8)
		{
			goto IL_B2C;
		}
		IL_BC0:
		num = (918257647U ^ num);
		return null;
		Block_24:
		num += 914868608U;
		goto IL_A81;
		Block_30:
		object obj9 = dictionary4;
		num <<= 12;
		Monitor.Enter(obj9);
		DynamicMethod dynamicMethod;
		try
		{
			ILGenerator ilgenerator2;
			do
			{
				IL_639:
				Dictionary<MethodBase, DynamicMethod> dictionary5 = GClass18.dictionary_2;
				num = (19218581U & num);
				bool flag9 = dictionary5.TryGetValue(methodBase_0, out dynamicMethod);
				num -= 166017259U;
				if (flag9)
				{
					goto IL_9A2;
				}
				for (;;)
				{
					IL_914:
					int num17 = array5.Length;
					num &= 698310876U;
					Type[] array8 = new Type[num17];
					for (;;)
					{
						IL_8DE:
						Type[] array9 = array8;
						num >>= 25;
						array9[(int)(num - 16U)] = methodBase_0.DeclaringType;
						int num18 = (int)(num - 16U);
						if (378163535U >= num)
						{
							for (;;)
							{
								num *= 328938139U;
								if ((78739864U ^ num) == 0U)
								{
									goto IL_914;
								}
								ParameterInfo[] parameters;
								if (num18 >= parameters.Length)
								{
									break;
								}
								array8[num18 + 1] = parameters[num18].ParameterType;
								num18++;
								num = 16U;
							}
							string name = "";
							if (methodInfo == null)
							{
								goto IL_72C;
							}
							num = (1036865658U | num);
							MethodInfo methodInfo4 = methodInfo;
							num %= 454969748U;
							Type returnType2 = methodInfo4.ReturnType;
							Type typeFromHandle2 = typeof(void);
							num = 1742346744U - num;
							if (returnType2 == typeFromHandle2)
							{
								num ^= 1503926934U;
								goto IL_72C;
							}
							MethodInfo methodInfo5 = methodInfo;
							num <<= 29;
							Type returnType3 = methodInfo5.ReturnType;
							num ^= 418824677U;
							IL_737:
							Type[] parameterTypes = array8;
							Module module = typeof(GClass18).Module;
							num -= 1514355649U;
							dynamicMethod = new DynamicMethod(name, returnType3, parameterTypes, module, (num ^ 2125694501U) != 0U);
							num >>= 23;
							if (542932203U <= num)
							{
								continue;
							}
							DynamicMethod dynamicMethod2 = dynamicMethod;
							num = (1619415680U ^ num);
							ILGenerator ilgenerator = dynamicMethod2.GetILGenerator();
							num = 707537272U - num;
							ilgenerator2 = ilgenerator;
							if (num == 452333043U)
							{
								goto IL_639;
							}
							ILGenerator ilgenerator3 = ilgenerator2;
							num >>= 8;
							GClass18.Class7 @class;
							bool flag10 = @class.vmethod_3();
							num = 71436835U * num;
							OpCode opcode;
							if (!flag10)
							{
								opcode = OpCodes.Ldarg;
							}
							else
							{
								num = 1815117160U - num;
								opcode = OpCodes.Ldarga;
								num += 3191837468U;
							}
							num = 1249397135U * num;
							int arg = (int)(num ^ 3348590302U);
							num <<= 27;
							ilgenerator3.Emit(opcode, arg);
							int num19 = (int)(num + 268435457U);
							num ^= 180363705U;
							int num20 = num19;
							if (num < 1198742616U)
							{
								goto IL_639;
							}
							for (;;)
							{
								num -= 716795438U;
								int num21 = num20;
								int num22 = array8.Length;
								num = 5636462U << (int)num;
								int num23 = num22;
								num = 1575973667U % num;
								if (num21 >= num23)
								{
									goto Block_48;
								}
								ILGenerator ilgenerator4 = ilgenerator2;
								Dictionary<int, GClass18.Class7> dictionary6 = dictionary;
								int key2 = num20 - 1;
								num = 1549795328U;
								OpCode opcode2;
								if (!dictionary6.ContainsKey(key2))
								{
									num = 540037514U / num;
									opcode2 = OpCodes.Ldarg;
								}
								else
								{
									num = (443564966U & num);
									opcode2 = OpCodes.Ldarga;
									num += 3886022656U;
								}
								num = 1528693852U << (int)num;
								ilgenerator4.Emit(opcode2, num20);
								if (1695883488U == num)
								{
									goto IL_8DE;
								}
								int num24 = num20 + (int)(num - 1528693851U);
								num = 543773982U % num;
								num20 = num24;
								num += 3663121563U;
							}
							IL_72C:
							num -= 1622960075U;
							returnType3 = null;
							goto IL_737;
						}
						goto IL_639;
					}
				}
				Block_48:
				num = 2084766590U % num;
				ILGenerator ilgenerator5 = ilgenerator2;
				num ^= 610602945U;
				OpCode call = OpCodes.Call;
				MethodInfo meth = methodInfo;
				num -= 1743809667U;
				ilgenerator5.Emit(call, meth);
				num -= 127666417U;
			}
			while (num < 1167855109U);
			ILGenerator ilgenerator6 = ilgenerator2;
			num = (752898259U ^ num);
			ilgenerator6.Emit(OpCodes.Ret);
			num >>= 4;
			GClass18.dictionary_2[methodBase_0] = dynamicMethod;
			num += 3904577382U;
			IL_9A2:;
		}
		finally
		{
			Monitor.Exit(dictionary4);
		}
		obj6 = dynamicMethod.Invoke(null, array5);
		using (Dictionary<int, GClass18.Class7>.Enumerator enumerator2 = dictionary.GetEnumerator())
		{
			do
			{
				for (;;)
				{
					num = 1058617789U;
					if (!enumerator2.MoveNext())
					{
						break;
					}
					KeyValuePair<int, GClass18.Class7> keyValuePair2 = enumerator2.Current;
					keyValuePair2.Value.vmethod_2(array5[keyValuePair2.Key + 1]);
				}
			}
			while (830887917U >= num);
		}
		dictionary.Clear();
		num = 91736448U;
		goto IL_A81;
		IL_613:
		throw new NullReferenceException();
		IL_A5E:
		object obj10 = methodBase_0.Invoke(obj4, array);
		num |= 1366820804U;
		obj6 = obj10;
		num += 2281214340U;
		goto IL_A81;
	}

	// Token: 0x06000153 RID: 339 RVA: 0x0000BC80 File Offset: 0x00009E80
	private GClass18.Class7 method_32(int int_1, bool bool_0)
	{
		uint num = 1393960917U;
		Dictionary<int, GClass18.Class7> dictionary;
		object[] array;
		int num13;
		object object_2;
		for (;;)
		{
			IL_309:
			num = 667039126U + num;
			int num2 = this.int_0;
			num = 606482993U - num;
			int num3 = num2;
			num = (713313555U | num);
			for (;;)
			{
				IL_256:
				num *= 304035059U;
				int num4 = int_1;
				num *= 1045251148U;
				this.int_0 = num4;
				for (;;)
				{
					ushort num5 = (ushort)this.method_4();
					num <<= 12;
					ushort num6 = num5;
					num = 2032340956U - num;
					ushort num7 = num6;
					num *= 1155493508U;
					if ((num ^ 1796751560U) == 0U)
					{
						goto IL_309;
					}
					dictionary = new Dictionary<int, GClass18.Class7>();
					num = 1141650025U / num;
					do
					{
						array = null;
						if (1755807328 << (int)num == 0)
						{
							goto IL_256;
						}
						if ((uint)num7 > num - 0U)
						{
							if (num == 1531844734U)
							{
								goto IL_256;
							}
							array = new object[(int)num7];
							if (690492515U < num)
							{
								goto IL_309;
							}
							int num8 = (int)num7;
							num %= 1388465067U;
							int num9 = (int)(num - uint.MaxValue);
							num %= 1571947648U;
							int num10 = num8 - num9;
							if (num >= 784548264U)
							{
								goto IL_309;
							}
							for (;;)
							{
								num = 135267357U + num;
								if (1879064774U + num == 0U)
								{
									goto IL_309;
								}
								uint num11 = (uint)num10;
								num >>= 20;
								if (num11 < num - 129U)
								{
									break;
								}
								GClass18.Class7 @class = this.method_1();
								GClass18.Class7 class2 = @class;
								num = 273637815U;
								if (class2.vmethod_3())
								{
									num &= 466883284U;
									Dictionary<int, GClass18.Class7> dictionary2 = dictionary;
									num |= 1203577425U;
									int key = num10;
									num += 1001277626U;
									GClass18.Class7 value = @class;
									num = 1237800497U / num;
									dictionary2[key] = value;
									num += 273637815U;
								}
								num = 531250008U << (int)num;
								object[] array2 = array;
								int num12 = num10;
								object object_ = @class;
								num ^= 499392921U;
								object obj = this.method_24(object_, this.method_26(this.method_5())).vmethod_1();
								num = (296102442U | num);
								array2[num12] = obj;
								num |= 2024342155U;
								num10 -= (int)(num - 4193201082U);
								num += 101766213U;
							}
							num ^= 129U;
						}
						num = 977169663U << (int)num;
						num13 = this.method_5();
						num = 1580090081U << (int)num;
					}
					while (num * 1178535222U != 0U);
					num |= 148513770U;
					int_1 = this.int_0;
					num = 2099931326U + num;
					if (1974739631U <= num)
					{
						goto IL_309;
					}
					int num14 = num3;
					num = 1428970402U - num;
					this.int_0 = num14;
					if (num + 1423343522U == 0U)
					{
						goto IL_309;
					}
					num = 2089424429U - num;
					if (!bool_0)
					{
						goto IL_2C2;
					}
					if (num - 1835999263U != 0U)
					{
						goto IL_273;
					}
				}
			}
			IL_273:
			bool flag = array != null;
			num = (718216860U | num);
			if (!flag)
			{
				goto IL_33E;
			}
			if (num == 947466663U)
			{
				continue;
			}
			object[] array3 = array;
			num -= 1550744958U;
			int num15 = (int)(num ^ 3548439105U);
			num += 1106974825U;
			bool flag2 = array3[num15];
			num = (1205747000U & num);
			num += 671616779U;
			if (!flag2)
			{
				goto IL_334;
			}
			IL_2C2:
			num &= 1459895539U;
			if (1568605430U > num)
			{
				GClass18 gclass = new GClass18();
				num = 1986738054U << (int)num;
				object_2 = gclass.method_112(array, int_1);
				num %= 505702969U;
				if (num != 620052356U)
				{
					break;
				}
			}
		}
		Dictionary<int, GClass18.Class7> dictionary3 = dictionary;
		num = 583013871U * num;
		using (Dictionary<int, GClass18.Class7>.Enumerator enumerator = dictionary3.GetEnumerator())
		{
			if (1161436184U == num)
			{
				goto IL_396;
			}
			for (;;)
			{
				IL_38A:
				if (num - 678914236U != 0U)
				{
					num = (629939946U ^ num);
					bool flag3 = enumerator.MoveNext();
					num %= 1290870679U;
					if (flag3)
					{
						goto IL_396;
					}
					if (1315513216U / num != 0U)
					{
						break;
					}
				}
			}
			goto IL_3F4;
			IL_396:
			KeyValuePair<int, GClass18.Class7> keyValuePair = enumerator.Current;
			keyValuePair.Value.vmethod_2(array[keyValuePair.Key]);
			num = 1879895734U;
			goto IL_38A;
		}
		IL_3F4:
		if (num13 != 0)
		{
			Type type = this.method_26(num13);
			Type type2 = type;
			RuntimeTypeHandle handle = typeof(void).TypeHandle;
			num = 22924U;
			if (type2 != Type.GetTypeFromHandle(handle))
			{
				num = 1617766837U >> (int)num;
				num -= 1904882472U;
				return this.method_24(object_2, type);
			}
		}
		return null;
		IL_334:
		num += 42801292U;
		IL_33E:
		throw new NullReferenceException();
	}

	// Token: 0x06000154 RID: 340 RVA: 0x0000C0F0 File Offset: 0x0000A2F0
	private bool method_33(object object_0, Type type_1)
	{
		uint num = 4144638993U;
		if (object_0 == null)
		{
			return num - 4144638992U != 0U;
		}
		num = (90977433U & num);
		Type type = object_0.GetType();
		num = (193939931U ^ num);
		Type type2 = type;
		Type type3 = type2;
		num %= 1716984743U;
		if (type3 != type_1)
		{
			num += 1327957303U;
			if (!type_1.IsAssignableFrom(type2))
			{
				return num + 2723253503U != 0U;
			}
			num ^= 1395203787U;
		}
		num ^= 1760108984U;
		return (num ^ 1718504563U) != 0U;
	}

	// Token: 0x06000155 RID: 341 RVA: 0x0000C16C File Offset: 0x0000A36C
	private void method_34(Exception exception_1)
	{
		uint num = 157315276U;
		GClass18.Class36 class2;
		for (;;)
		{
			IL_4BD:
			num = 1603616683U >> (int)num;
			this.stack_0.Clear();
			if (663166692U > num)
			{
				goto IL_42E;
			}
			goto IL_49F;
			for (;;)
			{
				IL_469:
				num &= 993150899U;
				num = 845952676U >> (int)num;
				if (this.stack_1.Count == 0)
				{
					goto Block_21;
				}
				List<GClass18.Class36> list = this.stack_1.Peek().method_4();
				bool flag = this.class36_0 != null;
				num = 4134721398U;
				int num4;
				if (flag)
				{
					num = 470879897U % num;
					if (num >= 1724328753U)
					{
						goto IL_4BD;
					}
					int num2 = list.IndexOf(this.class36_0);
					int num3 = (int)(num - 470879896U);
					num <<= 10;
					num4 = num2 + num3;
				}
				else
				{
					num -= 1717045322U;
					num4 = (int)(num ^ 2417676076U);
					num ^= 3558910764U;
				}
				num = (348263446U & num);
				GClass18.Class36 @class = null;
				num = 368715968U / num;
				this.class36_0 = @class;
				int num5 = num4;
				if (num <= 287774234U)
				{
					while (2113956319U > num)
					{
						int num6 = num5;
						num &= 539167616U;
						List<GClass18.Class36> list2 = list;
						num /= 1187924685U;
						int count = list2.Count;
						num = (1276802090U ^ num);
						if (num6 < count)
						{
							class2 = list[num5];
							byte b = class2.method_0();
							num = 448757663U;
							if (b != 0)
							{
								num = 1856375275U * num;
								byte b2 = b;
								num = 1905723106U / num;
								uint num7 = num + 0U;
								num = 791312041U + num;
								if (b2 == num7)
								{
									goto IL_391;
								}
								if (366114103U / num != 0U)
								{
									goto IL_42E;
								}
							}
							else
							{
								Type type = exception_1.GetType();
								if (50942587U >= num)
								{
									goto IL_44D;
								}
								Type type2 = this.method_26(class2.method_2());
								if (type == type2)
								{
									goto IL_52D;
								}
								num = 204426869U % num;
								bool flag2 = type.IsSubclassOf(type2);
								num ^= 587544799U;
								if (flag2)
								{
									goto IL_523;
								}
							}
							num = 820263937U % num;
							int num8 = num5;
							num %= 1565541055U;
							int num9 = (int)(num ^ 28951894U);
							num /= 357660558U;
							int num10 = num8 + num9;
							num = 1736337202U >> (int)num;
							num5 = num10;
							num += 2558630099U;
						}
						else
						{
							num -= 1876972686U;
							num <<= 16;
							Stack<GClass18.Class37> stack = this.stack_1;
							num >>= 13;
							stack.Pop();
							if (num + 58609901U != 0U)
							{
								int count2 = list.Count;
								num ^= 561409996U;
								int num11 = count2;
								while (num != 83183515U)
								{
									int num12 = num11;
									uint num13 = num - 561419052U;
									num |= 1680957761U;
									if (num12 > num13)
									{
										GClass18.Class36 class3 = list[num11 - 1];
										byte b3 = class3.method_0();
										int num14 = 2;
										num = 1937470607U;
										if (b3 == num14)
										{
											goto IL_2E5;
										}
										if (num * 1579702067U == 0U)
										{
											goto IL_4BD;
										}
										GClass18.Class36 class4 = class3;
										num = 1629772013U + num;
										byte b4 = class4.method_0();
										uint num15 = num ^ 3567242616U;
										num *= 2092456064U;
										if (b4 == num15)
										{
											num ^= 2362583695U;
											goto IL_2E5;
										}
										IL_31E:
										num11 -= (int)(num ^ 4289289729U);
										num ^= 3739209004U;
										continue;
										IL_2E5:
										num = 486633007U - num;
										num <<= 13;
										Stack<int> stack2 = this.stack_2;
										num = 1678579793U + num;
										stack2.Push(class3.method_1());
										num += 3697821103U;
										goto IL_31E;
									}
									if (num + 1027604562U == 0U)
									{
										goto IL_44D;
									}
									num -= 1184175014U;
									Stack<int> stack3 = this.stack_2;
									num >>= 1;
									bool count3 = stack3.Count != 0;
									num ^= 259092451U;
									if (count3)
									{
										goto Block_18;
									}
									goto IL_469;
								}
								goto IL_42E;
							}
							goto IL_469;
						}
					}
					goto IL_4BD;
				}
				goto IL_44D;
			}
			IL_391:
			num = 1420249778U >> (int)num;
			this.class36_0 = class2;
			num = 867566464U / num;
			if (num >> 27 != 0U)
			{
				continue;
			}
			num += 1315321712U;
			Stack<GClass18.Class8> stack4 = this.stack_0;
			num /= 1672308393U;
			GClass18.Class8 item = new GClass18.Class14(this.exception_0);
			num = 1642954634U + num;
			stack4.Push(item);
			num = 1235050209U << (int)num;
			int num16 = class2.method_2();
			num = 1447386114U << (int)num;
			this.int_0 = num16;
			if ((271329429U ^ num) == 0U)
			{
				goto IL_42E;
			}
			return;
			Block_18:
			if (1737785083U - num != 0U)
			{
				break;
			}
			goto IL_42E;
			IL_49F:
			num >>= 14;
			this.exception_0 = exception_1;
			if (num + 1210325936U == 0U)
			{
				continue;
			}
			num ^= 0U;
			goto IL_469;
			IL_44D:
			num &= 1656117029U;
			bool flag3 = this.class36_0 != null;
			num = 1170476746U * num;
			if (flag3)
			{
				goto IL_469;
			}
			num = (1708992623U & num);
			goto IL_49F;
			IL_42E:
			num /= 966094107U;
			Stack<int> stack5 = this.stack_2;
			num <<= 16;
			stack5.Clear();
			goto IL_44D;
		}
		num ^= 1586250894U;
		Stack<int> stack6 = this.stack_2;
		num += 777064728U;
		int num17 = stack6.Pop();
		num ^= 2129400960U;
		this.int_0 = num17;
		return;
		Block_21:
		num /= 21185107U;
		throw exception_1;
		IL_523:
		num ^= 898959669U;
		IL_52D:
		num = 324035046U / num;
		this.stack_1.Pop();
		num <<= 22;
		Stack<GClass18.Class8> stack7 = this.stack_0;
		num ^= 342713135U;
		num = (1440047854U | num);
		stack7.Push(new GClass18.Class14(this.exception_0));
		num = 1030971318U / num;
		num <<= 30;
		GClass18.Class36 class5 = class2;
		num = (1503399003U | num);
		int num18 = class5.method_1();
		num <<= 29;
		this.int_0 = num18;
	}

	// Token: 0x06000156 RID: 342 RVA: 0x0000C728 File Offset: 0x0000A928
	private void method_35()
	{
		GClass18.Class7 class2;
		uint num;
		do
		{
			Type type_ = this.method_26(this.method_1().DE119705());
			GClass18.Class7 @class = this.method_1();
			class2 = this.method_24(this.method_1().vmethod_1(), type_);
			bool flag = @class.vmethod_3();
			num = 1534996998U;
			if (flag)
			{
				if ((num & 1667791914U) == 0U)
				{
					continue;
				}
				GClass18.Class7 class7_ = class2;
				num = 55511543U - num;
				GClass18.Class7 class7_2 = @class;
				num ^= 96349950U;
				class2 = new GClass18.Class20(class7_, class7_2);
				num ^= 4178627337U;
			}
		}
		while (num / 1991116264U != 0U);
		num = (2102346325U | num);
		List<GClass18.Class7> list = this.list_0;
		num = 1318783437U << (int)num;
		GClass18.Class7 item = class2;
		num = 1241531915U >> (int)num;
		list.Add(item);
	}

	// Token: 0x06000157 RID: 343 RVA: 0x0000C808 File Offset: 0x0000AA08
	private void method_36()
	{
		int num = this.method_1().DE119705();
		List<GClass18.Class37>.Enumerator enumerator = this.list_1.GetEnumerator();
		uint num2 = 136U;
		using (List<GClass18.Class37>.Enumerator enumerator2 = enumerator)
		{
			if (1527911979U * num2 == 0U)
			{
				goto IL_A0;
			}
			IL_45:
			num2 += 2100061275U;
			bool flag = enumerator2.MoveNext();
			num2 = (461331349U ^ num2);
			if (!flag)
			{
				return;
			}
			IL_5E:
			GClass18.Class37 @class = enumerator2.Current;
			num2 = 2074763251U;
			IL_A0:
			GClass18.Class37 class2 = @class;
			num2 ^= 148388720U;
			int num3 = class2.method_0();
			int num4 = num;
			num2 += 2358090757U;
			if (num3 != num4)
			{
				goto IL_45;
			}
			if (473595254U > num2)
			{
				Stack<GClass18.Class37> stack = this.stack_1;
				GClass18.Class37 item = @class;
				num2 = (335420630U | num2);
				stack.Push(item);
				num2 += 3959546794U;
				goto IL_45;
			}
			goto IL_5E;
		}
	}

	// Token: 0x06000158 RID: 344 RVA: 0x0000C8FC File Offset: 0x0000AAFC
	private void method_37()
	{
		this.method_0(new GClass18.Class9(this.method_5()));
	}

	// Token: 0x06000159 RID: 345 RVA: 0x0000C91C File Offset: 0x0000AB1C
	private void method_38()
	{
		this.method_0(new GClass18.Class10(this.method_6()));
	}

	// Token: 0x0600015A RID: 346 RVA: 0x0000C93C File Offset: 0x0000AB3C
	private void method_39()
	{
		this.method_0(new GClass18.Class11(this.method_7()));
	}

	// Token: 0x0600015B RID: 347 RVA: 0x0000C95C File Offset: 0x0000AB5C
	private void method_40()
	{
		this.method_0(new GClass18.Class12(this.method_8()));
	}

	// Token: 0x0600015C RID: 348 RVA: 0x0000C97C File Offset: 0x0000AB7C
	private void method_41()
	{
		this.method_0(new GClass18.Class14(null));
	}

	// Token: 0x0600015D RID: 349 RVA: 0x0000C998 File Offset: 0x0000AB98
	private void method_42()
	{
		this.method_0(new GClass18.Class13(this.method_25(this.method_1().DE119705())));
	}

	// Token: 0x0600015E RID: 350 RVA: 0x0000C9C4 File Offset: 0x0000ABC4
	private void method_43()
	{
		this.method_0(this.method_2().vmethod_0());
	}

	// Token: 0x0600015F RID: 351 RVA: 0x0000C9E4 File Offset: 0x0000ABE4
	private void method_44()
	{
		uint num = 1978868136U;
		do
		{
			GClass18.Class7 @class = this.method_1();
			num >>= 2;
			GClass18.Class7 class2 = @class;
			num |= 1443912370U;
			num /= 1117741002U;
			GClass18.Class7 class3 = this.method_1();
			num ^= 675770185U;
			GClass18.Class7 class4 = class3;
			num |= 938023697U;
			num = 2029485529U * num;
			GClass18.Class7 class7_ = class2;
			GClass18.Class7 class7_2 = class4;
			num &= 215556835U;
			this.method_0(this.method_11(class7_, class7_2, (num ^ 135275105U) != 0U, num - 135275105U != 0U));
		}
		while (1002909259U < num);
	}

	// Token: 0x06000160 RID: 352 RVA: 0x0000CA64 File Offset: 0x0000AC64
	private void method_45()
	{
		GClass18.Class7 class7_ = this.method_1();
		GClass18.Class7 class7_2 = this.method_1();
		this.method_0(this.method_11(class7_, class7_2, true, false));
	}

	// Token: 0x06000161 RID: 353 RVA: 0x0000CA90 File Offset: 0x0000AC90
	private void method_46()
	{
		GClass18.Class7 @class = this.method_1();
		uint num = 126247912U;
		do
		{
			num = 226100426U % num;
			GClass18.Class7 class2 = this.method_1();
			num = 329939306U << (int)num;
			GClass18.Class7 class3 = class2;
			num = 1229998090U % num;
			num *= 1072447150U;
			GClass18.Class7 class7_ = @class;
			num *= 736959095U;
			GClass18.Class7 class7_2 = class3;
			bool bool_ = num + 4001389357U != 0U;
			bool bool_2 = num + 4001389357U != 0U;
			num = (1734678229U & num);
			GClass18.Class7 class7_3 = this.method_11(class7_, class7_2, bool_, bool_2);
			num *= 1607563002U;
			this.method_0(class7_3);
		}
		while (num < 1640058501U);
	}

	// Token: 0x06000162 RID: 354 RVA: 0x0000CB28 File Offset: 0x0000AD28
	private void method_47()
	{
		uint num = 2139557542U;
		GClass18.Class7 class7_ = this.method_1();
		do
		{
			GClass18.Class7 @class = this.method_1();
			if (num <= 1752898218U)
			{
				break;
			}
			num = 1066696684U / num;
			GClass18.Class7 class7_2 = @class;
			num += 664958625U;
			this.method_0(this.method_12(class7_2, class7_, num - 664958625U != 0U, num - 664958625U != 0U));
		}
		while (num / 289543823U == 0U);
	}

	// Token: 0x06000163 RID: 355 RVA: 0x0000CB88 File Offset: 0x0000AD88
	private void method_48()
	{
		uint num = 382676158U;
		GClass18.Class7 class7_;
		GClass18.Class7 @class;
		for (;;)
		{
			num %= 1878263116U;
			class7_ = this.method_1();
			if (453731947U >= num)
			{
				num ^= 2036609331U;
				@class = this.method_1();
				if (2035640259 << (int)num != 0)
				{
					break;
				}
			}
		}
		do
		{
			GClass18.Class7 class7_2 = @class;
			num /= 1715601467U;
			this.method_0(this.method_12(class7_2, class7_, (num ^ 0U) != 0U, (num ^ 1U) != 0U));
		}
		while (545409455U >> (int)num == 0U);
	}

	// Token: 0x06000164 RID: 356 RVA: 0x0000CC08 File Offset: 0x0000AE08
	private void method_49()
	{
		GClass18.Class7 class7_ = this.method_1();
		GClass18.Class7 class7_2 = this.method_1();
		this.method_0(this.method_12(class7_2, class7_, true, true));
	}

	// Token: 0x06000165 RID: 357 RVA: 0x0000CC34 File Offset: 0x0000AE34
	private void method_50()
	{
		GClass18.Class7 @class = this.method_1();
		GClass18.Class7 class2 = this.method_1();
		uint num = 1052979996U;
		do
		{
			GClass18.Class7 class7_ = class2;
			num = 2084516361U << (int)num;
			GClass18.Class7 class7_2 = @class;
			num <<= 5;
			bool bool_ = (num ^ 0U) != 0U;
			bool bool_2 = (num ^ 0U) != 0U;
			num %= 364150385U;
			GClass18.Class7 class7_3 = this.method_13(class7_, class7_2, bool_, bool_2);
			num = 990272797U + num;
			this.method_0(class7_3);
		}
		while (1970961045U + num == 0U);
	}

	// Token: 0x06000166 RID: 358 RVA: 0x0000CCB0 File Offset: 0x0000AEB0
	private void method_51()
	{
		uint num = 1497267314U;
		do
		{
			num %= 2028940080U;
			GClass18.Class7 @class = this.method_1();
			num -= 864051766U;
			if (1570250314U >> (int)num == 0U)
			{
				break;
			}
			GClass18.Class7 class3;
			do
			{
				num += 980306902U;
				GClass18.Class7 class2 = this.method_1();
				num += 1721435812U;
				class3 = class2;
				num = 997354886U * num;
			}
			while (96150676U >= num);
			num &= 254815851U;
			GClass18.Class7 class7_ = class3;
			num ^= 98467026U;
			GClass18.Class7 class7_2 = @class;
			bool bool_ = num + 4195460975U != 0U;
			num *= 1478648480U;
			bool bool_2 = num - 3863166784U != 0U;
			num |= 1128281976U;
			this.method_0(this.method_13(class7_, class7_2, bool_, bool_2));
		}
		while (1643581314U >= num);
	}

	// Token: 0x06000167 RID: 359 RVA: 0x0000CD5C File Offset: 0x0000AF5C
	private void method_52()
	{
		uint num = 111767018U;
		do
		{
			num = 119166845U >> (int)num;
			GClass18.Class7 @class = this.method_1();
			num = (2031890403U | num);
			GClass18.Class7 class7_ = @class;
			GClass18.Class7 class2;
			do
			{
				num &= 1155879500U;
				class2 = this.method_1();
				num = 338912539U * num;
			}
			while ((1523997941U ^ num) == 0U);
			num = 1217929861U % num;
			GClass18.Class7 class7_2 = class2;
			num &= 1714503544U;
			GClass18.Class7 class7_3 = this.method_13(class7_2, class7_, num + 3220168193U != 0U, num + 3220168193U != 0U);
			num = 1720672972U << (int)num;
			this.method_0(class7_3);
		}
		while ((661471660U ^ num) == 0U);
	}

	// Token: 0x06000168 RID: 360 RVA: 0x0000CDF8 File Offset: 0x0000AFF8
	private void method_53()
	{
		GClass18.Class7 class7_ = this.method_1();
		GClass18.Class7 class7_2 = this.method_1();
		this.method_0(this.method_14(class7_2, class7_, false));
	}

	// Token: 0x06000169 RID: 361 RVA: 0x0000CE24 File Offset: 0x0000B024
	private void method_54()
	{
		uint num = 1973701982U;
		do
		{
			GClass18.Class7 @class = this.method_1();
			num = 1836082425U >> (int)num;
			GClass18.Class7 class7_ = @class;
			GClass18.Class7 class7_2 = this.method_1();
			num = 2054252119U - num;
			this.method_0(this.method_14(class7_2, class7_, num + 2240715179U != 0U));
		}
		while (num % 2051299616U == 0U);
	}

	// Token: 0x0600016A RID: 362 RVA: 0x0000CE7C File Offset: 0x0000B07C
	private void method_55()
	{
		GClass18.Class7 class7_ = this.method_1();
		GClass18.Class7 class7_2 = this.method_1();
		this.method_0(this.method_15(class7_2, class7_, false));
	}

	// Token: 0x0600016B RID: 363 RVA: 0x0000CEA8 File Offset: 0x0000B0A8
	private void method_56()
	{
		GClass18.Class7 class7_ = this.method_1();
		GClass18.Class7 class7_2 = this.method_1();
		this.method_0(this.method_15(class7_2, class7_, true));
	}

	// Token: 0x0600016C RID: 364 RVA: 0x0000CED4 File Offset: 0x0000B0D4
	private void method_57()
	{
		GClass18.Class7 class7_ = this.method_1();
		GClass18.Class7 class7_2 = this.method_1();
		this.method_0(this.method_18(class7_2, class7_));
	}

	// Token: 0x0600016D RID: 365 RVA: 0x0000CF00 File Offset: 0x0000B100
	private void method_58()
	{
		GClass18.Class7 class7_ = this.method_1();
		GClass18.Class7 class7_2 = this.method_1();
		this.method_0(this.method_17(class7_2, class7_));
	}

	// Token: 0x0600016E RID: 366 RVA: 0x0000CF2C File Offset: 0x0000B12C
	private void method_59()
	{
		GClass18.Class7 class7_ = this.method_1();
		GClass18.Class7 class7_2 = this.method_1();
		this.method_0(this.method_16(class7_2, class7_));
	}

	// Token: 0x0600016F RID: 367 RVA: 0x0000CF58 File Offset: 0x0000B158
	private void method_60()
	{
		GClass18.Class7 class7_ = this.method_1();
		this.method_0(this.method_20(class7_));
	}

	// Token: 0x06000170 RID: 368 RVA: 0x0000CF7C File Offset: 0x0000B17C
	private void method_61()
	{
		GClass18.Class7 class7_ = this.method_1();
		this.method_0(this.method_21(class7_));
	}

	// Token: 0x06000171 RID: 369 RVA: 0x0000CFA0 File Offset: 0x0000B1A0
	private void method_62()
	{
		uint num = 568930861U;
		do
		{
			GClass18.Class7 @class = this.method_1();
			num = 972845608U * num;
			GClass18.Class7 class7_ = @class;
			GClass18.Class7 class7_2 = this.method_1();
			num = 1551399489U >> (int)num;
			num = (842157879U | num);
			this.method_0(this.method_22(class7_2, class7_, (num ^ 847150975U) != 0U));
		}
		while (655715088U >= num);
	}

	// Token: 0x06000172 RID: 370 RVA: 0x0000CFFC File Offset: 0x0000B1FC
	private void method_63()
	{
		uint num = 968831457U;
		do
		{
			GClass18.Class7 @class = this.method_1();
			num %= 264053676U;
			GClass18.Class7 class2 = this.method_1();
			num >>= 3;
			GClass18.Class7 class3 = class2;
			num -= 1632965243U;
			num = (1657210059U & num);
			GClass18.Class7 class7_ = class3;
			num |= 1627330100U;
			GClass18.Class7 class7_2 = @class;
			num &= 506480840U;
			GClass18.Class7 class7_3 = this.method_22(class7_, class7_2, num + 4258267073U != 0U);
			num /= 1708809044U;
			this.method_0(class7_3);
		}
		while ((num & 1559785135U) != 0U);
	}

	// Token: 0x06000173 RID: 371 RVA: 0x0000D074 File Offset: 0x0000B274
	private void method_64()
	{
		GClass18.Class7 class7_ = this.method_1();
		uint num = 2311803884U;
		GClass18.Class7 @class = this.method_1();
		do
		{
			GClass18.Class7 class7_2 = @class;
			num -= 635175885U;
			this.method_0(this.method_23(class7_2, class7_));
		}
		while (1938757764U == num);
	}

	// Token: 0x06000174 RID: 372 RVA: 0x0000D0C0 File Offset: 0x0000B2C0
	private void method_65()
	{
		Type type_ = this.method_26(this.method_1().DE119705());
		this.method_0(this.method_24(this.method_1(), type_));
	}

	// Token: 0x06000175 RID: 373 RVA: 0x0000D0F4 File Offset: 0x0000B2F4
	private void method_66()
	{
		uint num = 1673006347U;
		do
		{
			num = 323518101U * num;
			num = (1004607184U & num);
			Type type = this.method_26(this.method_1().DE119705());
			num = (858008609U & num);
			num ^= 956918760U;
			num = (1567245143U | num);
			GClass18.Class7 @class = this.method_1();
			Type type2 = type;
			num |= 1080631883U;
			bool bool_ = (num ^ 2104191999U) != 0U;
			num /= 1574650352U;
			object object_ = @class.F9291D0D(type2, bool_);
			num = 268698642U - num;
			Type type_ = type;
			num |= 899561222U;
			GClass18.Class7 class7_ = this.method_24(object_, type_);
			num ^= 1281711127U;
			this.method_0(class7_);
		}
		while (num <= 1826756834U);
	}

	// Token: 0x06000176 RID: 374 RVA: 0x0000D194 File Offset: 0x0000B394
	private void method_67()
	{
		Type type_ = this.method_26(this.method_1().DE119705());
		this.method_0(this.method_24(this.method_1().F9291D0D(type_, true), type_));
	}

	// Token: 0x06000177 RID: 375 RVA: 0x0000D1D0 File Offset: 0x0000B3D0
	private void method_68()
	{
		this.method_0(new GClass18.Class9(Marshal.SizeOf(this.method_26(this.method_5()))));
	}

	// Token: 0x06000178 RID: 376 RVA: 0x0000D1FC File Offset: 0x0000B3FC
	private void method_69()
	{
		uint num = 536087654U;
		for (;;)
		{
			num -= 1342246128U;
			num %= 123672225U;
			GClass18.Class7 @class = this.method_1();
			num <<= 24;
			int int_ = @class.DE119705();
			num %= 2065118923U;
			Type type_ = this.method_26(int_);
			if (num >= 335492135U)
			{
				GClass18.Class7 class2 = this.method_1();
				num = 1778543248U % num;
				GClass18.Class7 class3 = class2;
				num &= 1798793164U;
				if (!class3.vmethod_3())
				{
					GClass18.Class7 class4 = class2;
					num = 1563386971U >> (int)num;
					bool flag = class4.vmethod_1() is Pointer;
					num = (1803510831U & num);
					if (!flag)
					{
						break;
					}
					object ptr = class2.vmethod_1();
					num = (1187862910U ^ num);
					GClass18.Class7 class5 = new GClass18.Class23(new IntPtr(Pointer.Unbox(ptr)), type_);
					num = (1716026446U | num);
					class2 = class5;
					num += 2755175402U;
				}
				num &= 1276908670U;
				num <<= 12;
				num = 2053322790U * num;
				object object_ = class2;
				num <<= 13;
				this.method_0(this.method_24(object_, type_));
				if (num * 999249957U != 0U)
				{
					return;
				}
			}
		}
		throw new ArgumentException();
	}

	// Token: 0x06000179 RID: 377 RVA: 0x0000D304 File Offset: 0x0000B504
	private void method_70()
	{
		FieldInfo fieldInfo = this.method_28(this.method_1().DE119705());
		uint num = 15344U;
		object obj = this.method_1().vmethod_1();
		if (!fieldInfo.IsStatic)
		{
			if (num % 403261921U != 0U)
			{
				bool flag = obj != null;
				num = 162337610U - num;
				num += 4132660374U;
				if (flag)
				{
					goto IL_74;
				}
				num |= 1912807728U;
			}
			throw new NullReferenceException();
		}
		IL_74:
		num /= 1646552151U;
		num = 807883641U * num;
		FieldInfo fieldInfo2 = fieldInfo;
		object obj2 = obj;
		num ^= 1592660960U;
		this.method_0(this.method_24(fieldInfo2.GetValue(obj2), fieldInfo.FieldType));
	}

	// Token: 0x0600017A RID: 378 RVA: 0x0000D3B8 File Offset: 0x0000B5B8
	private void method_71()
	{
		FieldInfo fieldInfo = this.method_28(this.method_1().DE119705());
		object obj = this.method_1().vmethod_1();
		FieldInfo fieldInfo2 = fieldInfo;
		uint num = 1451229184U;
		if (!fieldInfo2.IsStatic)
		{
			bool flag = obj != null;
			num += 0U;
			if (!flag)
			{
				throw new NullReferenceException();
			}
		}
		num |= 1219369119U;
		this.method_0(new GClass18.Class21(fieldInfo, obj));
	}

	// Token: 0x0600017B RID: 379 RVA: 0x0000D438 File Offset: 0x0000B638
	private void method_72()
	{
		uint num = 832070649U;
		for (;;)
		{
			num |= 1811962004U;
			FieldInfo fieldInfo = this.method_28(this.method_1().DE119705());
			num = 2001289539U / num;
			FieldInfo fieldInfo2 = fieldInfo;
			GClass18.Class7 @class = this.method_1();
			num /= 1584618581U;
			GClass18.Class7 class2 = @class;
			for (;;)
			{
				num %= 454913365U;
				GClass18.Class7 class3 = this.method_1();
				num += 217386139U;
				object obj = class3.vmethod_1();
				num = (1152208380U & num);
				if (num >= 513036523U)
				{
					break;
				}
				if (!fieldInfo2.IsStatic)
				{
					num = 1823964262U << (int)num;
					bool flag = obj != null;
					num ^= 1654983832U;
					if (!flag)
					{
						num = 1684028496U + num;
						if (561675176U < num)
						{
							goto Block_3;
						}
						continue;
					}
				}
				num ^= 1455491577U;
				FieldInfo fieldInfo3 = fieldInfo2;
				object obj2 = obj;
				num = 1421870901U % num;
				num *= 1980453352U;
				object object_ = class2;
				num *= 290918382U;
				FieldInfo fieldInfo4 = fieldInfo2;
				num = (1756038063U ^ num);
				Type fieldType = fieldInfo4.FieldType;
				num += 1648579318U;
				fieldInfo3.SetValue(obj2, this.method_24(object_, fieldType).vmethod_1());
				if (1371372214U <= num)
				{
					return;
				}
			}
		}
		Block_3:
		throw new NullReferenceException();
	}

	// Token: 0x0600017C RID: 380 RVA: 0x0000D540 File Offset: 0x0000B740
	private void method_73()
	{
		FieldInfo fieldInfo = this.method_28(this.method_1().DE119705());
		GClass18.Class7 object_ = this.method_1();
		fieldInfo.SetValue(null, this.method_24(object_, fieldInfo.FieldType).vmethod_1());
	}

	// Token: 0x0600017D RID: 381 RVA: 0x0000D580 File Offset: 0x0000B780
	private void method_74()
	{
		Type type = this.method_26(this.method_1().DE119705());
		uint num = 97645U;
		for (;;)
		{
			num >>= 24;
			GClass18.Class7 object_ = this.method_1();
			num = 715481738U >> (int)num;
			GClass18.Class7 class2;
			for (;;)
			{
				GClass18.Class7 @class = this.method_1();
				num = 2059166258U * num;
				class2 = @class;
				if (class2.vmethod_3())
				{
					goto IL_C6;
				}
				if (1030125092U <= num)
				{
					object obj = class2.vmethod_1();
					num %= 1014593893U;
					if (!(obj is Pointer))
					{
						break;
					}
					num >>= 21;
					if (630014053U >= num)
					{
						IntPtr intptr_ = new IntPtr(Pointer.Unbox(class2.vmethod_1()));
						Type type_ = type;
						num %= 847523108U;
						GClass18.Class7 class3 = new GClass18.Class23(intptr_, type_);
						num = (1652319986U & num);
						class2 = class3;
						if (225924885 << (int)num != 0)
						{
							goto IL_B1;
						}
					}
				}
			}
			if (1504800119U * num != 0U)
			{
				break;
			}
			continue;
			IL_C6:
			GClass18.Class7 class4 = class2;
			num >>= 18;
			GClass18.Class7 class5 = this.method_24(object_, type);
			num %= 1854675016U;
			object object_2 = class5.vmethod_1();
			num = 862220960U / num;
			class4.vmethod_2(object_2);
			if (num >> 29 != 0U)
			{
				continue;
			}
			return;
			IL_B1:
			num ^= 3311276678U;
			goto IL_C6;
		}
		throw new ArgumentException();
	}

	// Token: 0x0600017E RID: 382 RVA: 0x0000D6B0 File Offset: 0x0000B8B0
	private void method_75()
	{
		this.method_0(this.list_0[(int)((ushort)this.method_4())].vmethod_0());
	}

	// Token: 0x0600017F RID: 383 RVA: 0x0000D6DC File Offset: 0x0000B8DC
	private void method_76()
	{
		this.method_0(new GClass18.Class19(this.list_0[(int)((ushort)this.method_4())]));
	}

	// Token: 0x06000180 RID: 384 RVA: 0x0000D708 File Offset: 0x0000B908
	private void method_77()
	{
		uint num = 1835210205U;
		GClass18.Class7 @class;
		GClass18.Class7 class2;
		do
		{
			num = 1268663553U % num;
			@class = this.method_1();
			if ((num ^ 358568276U) == 0U)
			{
				return;
			}
			List<GClass18.Class7> list = this.list_0;
			num *= 1950577707U;
			ushort num2 = (ushort)this.method_4();
			num &= 886930577U;
			class2 = list[(int)num2];
			num = (707552671U ^ num);
		}
		while (num > 1993684875U);
		GClass18.Class7 class3 = class2;
		num %= 1992232531U;
		object object_ = @class;
		num *= 442647663U;
		GClass18.Class7 class4 = class2;
		num = 1579507761U - num;
		object object_2 = this.method_24(object_, class4.vmethod_6()).vmethod_1();
		num += 1029527873U;
		class3.vmethod_2(object_2);
	}

	// Token: 0x06000181 RID: 385 RVA: 0x0000D7A4 File Offset: 0x0000B9A4
	private void method_78()
	{
		this.type_0 = this.method_26(this.method_1().DE119705());
	}

	// Token: 0x06000182 RID: 386 RVA: 0x0000D7C8 File Offset: 0x0000B9C8
	private void method_79()
	{
		uint num = 2021358200U;
		MethodBase methodBase;
		do
		{
			num += 262436063U;
			int int_ = this.method_1().DE119705();
			num *= 1645947495U;
			methodBase = this.method_27(int_);
		}
		while (num < 1252931771U);
		GClass18.Class7 class2;
		do
		{
			num += 735797057U;
			MethodBase methodBase_ = methodBase;
			num -= 1692149189U;
			GClass18.Class7 @class = this.method_31(methodBase_, num - 1430899581U != 0U);
			num %= 77289427U;
			class2 = @class;
			num = (378282410U | num);
		}
		while (1429691027U < num);
		do
		{
			bool flag = class2 != null;
			num = 1849647283U << (int)num;
			if (flag)
			{
				if (num + 1386244868U == 0U)
				{
					continue;
				}
				num = 2125230198U + num;
				this.method_0(class2);
				num += 2169737098U;
			}
		}
		while ((num & 1599735069U) == 0U);
	}

	// Token: 0x06000183 RID: 387 RVA: 0x0000D880 File Offset: 0x0000BA80
	private void method_80()
	{
		for (;;)
		{
			IL_00:
			MethodBase methodBase = this.method_27(this.method_1().DE119705());
			uint num = 1800703573U;
			MethodBase methodBase2 = methodBase;
			for (;;)
			{
				num /= 520841866U;
				bool flag = this.type_0 != null;
				num = 1272408838U / num;
				if (flag)
				{
					num /= 1702955851U;
					goto IL_40;
				}
				goto IL_1E0;
				IL_79:
				int num2 = (int)(num - 472318056U);
				ParameterInfo[] array;
				Type[] array2;
				int num3;
				if (1560422902 << (int)num != 0)
				{
					for (;;)
					{
						num &= 1815306475U;
						if (num / 1580083163U != 0U)
						{
							goto IL_00;
						}
						if (num2 >= array.Length)
						{
							break;
						}
						ParameterInfo parameterInfo = array[num2];
						array2[num3++] = parameterInfo.ParameterType;
						num2++;
						num = 472318056U;
					}
					Type type = this.type_0;
					num /= 233057531U;
					string name = methodBase2.Name;
					BindingFlags bindingAttr = (BindingFlags)(num ^ 12596U);
					Binder binder = null;
					num |= 1586300517U;
					Type[] types = array2;
					num -= 601557769U;
					ParameterModifier[] modifiers = null;
					num += 1282500365U;
					MethodInfo method = type.GetMethod(name, bindingAttr, binder, types, modifiers);
					bool flag2 = method != null;
					num = 1270100790U - num;
					if (flag2)
					{
						num %= 1584019771U;
						methodBase2 = method;
						num ^= 3274477210U;
					}
					num = 760285727U >> (int)num;
					num = (1635664929U ^ num);
					Type type2 = null;
					num |= 341061628U;
					this.type_0 = type2;
					num += 2747833946U;
					goto IL_1E0;
				}
				continue;
				IL_40:
				ParameterInfo[] parameters = methodBase2.GetParameters();
				num = (2135309358U & num);
				array2 = new Type[parameters.Length];
				int num4 = (int)(num - 0U);
				num = (1035927660U | num);
				num3 = num4;
				num = (1550280170U & num);
				array = parameters;
				goto IL_79;
				IL_1E0:
				MethodBase methodBase_ = methodBase2;
				num = 1841824289U % num;
				GClass18.Class7 @class = this.method_31(methodBase_, num - 145279172U != 0U);
				num <<= 31;
				GClass18.Class7 class2 = @class;
				num /= 631337617U;
				bool flag3 = class2 != null;
				num += 1619941333U;
				if (flag3)
				{
					if ((num ^ 1854483737U) == 0U)
					{
						goto IL_79;
					}
					num %= 1797607932U;
					this.method_0(class2);
					num += 0U;
				}
				if (2044819101U >> (int)num == 0U)
				{
					goto IL_40;
				}
				return;
			}
		}
	}

	// Token: 0x06000184 RID: 388 RVA: 0x0000DAE0 File Offset: 0x0000BCE0
	private void method_81()
	{
		uint num = 746464087U;
		MethodBase methodBase2;
		do
		{
			MethodBase methodBase = this.method_1().vmethod_1() as MethodBase;
			num = (519508448U ^ num);
			methodBase2 = methodBase;
			num /= 673003503U;
			if (methodBase2 != null)
			{
				goto IL_3D;
			}
		}
		while (num / 310721813U != 0U);
		throw new ArgumentException();
		IL_3D:
		num = 2091477583U * num;
		MethodBase methodBase_ = methodBase2;
		num = (1999131076U & num);
		bool bool_ = num - 1948794948U != 0U;
		num -= 1309757285U;
		GClass18.Class7 @class = this.method_31(methodBase_, bool_);
		num &= 83191471U;
		GClass18.Class7 class2 = @class;
		do
		{
			if (class2 != null)
			{
				num *= 566571883U;
				GClass18.Class7 class7_ = class2;
				num = 1567687131U * num;
				this.method_0(class7_);
				num += 3387173640U;
			}
		}
		while (442958661U == num);
	}

	// Token: 0x06000185 RID: 389 RVA: 0x0000DB8C File Offset: 0x0000BD8C
	private void method_82()
	{
		uint num;
		do
		{
			GClass18.Class7 @class = this.method_32(this.method_1().DE119705(), false);
			bool flag = @class != null;
			num = 682110853U;
			if (flag)
			{
				num &= 1293385228U;
				this.method_0(@class);
				num += 547881345U;
			}
		}
		while (num <= 28509335U);
	}

	// Token: 0x06000186 RID: 390 RVA: 0x0000DBEC File Offset: 0x0000BDEC
	private void method_83()
	{
		uint num = 1274695326U;
		GClass18.Class7 @class;
		do
		{
			num &= 2019700640U;
			num = 1312559370U / num;
			@class = this.method_32(this.method_1().DE119705(), (num ^ 0U) != 0U);
			num ^= 1423835869U;
			if (num > 1982738341U)
			{
				break;
			}
			bool flag = @class != null;
			num /= 1441941686U;
			if (!flag)
			{
				return;
			}
		}
		while ((num ^ 133782767U) == 0U);
		this.method_0(@class);
		num += 0U;
	}

	// Token: 0x06000187 RID: 391 RVA: 0x0000DC60 File Offset: 0x0000BE60
	private void method_84()
	{
		uint num = 364385154U;
		GClass18.Class7 class2;
		do
		{
			int int_ = this.method_1().DE119705();
			num = (1841120146U & num);
			MethodBase methodBase = this.method_27(int_);
			num |= 67461773U;
			MethodBase methodBase_ = methodBase;
			num += 342518899U;
			num = 1402417607U << (int)num;
			GClass18.Class7 @class = this.method_29(methodBase_);
			num /= 1683190540U;
			class2 = @class;
			if (class2 == null)
			{
				return;
			}
		}
		while (1962412674U == num);
		this.method_0(class2);
		num ^= 0U;
	}

	// Token: 0x06000188 RID: 392 RVA: 0x0000DCDC File Offset: 0x0000BEDC
	private void method_85()
	{
		uint num = 1414739560U;
		GClass18.Class7 class2;
		FieldInfo[] array;
		int i;
		for (;;)
		{
			num = 202004200U << (int)num;
			GClass18.Class7 @class = this.method_1();
			num = 689523322U + num;
			int int_ = @class.DE119705();
			num = 1624053170U << (int)num;
			Type type = this.method_26(int_);
			for (;;)
			{
				class2 = this.method_1();
				if (2014062031U < num)
				{
					for (;;)
					{
						IL_EF:
						bool isGenericType = type.IsGenericType;
						num += 345855348U;
						if (isGenericType)
						{
							Type type2 = type;
							num = 1257247182U << (int)num;
							Type genericTypeDefinition = type2.GetGenericTypeDefinition();
							RuntimeTypeHandle handle = typeof(Nullable<>).TypeHandle;
							num = 1424453473U * num;
							Type typeFromHandle = Type.GetTypeFromHandle(handle);
							num += 3418183028U;
							if (genericTypeDefinition == typeFromHandle)
							{
								goto Block_5;
							}
						}
						while (1668246278 << (int)num != 0)
						{
							Type type3 = type;
							num = 425212112U / num;
							bool isValueType = type3.IsValueType;
							num = 1001074163U << (int)num;
							if (isValueType)
							{
								if (num <= 337854927U)
								{
									break;
								}
								Type type4 = type;
								BindingFlags bindingAttr = (BindingFlags)(num - 1001074047U);
								num = 1281515374U % num;
								FieldInfo[] fields = type4.GetFields(bindingAttr);
								num = 1066812555U >> (int)num;
								array = fields;
								int num2 = (int)(num ^ 7U);
								num = 1639282925U >> (int)num;
								i = num2;
								if (453342298U >= num)
								{
									goto IL_20D;
								}
							}
							else
							{
								num = 1110716372U * num;
								if ((num ^ 348476984U) != 0U)
								{
									goto Block_4;
								}
								goto IL_EF;
							}
						}
						break;
					}
				}
			}
			Block_5:
			num <<= 3;
			class2.vmethod_2(null);
			if (1513515545U - num != 0U)
			{
				return;
			}
		}
		IL_20D:
		while (i < array.Length)
		{
			FieldInfo fieldInfo = array[i];
			FieldInfo fieldInfo2 = fieldInfo;
			object obj = class2.vmethod_1();
			bool isValueType2 = fieldInfo.FieldType.IsValueType;
			num = 1125540334U;
			object value;
			if (!isValueType2)
			{
				value = null;
			}
			else
			{
				Type fieldType = fieldInfo.FieldType;
				num = 874448029U << (int)num;
				value = Activator.CreateInstance(fieldType);
				num ^= 2184258030U;
			}
			fieldInfo2.SetValue(obj, value);
			num &= 552103547U;
			int num3 = i;
			num = (362161447U | num);
			int num4 = (int)(num + 3932789394U);
			num &= 368932743U;
			i = num3 + num4;
			num += 3945727466U;
		}
		return;
		Block_4:
		GClass18.Class7 class3 = class2;
		num /= 24999891U;
		class3.vmethod_2(null);
	}

	// Token: 0x06000189 RID: 393 RVA: 0x0000DF14 File Offset: 0x0000C114
	private void method_86()
	{
		int int_ = this.method_1().DE119705();
		GClass18.Class7 @class = this.method_1();
		uint num = 0U;
		GClass18.Class7 class2 = this.method_1();
		do
		{
			num -= 808925412U;
			GClass18.Class7 class7_ = class2;
			num += 157046958U;
			GClass18.Class7 class7_2 = @class;
			bool bool_ = (num ^ 3643088842U) != 0U;
			num &= 1506420722U;
			this.method_0(new GClass18.Class9(this.method_19(class7_, class7_2, bool_, int_)));
		}
		while (1257729344U >> (int)num == 0U);
	}

	// Token: 0x0600018A RID: 394 RVA: 0x0000DF94 File Offset: 0x0000C194
	private void method_87()
	{
		uint num = 2052069107U;
		for (;;)
		{
			num &= 1016742839U;
			GClass18.Class7 @class = this.method_1();
			num >>= 27;
			int int_ = @class.DE119705();
			GClass18.Class7 class2 = this.method_1();
			GClass18.Class7 class3 = this.method_1();
			num = 732315028U % num;
			if (147484175U + num != 0U)
			{
				GClass18.Class7 class7_ = class3;
				num = 1853580791U >> (int)num;
				GClass18.Class7 class7_2 = class2;
				num <<= 26;
				bool bool_ = num + 2214592513U != 0U;
				num %= 1131022453U;
				int int_2 = this.method_19(class7_, class7_2, bool_, int_);
				num >>= 6;
				this.method_0(new GClass18.Class9(int_2));
				if (num <= 789327919U)
				{
					break;
				}
			}
		}
	}

	// Token: 0x0600018B RID: 395 RVA: 0x0000E034 File Offset: 0x0000C234
	private void method_88()
	{
		Type elementType = this.method_26(this.method_1().DE119705());
		uint num = 963190924U;
		do
		{
			Array array_ = Array.CreateInstance(elementType, this.method_1().DE119705());
			num /= 944776336U;
			GClass18.Class7 class7_ = new GClass18.Class17(array_);
			num = 1155533990U << (int)num;
			this.method_0(class7_);
		}
		while ((977087406U ^ num) == 0U);
	}

	// Token: 0x0600018C RID: 396 RVA: 0x0000E0A8 File Offset: 0x0000C2A8
	private void method_89()
	{
		Type type_ = this.method_26(this.method_1().DE119705());
		uint num = 1951429103U;
		for (;;)
		{
			GClass18.Class7 @class = this.method_1();
			num = 1104304252U % num;
			GClass18.Class7 object_ = @class;
			num += 932975576U;
			GClass18.Class7 class2 = this.method_1();
			num = (461991727U & num);
			num %= 781403768U;
			GClass18.Class7 class3 = this.method_1();
			num += 637694082U;
			Array array = class3.vmethod_1() as Array;
			num = 1014172593U / num;
			Array array2 = array;
			num %= 49757080U;
			bool flag = array2 != null;
			num &= 867248671U;
			if (!flag)
			{
				break;
			}
			Array array3 = array2;
			num |= 887173894U;
			num -= 553025407U;
			object object_2 = this.method_24(object_, type_);
			Type type = array2.GetType();
			num <<= 28;
			Type elementType = type.GetElementType();
			num -= 1532828321U;
			GClass18.Class7 class4 = this.method_24(object_2, elementType);
			num = 2015380538U >> (int)num;
			object value = class4.vmethod_1();
			num = 1721764017U << (int)num;
			GClass18.Class7 class5 = class2;
			num = 436473617U / num;
			array3.SetValue(value, class5.DE119705());
			if (1702633855U + num != 0U)
			{
				return;
			}
		}
		throw new ArgumentException();
	}

	// Token: 0x0600018D RID: 397 RVA: 0x0000E1EC File Offset: 0x0000C3EC
	private void method_90()
	{
		uint num = 1581022836U;
		Type type_;
		GClass18.Class7 @class;
		Array array;
		for (;;)
		{
			num >>= 25;
			num >>= 7;
			type_ = this.method_26(this.method_1().DE119705());
			@class = this.method_1();
			array = (this.method_1().vmethod_1() as Array);
			num = 2079537109U;
			if (array == null)
			{
				break;
			}
			num %= 460982879U;
			if (num <= 1180324466U)
			{
				goto IL_81;
			}
		}
		throw new ArgumentException();
		IL_81:
		num = 1290164214U / num;
		object value = array.GetValue(@class.DE119705());
		num = 132533947U % num;
		GClass18.Class7 class7_ = this.method_24(value, type_);
		num = 707943437U >> (int)num;
		this.method_0(class7_);
	}

	// Token: 0x0600018E RID: 398 RVA: 0x0000E2B4 File Offset: 0x0000C4B4
	private void method_91()
	{
		for (;;)
		{
			Array array = this.method_1().vmethod_1() as Array;
			bool flag = array != null;
			uint num = 218157887U;
			if (flag)
			{
				Array array2 = array;
				num += 2050192280U;
				this.method_0(new GClass18.Class9(array2.Length));
				if (num > 924343802U)
				{
					break;
				}
			}
			else if (num >= 3242745U)
			{
				goto Block_2;
			}
		}
		return;
		Block_2:
		throw new ArgumentException();
	}

	// Token: 0x0600018F RID: 399 RVA: 0x0000E324 File Offset: 0x0000C524
	private void method_92()
	{
		uint num;
		do
		{
			GClass18.Class7 @class = this.method_1();
			Array array = this.method_1().vmethod_1() as Array;
			num = 0U;
			while (array == null)
			{
				if ((87953392U ^ num) != 0U)
				{
					goto IL_65;
				}
			}
			num = (1576229527U | num);
			Array array_ = array;
			num = 869888391U - num;
			this.method_0(new GClass18.Class22(array_, @class.DE119705()));
		}
		while (1158969389U >> (int)num == 0U);
		return;
		IL_65:
		throw new ArgumentException();
	}

	// Token: 0x06000190 RID: 400 RVA: 0x0000E39C File Offset: 0x0000C59C
	private void method_93()
	{
		uint num = 1753501493U;
		do
		{
			num %= 1728322813U;
			MethodBase methodBase_ = this.method_27(this.method_1().DE119705());
			num %= 477788689U;
			this.method_0(new GClass18.Class24(methodBase_));
		}
		while (num >> 12 == 0U);
	}

	// Token: 0x06000191 RID: 401 RVA: 0x0000E3E4 File Offset: 0x0000C5E4
	private void method_94()
	{
		uint num = 2019321932U;
		MethodBase methodBase;
		for (;;)
		{
			IL_25F:
			num = 188491264U >> (int)num;
			num = 168432613U << (int)num;
			GClass18.Class7 @class = this.method_1();
			num = (2101616875U & num);
			methodBase = this.method_27(@class.DE119705());
			for (;;)
			{
				IL_1EC:
				GClass18.Class7 class2 = this.method_1();
				num = 1345660631U << (int)num;
				object obj = class2.vmethod_1();
				num |= 1445947308U;
				Type type = obj.GetType();
				num = 877552050U * num;
				Type declaringType = methodBase.DeclaringType;
				ParameterInfo[] parameters = methodBase.GetParameters();
				int num2 = parameters.Length;
				num = 702742770U / num;
				Type[] array = new Type[num2];
				int num3 = (int)(num + 0U);
				num *= 1562841154U;
				int num4 = num3;
				ParameterInfo[] array2 = parameters;
				for (;;)
				{
					num = 1102578480U + num;
					int num5 = (int)(num ^ 1102578480U);
					num = 1884567371U * num;
					int num6 = num5;
					for (;;)
					{
						num = 310652882U + num;
						if (2142653746U + num == 0U)
						{
							goto IL_1EC;
						}
						int num7 = num6;
						ParameterInfo[] array3 = array2;
						num >>= 30;
						int num8 = array3.Length;
						num |= 70075826U;
						if (num7 >= num8)
						{
							break;
						}
						ParameterInfo parameterInfo = array2[num6];
						array[num4++] = parameterInfo.ParameterType;
						num6++;
						num = 3579330320U;
					}
					for (;;)
					{
						bool flag = type != null;
						num += 4230147853U;
						if (!flag)
						{
							break;
						}
						if (631326906U - num == 0U)
						{
							goto IL_25F;
						}
						Type type2 = type;
						num = 963261313U % num;
						Type type3 = declaringType;
						num /= 919621789U;
						if (type2 == type3)
						{
							goto Block_4;
						}
						MethodInfo method = type.GetMethod(methodBase.Name, BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.GetProperty | BindingFlags.SetProperty | BindingFlags.ExactBinding, null, CallingConventions.Any, array, null);
						bool flag2 = method != null;
						num = 3359489172U;
						if (flag2)
						{
							num += 615803966U;
							MethodInfo methodInfo = method;
							num = 939344531U + num;
							MethodInfo baseDefinition = methodInfo.GetBaseDefinition();
							MethodBase methodBase2 = methodBase;
							num += 2739818799U;
							if (baseDefinition == methodBase2)
							{
								goto Block_6;
							}
						}
						num = (1164924417U | num);
						if (num - 1698719409U == 0U)
						{
							goto IL_1EC;
						}
						Type type4 = type;
						num = 1928344735U * num;
						type = type4.BaseType;
						num += 1548215080U;
					}
					IL_1B2:
					num *= 866141724U;
					if (num / 971974363U != 0U)
					{
						continue;
					}
					goto IL_2A1;
					Block_4:
					num += 5256384U;
					goto IL_1B2;
					Block_6:
					num *= 461521610U;
					if ((num & 176181816U) != 0U)
					{
						MethodInfo method;
						MethodBase methodBase3 = method;
						num &= 97599476U;
						methodBase = methodBase3;
						goto IL_1B2;
					}
					goto IL_25F;
				}
			}
		}
		IL_2A1:
		num *= 508958548U;
		MethodBase methodBase_ = methodBase;
		num *= 81007047U;
		GClass18.Class7 class7_ = new GClass18.Class24(methodBase_);
		num = 1331907882U + num;
		this.method_0(class7_);
	}

	// Token: 0x06000192 RID: 402 RVA: 0x0000E6C0 File Offset: 0x0000C8C0
	private void method_95()
	{
		this.int_0 = this.method_1().DE119705();
	}

	// Token: 0x06000193 RID: 403 RVA: 0x0000E6E0 File Offset: 0x0000C8E0
	private void method_96()
	{
		uint num = 124148422U;
		do
		{
			this.method_1();
		}
		while (num >= 292769298U);
	}

	// Token: 0x06000194 RID: 404 RVA: 0x0000E704 File Offset: 0x0000C904
	private void method_97()
	{
		this.stack_2.Push(this.method_1().DE119705());
		GClass18.Class7 @class = this.method_1();
		uint num = 4073842038U;
		int num2 = @class.DE119705();
		for (;;)
		{
			num = (534383938U ^ num);
			bool count = this.stack_1.Count != 0;
			num = 1026228436U >> (int)num;
			if (count)
			{
				num >>= 22;
				int num3 = num2;
				num *= 646802925U;
				Stack<GClass18.Class37> stack = this.stack_1;
				num *= 1079193217U;
				GClass18.Class37 class2 = stack.Peek();
				num ^= 1813666100U;
				int num4 = class2.method_1();
				num *= 967399735U;
				if (num3 > num4)
				{
					goto IL_8E;
				}
				num ^= 3657448958U;
			}
			num *= 1142302271U;
			Exception ex = null;
			num = (1411463764U ^ num);
			this.exception_0 = ex;
			if (1286945740U < num)
			{
				continue;
			}
			Stack<GClass18.Class8> stack2 = this.stack_0;
			num *= 1215983881U;
			stack2.Clear();
			num >>= 2;
			if (140666227U <= num)
			{
				break;
			}
			IL_8E:
			List<GClass18.Class36> list = this.stack_1.Pop().method_4();
			int count2 = list.Count;
			num = 0U;
			int num5 = count2;
			for (;;)
			{
				num |= 1907775412U;
				int num6 = num5;
				uint num7 = num ^ 1907775412U;
				num = 1936358868U % num;
				if (num6 <= num7)
				{
					break;
				}
				GClass18.Class36 class3 = list[num5 - 1];
				byte b = class3.method_0();
				int num8 = 2;
				num = 334578922U;
				if (b == num8)
				{
					num /= 873470490U;
					this.stack_2.Push(class3.method_1());
					num ^= 334578922U;
				}
				num = 732562044U % num;
				int num9 = num5;
				int num10 = (int)(num + 4231563097U);
				num -= 323305112U;
				num5 = num9 - num10;
				num += 259900912U;
			}
			num += 4045258582U;
		}
		num %= 378275904U;
		num *= 402006533U;
		this.int_0 = this.stack_2.Pop();
	}

	// Token: 0x06000195 RID: 405 RVA: 0x0000E93C File Offset: 0x0000CB3C
	private void method_98()
	{
		for (;;)
		{
			bool flag = this.exception_0 != null;
			uint num = 324602059U;
			if (flag)
			{
				num *= 1147733036U;
				if (num >= 1299410781U)
				{
					goto IL_48;
				}
				Exception exception_ = this.exception_0;
				num ^= 28840256U;
				this.method_34(exception_);
				if (num != 2006285111U)
				{
					break;
				}
			}
			else if (num - 285111722U != 0U)
			{
				goto Block_3;
			}
		}
		return;
		Block_3:
		IL_48:
		this.int_0 = this.stack_2.Pop();
	}

	// Token: 0x06000196 RID: 406 RVA: 0x0000E9A4 File Offset: 0x0000CBA4
	private void method_99()
	{
		for (;;)
		{
			bool flag = this.method_1().DE119705() != 0;
			uint num = 422187873U;
			if (!flag)
			{
				num >>= 17;
				Exception exception_ = this.exception_0;
				num *= 1185811710U;
				this.method_34(exception_);
				if (738529252U != num)
				{
					break;
				}
			}
			else if (112742384U == num)
			{
				goto IL_93;
			}
			this.stack_1.Pop();
			num *= 1493771628U;
			Stack<GClass18.Class8> stack = this.stack_0;
			object object_ = this.exception_0;
			num <<= 5;
			GClass18.Class8 item = new GClass18.Class14(object_);
			num -= 1982933383U;
			stack.Push(item);
			num = 326307491U - num;
			if ((1350711991U ^ num) == 0U)
			{
				continue;
			}
			IL_93:
			num = 191460575U >> (int)num;
			num >>= 20;
			GClass18.Class36 @class = this.class36_0;
			num %= 598367118U;
			this.int_0 = @class.method_1();
			num += 1482909906U;
			num |= 1957912635U;
			this.class36_0 = null;
			if (num > 945114014U)
			{
				return;
			}
		}
	}

	// Token: 0x06000197 RID: 407 RVA: 0x0000EAA8 File Offset: 0x0000CCA8
	private void method_100()
	{
		Type type = this.method_26(this.method_1().DE119705());
		uint num = 817173847U;
		do
		{
			num >>= 7;
			object object_ = this.method_1();
			Type type_ = type;
			num += 874386891U;
			object object_2 = this.method_24(object_, type_).vmethod_1();
			num = (316952631U ^ num);
			this.method_0(new GClass18.Class14(object_2));
		}
		while (num <= 209545759U);
	}

	// Token: 0x06000198 RID: 408 RVA: 0x0000EB24 File Offset: 0x0000CD24
	private void method_101()
	{
		uint num = 1208420012U;
		Type type = this.method_26(this.method_1().DE119705());
		do
		{
			num <<= 24;
			num = (204284436U & num);
			object object_ = this.method_1().vmethod_1();
			Type type_ = type;
			num -= 738140270U;
			GClass18.Class7 class7_ = this.method_24(object_, type_);
			num = 1001870066U - num;
			this.method_0(class7_);
		}
		while (num == 1876643695U);
	}

	// Token: 0x06000199 RID: 409 RVA: 0x0000EB98 File Offset: 0x0000CD98
	private void method_102()
	{
		uint num;
		GClass18.Class7 @class;
		object obj2;
		for (;;)
		{
			IL_00:
			Type type = this.method_26(this.method_1().DE119705());
			num = 1487256640U;
			Type type2 = type;
			for (;;)
			{
				num = (429222594U ^ num);
				@class = this.method_1();
				if (num <= 530645298U)
				{
					goto IL_00;
				}
				for (;;)
				{
					GClass18.Class7 class2 = @class;
					num = 245054351U % num;
					object obj = class2.vmethod_1();
					num += 866345669U;
					obj2 = obj;
					bool flag = obj2 != null;
					num /= 760832705U;
					if (!flag)
					{
						goto Block_6;
					}
					num = 1810967332U / num;
					if (num * 914766843U == 0U)
					{
						goto IL_00;
					}
					if (type2.IsValueType)
					{
						Type type3 = type2;
						num >>= 7;
						object obj3 = obj2;
						num = 358422322U * num;
						Type type4 = obj3.GetType();
						num = 1255698614U / num;
						if (type3 != type4)
						{
							goto Block_2;
						}
						num = 1603890884U >> (int)num;
						if (num <= 1868979148U)
						{
							goto Block_3;
						}
					}
					else
					{
						TypeCode typeCode = Type.GetTypeCode(type2);
						if (1976919044U < num)
						{
							goto IL_00;
						}
						int num2 = typeCode - (TypeCode)(num - 1810967329U);
						num = (1519520919U & num);
						switch (num2)
						{
						case 0:
							goto IL_1EA;
						case 1:
							goto IL_352;
						case 2:
							goto IL_218;
						case 3:
							goto IL_394;
						case 4:
							goto IL_233;
						case 5:
							goto IL_3CF;
						case 6:
							goto IL_13A;
						case 7:
							goto IL_3F6;
						case 8:
							goto IL_149;
						case 9:
							goto IL_2B3;
						case 10:
							goto IL_2C4;
						case 11:
							goto IL_30A;
						default:
							if ((num ^ 565602178U) != 0U)
							{
								goto IL_121;
							}
							break;
						}
					}
				}
				IL_121:
				num = (440076046U & num);
				if (num - 1047407120U != 0U)
				{
					goto Block_7;
				}
				continue;
				IL_13A:
				if (num - 1125713784U != 0U)
				{
					goto Block_8;
				}
				continue;
				IL_149:
				num = (353133273U | num);
				num = (1633177927U & num);
				GClass18.Class7 class7_ = new GClass18.Class10((long)obj2);
				num = 124723682U - num;
				this.method_0(class7_);
				if (974215419U + num != 0U)
				{
					return;
				}
			}
			Block_2:
			num /= 1958631178U;
			if (1304844943U >> (int)num != 0U)
			{
				goto Block_11;
			}
			continue;
			Block_6:
			num = 210658667U >> (int)num;
			if (num != 1274438595U)
			{
				goto Block_10;
			}
			continue;
			Block_8:
			num %= 975845838U;
			GClass18.Class7 class7_2 = new GClass18.Class9((int)obj2);
			num = (564821046U | num);
			this.method_0(class7_2);
			if (num <= 1207435617U)
			{
				return;
			}
			continue;
			IL_1EA:
			if (num <= 1233550953U)
			{
				continue;
			}
			this.method_0(new GClass18.Class30((bool)obj2));
			if (414798438U < num)
			{
				return;
			}
			continue;
			IL_218:
			num >>= 29;
			if (num < 880873401U)
			{
				goto Block_14;
			}
			continue;
			IL_233:
			num %= 1901023612U;
			num -= 258345051U;
			object obj4 = obj2;
			num *= 136005489U;
			GClass18.Class7 class7_3 = new GClass18.Class28((short)obj4);
			num -= 1161914165U;
			this.method_0(class7_3);
			if (num >= 913782971U)
			{
				return;
			}
			continue;
			IL_2B3:
			if (1129215893U <= num)
			{
				goto Block_17;
			}
			continue;
			IL_2C4:
			num /= 720136506U;
			object obj5 = obj2;
			num = 740050084U * num;
			GClass18.Class7 class7_4 = new GClass18.Class11((float)obj5);
			num = 1815548313U >> (int)num;
			this.method_0(class7_4);
			if (446908874U >= num)
			{
				return;
			}
			continue;
			IL_30A:
			num = (215048401U ^ num);
			this.method_0(new GClass18.Class12((double)obj2));
			if ((num & 1999851637U) != 0U)
			{
				return;
			}
		}
		Block_3:
		this.method_0(@class);
		return;
		Block_7:
		throw new InvalidCastException();
		Block_10:
		throw new NullReferenceException();
		Block_11:
		throw new InvalidCastException();
		Block_14:
		this.method_0(new GClass18.Class33((sbyte)obj2));
		return;
		Block_17:
		num /= 832769639U;
		GClass18.Class7 class7_5 = new GClass18.Class35((ulong)obj2);
		num = 2094670622U >> (int)num;
		this.method_0(class7_5);
		return;
		IL_352:
		num &= 1358834531U;
		char char_ = (char)obj2;
		num = (329406666U | num);
		GClass18.Class7 class7_6 = new GClass18.Class31(char_);
		num = (1294695466U ^ num);
		this.method_0(class7_6);
		return;
		IL_394:
		num = 1882987669U * num;
		object obj6 = obj2;
		num = 1408662930U * num;
		byte byte_ = (byte)obj6;
		num = 1478325845U + num;
		GClass18.Class7 class7_7 = new GClass18.Class32(byte_);
		num *= 1812340417U;
		this.method_0(class7_7);
		return;
		IL_3CF:
		num >>= 29;
		object obj7 = obj2;
		num += 1127616724U;
		this.method_0(new GClass18.Class29((ushort)obj7));
		return;
		IL_3F6:
		num = 35860804U / num;
		num -= 939067181U;
		object obj8 = obj2;
		num = 1338247847U >> (int)num;
		uint uint_ = (uint)obj8;
		num = 1360798068U + num;
		this.method_0(new GClass18.Class34(uint_));
	}

	// Token: 0x0600019A RID: 410 RVA: 0x0000F00C File Offset: 0x0000D20C
	private void method_103()
	{
		this.method_0(new GClass18.Class9(Marshal.ReadInt32(new IntPtr(this.long_0 + (long)((ulong)this.method_1().vmethod_10())))));
	}

	// Token: 0x0600019B RID: 411 RVA: 0x0000F044 File Offset: 0x0000D244
	private void method_104()
	{
		int num;
		uint num2;
		for (;;)
		{
			num = this.method_1().DE119705();
			num2 = 695755936U;
			int num5;
			for (;;)
			{
				int num3 = num;
				num2 = (185666060U & num2);
				int num4 = num3 >> (int)(num2 + 4142923800U);
				num2 <<= 1;
				num5 = num4;
				num2 = 1337686616U + num2;
				if (1247483403U >> (int)num2 == 0U)
				{
					goto IL_1D;
				}
				int num6 = num5;
				num2 += 1115565717U;
				uint num7 = num2 ^ 2757339367U;
				num2 = 746675983U - num2;
				if (num6 <= num7)
				{
					goto IL_1D;
				}
				num2 = 303176659U << (int)num2;
				int num8 = num5;
				num2 &= 1066472734U;
				uint num9 = num2 ^ 134219031U;
				num2 %= 2065657987U;
				num2 ^= 2833929428U;
				if (num8 != num9)
				{
					num2 &= 182205512U;
					int num10 = num5;
					uint num11 = num2 ^ 13111395U;
					num2 ^= 2686599568U;
					if (num10 == num11)
					{
						goto IL_286;
					}
					if (num2 < 432886992U)
					{
						continue;
					}
					goto IL_13A;
				}
				IL_58:
				if (344397176U < num2)
				{
					goto Block_1;
				}
				continue;
				IL_1D:
				uint num12 = (uint)num5;
				num2 <<= 0;
				uint num13 = num12 - (num2 ^ 2284303907U);
				num2 *= 2050974252U;
				switch (num13)
				{
				case 0:
				case 1:
					goto IL_58;
				case 2:
				case 4:
					goto IL_276;
				case 3:
					goto IL_229;
				case 5:
					goto IL_286;
				}
				break;
			}
			if (273026715U + num2 != 0U)
			{
				uint num14 = (uint)num5;
				num2 <<= 20;
				if (num14 != (num2 ^ 494927882U))
				{
					goto Block_7;
				}
				if (num2 <= 595264188U)
				{
					goto Block_8;
				}
			}
		}
		Block_1:
		goto IL_1F4;
		Block_7:
		num2 ^= 3177861592U;
		goto IL_276;
		Block_8:
		ModuleHandle moduleHandle;
		try
		{
			if (198977283U % num2 != 0U)
			{
				do
				{
					num2 = 1670649991U * num2;
					num2 <<= 5;
					Module module = this.module_0;
					num2 %= 846752630U;
					moduleHandle = module.ModuleHandle;
					int fieldToken = num;
					num2 = 2138571062U / num2;
					object object_ = moduleHandle.ResolveFieldHandle(fieldToken);
					num2 = 1122057780U * num2;
					this.method_0(new GClass18.Class16(object_));
				}
				while (num2 >= 995951475U);
			}
			return;
		}
		catch
		{
			this.method_0(new GClass18.Class16(this.module_0.ModuleHandle.ResolveMethodHandle(num)));
			return;
		}
		goto IL_1F4;
		IL_13A:
		num2 ^= 0U;
		goto IL_276;
		IL_1F4:
		num2 += 45226648U;
		moduleHandle = this.module_0.ModuleHandle;
		int typeToken = num;
		num2 = (1657541391U ^ num2);
		this.method_0(new GClass18.Class16(moduleHandle.ResolveTypeHandle(typeToken)));
		return;
		IL_229:
		num2 = (538322973U | num2);
		num2 = (1351644069U & num2);
		num2 &= 1359436956U;
		moduleHandle = this.module_0.ModuleHandle;
		num2 ^= 2000686104U;
		int fieldToken2 = num;
		num2 >>= 1;
		this.method_0(new GClass18.Class16(moduleHandle.ResolveFieldHandle(fieldToken2)));
		return;
		IL_276:
		if ((num2 ^ 87501246U) != 0U)
		{
			throw new InvalidOperationException();
		}
		return;
		IL_286:
		num2 %= 120678626U;
		moduleHandle = this.module_0.ModuleHandle;
		num2 = 1975525352U >> (int)num2;
		int methodToken = num;
		num2 = 716898884U + num2;
		object object_2 = moduleHandle.ResolveMethodHandle(methodToken);
		num2 &= 795294963U;
		this.method_0(new GClass18.Class16(object_2));
	}

	// Token: 0x0600019C RID: 412 RVA: 0x0000F334 File Offset: 0x0000D534
	private void method_105()
	{
		Exception ex = this.method_1().vmethod_1() as Exception;
		uint num = 1038504768U;
		if (ex == null)
		{
			num <<= 24;
			throw new ArgumentException();
		}
		throw ex;
	}

	// Token: 0x0600019D RID: 413 RVA: 0x0000F368 File Offset: 0x0000D568
	private void method_106()
	{
		uint num;
		do
		{
			num = 593768540U;
			if (this.exception_0 != null)
			{
				goto IL_24;
			}
			num -= 1020882857U;
		}
		while (1654332581U > num);
		throw new InvalidOperationException();
		IL_24:
		num = (1315663377U ^ num);
		throw this.exception_0;
	}

	// Token: 0x0600019E RID: 414 RVA: 0x0000F3A8 File Offset: 0x0000D5A8
	private void method_107()
	{
		uint num = 553982771U;
		Type type;
		do
		{
			type = this.method_26(this.method_1().DE119705());
			num = 1316821649U >> (int)num;
		}
		while ((2023294773U & num) == 0U);
		GClass18.Class7 @class = this.method_1();
		num = (351488873U | num);
		GClass18.Class7 class2 = @class;
		num = (1016558833U ^ num);
		GClass18.Class7 class3 = class2;
		num = (1819292764U & num);
		object object_ = class3.vmethod_1();
		num -= 1693658510U;
		Type type_ = type;
		num -= 307108475U;
		bool flag = this.method_33(object_, type_);
		num &= 1976763825U;
		if (!flag)
		{
			throw new InvalidCastException();
		}
		num /= 1028802308U;
		GClass18.Class7 class7_ = class2;
		num = 1814309277U << (int)num;
		this.method_0(class7_);
	}

	// Token: 0x0600019F RID: 415 RVA: 0x0000F450 File Offset: 0x0000D650
	private void method_108()
	{
		uint num = 1477641984U;
		GClass18.Class7 class2;
		do
		{
			num = 269888075U * num;
			int int_ = this.method_1().DE119705();
			num = (1331715400U & num);
			Type type = this.method_26(int_);
			GClass18.Class7 @class = this.method_1();
			num = 452857464U << (int)num;
			class2 = @class;
			num >>= 19;
			if (num >> 8 == 0U)
			{
				return;
			}
			num = 823139270U / num;
			object object_ = class2.vmethod_1();
			num = 15556590U + num;
			Type type_ = type;
			num = 937897548U + num;
			if (this.method_33(object_, type_))
			{
				goto IL_98;
			}
		}
		while (num <= 371196202U);
		object object_2 = null;
		num += 421680469U;
		class2 = new GClass18.Class14(object_2);
		num += 3873286827U;
		IL_98:
		num = 1795980184U << (int)num;
		this.method_0(class2);
	}

	// Token: 0x060001A0 RID: 416 RVA: 0x0000F50C File Offset: 0x0000D70C
	private void method_109()
	{
		uint num = 140925422U;
		GClass18.Class7 class2;
		for (;;)
		{
			IL_BB:
			num *= 1817585884U;
			GClass18.Class7 @class = this.method_1();
			num >>= 7;
			class2 = @class;
			for (;;)
			{
				object obj = class2.vmethod_1();
				num |= 900815365U;
				bool flag = obj is IConvertible;
				num <<= 3;
				if (!flag)
				{
					goto Block_4;
				}
				num = (1552314902U ^ num);
				double num2 = class2.BF7BF7B8();
				num = 624501735U - num;
				double num3 = num2;
				if (1556366389U <= num)
				{
					goto IL_BB;
				}
				double d = num3;
				num <<= 14;
				bool flag2 = double.IsNaN(d);
				num *= 366152560U;
				if (!flag2)
				{
					num = (963276734U & num);
					bool flag3 = double.IsInfinity(num3);
					num |= 34955630U;
					if (!flag3)
					{
						break;
					}
					num += 3254689426U;
				}
				if (1091896325U <= num)
				{
					goto IL_D4;
				}
			}
			IL_B1:
			if (num != 1528513296U)
			{
				break;
			}
			continue;
			Block_4:
			num ^= 444081661U;
			GClass18.Class7 class3 = new GClass18.Class12(double.NaN);
			num = 53156158U % num;
			class2 = class3;
			num ^= 940996688U;
			goto IL_B1;
		}
		num %= 1604124836U;
		GClass18.Class7 class7_ = class2;
		num /= 1099921956U;
		this.method_0(class7_);
		return;
		IL_D4:
		throw new OverflowException();
	}

	// Token: 0x060001A1 RID: 417 RVA: 0x0000F60C File Offset: 0x0000D80C
	private unsafe void method_110()
	{
		IntPtr item = Marshal.AllocHGlobal(this.method_1().vmethod_13());
		this.list_2.Add(item);
		this.method_0(new GClass18.Class14(Pointer.Box(item.ToPointer(), typeof(void*))));
	}

	// Token: 0x060001A2 RID: 418 RVA: 0x0000F658 File Offset: 0x0000D858
	private void method_111()
	{
		List<IntPtr>.Enumerator enumerator = this.list_2.GetEnumerator();
		uint num = 67437142U;
		using (List<IntPtr>.Enumerator enumerator2 = enumerator)
		{
			for (;;)
			{
				while (714540846U != num)
				{
					num <<= 22;
					bool flag = enumerator2.MoveNext();
					num %= 1056768644U;
					if (flag)
					{
						Marshal.FreeHGlobal(enumerator2.Current);
						num = 67437142U;
					}
					else if (num - 927419765U != 0U)
					{
						goto Block_4;
					}
				}
			}
			Block_4:;
		}
	}

	// Token: 0x060001A3 RID: 419 RVA: 0x0000F6E4 File Offset: 0x0000D8E4
	public object method_112(object[] object_0, int int_1)
	{
		uint num = 1490165043U;
		do
		{
			this.int_0 = int_1;
			num = 401683510U - num;
		}
		while (num == 72688758U);
		num = 832577472U << (int)num;
		num ^= 2008548783U;
		GClass18.Class7 class7_ = new GClass18.Class17(object_0);
		num = 465512247U % num;
		this.method_0(class7_);
		object result;
		try
		{
			for (;;)
			{
				try
				{
					do
					{
						Dictionary<uint, GClass18.Delegate32> dictionary = this.dictionary_0;
						num = 1U;
						dictionary[(uint)this.method_3()]();
						for (;;)
						{
							bool flag = this.int_0 != 0;
							num /= 243948123U;
							if (flag)
							{
								break;
							}
							if (2061055390 << (int)num != 0)
							{
								goto IL_92;
							}
						}
					}
					while (num << 23 != 0U);
					continue;
					IL_92:;
				}
				catch (Exception exception_)
				{
					this.method_34(exception_);
					continue;
				}
				break;
			}
			result = this.method_1().vmethod_1();
		}
		finally
		{
			this.method_111();
		}
		return result;
	}

	// Token: 0x040000B5 RID: 181
	private readonly Dictionary<uint, GClass18.Delegate32> dictionary_0;

	// Token: 0x040000B6 RID: 182
	private readonly Module module_0;

	// Token: 0x040000B7 RID: 183
	private readonly long long_0;

	// Token: 0x040000B8 RID: 184
	private int int_0;

	// Token: 0x040000B9 RID: 185
	private Type type_0;

	// Token: 0x040000BA RID: 186
	private Stack<GClass18.Class8> stack_0;

	// Token: 0x040000BB RID: 187
	private static readonly Dictionary<int, object> dictionary_1 = new Dictionary<int, object>();

	// Token: 0x040000BC RID: 188
	private static readonly Dictionary<MethodBase, DynamicMethod> dictionary_2 = new Dictionary<MethodBase, DynamicMethod>();

	// Token: 0x040000BD RID: 189
	private List<GClass18.Class7> list_0;

	// Token: 0x040000BE RID: 190
	private List<GClass18.Class37> list_1;

	// Token: 0x040000BF RID: 191
	private Stack<GClass18.Class37> stack_1;

	// Token: 0x040000C0 RID: 192
	private Stack<int> stack_2;

	// Token: 0x040000C1 RID: 193
	private Exception exception_0;

	// Token: 0x040000C2 RID: 194
	private GClass18.Class36 class36_0;

	// Token: 0x040000C3 RID: 195
	private List<IntPtr> list_2;

	// Token: 0x0200004F RID: 79
	private static class Class6
	{
	}

	// Token: 0x02000050 RID: 80
	private abstract class Class7
	{
		// Token: 0x060001D6 RID: 470
		public abstract GClass18.Class7 vmethod_0();

		// Token: 0x060001D7 RID: 471
		public abstract object vmethod_1();

		// Token: 0x060001D8 RID: 472
		public abstract void vmethod_2(object object_0);

		// Token: 0x060001D9 RID: 473 RVA: 0x0000FAE0 File Offset: 0x0000DCE0
		public virtual bool vmethod_3()
		{
			return false;
		}

		// Token: 0x060001DA RID: 474 RVA: 0x0000FAF0 File Offset: 0x0000DCF0
		public virtual GClass18.Class8 vmethod_4()
		{
			throw new InvalidOperationException();
		}

		// Token: 0x060001DB RID: 475 RVA: 0x0000FB04 File Offset: 0x0000DD04
		public virtual GClass18.Class7 vmethod_5()
		{
			return this;
		}

		// Token: 0x060001DC RID: 476 RVA: 0x0000FB14 File Offset: 0x0000DD14
		public virtual Type vmethod_6()
		{
			throw new InvalidOperationException();
		}

		// Token: 0x060001DD RID: 477 RVA: 0x0000FB28 File Offset: 0x0000DD28
		public virtual TypeCode vmethod_7()
		{
			throw new InvalidOperationException();
		}

		// Token: 0x060001DE RID: 478 RVA: 0x0000FB3C File Offset: 0x0000DD3C
		public virtual bool A0715E7F()
		{
			return Convert.ToBoolean(this.vmethod_1());
		}

		// Token: 0x060001DF RID: 479 RVA: 0x0000FB54 File Offset: 0x0000DD54
		public virtual sbyte vmethod_8()
		{
			return Convert.ToSByte(this.vmethod_1());
		}

		// Token: 0x060001E0 RID: 480 RVA: 0x0000FB6C File Offset: 0x0000DD6C
		public virtual short DAAA832C()
		{
			return Convert.ToInt16(this.vmethod_1());
		}

		// Token: 0x060001E1 RID: 481 RVA: 0x0000FB84 File Offset: 0x0000DD84
		public virtual int DE119705()
		{
			return Convert.ToInt32(this.vmethod_1());
		}

		// Token: 0x060001E2 RID: 482 RVA: 0x0000FB9C File Offset: 0x0000DD9C
		public virtual long E9C7AF34()
		{
			return Convert.ToInt64(this.vmethod_1());
		}

		// Token: 0x060001E3 RID: 483 RVA: 0x0000FBB4 File Offset: 0x0000DDB4
		public virtual char C075F08B()
		{
			return Convert.ToChar(this.vmethod_1());
		}

		// Token: 0x060001E4 RID: 484 RVA: 0x0000FBCC File Offset: 0x0000DDCC
		public virtual byte vmethod_9()
		{
			return Convert.ToByte(this.vmethod_1());
		}

		// Token: 0x060001E5 RID: 485 RVA: 0x0000FBE4 File Offset: 0x0000DDE4
		public virtual ushort E1B55196()
		{
			return Convert.ToUInt16(this.vmethod_1());
		}

		// Token: 0x060001E6 RID: 486 RVA: 0x0000FBFC File Offset: 0x0000DDFC
		public virtual uint vmethod_10()
		{
			return Convert.ToUInt32(this.vmethod_1());
		}

		// Token: 0x060001E7 RID: 487 RVA: 0x0000FC14 File Offset: 0x0000DE14
		public virtual ulong vmethod_11()
		{
			return Convert.ToUInt64(this.vmethod_1());
		}

		// Token: 0x060001E8 RID: 488 RVA: 0x0000FC2C File Offset: 0x0000DE2C
		public virtual float vmethod_12()
		{
			return Convert.ToSingle(this.vmethod_1());
		}

		// Token: 0x060001E9 RID: 489 RVA: 0x0000FC44 File Offset: 0x0000DE44
		public virtual double BF7BF7B8()
		{
			return Convert.ToDouble(this.vmethod_1());
		}

		// Token: 0x060001EA RID: 490 RVA: 0x0000FC5C File Offset: 0x0000DE5C
		public override string ToString()
		{
			object obj = this.vmethod_1();
			uint num = 2952790016U;
			for (;;)
			{
				bool flag = obj != null;
				num &= 1163728751U;
				if (flag)
				{
					break;
				}
				num = (148588747U & num);
				if (1135895906U >= num)
				{
					goto IL_56;
				}
			}
			num = 416447888U - num;
			if ((1333493173U & num) != 0U)
			{
				object value = obj;
				num = (801063271U ^ num);
				return Convert.ToString(value);
			}
			IL_56:
			return null;
		}

		// Token: 0x060001EB RID: 491 RVA: 0x0000FCC0 File Offset: 0x0000DEC0
		public virtual IntPtr vmethod_13()
		{
			throw new InvalidOperationException();
		}

		// Token: 0x060001EC RID: 492 RVA: 0x0000FCD4 File Offset: 0x0000DED4
		public virtual UIntPtr vmethod_14()
		{
			throw new InvalidOperationException();
		}

		// Token: 0x060001ED RID: 493 RVA: 0x0000FCE8 File Offset: 0x0000DEE8
		public unsafe virtual void* vmethod_15()
		{
			throw new InvalidOperationException();
		}

		// Token: 0x060001EE RID: 494 RVA: 0x0000FCFC File Offset: 0x0000DEFC
		public virtual object F9291D0D(Type type_0, bool bool_0)
		{
			throw new InvalidOperationException();
		}
	}

	// Token: 0x02000051 RID: 81
	private abstract class Class8 : GClass18.Class7
	{
		// Token: 0x060001F0 RID: 496 RVA: 0x0000FD24 File Offset: 0x0000DF24
		public override GClass18.Class8 vmethod_4()
		{
			return this;
		}

		// Token: 0x060001F1 RID: 497 RVA: 0x0000FD34 File Offset: 0x0000DF34
		public override TypeCode vmethod_7()
		{
			return TypeCode.Empty;
		}
	}

	// Token: 0x02000052 RID: 82
	private sealed class Class9 : GClass18.Class8
	{
		// Token: 0x060001F3 RID: 499 RVA: 0x0000FD58 File Offset: 0x0000DF58
		public Class9(int int_1)
		{
			uint num = 296367579U;
			do
			{
				num = (554388449U | num);
				base..ctor();
				num = 899230351U >> (int)num;
			}
			while (390268957U < num);
			this.int_0 = int_1;
		}

		// Token: 0x060001F4 RID: 500 RVA: 0x0000FD98 File Offset: 0x0000DF98
		public override Type vmethod_6()
		{
			return typeof(int);
		}

		// Token: 0x060001F5 RID: 501 RVA: 0x0000FDB0 File Offset: 0x0000DFB0
		public override TypeCode vmethod_7()
		{
			return TypeCode.Int32;
		}

		// Token: 0x060001F6 RID: 502 RVA: 0x0000FDC0 File Offset: 0x0000DFC0
		public override GClass18.Class7 vmethod_0()
		{
			return new GClass18.Class9(this.int_0);
		}

		// Token: 0x060001F7 RID: 503 RVA: 0x0000FDD8 File Offset: 0x0000DFD8
		public override object vmethod_1()
		{
			return this.int_0;
		}

		// Token: 0x060001F8 RID: 504 RVA: 0x0000FDF0 File Offset: 0x0000DFF0
		public override void vmethod_2(object object_0)
		{
			uint num = 1391870444U;
			do
			{
				num %= 1381565388U;
				this.int_0 = Convert.ToInt32(object_0);
			}
			while (357564846U + num == 0U);
		}

		// Token: 0x060001F9 RID: 505 RVA: 0x0000FE20 File Offset: 0x0000E020
		public override bool A0715E7F()
		{
			return this.int_0 != 0;
		}

		// Token: 0x060001FA RID: 506 RVA: 0x0000FE38 File Offset: 0x0000E038
		public override sbyte vmethod_8()
		{
			return (sbyte)this.int_0;
		}

		// Token: 0x060001FB RID: 507 RVA: 0x0000FE4C File Offset: 0x0000E04C
		public override short DAAA832C()
		{
			return (short)this.int_0;
		}

		// Token: 0x060001FC RID: 508 RVA: 0x0000FE60 File Offset: 0x0000E060
		public override int DE119705()
		{
			return this.int_0;
		}

		// Token: 0x060001FD RID: 509 RVA: 0x0000FE74 File Offset: 0x0000E074
		public override long E9C7AF34()
		{
			return (long)this.int_0;
		}

		// Token: 0x060001FE RID: 510 RVA: 0x0000FE88 File Offset: 0x0000E088
		public override char C075F08B()
		{
			return (char)this.int_0;
		}

		// Token: 0x060001FF RID: 511 RVA: 0x0000FE9C File Offset: 0x0000E09C
		public override byte vmethod_9()
		{
			return (byte)this.int_0;
		}

		// Token: 0x06000200 RID: 512 RVA: 0x0000FEB0 File Offset: 0x0000E0B0
		public override ushort E1B55196()
		{
			return (ushort)this.int_0;
		}

		// Token: 0x06000201 RID: 513 RVA: 0x0000FEC4 File Offset: 0x0000E0C4
		public override uint vmethod_10()
		{
			return (uint)this.int_0;
		}

		// Token: 0x06000202 RID: 514 RVA: 0x0000FED8 File Offset: 0x0000E0D8
		public override ulong vmethod_11()
		{
			return (ulong)this.int_0;
		}

		// Token: 0x06000203 RID: 515 RVA: 0x0000FEEC File Offset: 0x0000E0EC
		public override float vmethod_12()
		{
			return (float)this.int_0;
		}

		// Token: 0x06000204 RID: 516 RVA: 0x0000FF00 File Offset: 0x0000E100
		public override double BF7BF7B8()
		{
			return (double)this.int_0;
		}

		// Token: 0x06000205 RID: 517 RVA: 0x0000FF14 File Offset: 0x0000E114
		public override IntPtr vmethod_13()
		{
			return new IntPtr(this.int_0);
		}

		// Token: 0x06000206 RID: 518 RVA: 0x0000FF2C File Offset: 0x0000E12C
		public override UIntPtr vmethod_14()
		{
			return new UIntPtr((uint)this.int_0);
		}

		// Token: 0x06000207 RID: 519 RVA: 0x0000FF44 File Offset: 0x0000E144
		public override GClass18.Class7 vmethod_5()
		{
			return new GClass18.Class34((uint)this.int_0);
		}

		// Token: 0x06000208 RID: 520 RVA: 0x0000FF5C File Offset: 0x0000E15C
		public override object F9291D0D(Type type_0, bool bool_0)
		{
			while (type_0 != typeof(IntPtr))
			{
				uint num = 1679362562U;
				if (type_0 == typeof(UIntPtr))
				{
					num += 108464687U;
					uint value;
					if (!bool_0)
					{
						num = (1937385586U & num);
						value = checked((uint)this.int_0);
					}
					else
					{
						num >>= 18;
						value = (uint)this.int_0;
						num += 1645208972U;
					}
					num = 929660744U << (int)num;
					return new UIntPtr(value);
				}
				num <<= 14;
				if (2037525387U * num != 0U)
				{
					num = 416838430U + num;
					TypeCode typeCode = Type.GetTypeCode(type_0);
					int num2 = typeCode - (TypeCode)(num ^ 1532556059U);
					num = 99956534U + num;
					switch (num2)
					{
					case 0:
						if (1312236818U <= num)
						{
							sbyte b;
							if (!bool_0)
							{
								b = checked((sbyte)this.int_0);
							}
							else
							{
								if ((30951831U ^ num) == 0U)
								{
									break;
								}
								sbyte b2 = (sbyte)(checked((uint)this.int_0));
								num *= 158231407U;
								b = b2;
								num ^= 1642290232U;
							}
							num |= 1862272221U;
							return b;
						}
						continue;
					case 1:
						num /= 1520189627U;
						if (num != 1215851830U)
						{
							num = (1272402293U ^ num);
							byte b3;
							if (!bool_0)
							{
								num >>= 19;
								b3 = checked((byte)this.int_0);
							}
							else
							{
								num = 511775839U * num;
								num |= 1938097589U;
								uint num3 = (uint)this.int_0;
								num = 1389562718U / num;
								b3 = checked((byte)num3);
								num ^= 2426U;
							}
							num |= 21041195U;
							return b3;
						}
						goto IL_401;
					case 2:
						checked
						{
							if (num != 959129075U)
							{
								short num4;
								if (!bool_0)
								{
									num %= 2129416533U;
									num >>= 30;
									num4 = (short)this.int_0;
								}
								else
								{
									num4 = (short)((uint)this.int_0);
									num ^= 1632512597U;
								}
								num ^= 1387269254U;
								return num4;
							}
							continue;
						}
					case 3:
						num = 1223122056U * num;
						if (899821154U != num)
						{
							num = (456131214U | num);
							ushort num5;
							if (bool_0)
							{
								if (663179515U >= num)
								{
									continue;
								}
								num &= 182210171U;
								num5 = checked((ushort)((uint)this.int_0));
								num += 16257540U;
							}
							else
							{
								num = (1267933246U & num);
								num5 = checked((ushort)this.int_0);
							}
							num <<= 6;
							return num5;
						}
						continue;
					case 4:
					{
						num /= 1786916904U;
						int num6;
						if (!bool_0)
						{
							num ^= 1677288003U;
							if ((163645881U & num) == 0U)
							{
								continue;
							}
							num6 = this.int_0;
						}
						else
						{
							if (num > 647501646U)
							{
								continue;
							}
							int num7 = (int)(checked((uint)this.int_0));
							num ^= 235036878U;
							num6 = num7;
							num ^= 1845166733U;
						}
						return num6;
					}
					case 5:
					{
						uint num9;
						if (!bool_0)
						{
							num = 1093142117U - num;
							if (num <= 768747984U)
							{
								break;
							}
							uint num8 = (uint)this.int_0;
							num &= 1820202866U;
							num9 = num8;
						}
						else
						{
							num &= 490418440U;
							num9 = (uint)this.int_0;
							num ^= 1297232912U;
						}
						return num9;
					}
					case 6:
						if (1638948802U + num != 0U)
						{
							num |= 1595808724U;
							long num10;
							if (!bool_0)
							{
								if (num <= 1091121192U)
								{
									continue;
								}
								num10 = (long)this.int_0;
							}
							else
							{
								num = (2022255290U | num);
								num *= 342189951U;
								ulong num11 = (ulong)this.int_0;
								num /= 1332757340U;
								num10 = (long)num11;
								num += 2136882130U;
							}
							num &= 1887913303U;
							return num10;
						}
						break;
					case 7:
						if (478297032U % num != 0U)
						{
							num = 815954124U << (int)num;
							uint num13;
							if (!bool_0)
							{
								num = 127673803U * num;
								num |= 580407480U;
								uint num12 = (uint)this.int_0;
								num |= 923821480U;
								num13 = num12;
							}
							else
							{
								num13 = (uint)this.int_0;
								num ^= 4078466488U;
							}
							return num13;
						}
						goto IL_401;
					case 8:
						goto IL_3C8;
					case 9:
					{
						num = (68446391U ^ num);
						double num15;
						if (bool_0)
						{
							if (num <= 1637115203U)
							{
								continue;
							}
							num = (84698920U ^ num);
							int num14 = this.int_0;
							num = 929907681U << (int)num;
							num15 = num14;
							num ^= 1944941729U;
						}
						else
						{
							num >>= 27;
							double num16 = (double)this.int_0;
							num = (435322029U ^ num);
							num15 = num16;
						}
						return num15;
					}
					default:
						if (num + 417298588U != 0U)
						{
							num ^= 0U;
							goto IL_3C8;
						}
						goto IL_401;
					}
					do
					{
						IL_41D:
						int size = IntPtr.Size;
						int num17 = 4;
						num = 1623284576U;
						if (size == num17)
						{
							goto Block_32;
						}
						num >>= 21;
						if (!bool_0)
						{
							goto IL_478;
						}
					}
					while (2010465955U >> (int)num == 0U);
					ulong num18 = (ulong)this.int_0;
					num = 372244691U - num;
					long value2 = (long)num18;
					num += 3922723383U;
					goto IL_4A8;
					Block_32:
					if (num > 1362055112U)
					{
						goto IL_401;
					}
					goto IL_457;
					IL_478:
					num = 1137521152U - num;
					long num19 = (long)this.int_0;
					num /= 272175141U;
					value2 = num19;
					IL_4A8:
					return new IntPtr(value2);
					IL_3C8:
					if ((num ^ 1369332868U) != 0U)
					{
						throw new ArgumentException();
					}
					break;
					IL_401:
					num >>= 0;
					int value3;
					if (bool_0)
					{
						num = (1260018803U & num);
						if (num << 27 != 0U)
						{
							break;
						}
						num /= 879565090U;
						uint num20 = (uint)this.int_0;
						num = 1733371294U * num;
						int num21 = (int)num20;
						num ^= 1299977946U;
						value3 = num21;
						num += 915679260U;
						goto IL_45D;
					}
					IL_457:
					value3 = this.int_0;
					IL_45D:
					num &= 1677161360U;
					IntPtr intPtr = new IntPtr(value3);
					num *= 1169955735U;
					return intPtr;
				}
			}
			goto IL_41D;
		}

		// Token: 0x040000E5 RID: 229
		private int int_0;
	}

	// Token: 0x02000053 RID: 83
	private sealed class Class10 : GClass18.Class8
	{
		// Token: 0x06000209 RID: 521 RVA: 0x00010460 File Offset: 0x0000E660
		public Class10(long long_1)
		{
			uint num = 373777722U;
			do
			{
				num = 205609728U << (int)num;
				base..ctor();
				num >>= 8;
			}
			while (1685728558U - num == 0U);
			do
			{
				num *= 544342086U;
				this.long_0 = long_1;
			}
			while (243498753U - num == 0U);
		}

		// Token: 0x0600020A RID: 522 RVA: 0x000104B0 File Offset: 0x0000E6B0
		public override Type vmethod_6()
		{
			return typeof(long);
		}

		// Token: 0x0600020B RID: 523 RVA: 0x000104C8 File Offset: 0x0000E6C8
		public override TypeCode vmethod_7()
		{
			return TypeCode.Int64;
		}

		// Token: 0x0600020C RID: 524 RVA: 0x000104D8 File Offset: 0x0000E6D8
		public override GClass18.Class7 vmethod_5()
		{
			return new GClass18.Class35((ulong)this.long_0);
		}

		// Token: 0x0600020D RID: 525 RVA: 0x000104F0 File Offset: 0x0000E6F0
		public override GClass18.Class7 vmethod_0()
		{
			return new GClass18.Class10(this.long_0);
		}

		// Token: 0x0600020E RID: 526 RVA: 0x00010508 File Offset: 0x0000E708
		public override object vmethod_1()
		{
			return this.long_0;
		}

		// Token: 0x0600020F RID: 527 RVA: 0x00010520 File Offset: 0x0000E720
		public override void vmethod_2(object object_0)
		{
			uint num = 1022719165U;
			do
			{
				long num2 = Convert.ToInt64(object_0);
				num = 332617784U - num;
				this.long_0 = num2;
			}
			while (num + 155529531U == 0U);
		}

		// Token: 0x06000210 RID: 528 RVA: 0x00010550 File Offset: 0x0000E750
		public override bool A0715E7F()
		{
			return this.long_0 != 0L;
		}

		// Token: 0x06000211 RID: 529 RVA: 0x00010570 File Offset: 0x0000E770
		public override char C075F08B()
		{
			return (char)this.long_0;
		}

		// Token: 0x06000212 RID: 530 RVA: 0x00010584 File Offset: 0x0000E784
		public override byte vmethod_9()
		{
			return (byte)this.long_0;
		}

		// Token: 0x06000213 RID: 531 RVA: 0x00010598 File Offset: 0x0000E798
		public override sbyte vmethod_8()
		{
			return (sbyte)this.long_0;
		}

		// Token: 0x06000214 RID: 532 RVA: 0x000105AC File Offset: 0x0000E7AC
		public override short DAAA832C()
		{
			return (short)this.long_0;
		}

		// Token: 0x06000215 RID: 533 RVA: 0x000105C0 File Offset: 0x0000E7C0
		public override int DE119705()
		{
			return (int)this.long_0;
		}

		// Token: 0x06000216 RID: 534 RVA: 0x000105D4 File Offset: 0x0000E7D4
		public override long E9C7AF34()
		{
			return this.long_0;
		}

		// Token: 0x06000217 RID: 535 RVA: 0x000105E8 File Offset: 0x0000E7E8
		public override ushort E1B55196()
		{
			return (ushort)this.long_0;
		}

		// Token: 0x06000218 RID: 536 RVA: 0x000105FC File Offset: 0x0000E7FC
		public override uint vmethod_10()
		{
			return (uint)this.long_0;
		}

		// Token: 0x06000219 RID: 537 RVA: 0x00010610 File Offset: 0x0000E810
		public override ulong vmethod_11()
		{
			return (ulong)this.long_0;
		}

		// Token: 0x0600021A RID: 538 RVA: 0x00010624 File Offset: 0x0000E824
		public override float vmethod_12()
		{
			return (float)this.long_0;
		}

		// Token: 0x0600021B RID: 539 RVA: 0x00010638 File Offset: 0x0000E838
		public override double BF7BF7B8()
		{
			return (double)this.long_0;
		}

		// Token: 0x0600021C RID: 540 RVA: 0x0001064C File Offset: 0x0000E84C
		public override IntPtr vmethod_13()
		{
			uint num = 304499625U;
			long value;
			if (IntPtr.Size != 4)
			{
				num %= 165087213U;
				if (1265837438U / num != 0U)
				{
					num = 432045975U / num;
					value = this.long_0;
					goto IL_57;
				}
			}
			num -= 982928085U;
			int num2 = (int)this.long_0;
			num %= 1397837417U;
			long num3 = (long)num2;
			num = 331364004U % num;
			value = num3;
			num ^= 331364007U;
			IL_57:
			num &= 1253977140U;
			return new IntPtr(value);
		}

		// Token: 0x0600021D RID: 541 RVA: 0x000106C0 File Offset: 0x0000E8C0
		public override UIntPtr vmethod_14()
		{
			int size = UIntPtr.Size;
			uint num = 1179U;
			ulong value;
			if (size != 4)
			{
				num = (1859457032U ^ num);
				if (num - 1093752758U != 0U)
				{
					num = 1888821042U % num;
					value = (ulong)this.long_0;
					goto IL_55;
				}
			}
			num -= 791026652U;
			ulong num2 = (ulong)((uint)this.long_0);
			num >>= 11;
			value = num2;
			num ^= 31068578U;
			IL_55:
			num = 2048682244U >> (int)num;
			return new UIntPtr(value);
		}

		// Token: 0x0600021E RID: 542 RVA: 0x00010738 File Offset: 0x0000E938
		public override object F9291D0D(Type type_0, bool bool_0)
		{
			uint num;
			for (;;)
			{
				IL_00:
				Type typeFromHandle = typeof(IntPtr);
				num = 2900992287U;
				if (type_0 == typeFromHandle)
				{
					break;
				}
				while (num > 351037263U)
				{
					num ^= 909080441U;
					RuntimeTypeHandle handle = typeof(UIntPtr).TypeHandle;
					num = 957827850U << (int)num;
					if (type_0 == Type.GetTypeFromHandle(handle))
					{
						if (1940922712U != num)
						{
							goto Block_8;
						}
						goto IL_00;
					}
					else
					{
						if (num < 425217603U)
						{
							goto IL_00;
						}
						num = 870331933U % num;
						TypeCode typeCode = Type.GetTypeCode(type_0);
						num += 719663135U;
						if (543581586U != num)
						{
							object obj = typeCode;
							object obj2 = num - 1589995063U;
							num = 1078621972U * num;
							object obj3 = obj - obj2;
							num *= 808538778U;
							switch (obj3)
							{
							case 0:
								if (1233412608U - num != 0U)
								{
									goto Block_9;
								}
								goto IL_00;
							case 1:
								goto IL_2B6;
							case 2:
								num += 362827762U;
								if (num % 1453410139U != 0U)
								{
									goto Block_10;
								}
								goto IL_00;
							case 3:
								if (num / 1881813534U == 0U)
								{
									goto IL_4EB;
								}
								if (!bool_0)
								{
									goto IL_348;
								}
								if (num + 743712117U != 0U)
								{
									goto Block_13;
								}
								goto IL_00;
							case 4:
								num *= 1362774083U;
								if (2008235050U >= num)
								{
									goto IL_4E0;
								}
								if (!bool_0)
								{
									if ((1098676119U ^ num) != 0U)
									{
										goto Block_16;
									}
									goto IL_00;
								}
								else
								{
									if (160260897 << (int)num != 0)
									{
										goto Block_17;
									}
									goto IL_00;
								}
								break;
							case 5:
								num >>= 22;
								if (1561014980U / num != 0U)
								{
									goto Block_18;
								}
								goto IL_00;
							case 6:
								num = 1559646436U % num;
								num = 1338254303U >> (int)num;
								if (!bool_0)
								{
									goto IL_403;
								}
								if (num / 1715873553U == 0U)
								{
									goto Block_6;
								}
								continue;
							case 7:
								goto IL_455;
							case 8:
								goto IL_493;
							case 9:
								num = 1247742937U >> (int)num;
								if (1955025553U <= num)
								{
									continue;
								}
								if (!bool_0)
								{
									goto IL_4A1;
								}
								num = (436344678U | num);
								if (390684843U * num != 0U)
								{
									goto Block_20;
								}
								goto IL_00;
							}
							goto Block_4;
						}
						break;
					}
				}
				break;
			}
			goto IL_4E0;
			Block_4:
			num ^= 0U;
			goto IL_493;
			Block_6:
			num >>= 10;
			ulong num2 = (ulong)this.long_0;
			num = 52124952U % num;
			long num3 = (long)num2;
			num &= 211838579U;
			long num4 = num3;
			num ^= 1646279148U;
			goto IL_44F;
			Block_8:
			ulong value;
			if (!bool_0)
			{
				num = 2094481166U % num;
				num = 1457941808U - num;
				ulong num5 = (ulong)this.long_0;
				num = 1886135823U << (int)num;
				value = num5;
			}
			else
			{
				num *= 1215511447U;
				if (98982530U / num != 0U)
				{
					goto IL_4EB;
				}
				num -= 1057315251U;
				value = (ulong)this.long_0;
				num += 3742480495U;
			}
			num = 1313570597U >> (int)num;
			return new UIntPtr(value);
			Block_9:
			sbyte b;
			if (!bool_0)
			{
				num |= 1529366711U;
				num /= 780421698U;
				b = checked((sbyte)this.long_0);
			}
			else
			{
				num = (1139817101U & num);
				num = 1699574932U << (int)num;
				ulong num6 = (ulong)this.long_0;
				num |= 446049787U;
				b = checked((sbyte)num6);
				num += 2149614086U;
			}
			num *= 544478590U;
			return b;
			Block_10:
			num /= 377035709U;
			ushort num10;
			checked
			{
				short num7;
				if (!bool_0)
				{
					num = (1453682802U & num);
					num = (705036521U ^ num);
					num7 = (short)this.long_0;
				}
				else
				{
					num >>= 13;
					ulong num8 = (ulong)this.long_0;
					num &= 1367741333U;
					num7 = (short)num8;
					num ^= 705036521U;
				}
				return num7;
				Block_13:
				ushort num9 = (ushort)((uint)this.long_0);
				num <<= 3;
				num10 = num9;
			}
			num += 2633403626U;
			goto IL_371;
			Block_16:
			int num11;
			long num16;
			checked
			{
				num11 = (int)this.long_0;
				goto IL_3A0;
				Block_17:
				num ^= 1018066555U;
				int num12 = (int)((ulong)this.long_0);
				num = (1776362268U | num);
				num11 = num12;
				num ^= 1976530559U;
				goto IL_3A0;
				Block_18:
				num >>= 15;
				uint num14;
				if (!bool_0)
				{
					if (num >= 449804110U)
					{
						goto IL_4EB;
					}
					num = (2039614020U ^ num);
					uint num13 = (uint)this.long_0;
					num /= 2084925948U;
					num14 = num13;
				}
				else
				{
					num = unchecked(706943497U + num);
					num = (507389546U & num);
					ulong num15 = (ulong)this.long_0;
					num = (1403668279U & num);
					num14 = (uint)num15;
					num ^= 35783168U;
				}
				return num14;
				Block_20:
				num16 = this.long_0;
			}
			num = 1777818850U * num;
			double num17 = num16;
			num ^= 1837294358U;
			goto IL_4DA;
			IL_2B6:
			num = 670957724U << (int)num;
			byte b2;
			if (!bool_0)
			{
				b2 = checked((byte)this.long_0);
			}
			else
			{
				num = 1095710632U % num;
				byte b3 = (byte)(checked((ulong)this.long_0));
				num = 1230389358U / num;
				b2 = b3;
				num += 670957722U;
			}
			num /= 803238248U;
			return b2;
			IL_348:
			ushort num18 = (ushort)this.long_0;
			num = 531190282U + num;
			num10 = num18;
			IL_371:
			return num10;
			IL_3A0:
			return num11;
			IL_403:
			num = 115936534U >> (int)num;
			num = 1646271452U << (int)num;
			num4 = this.long_0;
			IL_44F:
			return num4;
			IL_455:
			num |= 702035057U;
			ulong num19;
			if (!bool_0)
			{
				num ^= 407200696U;
				num19 = checked((ulong)this.long_0);
			}
			else
			{
				num = 1649169234U >> (int)num;
				num19 = (ulong)this.long_0;
				num ^= 4154257263U;
			}
			return num19;
			IL_493:
			if (1281951614U < num)
			{
				throw new ArgumentException();
			}
			goto IL_4EB;
			IL_4A1:
			num = (1785012158U ^ num);
			if (1695434798U <= num)
			{
				goto IL_4E0;
			}
			double num20 = (double)this.long_0;
			num >>= 26;
			num17 = num20;
			IL_4DA:
			return num17;
			IL_4E0:
			long value2;
			if (bool_0 || 1865770127U == num)
			{
				num = 797848356U + num;
				ulong num21 = (ulong)this.long_0;
				num = 1052722578U % num;
				value2 = checked((long)num21);
				num ^= 2455168141U;
				goto IL_513;
			}
			IL_4EB:
			value2 = this.long_0;
			IL_513:
			num = (463348264U | num);
			IntPtr intPtr = new IntPtr(value2);
			num = 1406220226U % num;
			return intPtr;
		}

		// Token: 0x040000E6 RID: 230
		private long long_0;
	}

	// Token: 0x02000054 RID: 84
	private sealed class Class11 : GClass18.Class8
	{
		// Token: 0x0600021F RID: 543 RVA: 0x00010C74 File Offset: 0x0000EE74
		public Class11(float float_1)
		{
			this.float_0 = float_1;
		}

		// Token: 0x06000220 RID: 544 RVA: 0x00010C90 File Offset: 0x0000EE90
		public override Type vmethod_6()
		{
			return typeof(float);
		}

		// Token: 0x06000221 RID: 545 RVA: 0x00010CA8 File Offset: 0x0000EEA8
		public override TypeCode vmethod_7()
		{
			return TypeCode.Single;
		}

		// Token: 0x06000222 RID: 546 RVA: 0x00010CB8 File Offset: 0x0000EEB8
		public override GClass18.Class7 vmethod_0()
		{
			return new GClass18.Class11(this.float_0);
		}

		// Token: 0x06000223 RID: 547 RVA: 0x00010CD0 File Offset: 0x0000EED0
		public override object vmethod_1()
		{
			return this.float_0;
		}

		// Token: 0x06000224 RID: 548 RVA: 0x00010CE8 File Offset: 0x0000EEE8
		public override void vmethod_2(object object_0)
		{
			this.float_0 = Convert.ToSingle(object_0);
		}

		// Token: 0x06000225 RID: 549 RVA: 0x00010D04 File Offset: 0x0000EF04
		public override bool A0715E7F()
		{
			return Convert.ToBoolean(this.float_0);
		}

		// Token: 0x06000226 RID: 550 RVA: 0x00010D1C File Offset: 0x0000EF1C
		public override sbyte vmethod_8()
		{
			return (sbyte)this.float_0;
		}

		// Token: 0x06000227 RID: 551 RVA: 0x00010D30 File Offset: 0x0000EF30
		public override short DAAA832C()
		{
			return (short)this.float_0;
		}

		// Token: 0x06000228 RID: 552 RVA: 0x00010D44 File Offset: 0x0000EF44
		public override int DE119705()
		{
			return (int)this.float_0;
		}

		// Token: 0x06000229 RID: 553 RVA: 0x00010D58 File Offset: 0x0000EF58
		public override long E9C7AF34()
		{
			return (long)this.float_0;
		}

		// Token: 0x0600022A RID: 554 RVA: 0x00010D6C File Offset: 0x0000EF6C
		public override char C075F08B()
		{
			return (char)this.float_0;
		}

		// Token: 0x0600022B RID: 555 RVA: 0x00010D80 File Offset: 0x0000EF80
		public override byte vmethod_9()
		{
			return (byte)this.float_0;
		}

		// Token: 0x0600022C RID: 556 RVA: 0x00010D94 File Offset: 0x0000EF94
		public override ushort E1B55196()
		{
			return (ushort)this.float_0;
		}

		// Token: 0x0600022D RID: 557 RVA: 0x00010DA8 File Offset: 0x0000EFA8
		public override uint vmethod_10()
		{
			return (uint)this.float_0;
		}

		// Token: 0x0600022E RID: 558 RVA: 0x00010DBC File Offset: 0x0000EFBC
		public override ulong vmethod_11()
		{
			return (ulong)this.float_0;
		}

		// Token: 0x0600022F RID: 559 RVA: 0x00010DD0 File Offset: 0x0000EFD0
		public override float vmethod_12()
		{
			return this.float_0;
		}

		// Token: 0x06000230 RID: 560 RVA: 0x00010DE4 File Offset: 0x0000EFE4
		public override double BF7BF7B8()
		{
			return (double)this.float_0;
		}

		// Token: 0x06000231 RID: 561 RVA: 0x00010DF8 File Offset: 0x0000EFF8
		public override IntPtr vmethod_13()
		{
			uint num2;
			for (;;)
			{
				int size = IntPtr.Size;
				int num = 4;
				num2 = 35730541U;
				if (size != num)
				{
					break;
				}
				num2 = 487008923U % num2;
				if (649217292U > num2)
				{
					goto Block_1;
				}
			}
			num2 = 1136881884U / num2;
			num2 = 720075725U - num2;
			long value = (long)this.float_0;
			goto IL_4B;
			Block_1:
			value = (long)((int)this.float_0);
			num2 ^= 733805244U;
			IL_4B:
			num2 = 731331246U >> (int)num2;
			return new IntPtr(value);
		}

		// Token: 0x06000232 RID: 562 RVA: 0x00010E64 File Offset: 0x0000F064
		public override UIntPtr vmethod_14()
		{
			int size = IntPtr.Size;
			uint num = 252670869U;
			ulong value;
			if (size != 4)
			{
				num = 1290607841U - num;
				value = (ulong)this.float_0;
			}
			else
			{
				num = (1486106143U ^ num);
				value = (ulong)((uint)this.float_0);
				num ^= 1783035078U;
			}
			num &= 819805884U;
			return new UIntPtr(value);
		}

		// Token: 0x06000233 RID: 563 RVA: 0x00010EB8 File Offset: 0x0000F0B8
		public override object F9291D0D(Type type_0, bool bool_0)
		{
			uint num;
			for (;;)
			{
				Type typeFromHandle = typeof(IntPtr);
				num = 1220505621U;
				if (type_0 == typeFromHandle)
				{
					break;
				}
				num = (789597975U | num);
				if (type_0 == typeof(UIntPtr))
				{
					if (num != 325213976U)
					{
						goto Block_2;
					}
				}
				else
				{
					num = 585376827U % num;
					if (num >= 587168946U)
					{
						break;
					}
					TypeCode typeCode = Type.GetTypeCode(type_0);
					num <<= 27;
					TypeCode typeCode2 = typeCode;
					uint num2 = (uint)typeCode2;
					num = 1534528013U - num;
					uint num3 = num2 - (num ^ 2205616648U);
					num = (1067082293U ^ num);
					switch (num3)
					{
					case 0:
						num = 1678793549U + num;
						if (!bool_0)
						{
							goto IL_10E;
						}
						num &= 75197502U;
						if (num % 845953723U != 0U)
						{
							goto Block_6;
						}
						continue;
					case 1:
						goto IL_145;
					case 2:
						goto IL_16E;
					case 3:
						goto IL_1B8;
					case 4:
						goto IL_1D5;
					case 5:
						goto IL_200;
					case 6:
						break;
					case 7:
						goto IL_21B;
					default:
						num ^= 0U;
						break;
					}
					num = 676354821U * num;
					if (num % 382428810U != 0U)
					{
						goto Block_7;
					}
				}
			}
			goto IL_247;
			Block_2:
			ulong num4 = (ulong)this.float_0;
			num = (538518440U ^ num);
			ulong value = num4;
			num *= 1213749078U;
			UIntPtr uintPtr = new UIntPtr(value);
			num = 1670718845U >> (int)num;
			return uintPtr;
			Block_6:
			num <<= 1;
			sbyte b = (sbyte)(checked((uint)this.float_0));
			num += 1628703239U;
			sbyte b2 = b;
			num += 3203873142U;
			goto IL_13F;
			Block_7:
			throw new ArgumentException();
			IL_10E:
			num %= 1447562498U;
			b2 = checked((sbyte)this.float_0);
			IL_13F:
			return b2;
			IL_145:
			num %= 1620460835U;
			if ((1408646204U ^ num) != 0U)
			{
				byte b3 = (byte)this.float_0;
				num %= 1490689082U;
				return b3;
			}
			goto IL_247;
			IL_16E:
			short num5;
			if (!bool_0)
			{
				num = 1970241270U - num;
				num >>= 8;
				num5 = checked((short)this.float_0);
			}
			else
			{
				uint num6 = (uint)this.float_0;
				num >>= 8;
				short num7 = (short)num6;
				num -= 1740725599U;
				num5 = num7;
				num += 1740435981U;
			}
			num >>= 26;
			return num5;
			IL_1B8:
			num >>= 29;
			ushort num8 = checked((ushort)this.float_0);
			num = 249392884U * num;
			return num8;
			IL_1D5:
			num = (506724511U | num);
			if (985885354U <= num)
			{
				int num9 = checked((int)this.float_0);
				num = 1143485025U >> (int)num;
				return num9;
			}
			goto IL_247;
			IL_200:
			num = 1994995809U * num;
			return checked((uint)this.float_0);
			IL_21B:
			num = 1981094253U >> (int)num;
			if ((num & 1109868812U) != 0U)
			{
				ulong num10 = (ulong)this.float_0;
				num |= 255670241U;
				return num10;
			}
			IL_247:
			long num11 = (long)this.float_0;
			num &= 422340667U;
			IntPtr intPtr = new IntPtr(num11);
			num = (298595510U ^ num);
			return intPtr;
		}

		// Token: 0x040000E7 RID: 231
		private float float_0;
	}

	// Token: 0x02000055 RID: 85
	private sealed class Class12 : GClass18.Class8
	{
		// Token: 0x06000234 RID: 564 RVA: 0x00011130 File Offset: 0x0000F330
		public Class12(double double_1)
		{
			uint num = 87098902U;
			do
			{
				base..ctor();
				num = 1200904621U << (int)num;
				this.double_0 = double_1;
			}
			while (num << 21 != 0U);
		}

		// Token: 0x06000235 RID: 565 RVA: 0x00011168 File Offset: 0x0000F368
		public override Type vmethod_6()
		{
			return typeof(double);
		}

		// Token: 0x06000236 RID: 566 RVA: 0x00011180 File Offset: 0x0000F380
		public override TypeCode vmethod_7()
		{
			return TypeCode.Double;
		}

		// Token: 0x06000237 RID: 567 RVA: 0x00011190 File Offset: 0x0000F390
		public override GClass18.Class7 vmethod_0()
		{
			return new GClass18.Class12(this.double_0);
		}

		// Token: 0x06000238 RID: 568 RVA: 0x000111A8 File Offset: 0x0000F3A8
		public override object vmethod_1()
		{
			return this.double_0;
		}

		// Token: 0x06000239 RID: 569 RVA: 0x000111C0 File Offset: 0x0000F3C0
		public override void vmethod_2(object object_0)
		{
			this.double_0 = (double)object_0;
		}

		// Token: 0x0600023A RID: 570 RVA: 0x000111DC File Offset: 0x0000F3DC
		public override bool A0715E7F()
		{
			return Convert.ToBoolean(this.double_0);
		}

		// Token: 0x0600023B RID: 571 RVA: 0x000111F4 File Offset: 0x0000F3F4
		public override sbyte vmethod_8()
		{
			return (sbyte)this.double_0;
		}

		// Token: 0x0600023C RID: 572 RVA: 0x00011208 File Offset: 0x0000F408
		public override short DAAA832C()
		{
			return (short)this.double_0;
		}

		// Token: 0x0600023D RID: 573 RVA: 0x0001121C File Offset: 0x0000F41C
		public override int DE119705()
		{
			return (int)this.double_0;
		}

		// Token: 0x0600023E RID: 574 RVA: 0x00011230 File Offset: 0x0000F430
		public override long E9C7AF34()
		{
			return (long)this.double_0;
		}

		// Token: 0x0600023F RID: 575 RVA: 0x00011244 File Offset: 0x0000F444
		public override char C075F08B()
		{
			return (char)this.double_0;
		}

		// Token: 0x06000240 RID: 576 RVA: 0x00011258 File Offset: 0x0000F458
		public override byte vmethod_9()
		{
			return (byte)this.double_0;
		}

		// Token: 0x06000241 RID: 577 RVA: 0x0001126C File Offset: 0x0000F46C
		public override ushort E1B55196()
		{
			return (ushort)this.double_0;
		}

		// Token: 0x06000242 RID: 578 RVA: 0x00011280 File Offset: 0x0000F480
		public override uint vmethod_10()
		{
			return (uint)this.double_0;
		}

		// Token: 0x06000243 RID: 579 RVA: 0x00011294 File Offset: 0x0000F494
		public override ulong vmethod_11()
		{
			return (ulong)this.double_0;
		}

		// Token: 0x06000244 RID: 580 RVA: 0x000112A8 File Offset: 0x0000F4A8
		public override float vmethod_12()
		{
			return (float)this.double_0;
		}

		// Token: 0x06000245 RID: 581 RVA: 0x000112BC File Offset: 0x0000F4BC
		public override double BF7BF7B8()
		{
			return this.double_0;
		}

		// Token: 0x06000246 RID: 582 RVA: 0x000112D0 File Offset: 0x0000F4D0
		public override IntPtr vmethod_13()
		{
			int size = IntPtr.Size;
			int num = 4;
			uint num2 = 220995695U;
			long value;
			if (size == num)
			{
				if (num2 / 421153148U == 0U)
				{
					num2 = 1943417528U >> (int)num2;
					int num3 = (int)this.double_0;
					num2 -= 570503291U;
					long num4 = (long)num3;
					num2 = 1121130702U << (int)num2;
					value = num4;
					num2 ^= 1691883644U;
					goto IL_72;
				}
			}
			num2 /= 771890331U;
			long num5 = (long)this.double_0;
			num2 = 1430526076U >> (int)num2;
			value = num5;
			IL_72:
			return new IntPtr(value);
		}

		// Token: 0x06000247 RID: 583 RVA: 0x00011354 File Offset: 0x0000F554
		public override UIntPtr vmethod_14()
		{
			int size = IntPtr.Size;
			int num = 4;
			uint num2 = 2147483648U;
			ulong value;
			if (size != num)
			{
				num2 >>= 2;
				ulong num3 = (ulong)this.double_0;
				num2 &= 1800347728U;
				value = num3;
			}
			else
			{
				num2 /= 326131329U;
				ulong num4 = (ulong)((uint)this.double_0);
				num2 = 1208825389U * num2;
				value = num4;
				num2 += 1873853170U;
			}
			num2 &= 699818072U;
			return new UIntPtr(value);
		}

		// Token: 0x06000248 RID: 584 RVA: 0x000113C4 File Offset: 0x0000F5C4
		public override object F9291D0D(Type type_0, bool bool_0)
		{
			uint num;
			for (;;)
			{
				IL_00:
				Type typeFromHandle = typeof(IntPtr);
				num = 2908150528U;
				if (type_0 == typeFromHandle)
				{
					break;
				}
				for (;;)
				{
					num %= 603914509U;
					num &= 1780957270U;
					Type typeFromHandle2 = typeof(UIntPtr);
					num = 1340625835U - num;
					if (type_0 == typeFromHandle2)
					{
						goto Block_5;
					}
					if (2066380250U >> (int)num != 0U)
					{
						TypeCode typeCode = Type.GetTypeCode(type_0);
						num = 992094821U / num;
						object obj = typeCode;
						object obj2 = num ^ 5U;
						num = 1461810168U + num;
						object obj3 = obj - obj2;
						num = 1354435350U + num;
						switch (obj3)
						{
						case 0:
							goto IL_E8;
						case 1:
							goto IL_1EB;
						case 2:
							num /= 244608015U;
							num = 1505910011U % num;
							if (!bool_0)
							{
								goto IL_210;
							}
							num = 660284007U % num;
							if (267723731U != num)
							{
								goto Block_4;
							}
							continue;
						case 3:
							goto IL_129;
						case 4:
							goto IL_139;
						case 5:
							goto IL_279;
						case 6:
							goto IL_2A6;
						case 7:
							goto IL_2C9;
						case 8:
							goto IL_2E6;
						case 9:
							goto IL_14A;
						}
						goto Block_2;
					}
					goto IL_00;
				}
				IL_E8:
				num = 1739946120U % num;
				if (2087977362U * num == 0U)
				{
					goto IL_1D1;
				}
				num <<= 15;
				if (!bool_0)
				{
					num ^= 1829117911U;
					if (887645184U < num)
					{
						goto Block_8;
					}
					continue;
				}
				else
				{
					if (327226763U <= num)
					{
						goto Block_9;
					}
					continue;
				}
				IL_129:
				if (187321818U < num)
				{
					goto Block_10;
				}
				continue;
				IL_139:
				if (1305177391U * num != 0U)
				{
					goto Block_11;
				}
				continue;
				IL_14A:
				if ((num & 1121021573U) != 0U)
				{
					goto Block_12;
				}
			}
			num *= 1595938602U;
			long num2 = (long)this.double_0;
			num |= 1029658872U;
			IntPtr intPtr = new IntPtr(num2);
			num = (1610104774U ^ num);
			return intPtr;
			Block_2:
			num ^= 0U;
			goto IL_2E6;
			Block_4:
			num = (495929339U & num);
			uint num3 = (uint)this.double_0;
			num = 2084325571U - num;
			short num4 = (short)num3;
			num ^= 1112812651U;
			short num5 = num4;
			num ^= 1047028905U;
			goto IL_249;
			Block_5:
			goto IL_1D1;
			Block_8:
			num *= 994199406U;
			uint num11;
			checked
			{
				sbyte b = (sbyte)this.double_0;
				goto IL_1C3;
				Block_9:
				num = (20452563U & num);
				uint num6 = (uint)this.double_0;
				num <<= 11;
				b = (sbyte)num6;
				num ^= 61624162U;
				goto IL_1C3;
				Block_10:
				return (ushort)this.double_0;
				Block_11:
				int num7 = (int)this.double_0;
				num = unchecked(1171865895U + num);
				return num7;
				Block_12:
				double num8 = this.double_0;
				num ^= 510729196U;
				return num8;
				IL_1C3:
				num |= 820652212U;
				return b;
				IL_1D1:
				ulong num9 = (ulong)this.double_0;
				num = (1251156750U & num);
				return new UIntPtr(num9);
				IL_1EB:
				num = (302711042U & num);
				num = (36400153U | num);
				byte b2 = (byte)this.double_0;
				num &= 980098100U;
				return b2;
				IL_210:
				num %= 1805911022U;
				num5 = (short)this.double_0;
				IL_249:
				num |= 2116892506U;
				return num5;
				IL_279:
				num %= 684012516U;
				num = 1197034168U % num;
				uint num10 = (uint)this.double_0;
				num = 990272791U % num;
				num11 = num10;
			}
			num *= 1383102355U;
			return num11;
			IL_2A6:
			long num12 = (long)this.double_0;
			num &= 818378520U;
			long num13 = num12;
			num = 535977458U << (int)num;
			return num13;
			IL_2C9:
			num = 1229745701U + num;
			num <<= 16;
			return checked((ulong)this.double_0);
			IL_2E6:
			num = (544962993U ^ num);
			throw new ArgumentException();
		}

		// Token: 0x040000E8 RID: 232
		private double double_0;
	}

	// Token: 0x02000056 RID: 86
	private sealed class Class13 : GClass18.Class8
	{
		// Token: 0x06000249 RID: 585 RVA: 0x000116D8 File Offset: 0x0000F8D8
		public Class13(string string_1)
		{
			this.string_0 = string_1;
		}

		// Token: 0x0600024A RID: 586 RVA: 0x000116F4 File Offset: 0x0000F8F4
		public override Type vmethod_6()
		{
			return typeof(string);
		}

		// Token: 0x0600024B RID: 587 RVA: 0x0001170C File Offset: 0x0000F90C
		public override TypeCode vmethod_7()
		{
			return TypeCode.Object;
		}

		// Token: 0x0600024C RID: 588 RVA: 0x0001171C File Offset: 0x0000F91C
		public override GClass18.Class7 vmethod_0()
		{
			return new GClass18.Class13(this.string_0);
		}

		// Token: 0x0600024D RID: 589 RVA: 0x00011734 File Offset: 0x0000F934
		public override object vmethod_1()
		{
			return this.string_0;
		}

		// Token: 0x0600024E RID: 590 RVA: 0x00011748 File Offset: 0x0000F948
		public override void vmethod_2(object object_0)
		{
			uint num;
			string text;
			if (object_0 == null)
			{
				num = 1761757650U;
				text = null;
			}
			else
			{
				text = Convert.ToString(object_0);
				num = 1761757650U;
			}
			num %= 1414092498U;
			this.string_0 = text;
		}

		// Token: 0x0600024F RID: 591 RVA: 0x00011784 File Offset: 0x0000F984
		public override bool A0715E7F()
		{
			return this.string_0 != null;
		}

		// Token: 0x06000250 RID: 592 RVA: 0x0001179C File Offset: 0x0000F99C
		public override string ToString()
		{
			return this.string_0;
		}

		// Token: 0x040000E9 RID: 233
		private string string_0;
	}

	// Token: 0x02000057 RID: 87
	private sealed class Class28 : GClass18.Class7
	{
		// Token: 0x06000251 RID: 593 RVA: 0x000117B0 File Offset: 0x0000F9B0
		public Class28(short short_1)
		{
			this.short_0 = short_1;
		}

		// Token: 0x06000252 RID: 594 RVA: 0x000117CC File Offset: 0x0000F9CC
		public override Type vmethod_6()
		{
			return typeof(short);
		}

		// Token: 0x06000253 RID: 595 RVA: 0x000117E4 File Offset: 0x0000F9E4
		public override GClass18.Class7 vmethod_0()
		{
			return new GClass18.Class28(this.short_0);
		}

		// Token: 0x06000254 RID: 596 RVA: 0x000117FC File Offset: 0x0000F9FC
		public override object vmethod_1()
		{
			return this.short_0;
		}

		// Token: 0x06000255 RID: 597 RVA: 0x00011814 File Offset: 0x0000FA14
		public override void vmethod_2(object object_0)
		{
			this.short_0 = Convert.ToInt16(object_0);
		}

		// Token: 0x06000256 RID: 598 RVA: 0x00011830 File Offset: 0x0000FA30
		public override GClass18.Class8 vmethod_4()
		{
			return new GClass18.Class9(this.DE119705());
		}

		// Token: 0x06000257 RID: 599 RVA: 0x00011848 File Offset: 0x0000FA48
		public override sbyte vmethod_8()
		{
			return (sbyte)this.short_0;
		}

		// Token: 0x06000258 RID: 600 RVA: 0x0001185C File Offset: 0x0000FA5C
		public override byte vmethod_9()
		{
			return (byte)this.short_0;
		}

		// Token: 0x06000259 RID: 601 RVA: 0x00011870 File Offset: 0x0000FA70
		public override short DAAA832C()
		{
			return this.short_0;
		}

		// Token: 0x0600025A RID: 602 RVA: 0x00011884 File Offset: 0x0000FA84
		public override ushort E1B55196()
		{
			return (ushort)this.short_0;
		}

		// Token: 0x0600025B RID: 603 RVA: 0x00011898 File Offset: 0x0000FA98
		public override int DE119705()
		{
			return (int)this.short_0;
		}

		// Token: 0x0600025C RID: 604 RVA: 0x000118AC File Offset: 0x0000FAAC
		public override uint vmethod_10()
		{
			return (uint)this.short_0;
		}

		// Token: 0x040000EA RID: 234
		private short short_0;
	}

	// Token: 0x02000058 RID: 88
	private sealed class Class29 : GClass18.Class7
	{
		// Token: 0x0600025D RID: 605 RVA: 0x000118C0 File Offset: 0x0000FAC0
		public Class29(ushort ushort_1)
		{
			uint num = 1698890160U;
			do
			{
				this.ushort_0 = ushort_1;
			}
			while (577717156U > num);
		}

		// Token: 0x0600025E RID: 606 RVA: 0x000118E8 File Offset: 0x0000FAE8
		public override Type vmethod_6()
		{
			return typeof(ushort);
		}

		// Token: 0x0600025F RID: 607 RVA: 0x00011900 File Offset: 0x0000FB00
		public override GClass18.Class7 vmethod_0()
		{
			return new GClass18.Class29(this.ushort_0);
		}

		// Token: 0x06000260 RID: 608 RVA: 0x00011918 File Offset: 0x0000FB18
		public override object vmethod_1()
		{
			return this.ushort_0;
		}

		// Token: 0x06000261 RID: 609 RVA: 0x00011930 File Offset: 0x0000FB30
		public override void vmethod_2(object object_0)
		{
			uint num = 1833131697U;
			do
			{
				this.ushort_0 = Convert.ToUInt16(object_0);
			}
			while (num > 1843871074U);
		}

		// Token: 0x06000262 RID: 610 RVA: 0x00011958 File Offset: 0x0000FB58
		public override GClass18.Class8 vmethod_4()
		{
			return new GClass18.Class9(this.DE119705());
		}

		// Token: 0x06000263 RID: 611 RVA: 0x00011970 File Offset: 0x0000FB70
		public override sbyte vmethod_8()
		{
			return (sbyte)this.ushort_0;
		}

		// Token: 0x06000264 RID: 612 RVA: 0x00011984 File Offset: 0x0000FB84
		public override byte vmethod_9()
		{
			return (byte)this.ushort_0;
		}

		// Token: 0x06000265 RID: 613 RVA: 0x00011998 File Offset: 0x0000FB98
		public override short DAAA832C()
		{
			return (short)this.ushort_0;
		}

		// Token: 0x06000266 RID: 614 RVA: 0x000119AC File Offset: 0x0000FBAC
		public override ushort E1B55196()
		{
			return this.ushort_0;
		}

		// Token: 0x06000267 RID: 615 RVA: 0x000119C0 File Offset: 0x0000FBC0
		public override int DE119705()
		{
			return (int)this.ushort_0;
		}

		// Token: 0x06000268 RID: 616 RVA: 0x000119D4 File Offset: 0x0000FBD4
		public override uint vmethod_10()
		{
			return (uint)this.ushort_0;
		}

		// Token: 0x040000EB RID: 235
		private ushort ushort_0;
	}

	// Token: 0x02000059 RID: 89
	private sealed class Class30 : GClass18.Class7
	{
		// Token: 0x06000269 RID: 617 RVA: 0x000119E8 File Offset: 0x0000FBE8
		public Class30(bool bool_1)
		{
			this.bool_0 = bool_1;
		}

		// Token: 0x0600026A RID: 618 RVA: 0x00011A04 File Offset: 0x0000FC04
		public override Type vmethod_6()
		{
			return typeof(bool);
		}

		// Token: 0x0600026B RID: 619 RVA: 0x00011A1C File Offset: 0x0000FC1C
		public override GClass18.Class7 vmethod_0()
		{
			return new GClass18.Class30(this.bool_0);
		}

		// Token: 0x0600026C RID: 620 RVA: 0x00011A34 File Offset: 0x0000FC34
		public override object vmethod_1()
		{
			return this.bool_0;
		}

		// Token: 0x0600026D RID: 621 RVA: 0x00011A4C File Offset: 0x0000FC4C
		public override void vmethod_2(object object_0)
		{
			this.bool_0 = Convert.ToBoolean(object_0);
		}

		// Token: 0x0600026E RID: 622 RVA: 0x00011A68 File Offset: 0x0000FC68
		public override GClass18.Class8 vmethod_4()
		{
			return new GClass18.Class9(this.DE119705());
		}

		// Token: 0x0600026F RID: 623 RVA: 0x00011A80 File Offset: 0x0000FC80
		public override int DE119705()
		{
			bool flag = this.bool_0;
			uint num = 290133782U;
			if (!flag)
			{
				return (int)(num ^ 290133782U);
			}
			return (int)(num ^ 290133783U);
		}

		// Token: 0x040000EC RID: 236
		private bool bool_0;
	}

	// Token: 0x0200005A RID: 90
	private sealed class Class31 : GClass18.Class7
	{
		// Token: 0x06000270 RID: 624 RVA: 0x00011AB0 File Offset: 0x0000FCB0
		public Class31(char char_1)
		{
			this.char_0 = char_1;
		}

		// Token: 0x06000271 RID: 625 RVA: 0x00011ACC File Offset: 0x0000FCCC
		public override Type vmethod_6()
		{
			return typeof(char);
		}

		// Token: 0x06000272 RID: 626 RVA: 0x00011AE4 File Offset: 0x0000FCE4
		public override GClass18.Class7 vmethod_0()
		{
			return new GClass18.Class31(this.char_0);
		}

		// Token: 0x06000273 RID: 627 RVA: 0x00011AFC File Offset: 0x0000FCFC
		public override object vmethod_1()
		{
			return this.char_0;
		}

		// Token: 0x06000274 RID: 628 RVA: 0x00011B14 File Offset: 0x0000FD14
		public override void vmethod_2(object object_0)
		{
			uint num = 991976075U;
			do
			{
				num = (1411404355U | num);
				char c = Convert.ToChar(object_0);
				num = 1485447824U % num;
				this.char_0 = c;
			}
			while (84093558U == num);
		}

		// Token: 0x06000275 RID: 629 RVA: 0x00011B4C File Offset: 0x0000FD4C
		public override GClass18.Class8 vmethod_4()
		{
			return new GClass18.Class9(this.DE119705());
		}

		// Token: 0x06000276 RID: 630 RVA: 0x00011B64 File Offset: 0x0000FD64
		public override sbyte vmethod_8()
		{
			return (sbyte)this.char_0;
		}

		// Token: 0x06000277 RID: 631 RVA: 0x00011B78 File Offset: 0x0000FD78
		public override byte vmethod_9()
		{
			return (byte)this.char_0;
		}

		// Token: 0x06000278 RID: 632 RVA: 0x00011B8C File Offset: 0x0000FD8C
		public override short DAAA832C()
		{
			return (short)this.char_0;
		}

		// Token: 0x06000279 RID: 633 RVA: 0x00011BA0 File Offset: 0x0000FDA0
		public override ushort E1B55196()
		{
			return (ushort)this.char_0;
		}

		// Token: 0x0600027A RID: 634 RVA: 0x00011BB4 File Offset: 0x0000FDB4
		public override int DE119705()
		{
			return (int)this.char_0;
		}

		// Token: 0x0600027B RID: 635 RVA: 0x00011BC8 File Offset: 0x0000FDC8
		public override uint vmethod_10()
		{
			return (uint)this.char_0;
		}

		// Token: 0x040000ED RID: 237
		private char char_0;
	}

	// Token: 0x0200005B RID: 91
	private sealed class Class32 : GClass18.Class7
	{
		// Token: 0x0600027C RID: 636 RVA: 0x00011BDC File Offset: 0x0000FDDC
		public Class32(byte byte_1)
		{
			this.byte_0 = byte_1;
		}

		// Token: 0x0600027D RID: 637 RVA: 0x00011BF8 File Offset: 0x0000FDF8
		public override Type vmethod_6()
		{
			return typeof(byte);
		}

		// Token: 0x0600027E RID: 638 RVA: 0x00011C10 File Offset: 0x0000FE10
		public override GClass18.Class7 vmethod_0()
		{
			return new GClass18.Class32(this.byte_0);
		}

		// Token: 0x0600027F RID: 639 RVA: 0x00011C28 File Offset: 0x0000FE28
		public override object vmethod_1()
		{
			return this.byte_0;
		}

		// Token: 0x06000280 RID: 640 RVA: 0x00011C40 File Offset: 0x0000FE40
		public override void vmethod_2(object object_0)
		{
			uint num = 1246172172U;
			do
			{
				num = 797590100U - num;
				num /= 1535016375U;
				this.byte_0 = Convert.ToByte(object_0);
			}
			while (num >= 1983849651U);
		}

		// Token: 0x06000281 RID: 641 RVA: 0x00011C78 File Offset: 0x0000FE78
		public override GClass18.Class8 vmethod_4()
		{
			return new GClass18.Class9(this.DE119705());
		}

		// Token: 0x06000282 RID: 642 RVA: 0x00011C90 File Offset: 0x0000FE90
		public override sbyte vmethod_8()
		{
			return (sbyte)this.byte_0;
		}

		// Token: 0x06000283 RID: 643 RVA: 0x00011CA4 File Offset: 0x0000FEA4
		public override byte vmethod_9()
		{
			return this.byte_0;
		}

		// Token: 0x06000284 RID: 644 RVA: 0x00011CB8 File Offset: 0x0000FEB8
		public override short DAAA832C()
		{
			return (short)this.byte_0;
		}

		// Token: 0x06000285 RID: 645 RVA: 0x00011CCC File Offset: 0x0000FECC
		public override ushort E1B55196()
		{
			return (ushort)this.byte_0;
		}

		// Token: 0x06000286 RID: 646 RVA: 0x00011CE0 File Offset: 0x0000FEE0
		public override int DE119705()
		{
			return (int)this.byte_0;
		}

		// Token: 0x06000287 RID: 647 RVA: 0x00011CF4 File Offset: 0x0000FEF4
		public override uint vmethod_10()
		{
			return (uint)this.byte_0;
		}

		// Token: 0x040000EE RID: 238
		private byte byte_0;
	}

	// Token: 0x0200005C RID: 92
	private sealed class Class33 : GClass18.Class7
	{
		// Token: 0x06000288 RID: 648 RVA: 0x00011D08 File Offset: 0x0000FF08
		public Class33(sbyte sbyte_1)
		{
			this.sbyte_0 = sbyte_1;
		}

		// Token: 0x06000289 RID: 649 RVA: 0x00011D24 File Offset: 0x0000FF24
		public override Type vmethod_6()
		{
			return typeof(sbyte);
		}

		// Token: 0x0600028A RID: 650 RVA: 0x00011D3C File Offset: 0x0000FF3C
		public override GClass18.Class7 vmethod_0()
		{
			return new GClass18.Class33(this.sbyte_0);
		}

		// Token: 0x0600028B RID: 651 RVA: 0x00011D54 File Offset: 0x0000FF54
		public override object vmethod_1()
		{
			return this.sbyte_0;
		}

		// Token: 0x0600028C RID: 652 RVA: 0x00011D6C File Offset: 0x0000FF6C
		public override void vmethod_2(object object_0)
		{
			uint num = 1739460505U;
			do
			{
				num = (1821078005U & num);
				num <<= 11;
				sbyte b = Convert.ToSByte(object_0);
				num = (2002550586U & num);
				this.sbyte_0 = b;
			}
			while (num - 2083264058U == 0U);
		}

		// Token: 0x0600028D RID: 653 RVA: 0x00011DAC File Offset: 0x0000FFAC
		public override GClass18.Class8 vmethod_4()
		{
			return new GClass18.Class9(this.DE119705());
		}

		// Token: 0x0600028E RID: 654 RVA: 0x00011DC4 File Offset: 0x0000FFC4
		public override sbyte vmethod_8()
		{
			return this.sbyte_0;
		}

		// Token: 0x0600028F RID: 655 RVA: 0x00011DD8 File Offset: 0x0000FFD8
		public override byte vmethod_9()
		{
			return (byte)this.sbyte_0;
		}

		// Token: 0x06000290 RID: 656 RVA: 0x00011DEC File Offset: 0x0000FFEC
		public override short DAAA832C()
		{
			return (short)this.sbyte_0;
		}

		// Token: 0x06000291 RID: 657 RVA: 0x00011E00 File Offset: 0x00010000
		public override ushort E1B55196()
		{
			return (ushort)this.sbyte_0;
		}

		// Token: 0x06000292 RID: 658 RVA: 0x00011E14 File Offset: 0x00010014
		public override int DE119705()
		{
			return (int)this.sbyte_0;
		}

		// Token: 0x06000293 RID: 659 RVA: 0x00011E28 File Offset: 0x00010028
		public override uint vmethod_10()
		{
			return (uint)this.sbyte_0;
		}

		// Token: 0x040000EF RID: 239
		private sbyte sbyte_0;
	}

	// Token: 0x0200005D RID: 93
	private sealed class Class34 : GClass18.Class7
	{
		// Token: 0x06000294 RID: 660 RVA: 0x00011E3C File Offset: 0x0001003C
		public Class34(uint uint_1)
		{
			this.uint_0 = uint_1;
		}

		// Token: 0x06000295 RID: 661 RVA: 0x00011E58 File Offset: 0x00010058
		public override Type vmethod_6()
		{
			return typeof(uint);
		}

		// Token: 0x06000296 RID: 662 RVA: 0x00011E70 File Offset: 0x00010070
		public override GClass18.Class7 vmethod_0()
		{
			return new GClass18.Class34(this.uint_0);
		}

		// Token: 0x06000297 RID: 663 RVA: 0x00011E88 File Offset: 0x00010088
		public override object vmethod_1()
		{
			return this.uint_0;
		}

		// Token: 0x06000298 RID: 664 RVA: 0x00011EA0 File Offset: 0x000100A0
		public override void vmethod_2(object object_0)
		{
			this.uint_0 = Convert.ToUInt32(object_0);
		}

		// Token: 0x06000299 RID: 665 RVA: 0x00011EBC File Offset: 0x000100BC
		public override GClass18.Class8 vmethod_4()
		{
			return new GClass18.Class9(this.DE119705());
		}

		// Token: 0x0600029A RID: 666 RVA: 0x00011ED4 File Offset: 0x000100D4
		public override sbyte vmethod_8()
		{
			return (sbyte)this.uint_0;
		}

		// Token: 0x0600029B RID: 667 RVA: 0x00011EE8 File Offset: 0x000100E8
		public override byte vmethod_9()
		{
			return (byte)this.uint_0;
		}

		// Token: 0x0600029C RID: 668 RVA: 0x00011EFC File Offset: 0x000100FC
		public override short DAAA832C()
		{
			return (short)this.uint_0;
		}

		// Token: 0x0600029D RID: 669 RVA: 0x00011F10 File Offset: 0x00010110
		public override ushort E1B55196()
		{
			return (ushort)this.uint_0;
		}

		// Token: 0x0600029E RID: 670 RVA: 0x00011F24 File Offset: 0x00010124
		public override int DE119705()
		{
			return (int)this.uint_0;
		}

		// Token: 0x0600029F RID: 671 RVA: 0x00011F38 File Offset: 0x00010138
		public override uint vmethod_10()
		{
			return this.uint_0;
		}

		// Token: 0x040000F0 RID: 240
		private uint uint_0;
	}

	// Token: 0x0200005E RID: 94
	private sealed class Class35 : GClass18.Class7
	{
		// Token: 0x060002A0 RID: 672 RVA: 0x00011F4C File Offset: 0x0001014C
		public Class35(ulong ulong_1)
		{
			this.ulong_0 = ulong_1;
		}

		// Token: 0x060002A1 RID: 673 RVA: 0x00011F68 File Offset: 0x00010168
		public override Type vmethod_6()
		{
			return typeof(ulong);
		}

		// Token: 0x060002A2 RID: 674 RVA: 0x00011F80 File Offset: 0x00010180
		public override GClass18.Class7 vmethod_0()
		{
			return new GClass18.Class35(this.ulong_0);
		}

		// Token: 0x060002A3 RID: 675 RVA: 0x00011F98 File Offset: 0x00010198
		public override object vmethod_1()
		{
			return this.ulong_0;
		}

		// Token: 0x060002A4 RID: 676 RVA: 0x00011FB0 File Offset: 0x000101B0
		public override void vmethod_2(object object_0)
		{
			this.ulong_0 = Convert.ToUInt64(object_0);
		}

		// Token: 0x060002A5 RID: 677 RVA: 0x00011FCC File Offset: 0x000101CC
		public override GClass18.Class8 vmethod_4()
		{
			return new GClass18.Class10(this.E9C7AF34());
		}

		// Token: 0x060002A6 RID: 678 RVA: 0x00011FE4 File Offset: 0x000101E4
		public override sbyte vmethod_8()
		{
			return (sbyte)this.ulong_0;
		}

		// Token: 0x060002A7 RID: 679 RVA: 0x00011FF8 File Offset: 0x000101F8
		public override byte vmethod_9()
		{
			return (byte)this.ulong_0;
		}

		// Token: 0x060002A8 RID: 680 RVA: 0x0001200C File Offset: 0x0001020C
		public override short DAAA832C()
		{
			return (short)this.ulong_0;
		}

		// Token: 0x060002A9 RID: 681 RVA: 0x00012020 File Offset: 0x00010220
		public override ushort E1B55196()
		{
			return (ushort)this.ulong_0;
		}

		// Token: 0x060002AA RID: 682 RVA: 0x00012034 File Offset: 0x00010234
		public override int DE119705()
		{
			return (int)this.ulong_0;
		}

		// Token: 0x060002AB RID: 683 RVA: 0x00012048 File Offset: 0x00010248
		public override uint vmethod_10()
		{
			return (uint)this.ulong_0;
		}

		// Token: 0x060002AC RID: 684 RVA: 0x0001205C File Offset: 0x0001025C
		public override long E9C7AF34()
		{
			return (long)this.ulong_0;
		}

		// Token: 0x060002AD RID: 685 RVA: 0x00012070 File Offset: 0x00010270
		public override ulong vmethod_11()
		{
			return this.ulong_0;
		}

		// Token: 0x040000F1 RID: 241
		private ulong ulong_0;
	}

	// Token: 0x0200005F RID: 95
	private sealed class Class14 : GClass18.Class8
	{
		// Token: 0x060002AE RID: 686 RVA: 0x00012084 File Offset: 0x00010284
		public Class14(object object_1)
		{
			this.object_0 = object_1;
		}

		// Token: 0x060002AF RID: 687 RVA: 0x000120A0 File Offset: 0x000102A0
		public override Type vmethod_6()
		{
			return typeof(object);
		}

		// Token: 0x060002B0 RID: 688 RVA: 0x000120B8 File Offset: 0x000102B8
		public override TypeCode vmethod_7()
		{
			return TypeCode.Object;
		}

		// Token: 0x060002B1 RID: 689 RVA: 0x000120C8 File Offset: 0x000102C8
		public override GClass18.Class7 vmethod_0()
		{
			return new GClass18.Class14(this.object_0);
		}

		// Token: 0x060002B2 RID: 690 RVA: 0x000120E0 File Offset: 0x000102E0
		public override object vmethod_1()
		{
			return this.object_0;
		}

		// Token: 0x060002B3 RID: 691 RVA: 0x000120F4 File Offset: 0x000102F4
		public override void vmethod_2(object object_1)
		{
			this.object_0 = object_1;
		}

		// Token: 0x060002B4 RID: 692 RVA: 0x00012108 File Offset: 0x00010308
		public override bool A0715E7F()
		{
			return this.object_0 != null;
		}

		// Token: 0x040000F2 RID: 242
		private object object_0;
	}

	// Token: 0x02000060 RID: 96
	private sealed class Class15 : GClass18.Class8
	{
		// Token: 0x060002B5 RID: 693 RVA: 0x00012120 File Offset: 0x00010320
		public Class15(object object_1, Type type_1)
		{
			uint num = 1827292182U;
			for (;;)
			{
				base..ctor();
				num = 175004812U - num;
				if (num >> 12 != 0U)
				{
					num |= 856104873U;
					num = (953187440U | num);
					this.object_0 = object_1;
					num = 1435317759U >> (int)num;
					if (1474194163U >= num)
					{
						num &= 568348389U;
						this.type_0 = type_1;
						num = (2123178486U & num);
						this.class7_0 = GClass18.Class15.smethod_0(object_1);
						if (2043883668U >= num)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x060002B6 RID: 694 RVA: 0x000121A8 File Offset: 0x000103A8
		private static GClass18.Class7 smethod_0(object object_1)
		{
			IntPtr intPtr = (object_1 == null) ? IntPtr.Zero : new IntPtr(Pointer.Unbox(object_1));
			int size = IntPtr.Size;
			uint num = 516503185U;
			if (size == 4)
			{
				num = (556422801U & num);
				int int_ = intPtr.ToInt32();
				num = 25388512U - num;
				return new GClass18.Class9(int_);
			}
			num = (75186418U & num);
			num %= 906448072U;
			return new GClass18.Class10(intPtr.ToInt64());
		}

		// Token: 0x060002B7 RID: 695 RVA: 0x00012218 File Offset: 0x00010418
		public override Type vmethod_6()
		{
			return this.type_0;
		}

		// Token: 0x060002B8 RID: 696 RVA: 0x0001222C File Offset: 0x0001042C
		public override TypeCode vmethod_7()
		{
			int size = IntPtr.Size;
			int num = 4;
			uint num2 = 1145523927U;
			if (size != num)
			{
				return (TypeCode)(num2 ^ 1145523931U);
			}
			return (int)num2 + (TypeCode)(-1145523917);
		}

		// Token: 0x060002B9 RID: 697 RVA: 0x00012258 File Offset: 0x00010458
		public override GClass18.Class7 vmethod_0()
		{
			return new GClass18.Class15(this.object_0, this.type_0);
		}

		// Token: 0x060002BA RID: 698 RVA: 0x00012278 File Offset: 0x00010478
		public override object vmethod_1()
		{
			return this.object_0;
		}

		// Token: 0x060002BB RID: 699 RVA: 0x0001228C File Offset: 0x0001048C
		public override void vmethod_2(object object_1)
		{
			this.object_0 = object_1;
			this.class7_0 = GClass18.Class15.smethod_0(object_1);
		}

		// Token: 0x060002BC RID: 700 RVA: 0x000122AC File Offset: 0x000104AC
		public override bool A0715E7F()
		{
			return this.object_0 != null;
		}

		// Token: 0x060002BD RID: 701 RVA: 0x000122C4 File Offset: 0x000104C4
		public override sbyte vmethod_8()
		{
			return this.class7_0.vmethod_8();
		}

		// Token: 0x060002BE RID: 702 RVA: 0x000122DC File Offset: 0x000104DC
		public override short DAAA832C()
		{
			return this.class7_0.DAAA832C();
		}

		// Token: 0x060002BF RID: 703 RVA: 0x000122F4 File Offset: 0x000104F4
		public override int DE119705()
		{
			return this.class7_0.DE119705();
		}

		// Token: 0x060002C0 RID: 704 RVA: 0x0001230C File Offset: 0x0001050C
		public override long E9C7AF34()
		{
			return this.class7_0.E9C7AF34();
		}

		// Token: 0x060002C1 RID: 705 RVA: 0x00012324 File Offset: 0x00010524
		public override byte vmethod_9()
		{
			return this.class7_0.vmethod_9();
		}

		// Token: 0x060002C2 RID: 706 RVA: 0x0001233C File Offset: 0x0001053C
		public override ushort E1B55196()
		{
			return this.class7_0.E1B55196();
		}

		// Token: 0x060002C3 RID: 707 RVA: 0x00012354 File Offset: 0x00010554
		public override uint vmethod_10()
		{
			return this.class7_0.vmethod_10();
		}

		// Token: 0x060002C4 RID: 708 RVA: 0x0001236C File Offset: 0x0001056C
		public override ulong vmethod_11()
		{
			return this.class7_0.vmethod_11();
		}

		// Token: 0x060002C5 RID: 709 RVA: 0x00012384 File Offset: 0x00010584
		public override float vmethod_12()
		{
			return this.class7_0.vmethod_12();
		}

		// Token: 0x060002C6 RID: 710 RVA: 0x0001239C File Offset: 0x0001059C
		public override double BF7BF7B8()
		{
			return this.class7_0.BF7BF7B8();
		}

		// Token: 0x060002C7 RID: 711 RVA: 0x000123B4 File Offset: 0x000105B4
		public override IntPtr vmethod_13()
		{
			return this.class7_0.vmethod_13();
		}

		// Token: 0x060002C8 RID: 712 RVA: 0x000123CC File Offset: 0x000105CC
		public override UIntPtr vmethod_14()
		{
			return this.class7_0.vmethod_14();
		}

		// Token: 0x060002C9 RID: 713 RVA: 0x000123E4 File Offset: 0x000105E4
		public unsafe override void* vmethod_15()
		{
			return Pointer.Unbox(this.object_0);
		}

		// Token: 0x060002CA RID: 714 RVA: 0x000123FC File Offset: 0x000105FC
		public override object F9291D0D(Type type_1, bool bool_0)
		{
			return this.class7_0.F9291D0D(type_1, bool_0);
		}

		// Token: 0x040000F3 RID: 243
		private object object_0;

		// Token: 0x040000F4 RID: 244
		private Type type_0;

		// Token: 0x040000F5 RID: 245
		private GClass18.Class7 class7_0;
	}

	// Token: 0x02000061 RID: 97
	private sealed class Class16 : GClass18.Class8
	{
		// Token: 0x060002CB RID: 715 RVA: 0x00012418 File Offset: 0x00010618
		public Class16(object object_1)
		{
			uint num = 138937480U;
			do
			{
				num = (1913398233U | num);
				base..ctor();
				num <<= 27;
				num /= 1648371262U;
				if (object_1 != null)
				{
					num = 1545674688U / num;
					if (583537846U >= num)
					{
						continue;
					}
					bool flag = object_1 is ValueType;
					num = (755393708U & num);
					num ^= 738198690U;
					if (!flag)
					{
						num %= 551898503U;
						if (1327710902U != num)
						{
							goto Block_4;
						}
						continue;
					}
				}
				num *= 811159191U;
				this.object_0 = object_1;
			}
			while (num < 775772804U);
			return;
			Block_4:
			throw new ArgumentException();
		}

		// Token: 0x060002CC RID: 716 RVA: 0x000124AC File Offset: 0x000106AC
		public override Type vmethod_6()
		{
			return typeof(ValueType);
		}

		// Token: 0x060002CD RID: 717 RVA: 0x000124C4 File Offset: 0x000106C4
		public override GClass18.Class7 vmethod_0()
		{
			return new GClass18.Class16(this.object_0);
		}

		// Token: 0x060002CE RID: 718 RVA: 0x000124DC File Offset: 0x000106DC
		public override object vmethod_1()
		{
			return this.object_0;
		}

		// Token: 0x060002CF RID: 719 RVA: 0x000124F0 File Offset: 0x000106F0
		public override void vmethod_2(object object_1)
		{
			uint num = 303768973U;
			if (object_1 != null)
			{
				num >>= 3;
				bool flag = object_1 is ValueType;
				num ^= 274219324U;
				if (!flag)
				{
					throw new ArgumentException();
				}
			}
			num |= 1914910392U;
			this.object_0 = object_1;
		}

		// Token: 0x040000F6 RID: 246
		private object object_0;
	}

	// Token: 0x02000062 RID: 98
	private sealed class Class17 : GClass18.Class8
	{
		// Token: 0x060002D0 RID: 720 RVA: 0x00012534 File Offset: 0x00010734
		public Class17(Array array_1)
		{
			uint num = 964385326U;
			do
			{
				num ^= 548407584U;
				base..ctor();
				num /= 1852840366U;
			}
			while (num >= 2028219716U);
			do
			{
				num = 549477098U << (int)num;
				this.array_0 = array_1;
			}
			while (num << 7 == 0U);
		}

		// Token: 0x060002D1 RID: 721 RVA: 0x00012584 File Offset: 0x00010784
		public override Type vmethod_6()
		{
			return typeof(Array);
		}

		// Token: 0x060002D2 RID: 722 RVA: 0x0001259C File Offset: 0x0001079C
		public override GClass18.Class7 vmethod_0()
		{
			return new GClass18.Class17(this.array_0);
		}

		// Token: 0x060002D3 RID: 723 RVA: 0x000125B4 File Offset: 0x000107B4
		public override object vmethod_1()
		{
			return this.array_0;
		}

		// Token: 0x060002D4 RID: 724 RVA: 0x000125C8 File Offset: 0x000107C8
		public override void vmethod_2(object object_0)
		{
			this.array_0 = (Array)object_0;
		}

		// Token: 0x060002D5 RID: 725 RVA: 0x000125E4 File Offset: 0x000107E4
		public override bool A0715E7F()
		{
			return this.array_0 != null;
		}

		// Token: 0x040000F7 RID: 247
		private Array array_0;
	}

	// Token: 0x02000063 RID: 99
	private abstract class Class18 : GClass18.Class8
	{
		// Token: 0x060002D6 RID: 726 RVA: 0x000125FC File Offset: 0x000107FC
		public override bool vmethod_3()
		{
			return true;
		}

		// Token: 0x060002D7 RID: 727 RVA: 0x0001260C File Offset: 0x0001080C
		protected Class18()
		{
			uint num = 326589643U;
			do
			{
				base..ctor();
			}
			while (num < 279729742U);
		}
	}

	// Token: 0x02000064 RID: 100
	private sealed class Class19 : GClass18.Class18
	{
		// Token: 0x060002D8 RID: 728 RVA: 0x00012630 File Offset: 0x00010830
		public Class19(GClass18.Class7 class7_1)
		{
			this.class7_0 = class7_1;
		}

		// Token: 0x060002D9 RID: 729 RVA: 0x0001264C File Offset: 0x0001084C
		public override Type vmethod_6()
		{
			return this.class7_0.vmethod_6();
		}

		// Token: 0x060002DA RID: 730 RVA: 0x00012664 File Offset: 0x00010864
		public override GClass18.Class7 vmethod_0()
		{
			return new GClass18.Class19(this.class7_0);
		}

		// Token: 0x060002DB RID: 731 RVA: 0x0001267C File Offset: 0x0001087C
		public override object vmethod_1()
		{
			return this.class7_0.vmethod_1();
		}

		// Token: 0x060002DC RID: 732 RVA: 0x00012694 File Offset: 0x00010894
		public override void vmethod_2(object object_0)
		{
			uint num = 565796175U;
			do
			{
				num >>= 24;
				GClass18.Class7 @class = this.class7_0;
				num = 1470647523U / num;
				@class.vmethod_2(object_0);
			}
			while (1599033707U >> (int)num == 0U);
		}

		// Token: 0x060002DD RID: 733 RVA: 0x000126D4 File Offset: 0x000108D4
		public override bool A0715E7F()
		{
			return this.class7_0 != null;
		}

		// Token: 0x040000F8 RID: 248
		private GClass18.Class7 class7_0;
	}

	// Token: 0x02000065 RID: 101
	private sealed class Class20 : GClass18.Class18
	{
		// Token: 0x060002DE RID: 734 RVA: 0x000126EC File Offset: 0x000108EC
		public Class20(GClass18.Class7 class7_2, GClass18.Class7 class7_3)
		{
			this.class7_0 = class7_2;
			this.class7_1 = class7_3;
		}

		// Token: 0x060002DF RID: 735 RVA: 0x00012710 File Offset: 0x00010910
		public override Type vmethod_6()
		{
			return this.class7_0.vmethod_6();
		}

		// Token: 0x060002E0 RID: 736 RVA: 0x00012728 File Offset: 0x00010928
		public override GClass18.Class7 vmethod_0()
		{
			return new GClass18.Class20(this.class7_0, this.class7_1);
		}

		// Token: 0x060002E1 RID: 737 RVA: 0x00012748 File Offset: 0x00010948
		public override object vmethod_1()
		{
			return this.class7_0.vmethod_1();
		}

		// Token: 0x060002E2 RID: 738 RVA: 0x00012760 File Offset: 0x00010960
		public override void vmethod_2(object object_0)
		{
			this.class7_0.vmethod_2(object_0);
			this.class7_1.vmethod_2(this.class7_0.vmethod_1());
		}

		// Token: 0x060002E3 RID: 739 RVA: 0x00012790 File Offset: 0x00010990
		public override bool A0715E7F()
		{
			return this.class7_0 != null;
		}

		// Token: 0x040000F9 RID: 249
		private GClass18.Class7 class7_0;

		// Token: 0x040000FA RID: 250
		private GClass18.Class7 class7_1;
	}

	// Token: 0x02000066 RID: 102
	private sealed class Class21 : GClass18.Class18
	{
		// Token: 0x060002E4 RID: 740 RVA: 0x000127A8 File Offset: 0x000109A8
		public Class21(FieldInfo fieldInfo_1, object object_1)
		{
			uint num = 3584491071U;
			do
			{
				num = 615526087U >> (int)num;
				this.fieldInfo_0 = fieldInfo_1;
				num *= 1244272770U;
				num = 304759538U << (int)num;
				num = 1810902738U * num;
				this.object_0 = object_1;
			}
			while (776633745U == num);
		}

		// Token: 0x060002E5 RID: 741 RVA: 0x0001280C File Offset: 0x00010A0C
		public override Type vmethod_6()
		{
			return this.fieldInfo_0.FieldType;
		}

		// Token: 0x060002E6 RID: 742 RVA: 0x00012824 File Offset: 0x00010A24
		public override GClass18.Class7 vmethod_0()
		{
			return new GClass18.Class21(this.fieldInfo_0, this.object_0);
		}

		// Token: 0x060002E7 RID: 743 RVA: 0x00012844 File Offset: 0x00010A44
		public override object vmethod_1()
		{
			return this.fieldInfo_0.GetValue(this.object_0);
		}

		// Token: 0x060002E8 RID: 744 RVA: 0x00012864 File Offset: 0x00010A64
		public override void vmethod_2(object object_1)
		{
			uint num = 206140037U;
			do
			{
				num &= 266952663U;
				FieldInfo fieldInfo = this.fieldInfo_0;
				num = 527855676U - num;
				object obj = this.object_0;
				num = (1362786868U | num);
				num = 881425309U >> (int)num;
				fieldInfo.SetValue(obj, object_1);
			}
			while (78993092U < num);
		}

		// Token: 0x040000FB RID: 251
		private FieldInfo fieldInfo_0;

		// Token: 0x040000FC RID: 252
		private object object_0;
	}

	// Token: 0x02000067 RID: 103
	private sealed class Class22 : GClass18.Class18
	{
		// Token: 0x060002E9 RID: 745 RVA: 0x000128B8 File Offset: 0x00010AB8
		public Class22(Array array_1, int int_1)
		{
			uint num = 1591298456U;
			do
			{
				base..ctor();
				num &= 2110792824U;
				this.array_0 = array_1;
			}
			while (485572627U * num == 0U);
			this.int_0 = int_1;
		}

		// Token: 0x060002EA RID: 746 RVA: 0x000128F0 File Offset: 0x00010AF0
		public override Type vmethod_6()
		{
			return this.array_0.GetType().GetElementType();
		}

		// Token: 0x060002EB RID: 747 RVA: 0x00012910 File Offset: 0x00010B10
		public override GClass18.Class7 vmethod_0()
		{
			return new GClass18.Class22(this.array_0, this.int_0);
		}

		// Token: 0x060002EC RID: 748 RVA: 0x00012930 File Offset: 0x00010B30
		public override object vmethod_1()
		{
			return this.array_0.GetValue(this.int_0);
		}

		// Token: 0x060002ED RID: 749 RVA: 0x00012950 File Offset: 0x00010B50
		public override void vmethod_2(object object_0)
		{
			this.array_0.SetValue(object_0, this.int_0);
		}

		// Token: 0x060002EE RID: 750 RVA: 0x00012970 File Offset: 0x00010B70
		public override UIntPtr vmethod_14()
		{
			DynamicMethod dynamicMethod = new DynamicMethod("", typeof(UIntPtr), new Type[]
			{
				this.array_0.GetType(),
				typeof(int)
			}, typeof(GClass18).Module, true);
			ILGenerator ilgenerator = dynamicMethod.GetILGenerator();
			ilgenerator.Emit(OpCodes.Ldarg, 0);
			ilgenerator.Emit(OpCodes.Ldarg, 1);
			ilgenerator.Emit(OpCodes.Ldelema, this.array_0.GetType().GetElementType());
			ilgenerator.Emit(OpCodes.Conv_U);
			ilgenerator.Emit(OpCodes.Ret);
			return (UIntPtr)dynamicMethod.Invoke(null, new object[]
			{
				this.array_0,
				this.int_0
			});
		}

		// Token: 0x040000FD RID: 253
		private Array array_0;

		// Token: 0x040000FE RID: 254
		private int int_0;
	}

	// Token: 0x02000068 RID: 104
	private sealed class Class24 : GClass18.Class8
	{
		// Token: 0x060002EF RID: 751 RVA: 0x00012A38 File Offset: 0x00010C38
		public Class24(MethodBase methodBase_1)
		{
			this.methodBase_0 = methodBase_1;
		}

		// Token: 0x060002F0 RID: 752 RVA: 0x00012A54 File Offset: 0x00010C54
		public override Type vmethod_6()
		{
			return typeof(MethodBase);
		}

		// Token: 0x060002F1 RID: 753 RVA: 0x00012A6C File Offset: 0x00010C6C
		public override GClass18.Class7 vmethod_0()
		{
			return new GClass18.Class24(this.methodBase_0);
		}

		// Token: 0x060002F2 RID: 754 RVA: 0x00012A84 File Offset: 0x00010C84
		public override object vmethod_1()
		{
			return this.methodBase_0;
		}

		// Token: 0x060002F3 RID: 755 RVA: 0x00012A98 File Offset: 0x00010C98
		public override void vmethod_2(object object_0)
		{
			this.methodBase_0 = (MethodBase)object_0;
		}

		// Token: 0x060002F4 RID: 756 RVA: 0x00012AB4 File Offset: 0x00010CB4
		public override bool A0715E7F()
		{
			return this.methodBase_0 != null;
		}

		// Token: 0x060002F5 RID: 757 RVA: 0x00012ACC File Offset: 0x00010CCC
		public override IntPtr vmethod_13()
		{
			return this.methodBase_0.MethodHandle.GetFunctionPointer();
		}

		// Token: 0x040000FF RID: 255
		private MethodBase methodBase_0;
	}

	// Token: 0x02000069 RID: 105
	private sealed class Class25 : GClass18.Class8
	{
		// Token: 0x060002F6 RID: 758 RVA: 0x00012AEC File Offset: 0x00010CEC
		public Class25(IntPtr intptr_1)
		{
			uint num = 768349541U;
			base..ctor();
			do
			{
				num = (1338337728U & num);
				this.intptr_0 = intptr_1;
				num = (1061568375U & num);
				num &= 690764246U;
				num = 1970344487U + num;
				IntPtr intptr_2 = this.intptr_0;
				num &= 384962458U;
				GClass18.Class7 @class = GClass18.Class25.smethod_0(intptr_2);
				num >>= 19;
				this.class7_0 = @class;
			}
			while (num + 1370978585U == 0U);
		}

		// Token: 0x060002F7 RID: 759 RVA: 0x00012B58 File Offset: 0x00010D58
		private static GClass18.Class7 smethod_0(IntPtr intptr_1)
		{
			uint num2;
			do
			{
				int size = IntPtr.Size;
				int num = 4;
				num2 = 1584351107U;
				if (size != num)
				{
					goto IL_21;
				}
				num2 = (283409721U ^ num2);
			}
			while ((86650907U ^ num2) == 0U);
			goto IL_3F;
			IL_21:
			if (num2 / 727722953U != 0U)
			{
				num2 >>= 26;
				return new GClass18.Class10(intptr_1.ToInt64());
			}
			IL_3F:
			num2 *= 763774063U;
			return new GClass18.Class9(intptr_1.ToInt32());
		}

		// Token: 0x060002F8 RID: 760 RVA: 0x00012BB8 File Offset: 0x00010DB8
		public override Type vmethod_6()
		{
			return typeof(IntPtr);
		}

		// Token: 0x060002F9 RID: 761 RVA: 0x00012BD0 File Offset: 0x00010DD0
		public override TypeCode vmethod_7()
		{
			return this.class7_0.vmethod_7();
		}

		// Token: 0x060002FA RID: 762 RVA: 0x00012BE8 File Offset: 0x00010DE8
		public override GClass18.Class7 vmethod_0()
		{
			return new GClass18.Class25(this.intptr_0);
		}

		// Token: 0x060002FB RID: 763 RVA: 0x00012C00 File Offset: 0x00010E00
		public override object vmethod_1()
		{
			return this.intptr_0;
		}

		// Token: 0x060002FC RID: 764 RVA: 0x00012C18 File Offset: 0x00010E18
		public override void vmethod_2(object object_0)
		{
			uint num = 2139627176U;
			do
			{
				IntPtr intPtr = (IntPtr)object_0;
				num >>= 16;
				this.intptr_0 = intPtr;
				num = 443053514U << (int)num;
				if ((54338190U ^ num) == 0U)
				{
					break;
				}
				this.class7_0 = GClass18.Class25.smethod_0(this.intptr_0);
			}
			while ((463941420U ^ num) == 0U);
		}

		// Token: 0x060002FD RID: 765 RVA: 0x00012C74 File Offset: 0x00010E74
		public override bool A0715E7F()
		{
			return this.intptr_0 != IntPtr.Zero;
		}

		// Token: 0x060002FE RID: 766 RVA: 0x00012C94 File Offset: 0x00010E94
		public override sbyte vmethod_8()
		{
			return this.class7_0.vmethod_8();
		}

		// Token: 0x060002FF RID: 767 RVA: 0x00012CAC File Offset: 0x00010EAC
		public override short DAAA832C()
		{
			return this.class7_0.DAAA832C();
		}

		// Token: 0x06000300 RID: 768 RVA: 0x00012CC4 File Offset: 0x00010EC4
		public override int DE119705()
		{
			return this.class7_0.DE119705();
		}

		// Token: 0x06000301 RID: 769 RVA: 0x00012CDC File Offset: 0x00010EDC
		public override long E9C7AF34()
		{
			return this.class7_0.E9C7AF34();
		}

		// Token: 0x06000302 RID: 770 RVA: 0x00012CF4 File Offset: 0x00010EF4
		public override byte vmethod_9()
		{
			return this.class7_0.vmethod_9();
		}

		// Token: 0x06000303 RID: 771 RVA: 0x00012D0C File Offset: 0x00010F0C
		public override ushort E1B55196()
		{
			return this.class7_0.E1B55196();
		}

		// Token: 0x06000304 RID: 772 RVA: 0x00012D24 File Offset: 0x00010F24
		public override uint vmethod_10()
		{
			return this.class7_0.vmethod_10();
		}

		// Token: 0x06000305 RID: 773 RVA: 0x00012D3C File Offset: 0x00010F3C
		public override ulong vmethod_11()
		{
			return this.class7_0.vmethod_11();
		}

		// Token: 0x06000306 RID: 774 RVA: 0x00012D54 File Offset: 0x00010F54
		public override float vmethod_12()
		{
			return this.class7_0.vmethod_12();
		}

		// Token: 0x06000307 RID: 775 RVA: 0x00012D6C File Offset: 0x00010F6C
		public override double BF7BF7B8()
		{
			return this.class7_0.BF7BF7B8();
		}

		// Token: 0x06000308 RID: 776 RVA: 0x00012D84 File Offset: 0x00010F84
		public override IntPtr vmethod_13()
		{
			return this.intptr_0;
		}

		// Token: 0x06000309 RID: 777 RVA: 0x00012D98 File Offset: 0x00010F98
		public override UIntPtr vmethod_14()
		{
			return this.class7_0.vmethod_14();
		}

		// Token: 0x0600030A RID: 778 RVA: 0x00012DB0 File Offset: 0x00010FB0
		public unsafe override void* vmethod_15()
		{
			return this.intptr_0.ToPointer();
		}

		// Token: 0x0600030B RID: 779 RVA: 0x00012DC8 File Offset: 0x00010FC8
		public override object F9291D0D(Type type_0, bool bool_0)
		{
			return this.class7_0.F9291D0D(type_0, bool_0);
		}

		// Token: 0x04000100 RID: 256
		private IntPtr intptr_0;

		// Token: 0x04000101 RID: 257
		private GClass18.Class7 class7_0;
	}

	// Token: 0x0200006A RID: 106
	private sealed class Class26 : GClass18.Class8
	{
		// Token: 0x0600030C RID: 780 RVA: 0x00012DE4 File Offset: 0x00010FE4
		public Class26(UIntPtr uintptr_1)
		{
			this.uintptr_0 = uintptr_1;
			this.class7_0 = GClass18.Class26.smethod_0(this.uintptr_0);
		}

		// Token: 0x0600030D RID: 781 RVA: 0x00012E10 File Offset: 0x00011010
		private static GClass18.Class7 smethod_0(UIntPtr uintptr_1)
		{
			int size = IntPtr.Size;
			int num = 4;
			uint num2 = 3087007744U;
			if (size == num)
			{
				num2 += 838082885U;
				if (num2 >= 889876833U)
				{
					num2 /= 814489740U;
					return new GClass18.Class9((int)uintptr_1.ToUInt32());
				}
			}
			long long_ = (long)uintptr_1.ToUInt64();
			num2 = 2082674724U % num2;
			return new GClass18.Class10(long_);
		}

		// Token: 0x0600030E RID: 782 RVA: 0x00012E6C File Offset: 0x0001106C
		public override Type vmethod_6()
		{
			return typeof(UIntPtr);
		}

		// Token: 0x0600030F RID: 783 RVA: 0x00012E84 File Offset: 0x00011084
		public override TypeCode vmethod_7()
		{
			return this.class7_0.vmethod_7();
		}

		// Token: 0x06000310 RID: 784 RVA: 0x00012E9C File Offset: 0x0001109C
		public override GClass18.Class7 vmethod_0()
		{
			return new GClass18.Class26(this.uintptr_0);
		}

		// Token: 0x06000311 RID: 785 RVA: 0x00012EB4 File Offset: 0x000110B4
		public override object vmethod_1()
		{
			return this.uintptr_0;
		}

		// Token: 0x06000312 RID: 786 RVA: 0x00012ECC File Offset: 0x000110CC
		public override void vmethod_2(object object_0)
		{
			this.uintptr_0 = (UIntPtr)object_0;
			this.class7_0 = GClass18.Class26.smethod_0(this.uintptr_0);
		}

		// Token: 0x06000313 RID: 787 RVA: 0x00012EF8 File Offset: 0x000110F8
		public override bool A0715E7F()
		{
			return this.uintptr_0 != UIntPtr.Zero;
		}

		// Token: 0x06000314 RID: 788 RVA: 0x00012F18 File Offset: 0x00011118
		public override sbyte vmethod_8()
		{
			return this.class7_0.vmethod_8();
		}

		// Token: 0x06000315 RID: 789 RVA: 0x00012F30 File Offset: 0x00011130
		public override short DAAA832C()
		{
			return this.class7_0.DAAA832C();
		}

		// Token: 0x06000316 RID: 790 RVA: 0x00012F48 File Offset: 0x00011148
		public override int DE119705()
		{
			return this.class7_0.DE119705();
		}

		// Token: 0x06000317 RID: 791 RVA: 0x00012F60 File Offset: 0x00011160
		public override long E9C7AF34()
		{
			return this.class7_0.E9C7AF34();
		}

		// Token: 0x06000318 RID: 792 RVA: 0x00012F78 File Offset: 0x00011178
		public override byte vmethod_9()
		{
			return this.class7_0.vmethod_9();
		}

		// Token: 0x06000319 RID: 793 RVA: 0x00012F90 File Offset: 0x00011190
		public override ushort E1B55196()
		{
			return this.class7_0.E1B55196();
		}

		// Token: 0x0600031A RID: 794 RVA: 0x00012FA8 File Offset: 0x000111A8
		public override uint vmethod_10()
		{
			return this.class7_0.vmethod_10();
		}

		// Token: 0x0600031B RID: 795 RVA: 0x00012FC0 File Offset: 0x000111C0
		public override ulong vmethod_11()
		{
			return this.class7_0.vmethod_11();
		}

		// Token: 0x0600031C RID: 796 RVA: 0x00012FD8 File Offset: 0x000111D8
		public override float vmethod_12()
		{
			return this.class7_0.vmethod_12();
		}

		// Token: 0x0600031D RID: 797 RVA: 0x00012FF0 File Offset: 0x000111F0
		public override double BF7BF7B8()
		{
			return this.class7_0.BF7BF7B8();
		}

		// Token: 0x0600031E RID: 798 RVA: 0x00013008 File Offset: 0x00011208
		public override IntPtr vmethod_13()
		{
			return this.class7_0.vmethod_13();
		}

		// Token: 0x0600031F RID: 799 RVA: 0x00013020 File Offset: 0x00011220
		public override UIntPtr vmethod_14()
		{
			return this.uintptr_0;
		}

		// Token: 0x06000320 RID: 800 RVA: 0x00013034 File Offset: 0x00011234
		public unsafe override void* vmethod_15()
		{
			return this.uintptr_0.ToPointer();
		}

		// Token: 0x06000321 RID: 801 RVA: 0x0001304C File Offset: 0x0001124C
		public override object F9291D0D(Type type_0, bool bool_0)
		{
			return this.class7_0.F9291D0D(type_0, bool_0);
		}

		// Token: 0x04000102 RID: 258
		private UIntPtr uintptr_0;

		// Token: 0x04000103 RID: 259
		private GClass18.Class7 class7_0;
	}

	// Token: 0x0200006B RID: 107
	private sealed class Class27 : GClass18.Class8
	{
		// Token: 0x06000322 RID: 802 RVA: 0x00013068 File Offset: 0x00011268
		public Class27(Enum enum_1)
		{
			uint num;
			do
			{
				base..ctor();
				num = 1914192369U;
				if (enum_1 == null)
				{
					goto IL_6E;
				}
				num *= 1779320887U;
				this.enum_0 = enum_1;
				num &= 2089041049U;
				if (num >= 1510830452U)
				{
					goto IL_76;
				}
				num = 1188774372U >> (int)num;
				Enum enum_2 = this.enum_0;
				num = 1988587933U >> (int)num;
				GClass18.Class7 @class = GClass18.Class27.smethod_0(enum_2);
				num += 1011949089U;
				this.class7_0 = @class;
			}
			while ((1056395209U ^ num) == 0U);
			return;
			IL_6E:
			num |= 416818565U;
			IL_76:
			throw new ArgumentException();
		}

		// Token: 0x06000323 RID: 803 RVA: 0x000130F4 File Offset: 0x000112F4
		private static GClass18.Class7 smethod_0(Enum enum_1)
		{
			uint num = 2134116521U;
			for (;;)
			{
				IL_69:
				TypeCode typeCode = enum_1.GetTypeCode();
				num = 546593184U >> (int)num;
				for (;;)
				{
					switch (typeCode - (TypeCode)(num ^ 1067561U))
					{
					case 0:
					case 2:
					case 4:
						goto IL_58;
					case 1:
					case 3:
					case 5:
						goto IL_92;
					case 6:
						goto IL_BF;
					case 7:
						goto IL_D3;
					default:
						if (552735480U + num == 0U)
						{
							goto IL_69;
						}
						num = 1416572390U - num;
						if (88178299 << (int)num != 0)
						{
							goto IL_80;
						}
						break;
					}
				}
				IL_58:
				num &= 1960129016U;
				if (num + 1666779723U != 0U)
				{
					goto IL_86;
				}
			}
			IL_80:
			throw new InvalidOperationException();
			IL_86:
			return new GClass18.Class9(Convert.ToInt32(enum_1));
			IL_92:
			num |= 1623023309U;
			if (num % 956251732U != 0U)
			{
				num = (510660190U | num);
				int int_ = (int)Convert.ToUInt32(enum_1);
				num |= 1943145277U;
				return new GClass18.Class9(int_);
			}
			IL_BF:
			num /= 661915647U;
			return new GClass18.Class10(Convert.ToInt64(enum_1));
			IL_D3:
			num *= 95895598U;
			return new GClass18.Class10((long)Convert.ToUInt64(enum_1));
		}

		// Token: 0x06000324 RID: 804 RVA: 0x000131E8 File Offset: 0x000113E8
		public override GClass18.Class7 vmethod_5()
		{
			return this.class7_0.vmethod_5();
		}

		// Token: 0x06000325 RID: 805 RVA: 0x00013200 File Offset: 0x00011400
		public override Type vmethod_6()
		{
			return this.enum_0.GetType();
		}

		// Token: 0x06000326 RID: 806 RVA: 0x00013218 File Offset: 0x00011418
		public override TypeCode vmethod_7()
		{
			return this.class7_0.vmethod_7();
		}

		// Token: 0x06000327 RID: 807 RVA: 0x00013230 File Offset: 0x00011430
		public override GClass18.Class7 vmethod_0()
		{
			return new GClass18.Class27(this.enum_0);
		}

		// Token: 0x06000328 RID: 808 RVA: 0x00013248 File Offset: 0x00011448
		public override object vmethod_1()
		{
			return this.enum_0;
		}

		// Token: 0x06000329 RID: 809 RVA: 0x0001325C File Offset: 0x0001145C
		public override void vmethod_2(object object_0)
		{
			uint num = 1454908351U;
			if (object_0 == null)
			{
				throw new ArgumentException();
			}
			num = 615721724U + num;
			num = (586178426U & num);
			num = 1740401661U >> (int)num;
			Enum @enum = (Enum)object_0;
			num &= 1994860952U;
			this.enum_0 = @enum;
			num ^= 1674777251U;
			num |= 33042743U;
			this.class7_0 = GClass18.Class27.smethod_0(this.enum_0);
		}

		// Token: 0x0600032A RID: 810 RVA: 0x000132CC File Offset: 0x000114CC
		public override byte vmethod_9()
		{
			return this.class7_0.vmethod_9();
		}

		// Token: 0x0600032B RID: 811 RVA: 0x000132E4 File Offset: 0x000114E4
		public override sbyte vmethod_8()
		{
			return this.class7_0.vmethod_8();
		}

		// Token: 0x0600032C RID: 812 RVA: 0x000132FC File Offset: 0x000114FC
		public override short DAAA832C()
		{
			return this.class7_0.DAAA832C();
		}

		// Token: 0x0600032D RID: 813 RVA: 0x00013314 File Offset: 0x00011514
		public override ushort E1B55196()
		{
			return this.class7_0.E1B55196();
		}

		// Token: 0x0600032E RID: 814 RVA: 0x0001332C File Offset: 0x0001152C
		public override int DE119705()
		{
			return this.class7_0.DE119705();
		}

		// Token: 0x0600032F RID: 815 RVA: 0x00013344 File Offset: 0x00011544
		public override uint vmethod_10()
		{
			return this.class7_0.vmethod_10();
		}

		// Token: 0x06000330 RID: 816 RVA: 0x0001335C File Offset: 0x0001155C
		public override long E9C7AF34()
		{
			return this.class7_0.E9C7AF34();
		}

		// Token: 0x06000331 RID: 817 RVA: 0x00013374 File Offset: 0x00011574
		public override ulong vmethod_11()
		{
			return this.class7_0.vmethod_11();
		}

		// Token: 0x06000332 RID: 818 RVA: 0x0001338C File Offset: 0x0001158C
		public override float vmethod_12()
		{
			return this.class7_0.vmethod_12();
		}

		// Token: 0x06000333 RID: 819 RVA: 0x000133A4 File Offset: 0x000115A4
		public override double BF7BF7B8()
		{
			return this.class7_0.BF7BF7B8();
		}

		// Token: 0x06000334 RID: 820 RVA: 0x000133BC File Offset: 0x000115BC
		public override IntPtr vmethod_13()
		{
			uint num = 2039153825U;
			for (;;)
			{
				int size = IntPtr.Size;
				uint num2 = num ^ 2039153829U;
				num |= 1454406197U;
				if (size == num2)
				{
					break;
				}
				if ((1515854544U ^ num) != 0U)
				{
					goto IL_5A;
				}
			}
			num &= 1232816079U;
			long value;
			if (num < 1256413431U)
			{
				num = 1974415166U - num;
				long num3 = (long)this.DE119705();
				num = 108878848U - num;
				value = num3;
				num ^= 2779909618U;
				goto IL_60;
			}
			IL_5A:
			value = this.E9C7AF34();
			IL_60:
			return new IntPtr(value);
		}

		// Token: 0x06000335 RID: 821 RVA: 0x00013430 File Offset: 0x00011630
		public override UIntPtr vmethod_14()
		{
			int size = IntPtr.Size;
			uint num = 3572001074U;
			ulong value;
			if (size != 4)
			{
				num = (529806219U ^ num);
				value = this.vmethod_11();
			}
			else
			{
				ulong num2 = (ulong)this.vmethod_10();
				num /= 119298449U;
				value = num2;
				num ^= 3413924516U;
			}
			return new UIntPtr(value);
		}

		// Token: 0x06000336 RID: 822 RVA: 0x00013480 File Offset: 0x00011680
		public override object F9291D0D(Type type_0, bool bool_0)
		{
			return this.class7_0.F9291D0D(type_0, bool_0);
		}

		// Token: 0x04000104 RID: 260
		private Enum enum_0;

		// Token: 0x04000105 RID: 261
		private GClass18.Class7 class7_0;
	}

	// Token: 0x0200006C RID: 108
	private sealed class Class23 : GClass18.Class18
	{
		// Token: 0x06000337 RID: 823 RVA: 0x0001349C File Offset: 0x0001169C
		public Class23(IntPtr intptr_1, Type type_1)
		{
			this.intptr_0 = intptr_1;
			this.type_0 = type_1;
		}

		// Token: 0x06000338 RID: 824 RVA: 0x000134C0 File Offset: 0x000116C0
		public override Type vmethod_6()
		{
			return typeof(Pointer);
		}

		// Token: 0x06000339 RID: 825 RVA: 0x000134D8 File Offset: 0x000116D8
		public override TypeCode vmethod_7()
		{
			return TypeCode.Empty;
		}

		// Token: 0x0600033A RID: 826 RVA: 0x000134E8 File Offset: 0x000116E8
		public override GClass18.Class7 vmethod_0()
		{
			return new GClass18.Class23(this.intptr_0, this.type_0);
		}

		// Token: 0x0600033B RID: 827 RVA: 0x00013508 File Offset: 0x00011708
		public override object vmethod_1()
		{
			Type type = this.type_0;
			uint num = 1253274285U;
			if (type.IsValueType)
			{
				num &= 1152217684U;
			}
			else if ((148714511U ^ num) != 0U)
			{
				throw new InvalidOperationException();
			}
			num >>= 30;
			IntPtr ptr = this.intptr_0;
			num %= 1223165142U;
			Type structureType = this.type_0;
			num = 755635433U % num;
			return Marshal.PtrToStructure(ptr, structureType);
		}

		// Token: 0x0600033C RID: 828 RVA: 0x0001356C File Offset: 0x0001176C
		public override void vmethod_2(object object_0)
		{
			uint num;
			for (;;)
			{
				IL_00:
				num = 577320853U;
				if (object_0 == null)
				{
					break;
				}
				while (!this.type_0.IsValueType)
				{
					num /= 1347712783U;
					if (num != 319824784U)
					{
						Type type = object_0.GetType();
						num = (1287609422U & num);
						TypeCode typeCode = Type.GetTypeCode(type);
						num = 567767355U << (int)num;
						if (num * 1087584132U == 0U)
						{
							goto IL_3C6;
						}
						switch (typeCode - (TypeCode)(num - 567767351U))
						{
						case 0:
							goto IL_1C5;
						case 1:
							goto IL_1FF;
						case 2:
							if (num < 1696935865U)
							{
								goto Block_8;
							}
							break;
						case 3:
							num <<= 10;
							if (1000604243U > num)
							{
								goto IL_00;
							}
							num -= 1258254820U;
							Marshal.WriteInt16(this.intptr_0, Convert.ToInt16(object_0));
							if (num < 1913991817U)
							{
								return;
							}
							goto IL_00;
						case 4:
						{
							num = 538981309U % num;
							num = (1725441573U | num);
							IntPtr ptr = this.intptr_0;
							num ^= 970348575U;
							num = (1123634831U & num);
							short val = (short)Convert.ToUInt16(object_0);
							num %= 1446396095U;
							Marshal.WriteInt16(ptr, val);
							if ((num ^ 1197427816U) == 0U)
							{
								continue;
							}
							return;
						}
						case 5:
							goto IL_256;
						case 6:
							goto IL_288;
						case 7:
							goto IL_2BE;
						case 8:
							if ((num ^ 1878096092U) != 0U)
							{
								goto Block_11;
							}
							goto IL_00;
						case 9:
							goto IL_312;
						case 10:
							goto IL_36B;
						default:
							if (num - 673273937U == 0U)
							{
								goto IL_00;
							}
							num = 463884445U + num;
							if (num >= 339482357U)
							{
								goto Block_7;
							}
							goto IL_00;
						}
					}
					IL_170:
					num = (2021490656U & num);
					IntPtr ptr2 = this.intptr_0;
					num = 1602649804U % num;
					bool fDeleteOld = (num ^ 515117004U) != 0U;
					num = 511196812U >> (int)num;
					Marshal.StructureToPtr(object_0, ptr2, fDeleteOld);
					if ((654712656U ^ num) != 0U)
					{
						goto Block_12;
					}
					goto IL_00;
				}
				if ((num ^ 2091205224U) != 0U)
				{
					goto IL_170;
				}
			}
			num /= 289882525U;
			goto IL_3C6;
			Block_7:
			throw new ArgumentException();
			Block_8:
			IntPtr ptr3 = this.intptr_0;
			num |= 1360409649U;
			Marshal.WriteByte(ptr3, Convert.ToByte(object_0));
			return;
			Block_11:
			IntPtr ptr4 = this.intptr_0;
			long val2 = (long)Convert.ToUInt64(object_0);
			num /= 1769889124U;
			Marshal.WriteInt64(ptr4, val2);
			return;
			Block_12:
			return;
			IL_1C5:
			num = 1334408968U - num;
			num = 19618026U % num;
			IntPtr ptr5 = this.intptr_0;
			num = (1179540605U | num);
			num -= 859208053U;
			char val3 = Convert.ToChar(object_0);
			num = 138048334U / num;
			Marshal.WriteInt16(ptr5, val3);
			return;
			IL_1FF:
			num |= 1260342786U;
			IntPtr ptr6 = this.intptr_0;
			num &= 2115372801U;
			num -= 973369768U;
			byte b = (byte)Convert.ToSByte(object_0);
			num = 1738695814U * num;
			byte val4 = b;
			num = 1060578625U % num;
			Marshal.WriteByte(ptr6, val4);
			return;
			IL_256:
			num = 59321159U * num;
			num |= 537160183U;
			IntPtr ptr7 = this.intptr_0;
			num |= 1691822007U;
			num = (795233492U | num);
			Marshal.WriteInt32(ptr7, Convert.ToInt32(object_0));
			return;
			IL_288:
			if (146176096U + num != 0U)
			{
				IntPtr ptr8 = this.intptr_0;
				num -= 49296565U;
				num %= 1623982761U;
				int val5 = (int)Convert.ToUInt32(object_0);
				num /= 214310309U;
				Marshal.WriteInt32(ptr8, val5);
				return;
			}
			return;
			IL_2BE:
			num |= 789530010U;
			num = 345341146U - num;
			IntPtr ptr9 = this.intptr_0;
			num /= 308547906U;
			num /= 661990505U;
			long val6 = Convert.ToInt64(object_0);
			num ^= 539107261U;
			Marshal.WriteInt64(ptr9, val6);
			return;
			IL_312:
			num *= 277693443U;
			num = 1268529163U << (int)num;
			IntPtr ptr10 = this.intptr_0;
			num = 744632406U % num;
			num = (1629766798U | num);
			byte[] bytes = BitConverter.GetBytes(Convert.ToSingle(object_0));
			num = 392644026U - num;
			int val7 = BitConverter.ToInt32(bytes, (int)(num ^ 2852180188U));
			num = 1066952514U % num;
			Marshal.WriteInt32(ptr10, val7);
			return;
			IL_36B:
			num ^= 1138571083U;
			num >>= 28;
			IntPtr ptr11 = this.intptr_0;
			num = (981938971U ^ num);
			double value = Convert.ToDouble(object_0);
			num |= 684199694U;
			byte[] bytes2 = BitConverter.GetBytes(value);
			num /= 111700760U;
			int startIndex = (int)(num ^ 8U);
			num = 1864966837U * num;
			long val8 = BitConverter.ToInt64(bytes2, startIndex);
			num |= 773803749U;
			Marshal.WriteInt64(ptr11, val8);
			return;
			IL_3C6:
			throw new ArgumentException();
		}

		// Token: 0x0600033D RID: 829 RVA: 0x00013948 File Offset: 0x00011B48
		public override sbyte vmethod_8()
		{
			return (sbyte)Marshal.ReadByte(this.intptr_0);
		}

		// Token: 0x0600033E RID: 830 RVA: 0x00013964 File Offset: 0x00011B64
		public override short DAAA832C()
		{
			return Marshal.ReadInt16(this.intptr_0);
		}

		// Token: 0x0600033F RID: 831 RVA: 0x0001397C File Offset: 0x00011B7C
		public override int DE119705()
		{
			return Marshal.ReadInt32(this.intptr_0);
		}

		// Token: 0x06000340 RID: 832 RVA: 0x00013994 File Offset: 0x00011B94
		public override long E9C7AF34()
		{
			return Marshal.ReadInt64(this.intptr_0);
		}

		// Token: 0x06000341 RID: 833 RVA: 0x000139AC File Offset: 0x00011BAC
		public override char C075F08B()
		{
			return (char)Marshal.ReadInt16(this.intptr_0);
		}

		// Token: 0x06000342 RID: 834 RVA: 0x000139C8 File Offset: 0x00011BC8
		public override byte vmethod_9()
		{
			return Marshal.ReadByte(this.intptr_0);
		}

		// Token: 0x06000343 RID: 835 RVA: 0x000139E0 File Offset: 0x00011BE0
		public override ushort E1B55196()
		{
			return (ushort)Marshal.ReadInt16(this.intptr_0);
		}

		// Token: 0x06000344 RID: 836 RVA: 0x000139FC File Offset: 0x00011BFC
		public override uint vmethod_10()
		{
			return (uint)Marshal.ReadInt32(this.intptr_0);
		}

		// Token: 0x06000345 RID: 837 RVA: 0x00013A14 File Offset: 0x00011C14
		public override ulong vmethod_11()
		{
			return (ulong)Marshal.ReadInt64(this.intptr_0);
		}

		// Token: 0x06000346 RID: 838 RVA: 0x00013A2C File Offset: 0x00011C2C
		public override float vmethod_12()
		{
			return BitConverter.ToSingle(BitConverter.GetBytes(Marshal.ReadInt32(this.intptr_0)), 0);
		}

		// Token: 0x06000347 RID: 839 RVA: 0x00013A50 File Offset: 0x00011C50
		public override double BF7BF7B8()
		{
			return BitConverter.ToDouble(BitConverter.GetBytes(Marshal.ReadInt64(this.intptr_0)), 0);
		}

		// Token: 0x06000348 RID: 840 RVA: 0x00013A74 File Offset: 0x00011C74
		public override IntPtr vmethod_13()
		{
			uint num2;
			do
			{
				int size = IntPtr.Size;
				int num = 4;
				num2 = 3485341045U;
				if (size != num)
				{
					num2 -= 1261516461U;
					if (num2 > 1551778620U)
					{
						goto Block_2;
					}
				}
			}
			while (1176388598U + num2 == 0U);
			num2 |= 1395065235U;
			long num3 = (long)Marshal.ReadInt32(this.intptr_0);
			num2 = (1742668552U ^ num2);
			long value = num3;
			num2 += 1208154670U;
			goto IL_70;
			Block_2:
			num2 = 1662070026U >> (int)num2;
			value = Marshal.ReadInt64(this.intptr_0);
			IL_70:
			num2 -= 1761161333U;
			return new IntPtr(value);
		}

		// Token: 0x06000349 RID: 841 RVA: 0x00013B00 File Offset: 0x00011D00
		public override UIntPtr vmethod_14()
		{
			return new UIntPtr((IntPtr.Size == 4) ? ((ulong)Marshal.ReadInt32(this.intptr_0)) : ((ulong)Marshal.ReadInt64(this.intptr_0)));
		}

		// Token: 0x04000106 RID: 262
		private IntPtr intptr_0;

		// Token: 0x04000107 RID: 263
		private Type type_0;
	}

	// Token: 0x0200006D RID: 109
	private sealed class Class36
	{
		// Token: 0x0600034A RID: 842 RVA: 0x00013B34 File Offset: 0x00011D34
		public Class36(byte byte_1, int int_2, int int_3)
		{
			this.byte_0 = byte_1;
			this.int_0 = int_2;
			this.int_1 = int_3;
		}

		// Token: 0x0600034B RID: 843 RVA: 0x00013B5C File Offset: 0x00011D5C
		public byte method_0()
		{
			return this.byte_0;
		}

		// Token: 0x0600034C RID: 844 RVA: 0x00013B70 File Offset: 0x00011D70
		public int method_1()
		{
			return this.int_0;
		}

		// Token: 0x0600034D RID: 845 RVA: 0x00013B84 File Offset: 0x00011D84
		public int method_2()
		{
			return this.int_1;
		}

		// Token: 0x04000108 RID: 264
		private byte byte_0;

		// Token: 0x04000109 RID: 265
		private int int_0;

		// Token: 0x0400010A RID: 266
		private int int_1;
	}

	// Token: 0x0200006E RID: 110
	private sealed class Class37
	{
		// Token: 0x0600034E RID: 846 RVA: 0x00013B98 File Offset: 0x00011D98
		public Class37(int int_2, int int_3)
		{
			uint num;
			do
			{
				this.list_0 = new List<GClass18.Class36>();
				num = 8028617U;
				base..ctor();
				do
				{
					num /= 833030916U;
					num |= 896277087U;
					this.int_0 = int_2;
					num = 23483935U % num;
				}
				while (494893318U < num);
				num ^= 1962414174U;
				this.int_1 = int_3;
			}
			while (755256642U % num == 0U);
		}

		// Token: 0x0600034F RID: 847 RVA: 0x00013C10 File Offset: 0x00011E10
		public int method_0()
		{
			return this.int_0;
		}

		// Token: 0x06000350 RID: 848 RVA: 0x00013C24 File Offset: 0x00011E24
		public int method_1()
		{
			return this.int_1;
		}

		// Token: 0x06000351 RID: 849 RVA: 0x00013C38 File Offset: 0x00011E38
		public int method_2(GClass18.Class37 class37_0)
		{
			uint num = 409273471U;
			IL_A5:
			while (class37_0 != null)
			{
				int num2;
				for (;;)
				{
					num -= 755914988U;
					num2 = this.int_0.CompareTo(class37_0.method_0());
					if (1043204374U > num)
					{
						goto IL_A5;
					}
					for (;;)
					{
						bool flag = num2 != 0;
						num <<= 6;
						if (!flag)
						{
							num = 1676699407U * num;
							if (num << 6 == 0U)
							{
								break;
							}
							int num3 = class37_0.method_1();
							if (num <= 139358752U)
							{
								goto IL_A8;
							}
							num += 1700354265U;
							num = 362875956U + num;
							int value = this.int_1;
							num /= 132058050U;
							num2 = num3.CompareTo(value);
							num += 3584746674U;
						}
						num = 1543314095U << (int)num;
						if (num > 596531002U)
						{
							return num2;
						}
					}
				}
				return num2;
			}
			IL_A8:
			num %= 2033744809U;
			return (int)(num ^ 409273470U);
		}

		// Token: 0x06000352 RID: 850 RVA: 0x00013D00 File Offset: 0x00011F00
		public void method_3(byte byte_0, int int_2, int int_3)
		{
			this.list_0.Add(new GClass18.Class36(byte_0, int_2, int_3));
		}

		// Token: 0x06000353 RID: 851 RVA: 0x00013D20 File Offset: 0x00011F20
		public List<GClass18.Class36> method_4()
		{
			return this.list_0;
		}

		// Token: 0x0400010B RID: 267
		private int int_0;

		// Token: 0x0400010C RID: 268
		private int int_1;

		// Token: 0x0400010D RID: 269
		private List<GClass18.Class36> list_0;
	}

	// Token: 0x0200006F RID: 111
	// (Invoke) Token: 0x06000355 RID: 853
	internal delegate void Delegate32();
}
