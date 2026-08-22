using System.Collections.Generic;

namespace RotationSolver.Basic;

/// <summary>
/// Minimal standalone localization helper for [RotationConfig(...)] attribute Name strings
/// (per-job rotation settings), which live in this assembly and cannot reference the main
/// RotationSolver project's Loc class (RotationSolver.Basic is a dependency of RotationSolver,
/// not the other way around).
/// </summary>
internal static class Loc
{
    private static readonly Dictionary<string, string> Map = new()
    {
        // --- Common / repeated across many jobs ---
        ["Enable Potion Usage"] = "啟用藥水使用",
        ["Potion Usage Presets"] = "藥水使用預設集",
        ["Use Opener Potion at minus time in seconds"] = "開場藥水使用時機（負秒數）",
        ["Use Opener Potion at minus (value in seconds)"] = "開場藥水使用時機（負秒數）",
        ["Use 1st Potion at (value in seconds - leave at 0 if using in opener)"] = "第一瓶藥水使用時機（秒數，若已在開場使用請設為 0）",
        ["Use 2nd Potion at (value in seconds)"] = "第二瓶藥水使用時機（秒數）",
        ["Use 3rd Potion at (value in seconds)"] = "第三瓶藥水使用時機（秒數）",
        ["Stop attacking while in Guard."] = "處於防禦狀態時停止攻擊。",
        ["Player health threshold needed for Bloodbath use"] = "使用嗜血所需的玩家血量門檻",
        ["Enemy health threshold needed for Smite use"] = "使用制裁所需的敵方血量門檻",
        ["Only use DOTs on targets with Boss Icon"] = "僅對有首領圖示的目標施放持續傷害技能",
        ["Prevent the use of defense abilties during burst"] = "爆發期間避免使用防禦技能",
        ["Use GCDs to heal. (Ignored if there are no healers alive in party)"] = "使用 GCD 技能治療。（若隊伍中沒有存活的治療者則忽略此設定）",
        ["Use GCDs to heal. (Ignored if you are the only healer in party)"] = "使用 GCD 技能治療。（若你是隊伍中唯一的治療者則忽略此設定）",
        ["Enable Swiftcast Restriction Logic to attempt to prevent actions other than Raise when you have swiftcast"] = "啟用瞬間咏唱限制邏輯，嘗試在擁有瞬間咏唱時避免使用復活以外的技能",
        ["Use Crimson Cyclone at any range, regardless of safety use with caution (Enabling this ignores the below distance setting)."] = "在任何距離使用緋紅旋風，無視安全距離（請謹慎使用，啟用後將忽略下方距離設定）。",
        ["Use Crimson Cyclone at any range, regardless of saftey use with caution (Enabling this ignores the below distance setting)."] = "在任何距離使用緋紅旋風，無視安全距離（請謹慎使用，啟用後將忽略下方距離設定）。",
        ["Max distance you can be from the target for Crimson Cyclone use"] = "使用緋紅旋風時與目標的最大距離",
        ["Use Crimson Cyclone when moving"] = "移動中使用緋紅旋風",
        ["Use Swiftcast on resurrection"] = "復活時使用瞬間咏唱",
        ["Use Swiftcast on ressurection"] = "復活時使用瞬間咏唱",
        ["Use Swiftcast on Ruby Ruin when not enough level for Ruby Rite"] = "等級不足以使用紅蓮儀典時，對紅蓮毀滅使用瞬間咏唱",
        ["Use Swiftcast on Ruby Outburst when not enough level for Ruby Rite"] = "等級不足以使用紅蓮儀典時，對紅蓮爆裂使用瞬間咏唱",
        ["Use Swiftcast on Garuda"] = "對迦樓羅使用瞬間咏唱",
        ["Use Swiftcast on Ruby Rite if you are not high enough level for Garuda"] = "等級不足以召喚迦樓羅時，對紅蓮儀典使用瞬間咏唱",
        ["Order"] = "順序",
        ["Use Physick above level 30"] = "30 等以上使用小奇蹟",

        // --- ChurinDRK / DRK_Reborn (Tank) ---
        ["MP Spending Strategy"] = "MP 消耗策略",
        ["Blood Gauge Strategy"] = "血條策略",
        ["Use The Blackest Night on lowest HP party member during AOE scenarios"] = "AOE 情境下對隊伍中 HP 最低的成員使用至黑之夜",
        ["Use Shadowstride in countdown"] = "倒數計時中使用暗影步",
        ["Target health threshold needed to use Blackest Night with above option"] = "搭配上述選項使用至黑之夜所需的目標血量門檻",
        ["Keep at least 3000 MP"] = "至少保留 3000 點 MP",

        // --- DSRViper (Extra) ---
        ["Use Uncoiled Fury for movement optimization"] = "使用蜷伏之怒以優化走位",
        ["Early Tincture timing (5s before Serpent's Ire)"] = "提前使用強化藥水的時機（毒蛇之怒前 5 秒）",
        ["Minimum buff time for safe Reawaken usage"] = "安全使用覺醒所需的最短增益剩餘時間",
        ["Max Rattling Coils before forced UF"] = "強制使用蜷伏之怒前的最大蜷伏次數",
        ["Prioritize buff alternation over timers"] = "優先輪替增益而非依計時器判斷",

        // --- ChurinMNK (Extra) ---
        ["Choose Opener."] = "選擇開場動作。",
        ["Choose Opener Variation"] = "選擇開場變化",

        // --- Rabbs_BLM (Extra) ---
        ["Use Countdown Ability (Fire 3)"] = "倒數計時使用技能（火 3）",
        ["When to use Opener"] = "何時使用開場動作",
        ["Which Opener to use"] = "使用哪種開場動作",
        ["When to use Burst"] = "何時進行爆發",
        ["Which Abilities for burst to manage"] = "爆發時要管理哪些技能",
        ["How to use pots"] = "如何使用藥水",

        // --- ChurinMCH / MCH_Reborn (Ranged) ---
        ["Use Bioblaster while moving"] = "移動中使用生化砲",
        ["Only use Wildfire on Boss targets"] = "僅對首領目標使用狂野射線",
        ["Use burst medicine in countdown (requires auto burst option on)"] = "倒數計時使用爆發藥劑（需開啟自動爆發選項）",
        ["Restrict mitigations to not overlap"] = "限制減傷技能不重疊使用",

        // --- ChurinSMN / SMN_Reborn (Magical) ---
        ["Enable Fight Presets? (Experimental)"] = "啟用戰鬥預設集？（實驗性功能）",
        ["Choose a Fight"] = "選擇戰鬥",
        ["Use radiant on cooldown. But still keeping one charge"] = "冷卻好即使用光輝，但保留一次充能",
        ["Use this if there's no other raid buff in your party"] = "隊伍中沒有其他團隊增益時使用此項",

        // --- ChurinDNC / DNC_Reborn (Ranged) ---
        ["Technical Step, Technical Finish & Tillana Hold Strategy"] = "技巧舞步、技巧完結與蒂拉娜保留策略",
        ["Standard Step, Standard Finish & Finishing Move Hold Strategy"] = "標準舞步、標準完結與完結技保留策略",
        ["How many seconds before combat starts to use Standard Step?"] = "戰鬥開始前幾秒使用標準舞步？",
        ["How many seconds before combat starts to use Standard Finish?"] = "戰鬥開始前幾秒使用標準完結？",
        ["Disable Standard Step in Burst"] = "爆發時停用標準舞步",
        ["Holds Tech Step if no targets in range (Warning, will drift)"] = "範圍內無目標時保留技巧舞步（注意：技能會延後施放）",
        ["Holds Standard Step if no targets in range (Warning, will drift & Buff may fall off)"] = "範圍內無目標時保留標準舞步（注意：技能會延後施放，增益可能消失）",
        ["Dance Partner Name (If empty or not found uses default dance partner priority)"] = "舞伴名稱（留空或找不到時使用預設舞伴優先順序）",

        // --- BLU_Basic (Limited Job) ---
        ["Single Target Spell"] = "單體法術",
        ["AoE Spell"] = "範圍法術",
        ["Healing Spell"] = "治療法術",
        ["Use Basic Instinct"] = "使用基本能力",
        ["Use Mighty Guard"] = "使用剛猛守護",
        ["Aetheric Mimicry Role"] = "以太模仿職責",

        // --- ChurinBRD / BRD_Reborn (Ranged) ---
        ["Choose Bard Song Timing Preset"] = "選擇吟遊詩人樂曲時機預設集",
        ["Custom Wanderer's Minuet Uptime"] = "自訂放浪神的小步舞曲持續時間",
        ["Custom Mage's Ballad Uptime"] = "自訂魔道士的敘事謠曲持續時間",
        ["Custom Army's Paeon Uptime"] = "自訂軍神的頌歌持續時間",
        ["Custom Wanderer's Weave Slot Timing"] = "自訂放浪神編織技能時機",
        ["Enable PrepullHeartbreak Shot? - Use with BMR Auto Attack Manager"] = "啟用戰前碎心箭？（需搭配 BMR 自動攻擊管理器使用）",
        ["Use Opener Potion at minus time in seconds - only use if potting early in the opener"] = "開場藥水使用時機（負秒數，僅適用於在開場提前使用藥水的情況）",
        ["Enable Sandbag Mode?"] = "啟用沙包模式？",
        ["Buff Alignment Timer (Experimental, do not touch if you don't understand it)"] = "增益對齊計時器（實驗性功能，若不了解請勿更動）",
        ["Attempt to assign Raging Strikes, Battle Voice, and Radiant Finale to specific ogcd slots (Experimental)"] = "嘗試將強力射擊、戰鬥之聲和光輝的最終樂章分配到特定 oGCD 位置（實驗性功能）",
        ["Soul Voice Threshold for Apex Arrow"] = "使用巔峰箭所需的靈魂之聲門檻",
        ["Wanderer's Minuet Uptime"] = "放浪神的小步舞曲持續時間",
        ["Mage's Ballad Uptime"] = "魔道士的敘事謠曲持續時間",
        ["Army's Paeon Uptime"] = "軍神的頌歌持續時間",
        ["First Song"] = "第一首樂曲",
        ["Use Warden's Paean on other players"] = "對其他玩家使用看守者的讚美詩",

        // --- Tank: WAR_Reborn ---
        ["Only use Nascent Flash if Tank Stance is off"] = "僅在關閉坦克姿態時使用新生閃",
        ["Use Bloodwhetting/Raw intuition on single enemies"] = "面對單一敵人時使用生血/原初直覺",
        ["Bloodwhetting/Raw intuition heal threshold"] = "生血/原初直覺的治療門檻",
        ["Use both stacks of Onslaught during burst while standing still"] = "站立不動時，爆發期間使用兩次衝鋒",
        ["Use a stack of Onslaught when its about to overcap while standing still"] = "站立不動時，衝鋒即將溢出時使用一次",
        ["Use Primal Rend while moving (Dangerous)"] = "移動中使用原初斬（危險）",
        ["Use Primal Rend while standing still outside of configured melee range (Dangerous)"] = "站立不動且超出設定近戰距離時使用原初斬（危險）",
        ["Max distance you can be from the boss for Primal Rend use (Danger, setting too high will get you killed)"] = "使用原初斬時與首領的最大距離（危險：設太高可能導致死亡）",
        ["Nascent Flash Heal Threshold"] = "新生閃治療門檻",
        ["Thrill Of Battle Heal Threshold"] = "戰慄治療門檻",
        ["Equilibrium Heal Threshold"] = "均衡治療門檻",

        // --- Healer: AST_Reborn ---
        ["Limit Macrocosmos to multihit party stacks"] = "僅在隊伍疊加多重命中時使用宇宙之圖",
        ["Use both stacks of Lightspeed while moving"] = "移動中使用兩次光速",
        ["Prevent actions while you have the bubble mit up"] = "擁有防護罩減傷時避免使用技能",
        ["Prioritize Microcosmos over all other healing when available"] = "可用時優先使用小宇宙圖而非其他治療手段",
        ["Simple Lord of Crowns logic (use under divinaiton)"] = "簡易王冠之主邏輯（於神占術下使用）",
        ["Detonate Earlthy Star when you have Giant Dominance"] = "擁有巨星支配時引爆星極",
        ["Use Earthly Star as an attack while moving"] = "移動中將星極作為攻擊手段使用",
        ["Use Earthly Star during countdown timer."] = "倒數計時中使用星極。",
        ["Minimum HP threshold party member needs to be to use Aspected Benefic"] = "使用陽星判定所需的隊伍成員最低血量門檻",
        ["Minimum HP threshold party member needs to be to use Synastry"] = "使用命運合圖所需的隊伍成員最低血量門檻",
        ["Minimum HP threshold among party member needed to use Horoscope"] = "使用占星術所需的隊伍成員最低血量門檻",
        ["Minimum average HP threshold among party members needed to use Lady Of Crowns"] = "使用王冠之女所需的隊伍平均最低血量門檻",
        ["Minimum HP threshold party member needs to be to use Essential Dignity 3rd charge"] = "使用高貴威儀第 3 次充能所需的隊伍成員最低血量門檻",
        ["Minimum HP threshold party member needs to be to use Essential Dignity 2nd charge"] = "使用高貴威儀第 2 次充能所需的隊伍成員最低血量門檻",
        ["Minimum HP threshold party member needs to be to use Essential Dignity last charge"] = "使用高貴威儀最後一次充能所需的隊伍成員最低血量門檻",
        ["Prioritize Essential Dignity over single target GCD heals when available"] = "可用時優先使用高貴威儀而非單體 GCD 治療",

        // --- Tank: PLD_Reborn ---
        ["Use Divine Veil during countdown"] = "倒數計時中使用神聖之幕",
        ["Only use Fight or Flight while in melee range of an enemy"] = "僅在近戰距離內使用戰鬥或逃跑",
        ["Prevent actions while you have Passage of Arms up"] = "擁有武裝的通道時避免使用技能",
        ["Use Hallowed Ground with Cover"] = "搭配掩護使用神聖領域",
        ["Use up both stacks of Intervene during burst window"] = "爆發時段用完兩次介入",
        ["Use Sheltron at minimum X Oath to prevent over cap (Set to 0 to disable)"] = "誓約值達最低 X 時使用防守之陣以避免溢出（設為 0 停用）",
        ["Health threshold for Intervention (Set to 0 to disable)"] = "使用介入的血量門檻（設為 0 停用）",
        ["Use Intervention on CoTank during tankbusters"] = "坦克死刑時對副坦使用介入",
        ["Health threshold for using Intervention to attempt to save someone"] = "使用介入嘗試救人的血量門檻",
        ["Health threshold for Cover (Set to 0 to disable)"] = "使用掩護的血量門檻（設為 0 停用）",
        ["Use Holy Spirit when out of melee range"] = "超出近戰距離時使用神聖之魂",
        ["Use Clemency with Requiescat"] = "搭配安魂祈禱使用清心",
        ["Minimum HP threshold party member needs to be to use Clemency with Requiescat"] = "搭配安魂祈禱使用清心所需的隊伍成員最低血量門檻",
        ["Use Clemency without Requiescat"] = "不搭配安魂祈禱使用清心",
        ["Minimum HP threshold party member needs to be to use Clemency without Requiescat"] = "不搭配安魂祈禱使用清心所需的隊伍成員最低血量門檻",

        // --- Healer: WHM_Reborn ---
        ["Limit Liturgy Of The Bell to multihit party stacks"] = "僅在隊伍疊加多重命中時使用鐘之聖詠",
        ["Use Tincture/Gemdraught when about to use Presence of Mind"] = "即將使用天覆之時前使用強化藥水",
        ["Use DOT while moving even if it does not need refresh (disabling is a damage down)"] = "移動中即使不需重新施放也施放持續傷害技能（停用會降低傷害）",
        ["Use Lily at max stacks/about to overcap."] = "百合花瓣達上限或即將溢出時使用。",
        ["Use Lily if about to overcap and no valid target nearby."] = "百合花瓣即將溢出且附近無有效目標時使用。",
        ["Number of GCDs before you cap on blue lillies that overcap protection will consider 'near full'."] = "距離藍百合花瓣上限多少個 GCD 時，溢出保護會視為「接近全滿」。",
        ["Regen on Tank at 5 seconds remaining on Prepull Countdown."] = "戰前倒數剩餘 5 秒時對坦克施放再生。",
        ["Use Divine Caress as soon as its available"] = "可用時立即使用神聖擁抱",
        ["Use Asylum as soon as a single player heal (i.e. tankbusters) while moving, in addition to normal logic"] = "移動中需要單體治療（如坦克死刑）時立即使用庇護所，作為一般邏輯的補充",
        ["Minimum health threshold party member needs to be to use Benediction"] = "使用天賜祝福所需的隊伍成員最低血量門檻",
        ["If a party member's health drops below this percentage, the Regen healing ability will not be used on them"] = "若隊伍成員血量低於此百分比，將不會對其施放再生",
        ["Casting cost requirement for Thin Air to be used"] = "使用無中生有所需的施法成本條件",
        ["How to manage the last thin air charge"] = "如何管理無中生有的最後一次充能",

        // --- Healer: SGE_Reborn ---
        ["Use Eukrasia Action to heal"] = "使用客觀性療法搭配技能治療",
        ["Attempt to prevent bricking by allowing E.Prog at the end of GCD logic (experimental)"] = "嘗試在 GCD 邏輯尾端允許使用客觀性掛症診療以避免斷循環（實驗性功能）",
        ["Use Eukrasia when out of combat"] = "戰鬥外使用客觀性療法",
        ["Use Rhizomata when out of combat"] = "戰鬥外使用根本互療",
        ["Limit Panhaima to multihit party stacks"] = "僅在隊伍疊加多重命中時使用全體療法",
        ["Health threshold party member needs to be to use Taurochole"] = "使用牛之膽汁所需的隊伍成員血量門檻",
        ["Health threshold party member needs to be to use Soteria"] = "使用蘇奧特利亞所需的隊伍成員血量門檻",
        ["Use Kerachole as a heal when applicable"] = "適用時將白蠟樹脂作為治療手段使用",
        ["Use Holos as a heal when applicable"] = "適用時將全體療法作為治療手段使用",
        ["Average health threshold party members need to be to use Holos"] = "使用全體療法所需的隊伍平均血量門檻",
        ["Health threshold tank party member needs to use Zoe"] = "使用佐伊所需的坦克血量門檻",
        ["Health threshold party member needs to be to use an OGCD Heal while not holding addersgal stacks"] = "未持有毒蛇眼層數時，使用 oGCD 治療所需的隊伍成員血量門檻",
        ["Health threshold tank party member needs to use an OGCD Heal on Tanks while not holding addersgal stacks"] = "未持有毒蛇眼層數時，對坦克使用 oGCD 治療所需的血量門檻",
        ["Health threshold party member needs to be to use Krasis"] = "使用醫術強化所需的隊伍成員血量門檻",
        ["Health threshold tank party member needs to use Krasis"] = "使用醫術強化所需的坦克血量門檻",
        ["Health threshold party member needs to be to use Pneuma as a ST heal"] = "以氣息作為單體治療所需的隊伍成員血量門檻",
        ["Health threshold tank party member needs to use Pneuma as a ST heal"] = "以氣息作為單體治療所需的坦克血量門檻",
        ["Average health threshold party members need to be to use Pneuma as an AOE heal"] = "以氣息作為範圍治療所需的隊伍平均血量門檻",
        ["Health threshold tank party member needs to use Pneuma as an AOE heal"] = "以氣息作為範圍治療所需的坦克血量門檻",

        // --- Healer: SCH_Reborn ---
        ["Limit Seraphism to multihit party stacks"] = "僅在隊伍疊加多重命中時使用熾天使化",
        ["Remove Aetherpact if the linked party member's HP is above this percentage"] = "連結對象血量高於此百分比時解除以太契約",
        ["Do not start Aetherpact if the target's HP is above this percentage (prevents toggling)"] = "目標血量高於此百分比時不啟動以太契約（避免反覆開關）",
        ["Minimum HP percent to use Excogitation as a heal instead of a defensive buff"] = "將預兆施術作為治療而非防禦增益使用的最低血量百分比",
        ["Party HP percent threshold to use Emergency Tactics with Succor"] = "搭配士氣高揚使用緊急戰術的隊伍血量百分比門檻",
        ["Average party HP percent to use Recitation with Indomitability (must be below AoE heal threshold)"] = "搭配不撓使用祈唱的隊伍平均血量百分比（須低於範圍治療門檻）",
        ["Average party HP percent to prioritize Indomitability and instant heals over heal-over-time effects"] = "優先使用不撓與瞬發治療而非持續治療效果的隊伍平均血量百分比",
        ["Estimated percent of HP dealt as DPS for ballpark calculations"] = "用於粗略估算的預估每秒傷害血量百分比",
        ["Seconds you must be stationary before Sacred Soil can be used"] = "使用聖域前需靜止不動的秒數",
        ["Seconds you must be moving before Ruin II will be used"] = "使用毀壞之光II前需移動的秒數",
        ["Minimum MP before prioritizing emergency healing and rezzing (willing to use Seraphism sooner)"] = "優先進行緊急治療與復活所需的最低 MP（會提前使用熾天使化）",
        ["Number of fewer mobs required to favor AoW spam over Bio (0 = use Bio if break-even below 30s)"] = "偏好連發鬼術而非病毒所需減少的怪物數量（0 = 損益低於 30 秒時使用病毒）",
        ["Minimum Fairy Gauge required before prioritizing Fey Union (link)"] = "優先使用精靈連結所需的最低精靈量表",
        ["Enable Swiftcast restriction: only allow Raise while Swiftcast is active"] = "啟用瞬間咏唱限制：僅在瞬間咏唱生效時允許使用復活",
        ["Use Recitation during the countdown opener"] = "倒數計時開場使用祈唱",
        ["Use Adloquium during the countdown opener"] = "倒數計時開場使用士氣高揚",
        ["Use Recitation with Succor, Concitation, or Accession"] = "搭配士氣高揚、意气风发或神來一擊使用祈唱",
        ["Use Dissipation during burst phases"] = "爆發階段使用消散",
        ["Use Sacred Soil's regeneration as a healing effect"] = "將聖域的持續回復作為治療效果使用",
        ["Allow Sacred Soil while moving if fighting a boss"] = "與首領戰鬥時允許移動中使用聖域",
        ["Enable ballpark DoT time-to-kill estimator (in addition to normal TTK configs)"] = "啟用持續傷害擊殺時間粗估功能（作為一般 TTK 設定的補充）",
        ["How to use Deployment Tactics"] = "如何使用戰術配置",

        // --- Melee: DRG_Reborn ---
        ["Use Doom Spike for damage uptime if out of melee range even if it breaks combo"] = "超出近戰距離時使用崩壞衝以維持傷害輸出，即使會中斷連段",
        ["Max distance you need to be from the target for Stardiver useage"] = "使用流星群所需與目標的最大距離",
        ["Max distance you need to be from the target for Dragonfire Dive useage"] = "使用龍炎沖所需與目標的最大距離",

        // --- Melee: NIN_Reborn ---
        ["Use Hide"] = "使用隱遁",
        ["Use Unhide"] = "使用解除隱遁",
        ["Use Mudras outside of combat when enemies are near"] = "戰鬥外附近有敵人時使用印術",
        ["Use both stacks of Mudras"] = "使用兩次印術",
        ["Use Forked Raiju instead of Fleeting Raiju if you are outside of range (Dangerous)"] = "超出距離時使用分身雷獸而非疾風雷獸（危險）",

        // --- Melee: VPR_Reborn ---
        ["Hold one charge of Uncoiled Fury after burst for movement"] = "爆發後保留一次蜷伏之怒的充能以供走位使用",
        ["Use up all charges of Uncoiled Fury if you have used Tincture/Gemdraught (Overrides next option)"] = "使用強化藥水後用完所有蜷伏之怒充能（此設定優先於下一項）",
        ["Allow Uncoiled Fury and Writhing Snap to overwrite oGCDs when at range"] = "在遠距離時允許蜷伏之怒與扭身猛咬覆蓋 oGCD",
        ["How many charges of Uncoiled Fury needs to be at before be used inside of melee (Ignores burst, leave at 3 to hold charges for out of melee uptime or burst only)"] = "在近戰距離內使用蜷伏之怒所需的最低充能數（不含爆發，設為 3 可保留充能供遠距離輸出或僅限爆發使用）",
        ["How long on the status time for Swift needs to be to allow reawaken use (setting this too low can lead to dropping buff)"] = "允許使用覺醒所需的迅捷狀態剩餘時間（設太低可能導致增益失效）",
        ["How long on the status time for Hunt needs to be to allow reawaken use (setting this too low can lead to dropping buff)"] = "允許使用覺醒所需的狩獵狀態剩餘時間（設太低可能導致增益失效）",
        ["How long has to pass on Serpents Ire's cooldown before the rotation starts pooling gauge for burst. Leave this alone if you dont know what youre doing. (Will still use Reawaken if you reach cap regardless of timer)"] = "毒蛇之怒冷卻經過多久後開始為爆發蓄力。若不清楚用途請勿更動。（無論計時器為何，量表滿時仍會使用覺醒）",
        ["Experimental Pot Usage(used up to 5 seconds before SerpentsIre comes off cooldown)"] = "實驗性藥水使用（於毒蛇之怒冷卻結束前最多 5 秒使用）",
        ["Restrict GCD use if Serpent's Tail, Twinblood, or Twinfang oGCDs can be used"] = "可使用毒蛇尾、雙生血或雙生牙 oGCD 時限制 GCD 使用",

        // --- Ranged: BRD_Reborn additional ---
        // (covered above)

        // --- Melee: RPR_Reborn ---
        ["Pool Shroud for Arcane Circle."] = "為神秘的圓環蓄積魂能。",
        ["Use custom timing to refresh Death's Design"] = "使用自訂時機重新施放死亡烙印",
        ["Refresh Death's Design with this many seconds remaining"] = "剩餘此秒數時重新施放死亡烙印",

        // --- Melee: MNK_Reborn ---
        ["Use Form Shift"] = "使用擬態轉換",
        ["Auto Use Perfect Balance (single target full auto mode, turn me off if you want total control of PB)"] = "自動使用完美平衡（單體全自動模式，若想完全手動控制完美平衡請關閉）",
        ["Auto Use Perfect Balance (aoe aggressive PB dump, turn me off if you don't want to waste PB in boss fight)"] = "自動使用完美平衡（範圍積極消耗模式，若不想在首領戰浪費完美平衡請關閉）",
        ["Use Howling Fist/Enlightenment as a ranged attack verses single target enemies"] = "對單體敵人以咆吼掌/天啟作為遠距離攻擊使用",
        ["Enable TEA Checker."] = "啟用亞歷山大：終極武神殿檢查器。",
        ["Use Masterful Blitz abilites as soon as they are available."] = "可用時立即使用秘技。",
        ["Use Riddle of Fire after this ability"] = "在此技能後使用心眼之火",

        // --- Melee: SAM_Reborn ---
        ["Prevent Higanbana use if theres more than one target"] = "有多個目標時避免使用彼岸花",
        ["Health threshold needed to use Tengentsu/ThirdEye outside of AOE mit scenarios."] = "非範圍減傷情境下使用天眼通/心眼所需的血量門檻。",
        ["Use Hagakure or Midare/Tendo Setsugekka when going from single target to AOE scenarios"] = "由單體轉為範圍情境時使用葉隱或亂形式雪月花/天道雪月花",

        // --- Magical: RDM_Reborn ---
        ["Prevent healing during burst combos"] = "爆發連段期間避免治療",
        ["Prevent raising during burst combos"] = "爆發連段期間避免復活",
        ["Use Vercure for Dualcast when out of combat."] = "戰鬥外利用雙重咏唱使用魔法回復。",
        ["Cast Reprise when moving with no instacast."] = "移動中無瞬發時施放悲別擊。",
        ["Only use Embolden if in Melee range."] = "僅在近戰距離內使用眾星旋律。",
        ["Use Displacement after Engagement (use at own risk)."] = "使用交鋒後使用調律位移（風險自負）。",

        // --- Duty: EmanationDefault ---
        ["Auto Use Vril"] = "自動使用維利",

        // --- Duty: MonsterHunterDefault ---
        ["Use Rathalos MegaPotion"] = "使用火龍特效藥",
        ["Player HP percent needed to use Rathalos MegaPotion"] = "使用火龍特效藥所需的玩家血量百分比",
        ["Use Arkveld MegaPotion"] = "使用尋覓特效藥",
        ["Player HP percent needed to use Arkveld MegaPotion"] = "使用尋覓特效藥所需的玩家血量百分比",

        // --- Duty: PhantomDefault ---
        ["Save Phantom Attacks for class specific damage bonus?"] = "是否保留幻影攻擊以取得職業特定傷害加成？",
        ["Prioritize Viper buff application and refresh over Phantom GCDs"] = "優先施放與延續毒蛇增益而非幻影 GCD 技能",
        ["Player HP percent needed to use Occult Resuscitation"] = "使用祕術復甦所需的玩家血量百分比",
        ["Use Pray as a Heal"] = "將祈禱作為治療使用",
        ["Use Phantom Judgement"] = "使用幻影審判",
        ["Use Cleansing"] = "使用淨化",
        ["Use Blessing"] = "使用祝福",
        ["Use Starfall"] = "使用流星墜落",
        ["Use Invulnerability for Starfall"] = "使用無敵搭配流星墜落",
        ["Max distance you can be from target for Phantom Kick use (Danger, you will die)"] = "使用幻影踢時與目標的最大距離（危險：可能致死）",
        ["Your MP needed to use Occult Chakra"] = "使用祕術脈輪所需的 MP",
        ["Your HP percentage needed to use Occult Chakra"] = "使用祕術脈輪所需的血量百分比",
        ["Use Dark Cannon or Shock Cannon in cases where the mob is immune to both blind and paralysis"] = "怪物同時免疫暗盲與麻痺時使用暗黑砲或電擊砲",
        ["Use Dark Cannon or Shock Cannon in cases where the mob is susceptible to both blind and paralysis"] = "怪物同時易受暗盲與麻痺影響時使用暗黑砲或電擊砲",
        ["Average party HP percent to predict to heal with judgement instead of damage things"] = "以審判作為治療而非傷害手段的隊伍平均血量百分比預測值",
        ["Average party HP percent to predict to heal instead of damage things"] = "以治療而非傷害為優先的隊伍平均血量百分比預測值",
        ["Average party HP percent needed to use Occult Elixir"] = "使用祕術萬能藥所需的隊伍平均血量百分比",
        ["Target HP percent needed to use Occult Potion"] = "使用祕術藥水所需的目標血量百分比",
        ["Only use Occult Potion on self"] = "僅對自己使用祕術藥水",
        ["Target MP needed to use Occult Ether"] = "使用祕術以太所需的目標 MP",
        ["Only use Occult Ether on self"] = "僅對自己使用祕術以太",
        ["Use Suspend out of combat"] = "戰鬥外使用懸停",
        ["Use Suspend in combat"] = "戰鬥中使用懸停",

        // --- Magical: PCT_Reborn ---
        ["Use HolyInWhite or CometInBlack while moving"] = "移動中使用白色聖光或黑色彗星",
        ["Paint overcap protection."] = "顏料溢出保護。",
        ["Use the paint overcap protection (will still use comet while moving if the setup is on)"] = "啟用顏料溢出保護（若已啟用相關設定，移動中仍會使用彗星）",
        ["Paint overcap protection limit. How many paint you need to be at for it to use Holy out of burst (Setting is ignored when you have Hyperphantasia)"] = "顏料溢出保護門檻。非爆發時顏料達多少會使用聖光（擁有超幻影時此設定將被忽略）",
        ["Use swiftcast on Rainbow Drip (Priority over below settings)"] = "對彩虹點滴使用瞬間咏唱（優先於以下設定）",
        ["Use swiftcast on Motif"] = "對圖紋使用瞬間咏唱",
        ["Which Motif to use swiftcast on"] = "對哪個圖紋使用瞬間咏唱",

        // --- PVP specific ---
        ["Shadowbringer Threshold"] = "暗影使者門檻",
        ["Allow Mineuchi to be used on any target rather than just targets that already have Kuzushi status."] = "允許對任意目標使用峰打，而非僅限已有崩狀態的目標。",
        ["Allow Hissatsu Soten to be used on any target regardless of distance (good luck)"] = "允許對任意距離的目標使用必殺技·蒼天（祝你好運）",
        ["Use Aquaveil on other players"] = "對其他玩家使用水流幕",
        ["Upper HP threshold you need to be to use Xenoglossy as a damage oGCD"] = "以異言令作為傷害 oGCD 使用的血量上限門檻",
        ["Lower HP threshold you need to be to use Xenoglossy as a heal oGCD"] = "以異言令作為治療 oGCD 使用的血量下限門檻",
        ["Health threshold needed to use Tempura Coat"] = "使用天婦羅衣所需的血量門檻",
        ["Freely use burst damage oGCDs"] = "自由使用爆發傷害 oGCD",
        ["Enemy HP threshold needed to use burst oGCDs on if previous config disabled"] = "前項設定停用時，使用爆發 oGCD 所需的敵方血量門檻",
        ["Allow the use of high jump if there are enemies in melee range."] = "近戰距離內有敵人時允許使用高跳。",

        // --- Magical: BLM_Default / BLM_RP ---
        ["Use Transpose to Astral Fire before Paradox"] = "在悖論前使用星極變換至火焰星極",
        ["Extend Astral Fire time more conservatively (3 GCDs) (Default is 2 GCDs)"] = "以較保守方式延長火焰星極時間（3 個 GCD，預設為 2 個 GCD）",
        ["Use Leylines in combat when standing still"] = "戰鬥中站立不動時使用黃道帶",
        ["Use both stacks of Leylines automatically"] = "自動使用兩次黃道帶",
        ["Use Retrace when out of Leylines in combat and standing still"] = "戰鬥中站立不動且不在黃道帶內時使用歸返",
        ["Use Gemdraught/Tincture/pot"] = "使用強化藥水",
    };

    public static string T(string s) => Map.TryGetValue(s, out var v) ? v : s;
}
