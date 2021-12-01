---
layout: wsdocs
title: Screen
parent: Modding
nav_order: 4
---

# Screens folder
{: .no_toc }

contains textures such as background, foreground, midground, scrolling images and masks.
{: .fs-6 .fw-300 }

All of the layers together of a screen can make this result (*without counting the hidden wall because that's a type of prop*):

![Example Image](https://raw.githubusercontent.com/Phoenixx19/JumpKingPlus/www/workshop/files/final.jpg)

Every layer has it's own name, format and folder.<br>The following list will go from back to front.

## Table of contents
{: .no_toc .text-delta }

1. TOC
{:toc}

## Background
At the lowest ground there's the background.
The background is usually used for **skies or gradients** to put back on a certain or multiple screens.<br>
The name of the file should be `bg(SCREEN NUMBER).xnb`, or as an example, `bg1.xnb`.

![BG](https://raw.githubusercontent.com/Phoenixx19/JumpKingPlus/www/workshop/files/background.png)

<br>

## Scrolling images

<div class="ws-buttons"><a class="ws-button" href="https://raw.githubusercontent.com/Phoenixx19/JumpKingPlus/www/workshop/files/scroll.xml"><ion-icon name="code-slash"></ion-icon> Example scroll.xml</a></div>

The scrolling texture is usually used for **clouds or birds** flying in the distance (*behind the player*).

The scrolling images are managed by an .xml file, that determines their texture, position, velocity and layer mode (see example scroll.xml above). The texture name should be the same of the name file. Which means if you created a new scrolling texture called `clouds.xnb` the name of the texture inside the scroll setting file should be `<texture>clouds</texture>`.

![Scrolling](https://raw.githubusercontent.com/Phoenixx19/JumpKingPlus/www/workshop/files/scroll.png)

<br>

## Midground
Right after the scrolling images, there's the midground.
The midground is usually used for **platforms and details** that want to be **behind the player** (the player can go over them).
The name of the file should be `(SCREEN NUMBER).xnb`, or as an example, `1.xnb`.

![MG](https://raw.githubusercontent.com/Phoenixx19/JumpKingPlus/www/workshop/files/midground.png)

<br>

## Masks
Masks (and so particles) are above the player layer-wise.
Masks can be used to give more depth to the level, some examples of masks are ash, rain and snow. The mask lets you **display the particles effect only on the blue/cyan mask you are creating**.

The animated backgrounds are stored inside the default `particles` folder, to add a particle effect [**head over the particles section**]().

The name of the file should be `(MASK NAME)mask(SCREEN NUMBER).xnb`, or as an example `light_snow_bgmask1.xnb`.

![Mask](https://raw.githubusercontent.com/Phoenixx19/JumpKingPlus/www/workshop/files/mask.png)

> Removing a mask inside a screen that has already a particle effect (written on `particles/weather.xml`) will display the effect on the whole screen.

<br>

## Foreground
The foreground work one layer above the masks and particles.
The foreground is used for **details that are in front of the player**, such as vines or grass.
The name of the file should be `fg(SCREEN NUMBER).xnb`, or as an example, `fg1.xnb`.

![FG](https://raw.githubusercontent.com/Phoenixx19/JumpKingPlus/www/workshop/files/foreground.png)