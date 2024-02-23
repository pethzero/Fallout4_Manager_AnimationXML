using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Fallout4_Position
{
    internal class SystemF4
    {
        // private Label lblLogTree; // เพิ่มตัวแปร lblLogTree เพื่อเก็บค่าของ TextBox จาก Form
        private Fallout4TreeXML FApp;
        // สร้าง constructor ที่รับค่าของ lblLogTree จาก Form

        public SystemF4(Fallout4TreeXML formApp)
        {
            FApp = formApp;
        }

        // เมธอดรับข้อมูลจาก TextBox
        public string ReceiveTextBoxData()
        {
             return "Finish";
        }


        public bool Process_Positon(string Head_Data,string Detail_data)
        {
            try
            {
                // Extracting necessary data
                string id_main = Head_Data;
                string data_animation_group = Detail_data;
                string pattern_Main = @"id=""([^""]+)"".*?animationGroup=""([^""]+)"".*?tags=""([^""]+)""";
                Match matchAnimation_Main = Regex.Match(id_main, pattern_Main);
                string id_position = matchAnimation_Main.Groups[1].Value;
                string id_AnimationGroup = matchAnimation_Main.Groups[2].Value;
                string id_tags = matchAnimation_Main.Groups[3].Value;
                string id_tree = $"{id_AnimationGroup}_Tree";

                // Initialize list of all animations
                List<string> list_animations_all = new List<string>
        {
            $"<position id=\"{id_position}\" positionTree=\"{id_tree}\" tags=\"{id_tags}\"/>",
            $"<position id=\"{id_position} Sequence\" animationGroup=\"{id_AnimationGroup}\" isHidden=\"true\" tags=\"{id_tags}\"/>"
        };

                // Detail animations
                List<string> list_animations_detail = new List<string>();
                foreach ((Match match, int i) in Regex.Matches(data_animation_group, @"id=""([^""]+)"".*?tags=""([^""]+)""").Select((match, index) => (match, index)))
                {
                    string animation = match.Groups[1].Value; // Animation
                    string tags = match.Groups[2].Value; // Tag

                    list_animations_detail.Add($"<position id=\"{id_position} (Stage {i + 1})\"  animation=\"{animation}\" isHidden=\"true\" tags=\"{tags}\"/>");
                }
                list_animations_all.AddRange(list_animations_detail);

                // Creating XML content for animations
                string xmlContent_animation = string.Join("\n", list_animations_all.Select(animationData => $"{animationData}"));

                // Creating XML content for tree
                string xmlContent_tree = $"<tree id=\"{id_tree}\" strictExiting=\"true\">\n";
                // Iterating through the list of animations
                for (int i = 0; i < list_animations_detail.Count; i++)
                {
                    string branch_id = (i == list_animations_detail.Count - 1 || i == list_animations_detail.Count - 2) ? ((i == list_animations_detail.Count - 1) ? "Finish" : "Climax") : $"Play Stage {i + 1}";
                    string branch_opening_tag = $"\t<branch id=\"{branch_id}\" positionID=\"{id_position} (Stage {i + 1})\" forceComplete=\"true\" time=\"10\">\n";
                    xmlContent_tree += branch_opening_tag;
                }
                foreach (string animation in list_animations_detail)
                {
                    xmlContent_tree += "\t</branch>\n";
                }
                // Close the tree structure
                xmlContent_tree += "</tree>";
                Console.WriteLine(xmlContent_tree);

                // Writing data to files
                // Check if the "output" folder exists
                string outputFolderPath = "output";
                if (!Directory.Exists(outputFolderPath))
                {
                    // If the "output" folder doesn't exist, create it
                    Directory.CreateDirectory(outputFolderPath);
                }

                // Write data to "create_positionData.xml" file in the "output" folder
                File.WriteAllText(Path.Combine(outputFolderPath, "create_positionData.xml"), xmlContent_animation);

                // Write data to "create_positionTreeData.xml" file in the "output" folder
                File.WriteAllText(Path.Combine(outputFolderPath, "create_positionTreeData.xml"), xmlContent_tree);

               

                return true;
            }
            catch (Exception ex)
            {
                // Handle exceptions
                Console.WriteLine(ex.Message);
                return false;
            }
        }

       


    }
}
