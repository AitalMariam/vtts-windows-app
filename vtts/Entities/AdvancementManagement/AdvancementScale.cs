﻿
using App.Gwin.Attributes;
using App.Gwin.Entities;
using vtts.Entities.InstitutionManagement;
using vtts.Entities.StaffManagement;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vtts.Entities.AdvancementManagement
{
    [GwinEntity(Localizable = true, isMaleName = true, DisplayMember = "Name")]
    [Menu(Group = "AdvanceManagement")]
    [ManagementForm(TitrePageGridView ="grid_title",Width =780)]
    public class AdvancementScale:BaseEntity
    {

        [EntryForm(Ordre = 3, GroupeBox = "AdvancemantScales")]
       
        [DataGrid(WidthColonne = 150)]
        public DateTime Date { get; set; }

        [EntryForm(Ordre = 3, GroupeBox = "AdvancemantScales")]
        [DataGrid(WidthColonne = 150)]
        [Relationship(Relation =RelationshipAttribute.Relations.ManyToOne)]
        [Filter(isValeurFiltreVide =false,WidthControl =150)]
        public Former Former { get; set; }


        [EntryForm(Ordre = 3, GroupeBox = "AdvancemantScales")]
        [DataGrid(WidthColonne = 150)]
        [Relationship(Relation = RelationshipAttribute.Relations.ManyToOne)]
        [Filter(Ordre =1,isValeurFiltreVide =true,WidthControl =150)]
        public Scale Scale { get; set; }

      

        [NotMapped]
        public string Name
        {
            get
            {
                if (Scale != null && Date != null)
                    return Scale + ":" + Date.ToShortDateString();
                else
                {
                    return "";
                }

            }
        }
    }
}
