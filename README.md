# Samurai-Game
this is a unity Game project for mobile. In this game player will have to deal with the enemies that are coming towards to him.
The samurai that is in our controll can not move. it can only atack and deflect. The player will be static and the enemies will be moving.
depending on the enemy, the player will have to deflect, atack or both in an order which is determined by the kind of enemy in order to defeat the enemy that is coming towards the player.
The player will be standin at the left side of the screen, and the enemies will coming towards from the right side of the screen. These are the main mechanics, further mechanics is not guarrantied to be added.

**A) Write a small pet project to get into coding again. The code in GitHub can be relatively simple (e.g., a game with console output). The doc can be short! (in contrast to the one below)**

**B**) Make sure each person has applied the following topics on the code which have been taught in the lecture:

1. Use and understand **GIT,** and be able to apply the basic commands. Can you experiment with time travelling or branches/merges? E.g. add some screenshots, add a paragraph text or show by reference/link into the commits, that you applied all the commands.
   
2. **UML:** at least **3** big different diagrams. "big" means you can pump it up artificially as written in DDD. You have 10 million $ from me! Please export the pics. I can not install all the tools to view them! For example, these diagrams are a good idea: Use-Case, Component D, Class D, and Activity Diagram.

SOLUTIONS:

Use-Case Diagram:

![image](https://github.com/user-attachments/assets/473672be-0f31-45d6-b0f1-f1ff20268557)


Class Diagram (not final):


![image](https://github.com/user-attachments/assets/bc7d1245-91fa-4710-a165-5475689c3428)


    

3. **REQUIREMENTS**: Create 5-10 good requirements for your project. Then put them into a simple tool (like Airtable, Notion or Trello) and a professional tool (like Monday, Jira, Doors, ObjectIF, Xebrio, etc.) Instead of the professional version, you can also build a tool yourself; e.g. with AI! If you have used AI / LLMs here, briefly describe where and how! However, it is more important here that some / many attributes are used!

   SOLUTIONS: non professional tool:
   [https://www.notion.so/Requirements-Engineering-for-Samurai-Game-15010139db9b8007bd93ebcbddd6c6d0](https://www.notion.so/invite/acd3f923c77d31aec91f7f6bd9e27ac8cb905568)
   ![image](https://github.com/user-attachments/assets/f8bb7b9a-350d-466d-a655-05d7c26892a2)

      Professional tool(Monday.com): The requirement details are written inside. When clicked on the requirement, a page shows up, and at that page click on the "item description" page to see the details.
      They are exactly the same requirements as the ones in notion.
   https://fahren1te.monday.com/boards/1743098787
   
   ![image](https://github.com/user-attachments/assets/1196ce4e-b168-4d67-add1-dc186345f8ea)


   



4. **ANALYSIS**: **A)** Think about your checklist (on an extra A4 page) from all the points of the ‘ANA - Analysis’ learning unit, with the points that you consider relevant for your project (e.g. 10-15 instead of 30 on the overall picture) **B)** Carry out an analysis of your semester project / your favourite project. Or have a start-up idea and would like to hand in the start-up analysis as part of a large documentary! There should be at least 2 pages. Take the 10-15 points from the checklist (with e.g. 1-2 paragraphs per point). Assume that you will soon have a fishing rod for the start-up chapter. If you are successful, you would receive a lot of ‘money’ in order to be allowed to design and implement it later. So get your start-up off to a successful start!The use of large language models is explicitly encouraged here! However, don't try to solve everything with one prompt and then submit 10 pages: get specific help!
Provide the prompts in brackets that have helped you to improve or structure something here! Please find the sweet spot between your own work/testing and content generation in order to learn something yourself throughout the entire process!

5. A) **DDD**: **(A)** Do an Event-Storming to find your Domains! If your domain is too small, invent other domains around and document these domains (as if you have 100 Mio € from Edlich-Investment!) **(B)**. Drop your Domains into a Core Domain Chart **(C)** and indicate the Relations = Mappings (! see MIRO examples again) between the Domains in a new diagram!

   SOLUTION:   https://miro.com/welcomeonboard/eTNtYUpBTFdheXBydXFRd2lPbkxRUmIxM0NyM0NYUFFVUnRNVXhwYWpWMXM3emErMmM1OTFkU2Iva09GcTJDdmRkM1Q3YU5ocnFkbnZLL2tWWDE5SFRrVGR0SUxuaTIvdTdsdDJEemc4NWhuTDBEZUs5OWpIMVR1MlhXOVJnWGEhZQ==?share_link_id=880248275322
![Samurai-game DDD (1)](https://github.com/user-attachments/assets/1ee3ae36-1653-44ae-8eac-68f9b63c7530)



6. **METRICS:** at least two. Sonarcube would be great. Other non-trivial metrics are also fine.
    
7. **CLEAN CODE DEVELOPMENT:** A) At least 5 points you can show me with an explanation of why this is clean code in your code and/or what has improved & B) >>10 points on your personal CCD cheat sheet. E.g. a PDF.
    
8. **REFACTORING**: Show me two (non-trivial) Refactoring Examples of your code! Showing the original content and the refactored code! Explain what happened, why and how it has improved! Again: do not send me pure AI work!
    
9. **BUILD** Management with any Build System as Ant, Maven, Gradle, etc. (only Travis is perhaps not enough) Do e.g. generate Docs, call tests, etc. (it could also be disconnected from the project just to learn a build tool!) => to be merged with 7!
    
10. **CONTINOUS DELIVERY:** show me your pipeline using e.g. **Jenkins**, **GitHub Actions**, GitLab CI, etc. E.g. you can also use Jenkins Pipelining or BlueOcean, etc. But at least insert more than 2 script calls as done in the lecture! (e.g. also call Ant or Gradle or something else).
    
11. Integrate some nice **UNIT TESTS** in your Code to be integrated into the Build!
    
12. Use a good **IDE** and get fluent with it: e.g. VSCode, IntelliJ. What are your favourite key shortcuts?!

   SOLUTIONS: I prefer visual studio 2022, and here are my favorite shortcuts:



   CTRL + K + C: make the selected lines comment  
    ![image](https://github.com/user-attachments/assets/350fc89a-940f-443e-8915-c0d84be49ad4)

   CTRL + R + R: renames a variable, changing its name everywhere that is is referanced
   ![image](https://github.com/user-attachments/assets/19637f3d-3f5e-473e-8e41-6337f19273ba)

   By far the BEST shortcut is
   ALT + up arrow, or down arrow: this was you can move a line of code up or down
   ![moving-line-up-or-down](https://github.com/user-attachments/assets/5d8057da-bce6-44ad-8faf-8d69c89dd62d)

   CTRL + M + M: open or close an outlining
  
   ![open-method-or-close](https://github.com/user-attachments/assets/cb04dbf8-a1b1-4bf1-9fec-64d1e57afbce)


13. **AI Coding**: Set Up an AI-coding environment on your computer like ZED, Aider, etc. Show your steps and personal experiences! ([ref](https://newsletter.pragmaticengineer.com/p/ide-that-software-engineers-love))
    
14. **FUNCTIONAL PROGRAMMING:** prove that you have covered all functional aspects in your code as:
    - only final data structures
    - (mostly) side-effect-free functions
    - the use of higher-order functions
    - functions as parameters and return values
    - use closures / anonymous functions
    - You can also do it outside of your project. Even in other languages such as F#, Clojure, Julia, etc.
      
15. Set up a running **AI Coding** environment! Prove it by coding something small.
    
