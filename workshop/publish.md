---
title: Publish
layout: default
type: workshop
date: 2021-04-11
Author: Phoenixx19
comments: false
toc: false
pinned: false
---

<script>
    function SingleDisplay(element) {
        document.getElementById(element).classList.add('out');
        document.getElementById(element).style.display = "block";
        setTimeout(() => {
            document.getElementById(element).classList.remove('out');
        }, 150);
    }

    function Display(element, secondElement) {

        document.getElementById(element).classList.add('out');
        setTimeout(() => {
            document.getElementById(element).classList.remove('out');
            document.getElementById(element).style.display = "none";
            document.getElementById(secondElement).classList.add('out');
            document.getElementById(secondElement).style.display = "block";
            setTimeout(() => {
                document.getElementById(secondElement).classList.remove('out');
            }, 150);
        }, 150);
    }
</script>

<div class="publish">
    <div class="hidden" id="home" style="display: block;">
        <h2>Add your creations on the workshop!</h2>
        <p>
            Would you like to release the map/level on the site?<br>
            ...or you have a reskin you want to publish?<br>
            ...or you have a fullfledged collection you would like to add?
        </p>
        <p>Proceed by choosing the type of your creation.</p>
        <div class="div-button" style="background:url(https://media.discordapp.net/attachments/771125324846858261/859834847589302332/unknown.png) no-repeat center;background-size: cover;">
            <a class="button level" onclick="Display('home', 'level-1')">Upload your level</a>
            <ion-icon name="map"></ion-icon>
        </div>
        <div class="div-button" style="background:url(https://media.discordapp.net/attachments/758021625252806739/883792892567638117/dapizzaishere.png) no-repeat center;background-size: cover;">
            <a class="button skins" onclick="Display('home', 'skins-1')">Upload your reskin or collection</a>
            <ion-icon name="layers"></ion-icon>
        </div>

        <hr style="margin:4rem 0;">

        <h3>Psst... hey... are you looking for some level tips?</h3>
        
        <div class="div-button" style="background:url(https://pbs.twimg.com/media/EreQjhKXIAI6wv6?format=jpg) no-repeat center;background-size: cover;">
            <a class="button tips" onclick="Display('home', 'tips')">
                Yes, give me some!
            </a>
            <ion-icon name="rocket"></ion-icon>
        </div>
    </div>

    <div class="hidden" id="level-1">
        <h2>Level publishing guidelines</h2>
    
        <p>Level design in Jump King is a delicate balance between <strong>fairness</strong> and <strong>hardness</strong>.</p>
        
        <p>These rules are not only made to prevent unfair and impossible levels but to respect Nexile's original ideas on mapping. Also in order to get your map approved on the site, these rules <strong>need</strong> to be followed.</p>

        {% include rules/levels.html %}

        <span class="button">
            <a class="button" onclick="Display('level-1', 'level-2')">I agree on the guidelines</a>
        </span>
    </div>

    <div class="hidden" id="skins-1">
        <h2>Skins and collections publish guidelines</h2>

        {% include rules/reskins.html %}

        <span class="button">
            <a class="button" onclick="Display('skins-1', 'skins-2')">I agree on the guidelines</a>
        </span>
    </div>

    <div class="hidden" id="level-2">
        <h2>Next step</h2>
        
        <p>To get it published on the site, fill in the following Google Form where it will get verified by one the level publisher testers.</p>
        
        <p>The .zip file should contain your mods folder and only the files needed for the level custom. Please host the level yourself, the JumpKingPlus' GitHub repository does not work as a cloud!</p>
        
        <span id="level-2-button" class="button">
            <a class="button" onclick="Display('level-2-button', 'level-form')">Show me the form</a>
            &nbsp;
            <a href="https://docs.google.com/forms/d/e/1FAIpQLSdNW8MMBcqeQVjTW8va8ZQXq1-txXwDukQTzHqq8c8iLpTfgA/viewform" target="_blank">Open form in a new window<ion-icon name="open"></ion-icon></a>
        </span>

        <iframe id="level-form" style="
            display: block;
            border: none;
            height: 100vh;
            width: 100%;
            margin-top: 2.5em;
            display: none;"
            src="https://docs.google.com/forms/d/e/1FAIpQLSdNW8MMBcqeQVjTW8va8ZQXq1-txXwDukQTzHqq8c8iLpTfgA/viewform?embedded=true">
            Loading...
        </iframe>

        <!-- <iframe src="https://docs.google.com/forms/d/e/1FAIpQLSdNW8MMBcqeQVjTW8va8ZQXq1-txXwDukQTzHqq8c8iLpTfgA/viewform?embedded=true" width="700" height="700" frameborder="0" marginheight="0" marginwidth="0" scrolling="auto">Loading…</iframe> -->
    </div>

    <div class="hidden" id="skins-2">
        <h2>Next step</h2>

        <p>To get it published on the site, fill in the following Google Form where it will get verified by the reskins/collection manager (MERNY#8542).</p>

        <p>The .zip file should contain your reskin or collection texture and only the xml needed for the reskin or collection. For reskins and collections, we can host your reskin since it's a small file.</p>

        <span id="skins-2-button" class="button">
            <a class="button" onclick="Display('skins-2-button', 'skins-form')">Show me the form</a>
            &nbsp;
            <a href="https://docs.google.com/forms/d/e/1FAIpQLSdBNK3Y1VTlHCBeHw8EdBDllwlgwyza06HSE-on7E3HgGbTHA/viewform" target="_blank">Open form in a new window<ion-icon name="open"></ion-icon></a>
        </span>

        <iframe id="skins-form" style="
            display: block;
            border: none;
            height: 100vh;
            width: 100%;
            margin-top: 2.5em;
            display: none;"
            src="https://docs.google.com/forms/d/e/1FAIpQLSdBNK3Y1VTlHCBeHw8EdBDllwlgwyza06HSE-on7E3HgGbTHA/viewform?embedded=true">
            Loading...
        </iframe>
    </div>

    <div class="hidden" id="tips">
        <h3>Level design tips</h3>

        <p>Here are some secret tips that you can pick to make a great level. You don't necessarily need to follow any of these below.</p>

        <h4>10 Level and art design tips</h4>
        <ol>
            <li>Write down your locations before starting with the level design; this will help you through the level design</li>
            <li>Make your platforms easy to navigate</li>
            <li>Don't exaggerate with the teleport blocks and make sure you can fall all way to the start of your level (unless you want checkpoints)</li>
            <li>Don't create a level which focuses only on one mechanic of the game</li>
            <li>Testing is a very important part, so don't forget to ask for an helping hand when it comes to testing</li>
            <li>Create your level as detailed and unique as possible</li>
            <li>Make sure your art design is made in the native Jump King resolution (480px x 360px)</li>
            <li>Make it as immersive as possible using music, SFX (Sound Effects), background to your advantage</li>
            <li>Try to create your own props, compositions instead of using the originals from Jump King, unless it's really necessary</li>
            <li>Make sure that you have a good segue between locations in the screens (background, midground)</li>
        </ol>
        <p>"Secret mapper tips" by Phoenixx19 and MERNY.</p>

        <hr>

        <h4>Very detailed tips from Babe of Ascension's creator</h4>
        <ol>
            <li>Don't have your level just be brutally hard just because you want to compete with whose level is the hardest, and don't have it be lazy 1 block jump after 1 block jump.</li>
            <li>Try to make something new! Make some gameplay no one has ever seen before, the combination of other gimmicks can help with that, just don't get too crazy with things like sand and ice, try and mess around with some unique room layouts with just the normal block and either build off of it or smooth it out to make it better to play.</li>
            <li>You can have your level inspired by other areas from the original Jump King or even other custom levels for that matter, just don't have them be direct copies, and don't take inspiration off of Underberg's gameplay. Just don't.</li>
            <li>Sketch out area ideas or just ideas for the level in general with some paper and pencil, or a drawing program if that suits your fancy better. Really think about what you're doing to be doing with your level, like what are the areas' themes and ideas?</li>
            <li>Make sure your level is well balanced and doesn't have super easy areas along with extreme difficulty spikes, like Underberg to Lost Frontier for example.</li>
            <li>Don't have constant ridiculous falls, like 8-15 screen falls everywhere. You can have those kind of falls just don't have many, take Towers in maps, they'll have super long falls if you mess up on the sides, so don't have those long falls in most places in your level.</li>
            <li>Try to avoid having random extreme jumps within levels, they make the level repetitive and grindy.</li>
            <li>Don't spam gimmicks in your level, ex: wind + sand in one area, and water + ice on the next.</li>
            <li>Think about the player, what are they doing to think about this thing in your level, what are they going to think about that thing in your level. Don't think in your head when designing your level, think inside someone elses.</li>
            <li>Playtesters. A recommendation of 3-5 playtesters is good to have your level be improved from others' opinions and thoughts on it. This adds on to tip #9 about you don't want to just think in your own head, get others' thoughts and opinions.</li>
            <li>Don't have your gameplay be difficult or designed in a way that makes someone want to just not play your level anymore, not due to rage, but due to just bad level design. If you have thoughts on this happening to your level, do a full run on it, along with your other playtesters to see if this reaction happens.</li>
        </ol>
        <p>"11 Tips" by IntroCar.</p>
    </div>
</div>