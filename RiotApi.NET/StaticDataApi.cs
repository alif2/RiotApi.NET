using System.Collections.Generic;
using RiotApi.NET.Objects.StaticDataApi;
using RiotApi.NET.Objects.StaticDataApi.Champions;
using RiotApi.NET.Objects.StaticDataApi.Items;
using RiotApi.NET.Objects.StaticDataApi.LanguageStrings;
using RiotApi.NET.Objects.StaticDataApi.Maps;
using RiotApi.NET.Objects.StaticDataApi.Masteries;
using RiotApi.NET.Objects.StaticDataApi.ProfileIcons;
using RiotApi.NET.Objects.StaticDataApi.Realms;
using RiotApi.NET.Objects.StaticDataApi.ReforgedRunes;
using RiotApi.NET.Objects.StaticDataApi.Runes;
using RiotApi.NET.Objects.StaticDataApi.SummonerSpells;

namespace RiotApi.NET
{
    public class StaticDataApi : Api
    {
        public StaticDataApi(RiotApi riotApi) : base(riotApi, "/lol/static-data/v3") {}

        public StaticChampionList GetChampions()
        {
            return RiotApi.GetObject<StaticChampionList>(BaseUrl + "/champions");
        }

        public StaticChampion GetChampions(long championId)
        {
            return RiotApi.GetObject<StaticChampion>(BaseUrl + $"/champions/{championId}");
        }

        public StaticItemList GetItems()
        {
            return RiotApi.GetObject<StaticItemList>(BaseUrl + "/items");
        }

        public StaticItem GetItems(long itemId)
        {
            return RiotApi.GetObject<StaticItem>(BaseUrl + $"/items/{itemId}");
        }

        public StaticLanguageStrings GetLanguageStrings()
        {
            return RiotApi.GetObject<StaticLanguageStrings>(BaseUrl + "/language-strings");
        }

        public IEnumerable<string> GetLanguages()
        {
            return RiotApi.GetObject<IEnumerable<string>>(BaseUrl + "/languages");
        }

        public StaticMapData GetMaps()
        {
            return RiotApi.GetObject<StaticMapData>(BaseUrl + "/maps");
        }

        public StaticMasteryList GetMasteries()
        {
            return RiotApi.GetObject<StaticMasteryList>(BaseUrl + "/masteries");
        }

        public StaticMastery GetMasteries(long masteryId)
        {
            return RiotApi.GetObject<StaticMastery>(BaseUrl + $"/masteries/{masteryId}");
        }

        public StaticProfileIconData GetProfileIcons()
        {
            return RiotApi.GetObject<StaticProfileIconData>(BaseUrl + "/profile-icons");
        }

        public StaticRealm GetRealms()
        {
            return RiotApi.GetObject<StaticRealm>(BaseUrl + "/realms");
        }

        public StaticReforgedRunePath GetReforgedRunePaths()
        {
            return RiotApi.GetObject<StaticReforgedRunePath>(BaseUrl + "/reforged-rune-paths");
        }

        public StaticReforgedRunePath GetReforgedRunePaths(long pathId)
        {
            return RiotApi.GetObject<StaticReforgedRunePath>(BaseUrl + $"/reforged-rune-paths/{pathId}");
        }

        public IEnumerable<StaticReforgedRune> GetReforgedRunes()
        {
            return RiotApi.GetObject<IEnumerable<StaticReforgedRune>>(BaseUrl + "/reforged-runes");
        }

        public StaticReforgedRune GetReforgedRunes(long runeId)
        {
            return RiotApi.GetObject<StaticReforgedRune>(BaseUrl + $"/reforged-runes/{runeId}");
        }

        public StaticRuneList GetRunes()
        {
            return RiotApi.GetObject<StaticRuneList>(BaseUrl + "/runes");
        }

        public StaticRune GetRunes(long runeId)
        {
            return RiotApi.GetObject<StaticRune>(BaseUrl + $"/runes/{runeId}");
        }

        public StaticSummonerSpellList GetSummonerSpells()
        {
            return RiotApi.GetObject<StaticSummonerSpellList>(BaseUrl + "/summoner-spells");
        }

        public StaticSummonerSpell GetSummonerSpells(long spellId)
        {
            return RiotApi.GetObject<StaticSummonerSpell>(BaseUrl + $"/summoner-spells{spellId}");
        }

        public string GetTarballLinks()
        {
            return RiotApi.GetObject<string>(BaseUrl + "/tarball-links");
        }

        public IEnumerable<string> GetVersions()
        {
            return RiotApi.GetObject<IEnumerable<string>>(BaseUrl + "/versions");
        }
    }
}
