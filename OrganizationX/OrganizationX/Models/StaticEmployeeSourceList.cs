using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrganizationX.Models
{
    public class StaticEmployeeSourceList
    {
        public Dictionary<string, List<string>> staticEmployeeSourceList = new Dictionary<string, List<string>>
        {
            
            {"Attrition", new List<string>{"Yes","No"}},
            {"BusinessTravel", new List<string>{ "Non-Travel", "Travel_Frequently", "Travel_Rarely"}},
            {"Department", new List<string>{ "Research & Development", "Sales"}},
            {"EducationField", new List<string>{"Human Resources","Life Sciences","Marketing", "Medical","Other","Technical Degree"}},
            {"Gender", new List<string>{ "Female","Male" }},
            {"JobRole", new List<string>{"Healthcare Representative","Human Resources","Laboratory Technician","Manager", "Manufacturing Director","Research Director","Research Scientist","Sales Executive","Sales Representative"}},
            {"MaritalStatus", new List<string>{"Single","Married","Divorced"}},
            {"Over18", new List<string>{"Y","N"}},
            {"OverTime", new List<string>{"Yes","No"}},


        };
        public List<String> GetList(string key)
        {
            if (staticEmployeeSourceList.ContainsKey(key))
            return staticEmployeeSourceList[key];
            return new List<string> { };
        }
        public List<SelectListItem> SelectAge { get; } = new List<SelectListItem>
        {
            new SelectListItem { Text = "1" },
            new SelectListItem { Text = "2" },
            new SelectListItem { Text = "3" },
        };


        public List<RelationType> RelationOption = new List<RelationType>()
        {
            {
                new RelationType{
                    Title = "Less Than",
                    HtmlCode = "&lt;",
                    AsciiCode = ">",
                }
            },
            {
                new RelationType{
                    Title = "Greater Than",
                    HtmlCode = "&gt;",
                    AsciiCode = "<",
                }
            },
            {
                new RelationType{
                    Title = "Equal To",
                    HtmlCode = "&#61;",
                    AsciiCode = "=",
                }
            },

        };


    }
}
