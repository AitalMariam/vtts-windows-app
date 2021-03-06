﻿using App.Gwin.Attributes;
using App.Gwin.Entities;
using App.Gwin.Entities.MultiLanguage;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vtts.Entities.ModuleManagement
{
    [GwinEntity(Localizable = true, isMaleName = false, DisplayMember = "Name")]
    [Menu(Group = "InstitutionManagement")]
    [ManagementForm(Width = 670, Height = 500, TitrePageGridView = "grid_title")]
    public class PrecisionContent:BaseEntity
    {
        public PrecisionContent()
        {
            Goal = new LocalizedString();
            Description = new LocalizedString();
        }
        [EntryForm(WidthControl = 200, Ordre = 3)]
        [DataGrid(WidthColonne = 150, Ordre = 2)]
        [Filter(WidthControl = 150, Ordre = 2,isValeurFiltreVide =true)]
        [Relationship(Relation =RelationshipAttribute.Relations.ManyToOne)]
        public  Precision Precision { set; get; }

        [EntryForm(WidthControl =200,MultiLine =true,NumberLine =3,Ordre =0)]
        [DataGrid(WidthColonne =150,Ordre =0)]
        [Filter(WidthControl= 150,Ordre =0)]
        public LocalizedString Goal{ set; get; }

        [EntryForm(WidthControl = 100, Ordre = 1)]
        [DataGrid(WidthColonne = 150, Ordre = 1)]
        [Filter(WidthControl = 150, Ordre = 1)]
        public int Duration { set; get; }

        [EntryForm(WidthControl = 200, MultiLine = true, NumberLine = 6, Ordre = 5)]
        [DataGrid(WidthColonne = 150, Ordre = 3)]
        [Filter(WidthControl = 150, Ordre = 3)]
        public LocalizedString Description { set; get; }

        [NotMapped]
        public string Name
        {
            get
            {
                if (Precision != null && Goal != null)
                    return Precision + " : " + Goal.Current;
                else
                {
                    return "";
                }

            }
        }


    }
}
