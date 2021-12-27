---
layout: post
title: Transparency and Security about JumpKingPlus
date: 2021-08-03
Author: Phoenixx19
tags: [info, not-release]
comments: false
toc: true
pinned: true
hidden: false
---

This is an in-depth blog post about the **transparency** and **security** concerns about JumpKingPlus that people could have.<br>
In this post, every possible concern (that could be found by *kebb#9498*) will be explained and clarified.

Before talking about this, I highly suggest you to join the **official Nexile / Jump King Discord server**, also to give more proof that this is safe, that can be found by clicking on the following badge. <a href="https://discord.gg/dUk9FPDNVq"><img src="https://badgen.net/discord/members/dUk9FPDNVq?style=flat-square" alt="Discord Badge" style="margin: 0 .1rem;display:inline-block;vertical-align:sub;"></a>

<!-- more -->
<hr>

## Who's behind JumpKingPlus?

My name is **Phoenixx19** (or Andrea).<br>
I am the founder and main JumpKingPlus developer, repository and website creator. Also one of the owners of the [__official JumpKingPlus' YouTube channel__](https://youtube.com/channel/UCPanZmDtq5azWY_OY9XKD5w). You can contact me through these following links:
- **Phoenixx19#0001** on Discord (add me for more inquiries about JumpKingPlus or about me)
- [**@phxx19**](https://www.twitter.com/phxx19) on Twitter
- [**Phoenixx19**](https://github.com/Phoenixx19) on Github



<hr>

## Clarifications about JumpKingPlus 

The most common question that everyone wants to know on first glance:

### Is JumpKingPlus safe to install?

Yes, it is safe to install.

The modded version of the executable file (JumpKing.exe), the dynamic library link (JumpKingPlus.dll) and the JumpKingPlusInstaller (the executable file that is used to install JumpKingPlus) are all **open source**.

- The __modded JumpKing.exe__ file can be accessed using a debugger. My personal choice is [**dnSpy**](https://github.com/dnSpy/dnSpy/releases/latest) for its relative simplicity in coding and reading code, but you can use anything that decompiles C#.
- The __JumpKingPlus.dll__ source code, which is used together with the modded JumpKing executable, can be found inside the main [__Github repository__](https://github.com/Phoenixx19/JumpKingPlus/tree/master/JumpKingPlus/JumpKingPlus).
- The __JumpKingInstaller__ has been made recently  open source, the code used in the [__Github repository__](https://github.com/Phoenixx19/JumpKingPlusInstaller) is still used nowadays on the installer.

The installer was made public and open source because of recently; the goal of making it public recently was to proof that the installer installs only the strict necessary. Made with [WixSharp installer library](https://wixtoolset.org/).

### Is this a virus, does it have malware?
I can not stress this enough; it is **NOT** a virus.

JumpKingPlus is open source, has hundreds of downloads, speedrunners use it for its fast reset time along with other features. If you need proof, head back to the [__FAQ page__]({{ site.baseurl }}/faq).

### Is this even official?
__Not official by Nexile, but approved by Nexile.__

There are multiple occasions where official Nexile developers endorsed it or shown interest on it:

<div class="swiper-container mySwiper">
    <div class="swiper-wrapper">
        <div class="swiper-slide">
            <blockquote class="twitter-tweet"><p lang="en" dir="ltr">Cool mod! <a href="https://t.co/cvsia7kYgj">https://t.co/cvsia7kYgj</a></p>&mdash; Nexile (@nexilegames) <a href="https://twitter.com/nexilegames/status/1325429701549027333?ref_src=twsrc%5Etfw">November 8, 2020</a></blockquote> <script async src="https://platform.twitter.com/widgets.js" charset="utf-8"></script>
        </div>
        <div class="swiper-slide">
            <blockquote class="twitter-tweet"><p lang="en" dir="ltr">Exciting to see the community devoting many hours into fan made content! Fan made maps even. <a href="https://t.co/dj34hSLnlJ">https://t.co/dj34hSLnlJ</a></p>&mdash; Nexile (@nexilegames) <a href="https://twitter.com/nexilegames/status/1419312990705291268?ref_src=twsrc%5Etfw">July 25, 2021</a></blockquote> <script async src="https://platform.twitter.com/widgets.js" charset="utf-8"></script>
        </div>
        <div class="swiper-slide">
            <a href="https://discord.com/channels/547420017738907657/547442326927179778/868872288139878461" target="_blank">
                <img src="https://github.com/Phoenixx19/JumpKingPlus/raw/www/images/announcement.png" alt="Thomas' blessing">
            </a>
        </div>
    </div>
    <div class="swiper-pagination"></div>
    <div class="swiper-button-next"></div>
    <div class="swiper-button-prev"></div>
</div>

<!-- Swiper JS -->
<link rel="stylesheet" href="https://unpkg.com/swiper/swiper-bundle.css" />
<link rel="stylesheet" href="https://unpkg.com/swiper/swiper-bundle.min.css" />
<script src="https://unpkg.com/swiper/swiper-bundle.js"></script>
<script src="https://unpkg.com/swiper/swiper-bundle.min.js"></script>

<!-- Initialize Swiper -->
<script>
    var swiper = new Swiper(".mySwiper", {
    slidesPerView: "auto",
    centeredSlides: true,
    autoplay: {
        delay: 5000,
        disableOnInteraction: true,
    },
    spaceBetween: 20,
    loop: true,
    pagination: {
        el: ".swiper-pagination",
        clickable: true,
    },
    navigation: {
        nextEl: ".swiper-button-next",
        prevEl: ".swiper-button-prev",
    },
    });
</script>

### Can workshop maps have viruses?
No.

A map or custom level; to get approved onto the site, needs to go through a Google Forms application on the Workshop section of the site.
In a couple days, the creator will get in contact with one of the *"JumpKingPlus custom levels team"* through Discord about the custom level.

The only type of files that a published map should have inside of the `mods` folder are:
- `.xnb` (packed MonoGame images or music)
- `.xml` (various settings files)
- readable `.txt` or `.xml` variants (like `.ravset` also known as the bird settings)

There is __nothing in a custom level that can be used to inject malware__ or viruses however, __every other file is strictly prohibited__ and the map application will still be rejected.

### What dependencies JumpKingPlus has?

`¯\_(ツ)_/¯` idk just a discord rpc library

[![Readme Card](https://github-readme-stats.vercel.app/api/pin/?username=Lachee&repo=discord-rpc-csharp&show_owner=true)](https://github.com/anuraghazra/github-readme-stats)


