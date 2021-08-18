﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;

namespace DnD_CharacterBuilder_Library
{
    public class PDFLayout
    {
        string htmlCode = "< html lang=\"en\"><head><meta charset=\"UTF-8\">" +
            "<style>.hide {  display: none !important;}" +
            "textarea {  font-size: 12px;  text-align: left;  width: calc(100% - 20px - 2px);  border-radius: 10px;  padding: 10px;  resize: none;  overflow: hidden;  height: 15em;}" +
            "input[type=checkbox] {  cursor: pointer;}div.box {  margin-top: 10px;}form.charsheet {  width: 800px;  right: 0;  left: 0;  margin-right: auto;  margin-left: auto;  margin-top: 10px;}" +
            "form.charsheet div.textblock {  display: flex;  flex-direction: column-reverse;  width: 100%;  align-items: center;}" +
            "form.charsheet div.textblock label {  text-align: center;  border: 1px solid black;  border-top: 0;  font-size: 10px;  width: calc(100% - 20px - 2px);  border-radius: 0 0 10px 10px;  padding: 4px 0;  font-weight: bold;}" +
            "form.charsheet div.textblock textarea {  border: 1px solid black;}form.charsheet ul {  margin: 0;  padding: 0;}form.charsheet ul li {  list-style-image: none;  display: block;}" +
            "form.charsheet ::-moz-placeholder {  color: #bbb;}" +
            "form.charsheet :-ms-input-placeholder {  color: #bbb;}" +
            "form.charsheet ::placeholder {  color: #bbb;}" +
            "form.charsheet label {  text-transform: uppercase;  font-size: 12px;}" +
            "form.charsheet header {  display: flex;  align-contents: stretch;  align-items: stretch;}" +
            "form.charsheet header section.charname {  border: 1px solid black;  border-right: 0;  border-radius: 10px 0 0 10px;  padding: 5px 0;  background-color: #eee;  width: 30%;  display: flex;  flex-direction: column-reverse;  bottom: 0;  top: 0;  margin: auto;}" +
            "form.charsheet header section.charname input {  padding: 0.5em;  margin: 5px;  border: 0;}" +
            "form.charsheet header section.charname label {  padding-left: 1em;}" +
            "form.charsheet header section.misc {  width: 70%;  border: 1px solid black;  border-radius: 10px;  padding-left: 1em;  padding-right: 1em;}" +
            "form.charsheet header section.misc ul {  padding: 10px 0px 5px 0px;  display: flex;  flex-wrap: wrap;}" +
            "form.charsheet header section.misc ul li {  width: 33.33333%;  display: flex;  flex-direction: column-reverse;}" +
            "form.charsheet header section.misc ul li label {  margin-bottom: 5px;}" +
            "form.charsheet header section.misc ul li input {  border: 0;  border-bottom: 1px solid #ddd;}" +
            "form.charsheet main {  display: flex;  justify-content: space-between;  margin-top: 20px;}" +
            "form.charsheet main div.label-container {  position: relative;  width: 100%;  height: 18px;  margin-top: 6px;  border: 1px solid black;  border-left: 0;  text-align: center;}" +
            "form.charsheet main div.label-container > label {  position: absolute;  left: 0;  top: 1px;  transform: translate(0%, 50%);  width: 100%;  font-size: 8px;}" +
            "form.charsheet main > section {  width: 32%;  display: flex;  flex-direction: column;}" +
            "form.charsheet main > section section.attributes {  width: 100%;  display: flex;  flex-direction: row;  justify-content: space-between;}" +
            "form.charsheet main > section section.attributes div.scores {  width: 101px;  background-color: #bbb;  border-radius: 10px;  padding-bottom: 5px;}" +
            "form.charsheet main > section section.attributes div.scores label {  font-size: 8px;  font-weight: bold;}" +
            "form.charsheet main > section section.attributes div.scores ul {  display: flex;  flex-direction: column;  justify-content: space-around;  align-items: center;  height: 100%;}" +
            "form.charsheet main > section section.attributes div.scores ul li {  height: 80px;  width: 70px;  background-color: white;  border: 1px solid black;  text-align: center;  display: flex;  flex-direction: column;  border-radius: 10px;}" +
            "form.charsheet main > section section.attributes div.scores ul li input {  width: 100%;  padding: 0;  border: 0;}" +
            "form.charsheet main > section section.attributes div.scores ul li div.score input {  text-align: center;  font-size: 40px;  padding: 2px 0px 0px 0px;  background: white;}" +
            "form.charsheet main > section section.attributes div.scores ul li div.modifier {  margin-top: 3px;}" +
            "form.charsheet main > section section.attributes div.scores ul li div.modifier input {  background: white;  width: 30px;  height: 20px;  border: 1px inset black;  border-radius: 20px;  margin: -1px;  text-align: center;}" +
            "form.charsheet main > section section.attributes div.attr-applications div.inspiration {  display: flex;  flex-direction: row-reverse;  justify-content: flex-end;}" +
            "form.charsheet main > section section.attributes div.attr-applications div.inspiration input {  -webkit-appearance: none;     -moz-appearance: none;          appearance: none;  border: 1px solid black;  padding: 15px;  border-radius: 10px;}" +
            "form.charsheet main > section section.attributes div.attr-applications div.proficiencybonus {  display: flex;  flex-direction: row-reverse;  justify-content: flex-end;}" +
            "form.charsheet main > section section.attributes div.attr-applications div.proficiencybonus input {  width: 30px;  height: 28px;  border: 1px solid black;  text-align: center;  border-radius: 10px;}" +
            "form.charsheet main > section section.attributes div.attr-applications div.list-section {  border: 1px solid black;  border-radius: 10px;  padding: 10px 5px;}" +
            "form.charsheet main > section section.attributes div.attr-applications div.list-section div.label {  margin-top: 10px;  margin-bottom: 2.5px;  text-align: center;  text-transform: uppercase;  font-size: 10px;  font-weight: bold;}" +
            "form.charsheet main > section section.attributes div.attr-applications div.list-section ul li {  display: flex;  align-items: center;}" +
            "form.charsheet main > section section.attributes div.attr-applications div.list-section ul li > * {  margin-left: 5px;}" +
            "form.charsheet main > section section.attributes div.attr-applications div.list-section ul li label {  text-transform: none;  font-size: 8px;  text-align: left;  order: 3;}" +
            "form.charsheet main > section section.attributes div.attr-applications div.list-section ul li label span.skill {  color: #bbb;}" +
            "form.charsheet main > section section.attributes div.attr-applications div.list-section ul li input[type=text] {  width: 30px;  font-size: 12px;  text-align: center;  border: 0;  border-bottom: 1px solid black;  order: 2;}" +
            "form.charsheet main > section section.attributes div.attr-applications div.list-section ul li input[type=checkbox] {  -webkit-appearance: none;     -moz-appearance: none;          appearance: none;  width: 10px;  height: 10px;  border: 1px solid black;  border-radius: 10px;  order: 1;}" +
            "form.charsheet main > section section.attributes div.attr-applications div.list-section ul li input[type=checkbox]:checked {  background-color: black;}" +
            "form.charsheet main > section div.passive-perception {  display: flex;  flex-direction: row-reverse;  justify-content: flex-end;}" +
            "form.charsheet main > section div.passive-perception input {  width: 30px;  height: 28px;  text-align: center;  border: 1px solid black;  border-radius: 10px;}" +
            "form.charsheet main > section div.otherprofs textarea {  height: 26em;}" +
            "form.charsheet main section.combat {  background-color: #eee;  display: flex;  flex-wrap: wrap;  border-radius: 10px;}" +
            "form.charsheet main section.combat > div {  overflow: hidden;}" +
            "form.charsheet main section.combat > div.armorclass, form.charsheet main section.combat > div.initiative, form.charsheet main section.combat > div.speed {  flex-basis: 33.333%;}" +
            "form.charsheet main section.combat > div.armorclass > div, form.charsheet main section.combat > div.initiative > div, form.charsheet main section.combat > div.speed > div {  display: flex;  flex-direction: column-reverse;  align-items: center;  margin-top: 10px;}" +
            "form.charsheet main section.combat > div.armorclass > div label, form.charsheet main section.combat > div.initiative > div label, form.charsheet main section.combat > div.speed > div label {  font-size: 8px;  width: 50px;  border: 1px solid black;  border-top: 0;  background-color: white;  text-align: center;  padding-top: 5px;  padding-bottom: 5px;  border-radius: 0 0 10px 10px;}" +
            "form.charsheet main section.combat > div.armorclass > div input, form.charsheet main section.combat > div.initiative > div input, form.charsheet main section.combat > div.speed > div input {  height: 70px;  width: 70px;  border-radius: 10px;  border: 1px solid black;  text-align: center;  font-size: 30px;}" +
            "form.charsheet main section.combat > div.hp {  flex-basis: 100%;}" +
            "form.charsheet main section.combat > div.hp > div.regular {  background-color: white;  border: 1px solid black;  margin: 10px;  margin-bottom: 5px;  border-radius: 10px 10px 0 0;}" +
            "form.charsheet main section.combat > div.hp > div.regular > div.max {  display: flex;  justify-content: space-around;  align-items: baseline;}" +
            "form.charsheet main section.combat > div.hp > div.regular > div.max label {  font-size: 10px;  text-transform: none;  color: #bbb;}" +
            "form.charsheet main section.combat > div.hp > div.regular > div.max input {  width: 40%;  border: 0;  border-bottom: 1px solid #ddd;  font-size: 12px;  text-align: center;}" +
            "form.charsheet main section.combat > div.hp > div.regular > div.current {  display: flex;  flex-direction: column-reverse;}" +
            "form.charsheet main section.combat > div.hp > div.regular > div.current input {  border: 0;  width: 100%;  padding: 1em 0;  font-size: 20px;  text-align: center;}" +
            "form.charsheet main section.combat > div.hp > div.regular > div.current label {  font-size: 10px;  padding-bottom: 5px;  text-align: center;  font-weight: bold;}" +
            "form.charsheet main section.combat > div.hp > div.temporary {  margin: 10px;  margin-top: 0;  border: 1px solid black;  border-radius: 0 0 10px 10px;  display: flex;  flex-direction: column-reverse;  background-color: white;}" +
            "form.charsheet main section.combat > div.hp > div.temporary input {  padding: 1em 0;  font-size: 20px;  border: 0;  text-align: center;}" +
            "form.charsheet main section.combat > div.hp > div.temporary label {  font-size: 10px;  padding-bottom: 5px;  text-align: center;  font-weight: bold;}" +
            "form.charsheet main section.combat > div.hitdice, form.charsheet main section.combat > div.deathsaves {  flex: 1 50%;  height: 100px;}" +
            "form.charsheet main section.combat > div.hitdice > div, form.charsheet main section.combat > div.deathsaves > div {  height: 80px;}" +
            "form.charsheet main section.combat > div.hitdice > div {  background-color: white;  margin: 10px;  border: 1px solid black;  border-radius: 10px;  display: flex;  flex-direction: column;}" +
            "form.charsheet main section.combat > div.hitdice > div > div.total {  display: flex;  align-items: baseline;  justify-content: space-around;  padding: 5px 0;}" +
            "form.charsheet main section.combat > div.hitdice > div > div.total label {  font-size: 10px;  color: #bbb;  margin: 0.25em;  text-transform: none;}" +
            "form.charsheet main section.combat > div.hitdice > div > div.total input {  font-size: 12px;  flex-grow: 1;  border: 0;  border-bottom: 1px solid #ddd;  width: 50%;  margin-right: 0.25em;  padding: 0 0.25em;  text-align: center;}" +
            "form.charsheet main section.combat > div.hitdice > div > div.remaining {  flex: 1;  display: flex;  flex-direction: column-reverse;}" +
            "form.charsheet main section.combat > div.hitdice > div > div.remaining label {  text-align: center;  padding: 2px;  font-size: 10px;}" +
            "form.charsheet main section.combat > div.hitdice > div > div.remaining input {  text-align: center;  border: 0;  flex: 1;}" +
            "form.charsheet main section.combat > div.deathsaves > div {  margin: 10px;  background: white;  border: 1px solid black;  border-radius: 10px;  display: flex;  flex-direction: column-reverse;}" +
            "form.charsheet main section.combat > div.deathsaves > div > div.label {  text-align: center;}" +
            "form.charsheet main section.combat > div.deathsaves > div > div.label label {  font-size: 10px;}" +
            "form.charsheet main section.combat > div.deathsaves > div > div.marks {  display: flex;  flex: 1;  flex-direction: column;  justify-content: center;}" +
            "form.charsheet main section.combat > div.deathsaves > div > div.marks div.deathsuccesses, form.charsheet main section.combat > div.deathsaves > div > div.marks div.deathfails {  display: flex;  align-items: center;}" +
            "form.charsheet main section.combat > div.deathsaves > div > div.marks div.deathsuccesses label, form.charsheet main section.combat > div.deathsaves > div > div.marks div.deathfails label {  font-size: 8px;  text-align: right;  flex: 1 50%;}" +
            "form.charsheet main section.combat > div.deathsaves > div div.bubbles {  flex: 1 40%;  margin-left: 5px;}" +
            "form.charsheet main section.combat > div.deathsaves > div div.bubbles input[type=checkbox] {  -webkit-appearance: none;     -moz-appearance: none;          appearance: none;  width: 10px;  height: 10px;  border: 1px solid black;  border-radius: 10px;}" +
            "form.charsheet main section.combat > div.deathsaves > div div.bubbles input[type=checkbox]:checked {  background-color: black;}" +
            "form.charsheet main section.attacksandspellcasting {  border: 1px solid black;  border-radius: 10px;  margin-top: 10px;}" +
            "form.charsheet main section.attacksandspellcasting > div {  margin: 10px;  display: flex;  flex-direction: column;}" +
            "form.charsheet main section.attacksandspellcasting > div > label {  order: 3;  text-align: center;}" +
            "form.charsheet main section.attacksandspellcasting > div > table {  width: 100%;}" +
            "form.charsheet main section.attacksandspellcasting > div > table th {  font-size: 10px;  color: #ddd;}" +
            "form.charsheet main section.attacksandspellcasting > div > table input {  width: calc(100% - 4px);  border: 0;  background-color: #eee;  font-size: 10px;  padding: 3px;}" +
            "form.charsheet main section.attacksandspellcasting > div textarea {  border: 0;}" +
            "form.charsheet main section.equipment {  border: 1px solid black;  border-radius: 10px;  margin-top: 10px;}" +
            "form.charsheet main section.equipment > div {  padding: 10px;  display: flex;  flex-direction: row;  flex-wrap: wrap;}" +
            "form.charsheet main section.equipment > div > div.money ul {  display: flex;  flex-direction: column;  justify-content: space-between;  height: 100%;}" +
            "form.charsheet main section.equipment > div > div.money ul > li {  display: flex;  align-items: center;}" +
            "form.charsheet main section.equipment > div > div.money ul > li label {  border: 1px solid black;  border-radius: 10px 0 0 10px;  border-right: 0;  width: 20px;  font-size: 8px;  text-align: center;  padding: 3px 0;}" +
            "form.charsheet main section.equipment > div > div.money ul > li input {  border: 1px solid black;  border-radius: 10px;  width: 40px;  padding: 10px 3px;  font-size: 12px;  text-align: center;}" +
            "form.charsheet main section.equipment > div > label {  order: 3;  text-align: center;  flex: 100%;}" +
            "form.charsheet main section.equipment > div > textarea {  flex: 1;  border: 0;}" +
            "form.charsheet main section.flavor {  padding: 10px;  background: #bbb;  border-radius: 10px;}" +
            "form.charsheet main section.flavor div {  background: white;  display: flex;  flex-direction: column-reverse;  padding: 5px;  border: 1px solid black;}" +
            "form.charsheet main section.flavor div label {  text-align: center;  font-size: 10px;  margin-top: 3px;}" +
            "form.charsheet main section.flavor div textarea {  border: 0;  border-radius: 0;  height: 4em;}" +
            "form.charsheet main section.flavor div:first-child {  border-radius: 10px 10px 0 0;}" +
            "form.charsheet main section.flavor div:not(:first-child) {  margin-top: 10px;}" +
            "form.charsheet main section.flavor div:last-child {  border-radius: 0 0 10px 10px;}" +
            "form.charsheet main section.features {  padding: 10px;}" +
            "form.charsheet main section.features div {  padding: 10px;  border: 1px solid black;  border-radius: 10px;  display: flex;  flex-direction: column-reverse;}" +
            "form.charsheet main section.features div label {  text-align: center;}" +
            "form.charsheet main section.features div textarea {  border: 0;  padding: 5px;  height: 43em;}" +
            "</style></head>" +
            "<body translate=\"no\">" +
            "<form class=\"charsheet\">" +
            "<header>" +
            "<section class=\"charname\"> <label for=\"charname\">Character Name</label><input name=\"charname\" placeholder=\"Thoradin Fireforge\"> </section>" +
            "<section class=\"misc\">" +
            "<ul>" +
            "<li><label for=\"classlevel\">Class &amp; Level</label><input name=\"classlevel\" placeholder=\"Paladin 2\"></li>" +
            "<li><label for=\"background\">Background</label><input name=\"background\" placeholder=\"Acolyte\"></li>" +
            "<li><label for=\"playername\">Player Name</label><input name=\"playername\" placeholder=\"Player McPlayerface\"></li>" +
            "<li><label for=\"race\">Race</label><input name=\"race\" placeholder=\"Half-elf\"></li>" +
            "<li><label for=\"alignment\">Alignment</label><input name=\"alignment\" placeholder=\"Lawful Good\"></li>" +
            "<li><label for=\"experiencepoints\">Experience Points</label><input name=\"experiencepoints\" placeholder=\"3240\"></li>" +
            "</ul></section></header>" +
            "<main>" +
            "<section>" +
            "<section class=\"attributes\">" +
            "<div class=\"scores\">" +
            "<ul>" +
            "<li><div class=\"score\"><label for=\"Strengthscore\">Strength</label><input name=\"Strengthscore\" placeholder=\"10\"></div><div class=\"modifier\"><input name=\"Strengthmod\" placeholder=\"+0\"></div></li>" +
            "<li><div class=\"score\"><label for=\"Dexterityscore\">Dexterity</label><input name=\"Dexterityscore\" placeholder=\"10\"></div><div class=\"modifier\"><input name=\"Dexteritymod\" placeholder=\"+0\"></div></li>" +
            "<li><div class=\"score\"><label for=\"Constitutionscore\">Constitution</label><input name=\"Constitutionscore\" placeholder=\"10\"></div><div class=\"modifier\"><input name=\"Constitutionmod\" placeholder=\"+0\"></div></li>" +
            "<li><div class=\"score\"><label for=\"Wisdomscore\">Wisdom</label><input name=\"Wisdomscore\" placeholder=\"10\"></div><div class=\"modifier\"><input name=\"Wisdommod\" placeholder=\"+0\"></div></li>" +
            "<li><div class=\"score\"><label for=\"Intelligencescore\">Intelligence</label><input name=\"Intelligencescore\" placeholder=\"10\"></div><div class=\"modifier\"><input name=\"Intelligencemod\" placeholder=\"+0\"></div></li>" +
            "<li><div class=\"score\"><label for=\"Charismascore\">Charisma</label><input name=\"Charismascore\" placeholder=\"10\"></div><div class=\"modifier\"><input name=\"Charismamod\" placeholder=\"+0\"></div></li>" +
            "</ul></div>" +
            "<div class=\"attr-applications\"><div class=\"inspiration box\"><div class=\"label-container\">" +
            "<label for=\"inspiration\">Inspiration</label></div><input name=\"inspiration\" type=\"checkbox\"></div>" +
            "<div class=\"proficiencybonus box\"><div class=\"label-container\"><label for=\"proficiencybonus\">Proficiency Bonus</label></div><input name=\"proficiencybonus\" placeholder=\"+2\"></div>" +
            "<div class=\"saves list-section box\">" +
            "<ul>" +
            "<li><label for=\"Strength-save\">Strength</label><input name=\"Strength-save\" placeholder=\"+0\" type=\"text\"><input name=\"Strength-save-prof\" type=\"checkbox\"></li>" +
            "<li><label for=\"Dexterity-save\">Dexterity</label><input name=\"Dexterity-save\" placeholder=\"+0\" type=\"text\"><input name=\"Dexterity-save-prof\" type=\"checkbox\"></li>" +
            "<li><label for=\"Constitution-save\">Constitution</label><input name=\"Constitution-save\" placeholder=\"+0\" type=\"text\"><input name=\"Constitution-save-prof\" type=\"checkbox\"></li>" +
            "<li><label for=\"Wisdom-save\">Wisdom</label><input name=\"Wisdom-save\" placeholder=\"+0\" type=\"text\"><input name=\"Wisdom-save-prof\" type=\"checkbox\"></li>" +
            "<li><label for=\"Intelligence-save\">Intelligence</label><input name=\"Intelligence-save\" placeholder=\"+0\" type=\"text\"><input name=\"Intelligence-save-prof\" type=\"checkbox\"></li>" +
            "<li><label for=\"Charisma-save\">Charisma</label><input name=\"Charisma-save\" placeholder=\"+0\" type=\"text\"><input name=\"Charisma-save-prof\" type=\"checkbox\"></li>" +
            "</ul>" +
            "<div class=\"label\">Saving Throws</div></div>" +
            "<div class=\"skills list-section box\">" +
            "<ul>" +
            "<li><label for=\"Acrobatics\">Acrobatics <span class=\"skill\">(Dex)</span></label><input name=\"Acrobatics\" placeholder=\"+0\" type=\"text\"><input name=\"Acrobatics-prof\" type=\"checkbox\"></li>" +
            "<li><label for=\"Animal Handling\">Animal Handling <span class=\"skill\">(Wis)</span></label><input name=\"Animal Handling\" placeholder=\"+0\" type=\"text\"><input name=\"Animal Handling-prof\" type=\"checkbox\"></li>" +
            "<li><label for=\"Arcana\">Arcana <span class=\"skill\">(Int)</span></label><input name=\"Arcana\" placeholder=\"+0\" type=\"text\"><input name=\"Arcana-prof\" type=\"checkbox\"></li>" +
            "<li><label for=\"Athletics\">Athletics <span class=\"skill\">(Str)</span></label><input name=\"Athletics\" placeholder=\"+0\" type=\"text\"><input name=\"Athletics-prof\" type=\"checkbox\"></li>" +
            "<li><label for=\"Deception\">Deception <span class=\"skill\">(Cha)</span></label><input name=\"Deception\" placeholder=\"+0\" type=\"text\"><input name=\"Deception-prof\" type=\"checkbox\"></li>" +
            "<li><label for=\"History\">History <span class=\"skill\">(Int)</span></label><input name=\"History\" placeholder=\"+0\" type=\"text\"><input name=\"History-prof\" type=\"checkbox\"></li>" +
            "<li><label for=\"Insight\">Insight <span class=\"skill\">(Wis)</span></label><input name=\"Insight\" placeholder=\"+0\" type=\"text\"><input name=\"Insight-prof\" type=\"checkbox\"></li>" +
            "<li><label for=\"Intimidation\">Intimidation <span class=\"skill\">(Cha)</span></label><input name=\"Intimidation\" placeholder=\"+0\" type=\"text\"><input name=\"Intimidation-prof\" type=\"checkbox\"></li>" +
            "<li><label for=\"Investigation\">Investigation <span class=\"skill\">(Int)</span></label><input name=\"Investigation\" placeholder=\"+0\" type=\"text\"><input name=\"Investigation-prof\" type=\"checkbox\"></li>" +
            "<li><label for=\"Medicine\">Medicine <span class=\"skill\">(Wis)</span></label><input name=\"Medicine\" placeholder=\"+0\" type=\"text\"><input name=\"Medicine-prof\" type=\"checkbox\"></li>" +
            "<li><label for=\"Nature\">Nature <span class=\"skill\">(Int)</span></label><input name=\"Nature\" placeholder=\"+0\" type=\"text\"><input name=\"Nature-prof\" type=\"checkbox\"></li>" +
            "<li><label for=\"Perception\">Perception <span class=\"skill\">(Wis)</span></label><input name=\"Perception\" placeholder=\"+0\" type=\"text\"><input name=\"Perception-prof\" type=\"checkbox\"></li>" +
            "<li><label for=\"Performance\">Performance <span class=\"skill\">(Cha)</span></label><input name=\"Performance\" placeholder=\"+0\" type=\"text\"><input name=\"Performance-prof\" type=\"checkbox\"></li>" +
            "<li><label for=\"Persuasion\">Persuasion <span class=\"skill\">(Cha)</span></label><input name=\"Persuasion\" placeholder=\"+0\" type=\"text\"><input name=\"Persuasion-prof\" type=\"checkbox\"></li>" +
            "<li><label for=\"Religion\">Religion <span class=\"skill\">(Int)</span></label><input name=\"Religion\" placeholder=\"+0\" type=\"text\"><input name=\"Religion-prof\" type=\"checkbox\"></li>" +
            "<li><label for=\"Sleight of Hand\">Sleight of Hand <span class=\"skill\">(Dex)</span></label><input name=\"Sleight of Hand\" placeholder=\"+0\" type=\"text\"><input name=\"Sleight of Hand-prof\" type=\"checkbox\"></li>" +
            "<li><label for=\"Stealth\">Stealth <span class=\"skill\">(Dex)</span></label><input name=\"Stealth\" placeholder=\"+0\" type=\"text\"><input name=\"Stealth-prof\" type=\"checkbox\"></li>" +
            "<li><label for=\"Survival\">Survival <span class=\"skill\">(Wis)</span></label><input name=\"Survival\" placeholder=\"+0\" type=\"text\"><input name=\"Survival-prof\" type=\"checkbox\"></li>" +
            "</ul>" +
            "<div class=\"label\">Skills</div></div></div>" +
            "</section>" +
            "<div class=\"passive-perception box\"><div class=\"label-container\"><label for=\"passiveperception\">Passive Wisdom (Perception)</label></div><input name=\"passiveperception\" placeholder=\"10\"></div>" +
            "<div class=\"otherprofs box textblock\"><label for=\"otherprofs\">Other Proficiencies and Languages</label><textarea name=\"otherprofs\"></textarea></div>" +
            "</section>" +
            "<section>" +
            "<section class=\"combat\">" +
            "<div class=\"armorclass\"><div><label for=\"ac\">Armor Class</label><input name=\"ac\" placeholder=\"10\" type=\"text\"></div></div>" +
            "<div class=\"initiative\"><div><label for=\"initiative\">Initiative</label><input name=\"initiative\" placeholder=\"+0\" type=\"text\"></div></div>" +
            "<div class=\"speed\"><div><label for=\"speed\">Speed</label><input name=\"speed\" placeholder=\"30\" type=\"text\"></div></div>" +
            "<div class=\"hp\"><div class=\"regular\"><div class=\"max\"><label for=\"maxhp\">Hit Point Maximum</label><input name=\"maxhp\" placeholder=\"10\" type=\"text\">            </div>            <div class=\"current\">              <label for=\"currenthp\">Current Hit Points</label><input name=\"currenthp\" type=\"text\">            </div>          </div>          <div class=\"temporary\">            <label for=\"temphp\">Temporary Hit Points</label><input name=\"temphp\" type=\"text\">          </div>        </div>        <div class=\"hitdice\">          <div>            <div class=\"total\">              <label for=\"totalhd\">Total</label><input name=\"totalhd\" placeholder=\"2d10\" type=\"text\">            </div>            <div class=\"remaining\">              <label for=\"remaininghd\">Hit Dice</label><input name=\"remaininghd\" type=\"text\">            </div>          </div>        </div>        <div class=\"deathsaves\">          <div>            <div class=\"label\">              <label>Death Saves</label>            </div>            <div class=\"marks\">              <div class=\"deathsuccesses\">                <label>Successes</label>                <div class=\"bubbles\">                  <input name=\"deathsuccess1\" type=\"checkbox\">                  <input name=\"deathsuccess2\" type=\"checkbox\">                  <input name=\"deathsuccess3\" type=\"checkbox\">                </div>              </div>              <div class=\"deathfails\">                <label>Failures</label>                <div class=\"bubbles\">                  <input name=\"deathfail1\" type=\"checkbox\">                  <input name=\"deathfail2\" type=\"checkbox\">                  <input name=\"deathfail3\" type=\"checkbox\">                </div>              </div>            </div>          </div>        </div>      </section>      <section class=\"attacksandspellcasting\">        <div>          <label>Attacks &amp; Spellcasting</label>          <table>            <thead>              <tr>                <th>                  Name                </th>                <th>                  Atk Bonus                </th>                <th>                  Damage/Type                </th>              </tr>            </thead>            <tbody>              <tr>                <td>                  <input name=\"atkname1\" type=\"text\">                </td>                <td>                  <input name=\"atkbonus1\" type=\"text\">                </td>                <td>                  <input name=\"atkdamage1\" type=\"text\">                </td>              </tr>              <tr>                <td>                  <input name=\"atkname2\" type=\"text\">                </td>                <td>                  <input name=\"atkbonus2\" type=\"text\">                </td>                <td>                  <input name=\"atkdamage2\" type=\"text\">                </td>              </tr>              <tr>                <td>                  <input name=\"atkname3\" type=\"text\">                </td>                <td>                  <input name=\"atkbonus3\" type=\"text\">                </td>                <td>                  <input name=\"atkdamage3\" type=\"text\">                </td>              </tr>            </tbody>          </table>          <textarea></textarea>        </div>      </section>      <section class=\"equipment\">        <div>          <label>Equipment</label>          <div class=\"money\">            <ul>              <li>                <label for=\"cp\">cp</label><input name=\"cp\">              </li>              <li>                <label for=\"sp\">sp</label><input name=\"sp\">              </li>              <li>                <label for=\"ep\">ep</label><input name=\"ep\">              </li>              <li>                <label for=\"gp\">gp</label><input name=\"gp\">              </li>              <li>                <label for=\"pp\">pp</label><input name=\"pp\">              </li>            </ul>          </div>          <textarea placeholder=\"Equipment list here\"></textarea>        </div>      </section>    </section>    <section>      <section class=\"flavor\">        <div class=\"personality\">          <label for=\"personality\">Personality</label><textarea name=\"personality\"></textarea>        </div>        <div class=\"ideals\">          <label for=\"ideals\">Ideals</label><textarea name=\"ideals\"></textarea>        </div>        <div class=\"bonds\">          <label for=\"bonds\">Bonds</label><textarea name=\"bonds\"></textarea>        </div>        <div class=\"flaws\">          <label for=\"flaws\">Flaws</label><textarea name=\"flaws\"></textarea>        </div>      </section>      <section class=\"features\">        <div>          <label for=\"features\">Features &amp; Traits</label><textarea name=\"features\"></textarea>        </div>      </section>    </section>  </main></form></body></html>";




    }
}
