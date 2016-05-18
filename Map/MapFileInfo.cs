using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UserCommand.Map
{
    public class MapFileInfo
    {
        const int KINGDOMMAX = 16;

        string file;
        string name;
        string description;

        UInt32 size_w;
        UInt32 size_h;
        UInt16 difficulty;
        UInt16[] races = new UInt16[KINGDOMMAX];
        UInt16[] unions = new UInt16[KINGDOMMAX];

        UInt16 kingdom_colors;
        UInt16 allow_human_colors;
        UInt16 allow_comp_colors;
        UInt16 rnd_races;

        UInt16 conditions_wins; // 0: wins def, 1: town, 2: hero, 3: artifact, 4: side, 5: gold
        bool comp_also_wins;
        bool allow_normal_victory;
        UInt32 wins1;
        UInt32 wins2;
        UInt16 conditions_loss; // 0: loss def, 1: town, 2: hero, 3: out time
        UInt32 loss1;
        UInt32 loss2;

        UInt32 localtime;

        bool with_heroes;
       

        public MapFileInfo()
        {
        }

        public static bool operator ==(MapFileInfo _fi1, MapFileInfo _fi2)
        {
            return (_fi1.file == _fi2.file) ? true : false ; 
        }

        public static bool operator !=(MapFileInfo _fi1, MapFileInfo _fi2)
        {
            return !(_fi1 == _fi2);
        }

        //public static MapFileInfo operator =(MapFileInfo value)
        //{
        //    return value;
        //}

        bool ReadMAP(ref string filename)
        {
            return true;   
        }

        bool ReadMP2(ref string filename)
        {
            return true;   
        }

        bool ReadSAV(ref string filename)
        {
            return true;   
        }

        //static bool NameSorting(const FileInfo &, const FileInfo &);
        //static bool FileSorting(const FileInfo &, const FileInfo &);
        //static bool	NameCompare(const FileInfo &, const FileInfo &);

        //bool	isAllowCountPlayers(u32) const;
        //bool	isMultiPlayerMap(void) const;
        //int		AllowCompHumanColors(void) const;
        //int		AllowComputerColors(void) const;
        //int		AllowHumanColors(void) const;
        //int		HumanOnlyColors(void) const;
        //int		ComputerOnlyColors(void) const;

        //int		KingdomRace(int color) const;

        //int		ConditionWins(void) const;
        //int		ConditionLoss(void) const;
        //bool	WinsCompAlsoWins(void) const;
        //bool	WinsAllowNormalVictory(void) const;
        //int		WinsFindArtifactID(void) const;
        //bool	WinsFindUltimateArtifact(void) const;
        //u32		WinsAccumulateGold(void) const;
        //Point	WinsMapsPositionObject(void) const;
        //Point	LossMapsPositionObject(void) const;
        //u32		LossCountDays(void) const;

        public void	Reset()
        {
        }

        public void	FillUnions()
        {
        }

       

        //Strea & operator<< (StreamBase &, const FileInfo &);
        //StreamBase & operator>> (StreamBase &, FileInfo &);
    }
}
