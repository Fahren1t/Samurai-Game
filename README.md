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

   SOLUTION:
   
   
   https://miro.com/welcomeonboard/eTNtYUpBTFdheXBydXFRd2lPbkxRUmIxM0NyM0NYUFFVUnRNVXhwYWpWMXM3emErMmM1OTFkU2Iva09GcTJDdmRkM1Q3YU5ocnFkbnZLL2tWWDE5SFRrVGR0SUxuaTIvdTdsdDJEemc4NWhuTDBEZUs5OWpIMVR1MlhXOVJnWGEhZQ==?share_link_id=880248275322
![Samurai-game DDD (1)](https://github.com/user-attachments/assets/1ee3ae36-1653-44ae-8eac-68f9b63c7530)



6. **METRICS:** at least two. Sonarcube would be great. Other non-trivial metrics are also fine.

SOLUTIONS:
   **1. Visual studio's build in Metrics**: How to access?
   By choosing the Analyze > Calculate Code Metrics menu command within Visual Studio.
   ![How-to-open-metrics-2](https://github.com/user-attachments/assets/4b8c9a9f-9cae-483d-9bc7-62b0d41b5d73)

   The first thing that got my attention was Unnecesarry files (marked with yellow). I was unsing some free assests for my project, and they came up with also scripts, which were unneeded.
   ![image](https://github.com/user-attachments/assets/4c5202fd-40c1-4fc7-b921-b22f3fb219b8)

   .
   
   It also made an error list to show the potential performance errors: 
   ![image](https://github.com/user-attachments/assets/f91c0646-49ef-4a48-8bcc-89d0b72abf98)
   
   I fixed all of them with refactoring (Except one because I will fill that later).
   ![image](https://github.com/user-attachments/assets/e2bb5dc4-c7d2-4551-bdb1-fff4d945221b)


   **2. NDepend:** this is a great tool for deep analisys for C# projects. NDepend is really easy to use and set. The only bad thing is that it is not for free. Currently I am using the trial version. But I will defitively have it in mind that if some day I need a metric for a C# project, NDepend is a great tool.    
   
![image](https://github.com/user-attachments/assets/ffc2bbfc-54e5-4871-ad60-bed4a03f9648)

.

I have found out that it takes some time for program to locate the codes. This makes so much sense, because before I arrenged the code files according to components. I put enemy classes together, but those enemy classes provide information to some player classes. Therefore it takes more time for that information to reach. It will look messier, but in terms of performance, it will be better
![image](https://github.com/user-attachments/assets/0ac03ea4-70eb-4cb6-a94f-3bdf836c962e)

.
I put them all in the same file. I will find and other way to short them but for now I will leave it as be. And code quality increased when I did it.
![image](https://github.com/user-attachments/assets/a38aef47-5f69-4b16-856e-4329621f5ad4) ![image](https://github.com/user-attachments/assets/ea30f7b8-93cd-4ece-8b94-d3d5eae5ed8a)

.

An other thing I noticed was I should have been using namespaces in order to manage the code better. So I added every class to a namespace that I declared

.

![image](https://github.com/user-attachments/assets/91212ef1-5b9b-459a-97ca-27325dbe07db)

.

Adding namespaces to the code caused some other issues I had to solve. But in the end, after sometime of adjustments, it made the code more efficient.

![image](https://github.com/user-attachments/assets/c50dbbc8-473a-458e-9534-dd34611291e7)

.
    
7. **CLEAN CODE DEVELOPMENT:** A) At least 5 points you can show me with an explanation of why this is clean code in your code and/or what has improved & B) >>10 points on your personal CCD cheat sheet. E.g. a PDF.

.

 1. For the naming, I tried to name as much as understandable as possible :

![image](https://github.com/user-attachments/assets/d383ed7c-9f77-44f5-8cfd-b65b7777775c)
  
.

 2. To make the code cleaner, I also changed some lines of codes which were used multiple times, with methods.   

   **Before:**
 
 ![image](https://github.com/user-attachments/assets/50410c97-34cd-41e7-8f73-d5989db81141) ![image](https://github.com/user-attachments/assets/3f3cacc0-9d0d-4d0b-86e3-8c53938ba824)

   **After:**

   ![image](https://github.com/user-attachments/assets/7270be89-14ea-4e3d-821f-9342d6a22283) ![image](https://github.com/user-attachments/assets/22b8bf16-4503-46e1-a475-5dcfc4788539) ![image](https://github.com/user-attachments/assets/16c99836-4fdb-4890-bf71-f76f0941a63c)

.

I also did the same thing for the confition operations:

**BEFORE:**

![image](https://github.com/user-attachments/assets/b4664a13-6fa0-4095-9f95-437b538f29de)

**AFTER:**

![image](https://github.com/user-attachments/assets/d835800d-fae9-4c0d-89ff-6dc86cd917f9) ![image](https://github.com/user-attachments/assets/b589d9ff-1261-43f9-b795-6c7b97b65bd7)

.

I also had to remove some magic numbers. This increased the amount of variable a lot though. I am not so sure if it is more efficient or not but oh well, thats what is was written in the documents so...

**BEFORE:**

![image](https://github.com/user-attachments/assets/646759fa-b9ce-4ffc-86b1-3026c4cf473c)

.

**AFTER:**

![image](https://github.com/user-attachments/assets/6549dbcb-a159-4e92-9548-04a08cda3cd7)

![image](https://github.com/user-attachments/assets/bdcb9899-fbda-4594-8dc0-b75905782a85)

8. **REFACTORING**: Show me two (non-trivial) Refactoring Examples of your code! Showing the original content and the refactored code! Explain what happened, why and how it has improved! Again: do not send me pure AI work!

.

   I have never realized that how much refactoring makes it easier to code. It even shows how it will look afterwards

   **1. Example:**  An example I can give is, by using **Visual Studio 2022**'s build in metrics, I can see the potential performance issues. And instead of finding a way to solve them, I can basicly just refactor the code and it fixes automaticly! . In this example, refactoring changed the code by replacing the equals operator, with a much more efficient build in method.

   ![image](https://github.com/user-attachments/assets/a4732f85-531e-4ae8-8577-ea28e96aa27b)

   

         
   ![image](https://github.com/user-attachments/assets/28ef1552-958a-4cdf-a27b-56e816ad5045)
   
   .
   
   **2. Example**: I can refactor the code so that it adds the class to a namespace automaticly 
   ![adding-namespaces-with-refactoring](https://github.com/user-attachments/assets/bdd288a6-eb83-4982-9b5d-1055e43caf0b)

   .

   **3. EXAMPLE:** I needed to extract a method from a condition to make the code cleaner therefore I used refactoring!
   
   ![image](https://github.com/user-attachments/assets/7aaa3294-225f-43e5-8d46-8dafa193561d)

   I also touched on this in the cleancode development so I will not go full on details. But basically with this, the code become more readable and easy to understand. 

   .

9. **BUILD** Management with any Build System as Ant, Maven, Gradle, etc. (only Travis is perhaps not enough) Do e.g. generate Docs, call tests, etc. (it could also be disconnected from the project just to learn a build tool!) => to be merged with 7!
    
10. **CONTINOUS DELIVERY:** show me your pipeline using e.g. **Jenkins**, **GitHub Actions**, GitLab CI, etc. E.g. you can also use Jenkins Pipelining or BlueOcean, etc. But at least insert more than 2 script calls as done in the lecture! (e.g. also call Ant or Gradle or something else).
    
11. Integrate some nice **UNIT TESTS** in your Code to be integrated into the Build!

   In Unity, unit tests work a little different. The unity engine has its own test runner which is really easy to use and understand. I haven't looked at how to intergrate tests to build, but I don't think it is necesary.

   In this example a the test is to check if the enemy health is set to one.
   
   ![Test-runner](https://github.com/user-attachments/assets/5fc9af43-7042-467d-a4b0-02cef8daed69)

.

   Here is the code for it. It is pretty basic.
   
   ![image](https://github.com/user-attachments/assets/4626d7bc-110e-4f2a-bb7c-c7ceeef45560)

    
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
   
**SOLUTION:** I have decided to use github copilot AI. It gives 2000 lines of code suggestions and 50 chat messages per month in its free version. It is not much but it was the easiest to set up in vs2022. Here are my experiences with the CoPilot

![image](https://github.com/user-attachments/assets/f797c467-f878-46f6-a2e1-fb3ed4c8a613)

Firstly I asked it to give me an analisis of the code. It gave me few suggestions which were made sense because at this point the update function was getting hard to process. It always looked complicated to me even though I looked at it million times. 

![image](https://github.com/user-attachments/assets/d0dc07a3-b249-4792-b95a-c20d788d02d8)

It said that in order to simplify the update function, the code could be written this way. Which I agree. I really would like to explore more because it is quite usefull. I will definitively use it when I continue my project. 

.

Final Code:

![image](https://github.com/user-attachments/assets/dcd9b892-bcbf-47b1-9efd-e364a5f4b2c2)

Has a little window I can use to chat or ask for instructions:

![image](https://github.com/user-attachments/assets/88c5003d-5afb-4512-befd-f7c84fc3ae51)

It predicts what I will write according to the previous examples. Fastening the code writing:

![image](https://github.com/user-attachments/assets/f7e1cd7f-7153-42dd-86a3-471771432860)

One final advantage is (possibly the best one), it can look at the error and can possibly give a solution!

![Fixing-issues-with-AI](https://github.com/user-attachments/assets/339bc9c8-e897-4263-8223-72a328c5aeea)


14. **FUNCTIONAL PROGRAMMING:** prove that you have covered all functional aspects in your code as:
    - only final data structures
    - (mostly) side-effect-free functions
    - the use of higher-order functions
    - functions as parameters and return values
    - use closures / anonymous functions
    - You can also do it outside of your project. Even in other languages such as F#, Clojure, Julia, etc.
      
**SOLUTION:** 

I chose to do it with a functional programming language F#. Therefore it is outside my project. Here is how the code looks like:

      // These are final data structures, these values are not changable, unless there is a "mutable" key word
      let numbers = [1; 2; 3; 4;453;85;9786753;354;768;645;7876;321435;6564321]

      let isEven = 
          fun x -> x % 2 = 0 //these are side effect free functions.
      
      let doubleIt =
          fun x -> x * 2 //these are side effect free functions.
      
      
      // Higher order functions usualls look something like this. This function uses other functions such as filter and map, one which filters numbers according to a condition and one which creates a new list
      // with these new filtered numbers, which we can insert a function that takes the double of these even numbers. 
      
      let evenNumbersInNumbers = List.filter isEven numbers 
      let doubledEvenNumbers = List.map doubleIt evenNumbersInNumbers 
      
      //this is an example of returning a function
      let applyTwice f x = f (f x)
      let triple x = x * 3
      
      let doubledEvenNumbersTripledTwice = 
          doubledEvenNumbers |> List.map (applyTwice triple) //and here we assign a value to y and return it as a value. basicly returning a function.
      
      
      // Closures generaly look like this. in this example counter is used to increase the value of func, and it is remembered, therefore the next func is increased because counter is increased everytime
      //the function is called. I hope it is clear.
      let counter  x =
          let mutable count = 1
          fun () ->
              count <- count + 1 
              let func = x + count
              printfn "the value is: %i" func
              func
      
      // Print Results
      printfn "original numbers: %A" numbers
      printfn "even numbers: %A" evenNumbersInNumbers
      
      printfn "doubled numbers: %A" doubledEvenNumbers
      printfn "2 times tripled numbers: %A" doubledEvenNumbersTripledTwice
      
      let myCounter = counter 10 //here we set counter as 10 (x is set to 10 basicly)
      
      // test closure
      let myResult1 = myCounter () //counter + 1
      let myResult2 = myCounter () //counter + 2
      let myResult3 = myCounter () //counter + 3

.

Here is how it looks in the IDE:

![image](https://github.com/user-attachments/assets/f2b96b65-975f-425f-968a-77d77bf349ac)

In this example, a list is made (final data structures). 

![image](https://github.com/user-attachments/assets/01ab1575-819a-415a-aeeb-cb658954ea12)

And firstly with this list a new list is created, with the even numbers in the main list (higher order functions are used). Afterwards this new even lists elemens are doubled with an other function (also with a higher order function). 

![image](https://github.com/user-attachments/assets/6ac496ee-4d83-4e19-a955-96e03dcbb3df)

After that with tripple and applyTwice funtion. the new doubled even list tripled 2 times, because one of the functions used here applies the given function twice. So the list elements are multiplied with 3, 2 times.

![image](https://github.com/user-attachments/assets/fe14e738-b5f3-4d18-830e-9876489e1e67)

And for the last one, counter function uses a mutable(changeble) variable, and this variable is remembered by the funtion inside of this function. everytime the superiour function is called, count increases, and it is used by the inner function in order to increase the return value func. Everytime the function is called it gives an other value.

![image](https://github.com/user-attachments/assets/2afc5e8d-3616-49a8-904e-b90389705755)
