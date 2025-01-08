# Lost Ronin game
this is a unity Game project for mobile. In this game player will have to deal with the enemies that are coming towards to him.
The samurai that is in our controll can not move. it can only atack and deflect. The player will be static and the enemies will be moving.
depending on the enemy, the player will have to deflect, atack or both in an order which is determined by the kind of enemy in order to defeat the enemy that is coming towards the player.
The player will be standin at the left side of the screen, and the enemies will coming towards from the right side of the screen. These are the main mechanics, further mechanics is not guarrantied to be added.




I will briefly explain how the development works with the engine, and with the codes. I in Unity developments, code files are called scripts. I will refer to them as scripts from now on. Unity provides a UI that allows to create some components,
and also allows those components to interract with each other. How does that work? in Unity there are scenes. A scene can contain Objects, where other scenes may not have. A scene may not have a connection with an other scene. You can think of this like a playground, where a playground has kids playing. They are all playing in that scene, but may not have any corrolation between some other playground.

![image](https://github.com/user-attachments/assets/fcacccd0-14a6-4dfa-acfa-e3139a81eac6)-------> scenes

In those scenes there are objects, you can think of them as kids playing in the playground. In unity, scripts can be attached the objects, basicly giving them controllablity. If a script is attached to an object, the specified actions in the script, are applied on the object that is is attached to. For example: there is an object called Player, and the script that is attached to the player says: If(input is a) {move to the right} and whenever a is pressed object moves to the right. 

![image](https://github.com/user-attachments/assets/38def441-064a-4bf7-a218-f0e87f3010cf)-------> Objects

Alongside with scripts, there are also components that can be attached, in order to give in some specific abilities to the object. For example: when rigidbody2D component is attached to the object, physics can be applied to the object, or if a collider is applied to an object, whenever some other object enters the collision area, the script that is attached to the first object, gets notified via a method when there is a collison.

![image](https://github.com/user-attachments/assets/9841ed57-0aaf-477b-a6bc-7948705f745c)


The Engine makes these iteractions possible, because the scripts inherit from a class which is called MonoBehaviour. Every class has to be inheriting from MonoBehaviour class or these interactions would not be possible. That is why some methods are actually inherited from other classes that MonoBehaviour inherits. Here are some example methods: Start(), Update(), OnTriggerEnter2D().

![image](https://github.com/user-attachments/assets/46ea586c-0736-48ed-86d1-65161c83f896) ![image](https://github.com/user-attachments/assets/2f92e08a-ce0c-41c1-a86c-0514e585d967)![image](https://github.com/user-attachments/assets/e363ce2f-3192-4d37-8399-a672fa052ff6)



The Some objects are saved in the scenes, therefore they are not able to be seen in the files (Unless they are prefabs).  

![image](https://github.com/user-attachments/assets/40405239-ecca-489e-9035-4cf26b84f028) ----------------->![image](https://github.com/user-attachments/assets/999d7e89-d2ca-4a5b-b632-2bea2ed1cb6d)

Here is the general UI of the Unity game engine:
![image](https://github.com/user-attachments/assets/69aa19cc-a652-41c4-a3b8-c98745b9d346)

Please note that the without the game engine the codes might not work. Neighter the engine nor the scripts can work without one an other. Thats why I will be putting the game's demo on the build file. 

Scripts are in the **Assets > Scripts** file.

.

.

.

.

.

**A) Write a small pet project to get into coding again. The code in GitHub can be relatively simple (e.g., a game with console output). The doc can be short! (in contrast to the one below)**

**B**) Make sure each person has applied the following topics on the code which have been taught in the lecture:

1. Use and understand **GIT,** and be able to apply the basic commands. Can you experiment with time travelling or branches/merges? E.g. add some screenshots, add a paragraph text or show by reference/link into the commits, that you applied all the commands.

   SOLUTIONS (SCREENSHOTS):

   staging files:
   ![staging-files](https://github.com/user-attachments/assets/aa37fc0b-54f9-44a0-bfe3-779e860356d7)
   
   .
   
   and destaging them:
   ![unstaging](https://github.com/user-attachments/assets/7f33cd5a-7de8-4bb2-954d-253d497ccb48)
   
   .
   
   .
   
   committing files and pushing them: 
   ![commit-and-push](https://github.com/user-attachments/assets/918f0516-7984-4de3-b9fd-52a406578144)
   
   .
   
   creating and deleting branches:
   ![branching](https://github.com/user-attachments/assets/487b3d09-1deb-48ff-bc46-363efd5d1837)

   .

   Reverting a commit:
   ![removing-features](https://github.com/user-attachments/assets/d3a9a2b6-981c-4b18-9ddc-08dd40dbec50)

   .

2. **UML:** at least **3** big different diagrams. "big" means you can pump it up artificially as written in DDD. You have 10 million $ from me! Please export the pics. I can not install all the tools to view them! For example, these diagrams are a good idea: Use-Case, Component D, Class D, and Activity Diagram.

SOLUTIONS:

.

I don't know if the links are working or not therefore I am also attaching the photos of the uml diagrams

.

Use-Case Diagram:

https://lucid.app/lucidchart/c3b0c051-3b11-4cda-8739-fc89dce105da/edit?viewport_loc=-358%2C-1242%2C3132%2C1672%2C0_0&invitationId=inv_5bc9d4e5-8ee8-4d85-b044-323568979755
![image](https://github.com/user-attachments/assets/473672be-0f31-45d6-b0f1-f1ff20268557)


Class Diagram (not final):

.

This is class diagram of my project, I said it is not final because it gets updated with every change I make naturally.

https://lucid.app/lucidchart/048a0c23-a577-42be-bc89-8a74fee67523/edit?viewport_loc=-1803%2C-1310%2C3316%2C1770%2C0_0&invitationId=inv_5076c84a-09b7-4485-bc53-d09012d8281e
![image](https://github.com/user-attachments/assets/bc7d1245-91fa-4710-a165-5475689c3428)


Component Diagram:

.

As explained in the beginning, the project cannot be exist without the Engine. I have also made a more complicated one, but unfortunately the app that I used limited my use of objects. 
I am also attaching that in case if you would like to know.
.

**MAIN DIAGRAM**
https://lucid.app/lucidchart/4ed20f63-7c15-485b-8b92-a2468c48d67f/edit?viewport_loc=-908%2C-1040%2C4698%2C2508%2C0_0&invitationId=inv_c3b48f94-7638-4f05-acb7-fa328df6cfc3    
![image](https://github.com/user-attachments/assets/869c2aa7-317d-48bc-99d1-e8ec21d4df2d)

.

**UNUSED DIAGRAM (NOT FINISHED)**
![image](https://github.com/user-attachments/assets/86e11626-2d62-4cb8-b4d9-c999ce9b6078)

.


3. **REQUIREMENTS**: Create 5-10 good requirements for your project. Then put them into a simple tool (like Airtable, Notion or Trello) and a professional tool (like Monday, Jira, Doors, ObjectIF, Xebrio, etc.) Instead of the professional version, you can also build a tool yourself; e.g. with AI! If you have used AI / LLMs here, briefly describe where and how! However, it is more important here that some / many attributes are used!

   SOLUTIONS: non professional tool:
   [https://www.notion.so/Requirements-Engineering-for-Samurai-Game-15010139db9b8007bd93ebcbddd6c6d0](https://www.notion.so/invite/acd3f923c77d31aec91f7f6bd9e27ac8cb905568)
   ![image](https://github.com/user-attachments/assets/f8bb7b9a-350d-466d-a655-05d7c26892a2)

      Professional tool(Monday.com): The requirement details are written inside. When clicked on the requirement, a page shows up, and at that page click on the "item description" page to see the details.
      They are exactly the same requirements as the ones in notion. Unfortunately my trial for the monday.com is ended and this page is not accessible I think. All I have is this screenshot I took.
   https://fahren1te.monday.com/boards/1743098787
   
   ![image](https://github.com/user-attachments/assets/1196ce4e-b168-4d67-add1-dc186345f8ea)


   



4. **ANALYSIS**: **A)** Think about your checklist (on an extra A4 page) from all the points of the ‘ANA - Analysis’ learning unit, with the points that you consider relevant for your project (e.g. 10-15 instead of 30 on the overall picture) **B)** Carry out an analysis of your semester project / your favourite project. Or have a start-up idea and would like to hand in the start-up analysis as part of a large documentary! There should be at least 2 pages. Take the 10-15 points from the checklist (with e.g. 1-2 paragraphs per point). Assume that you will soon have a fishing rod for the start-up chapter. If you are successful, you would receive a lot of ‘money’ in order to be allowed to design and implement it later. So get your start-up off to a successful start!The use of large language models is explicitly encouraged here! However, don't try to solve everything with one prompt and then submit 10 pages: get specific help!
Provide the prompts in brackets that have helped you to improve or structure something here! Please find the sweet spot between your own work/testing and content generation in order to learn something yourself throughout the entire process!

5. A) **DDD**: **(A)** Do an Event-Storming to find your Domains! If your domain is too small, invent other domains around and document these domains (as if you have 100 Mio € from Edlich-Investment!) **(B)**. Drop your Domains into a Core Domain Chart **(C)** and indicate the Relations = Mappings (! see MIRO examples again) between the Domains in a new diagram!

   SOLUTION:   https://miro.com/welcomeonboard/eTNtYUpBTFdheXBydXFRd2lPbkxRUmIxM0NyM0NYUFFVUnRNVXhwYWpWMXM3emErMmM1OTFkU2Iva09GcTJDdmRkM1Q3YU5ocnFkbnZLL2tWWDE5SFRrVGR0SUxuaTIvdTdsdDJEemc4NWhuTDBEZUs5OWpIMVR1MlhXOVJnWGEhZQ==?share_link_id=880248275322
![Samurai-game DDD (1)](https://github.com/user-attachments/assets/1ee3ae36-1653-44ae-8eac-68f9b63c7530)



6. **METRICS:** at least two. Sonarcube would be great. Other non-trivial metrics are also fine.

SOLUTIONS:
   **Visual studios build in Metrics**: How to access?
   By choosing the Analyze > Calculate Code Metrics menu command within Visual Studio.
   ![How-to-open-metrics-2](https://github.com/user-attachments/assets/4b8c9a9f-9cae-483d-9bc7-62b0d41b5d73)

   The first thing that got my attention was Unnecesarry files (marked with yellow). I was unsing some free assests for my project, and they came up with also scripts, which were unneeded.
   ![image](https://github.com/user-attachments/assets/4c5202fd-40c1-4fc7-b921-b22f3fb219b8)

   .
   
   It also made an error list to show the potential performance errors: 
   ![image](https://github.com/user-attachments/assets/f91c0646-49ef-4a48-8bcc-89d0b72abf98)
   
   I fixed all of them with refactoring (Except one because I will fill that later).
   ![image](https://github.com/user-attachments/assets/e2bb5dc4-c7d2-4551-bdb1-fff4d945221b)


   **NDepend:** this is a great tool for deep analisys for C# projects. NDepend is really easy to use and set. The only bad thing is that it is not for free. Currently I am using the trial version. But I will defitively have it in mind that if some day I need a metric for a C# project, NDepend is a great tool.    
   
![image](https://github.com/user-attachments/assets/ffc2bbfc-54e5-4871-ad60-bed4a03f9648)

.

I have found out that it takes some time for program to locate the codes. This makes so much sense, because before I arrenged the code files according to components. I put enemy classes together, but those enemy classes provide information to some player classes. Therefore it takes more time for that information to reach. It will look messier, but in terms of performance, it will be better
![image](https://github.com/user-attachments/assets/0ac03ea4-70eb-4cb6-a94f-3bdf836c962e)

.
I putt them all in the same file. I will find and other way to short them but for now I will leave it as be. And code quality increased when I did.
![image](https://github.com/user-attachments/assets/a38aef47-5f69-4b16-856e-4329621f5ad4) ![image](https://github.com/user-attachments/assets/ea30f7b8-93cd-4ece-8b94-d3d5eae5ed8a)


.
    
7. **CLEAN CODE DEVELOPMENT:** A) At least 5 points you can show me with an explanation of why this is clean code in your code and/or what has improved & B) >>10 points on your personal CCD cheat sheet. E.g. a PDF.
    
8. **REFACTORING**: Show me two (non-trivial) Refactoring Examples of your code! Showing the original content and the refactored code! Explain what happened, why and how it has improved! Again: do not send me pure AI work!

   I have never realized that how much refactoring makes it easier to code. An example I can give is, by using **Visual Studio 2022**'s build in metrics, I can see the potential performance issues. And instead of finding a way to solve them, I can basicly just refactor the code and it fixes automaticly!

   ![image](https://github.com/user-attachments/assets/a4732f85-531e-4ae8-8577-ea28e96aa27b)
   it even shows how it will look afterwards.

                                             |
   
                                             |
   
                                             |
   
                                             |
   
                                          \    /
   
                                            \/
         
   ![image](https://github.com/user-attachments/assets/28ef1552-958a-4cdf-a27b-56e816ad5045)
   This can be applied to all the issues. In this example the way to provide the tag was changed. There was a build in method for that which was faster! I was able to see that with metrics, and make it faster.

    
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
   ![image](https://github.com/user-attachments/assets/0e845a9e-a213-495c-8cbf-cb0bcfe2c6e3)


13. **AI Coding**: Set Up an AI-coding environment on your computer like ZED, Aider, etc. Show your steps and personal experiences! ([ref](https://newsletter.pragmaticengineer.com/p/ide-that-software-engineers-love))
    
14. **FUNCTIONAL PROGRAMMING:** prove that you have covered all functional aspects in your code as:
    - only final data structures
    - (mostly) side-effect-free functions
    - the use of higher-order functions
    - functions as parameters and return values
    - use closures / anonymous functions
    - You can also do it outside of your project. Even in other languages such as F#, Clojure, Julia, etc.
      
15. Set up a running **AI Coding** environment! Prove it by coding something small.
    
