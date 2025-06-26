# PROG6221POE3
Github link: https://github.com/SibleyDean/PROG6221POE3.git

Cybersecurity Chatbot – WPF Application (GUI) Overview
A desktop-based WPF (Windows Presentation Foundation) program, the Cybersecurity Chatbot is made to inform, help, and engage users with cybersecurity topics in a clever and entertaining manner.  Through a single user interface, the system integrates task management, quiz-based learning, activity recording, and simulation of natural language processing.
1. Core Chatbot Interaction:
    imporetd classes Used: ChatServ.cs, displayASCII.cs, tipsB.cs, responseB.cs
    Functionality: Users enter natural language questions such as "Remind me to update my password" or "Tell me about phishing."
    The chatbot uses manual natural language processing (NLP) techniques (string.Contains, ToLower, etc.) to identify keywords and then answers with pertinent information, actions, or advice.
    To prevent repetition, topics alternate between several explanations.
    responds to follow-up questions with relevant keywords inside each subject.
2. NLP Simulation (Natural Language Processing):
   Recognized Keywords: task, remind, quiz, help, activity log, etc.
   Flexible Input Handling: Supports prompts like “Start a quiz on phishing,” “What have you done?” or “Remind me next Monday.”
3. Task Assistant:
   Classes Used: TaskWindow.xaml, TaskManager.cs, TaskItem.cs
   Features: Through a GUI window or by typing in the chat, users can add tasks. Tasks include title, description, optional reminder, and a completion checkbox.
   A "Manage Tasks" button allows you to edit the tasks that are graphically handled in a GUI list.
   Users can mark jobs as completed straight from the GUI via a checkbox user interface.
4. Cybersecurity Mini-Game (Quiz):
   Classes Used: QuizWindow.xaml, Question.cs, QuizManager.cs
   Features:
   A button launches a quiz game with topics like Passwords, Phishing, etc. Each topic has 5 questions (3 multiple choice, 2 true/false).
   Users receive instant feedback after each question. A progress bar and score summary are shown at the end.
   Users can return to the main chatbot after finishing.
5. Sentiment Detection:
   Keywords Detected: “worried,” “confused,” “frustrated,” “curious,” etc.
   Functionality: Adjusts tone of response if user expresses concern, confusion, or fear. Empathic messages are displayed to offer reassurance and support.
6. Activity Log System:
   Classes Used: ActivityLog.cs
   Records major user actions like:
   Task added, reminder set, quiz started, interest captured, etc. Entries include timestamps and are stored in memory (with a size limit).
   Trigger phrases like: “What have you done?”, “Show activity log”, “Display recent actions”
    Displays the 10 most recent actions to the user.
7. Dark Mode & UI Customization (Optional):
   Visual features including font styling, spacing, and icons are supported by the WPF GUI.
   Users can change themes using a toggle button for dark mode, if it is enabled.  The output and input boxes are designed to be easier for users to read.

Reference list:
-- GeeksforGeeks (2018). Introduction to C# Windows Forms Applications. [online] GeeksforGeeks. Available at: https://www.geeksforgeeks.org/c-sharp/introduction-to-c-sharp-windows-forms-applications/.
-- Simplilearn.com. (n.d.). A One-Stop Solution for Creating a C# GUI | Simplilearn. [online] Available at: https://www.simplilearn.com/tutorials/c-sharp-tutorial/c-sharp-gui.
