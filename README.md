

# Bible Study Quiz Application

## Introduction
The Bible Study Quiz Application is an interactive web-based quiz designed to test users' knowledge of the Old Testament. The application dynamically loads questions, evaluates responses, and provides real-time feedback. This document serves as a comprehensive guide to understanding the application's features, installation, and testing strategy.

## Features
- **Dynamic Question Loading**: Questions are retrieved dynamically to ensure variety.
- **Answer Validation**: Immediate feedback on whether a selected answer is correct or incorrect.
- **Score Tracking**: Users can track their progress and final scores.
- **Edge Case Handling**: The application prevents navigation without answering and enforces single-answer selection.
- **Quiz Retake Option**: Users can restart the quiz upon completion.
- **Sound Effects**: The application provides sound feedback for correct and incorrect answers to enhance the user experience.
- **Timer**: A countdown timer is implemented to limit the time for each question, providing a sense of urgency and challenge.
- **Progress Bar**: A progress bar shows the user’s advancement through the quiz, indicating how many questions are left to answer.

## Installation Guide
### Prerequisites
Ensure you have the following installed:
- Node.js
- npm or yarn

### Setup Instructions
1. Clone the repository:
   ```bash
   git clone https://github.com/your-repo/bible-study-quiz.git
   ```
2. Navigate to the project folder:
   ```bash
   cd bible-study-quiz
   ```
3. Install dependencies:
   ```bash
   npm install
   ```
4. Start the development server:
   ```bash
   npm start
   ```

## Testing Strategy
The application has undergone rigorous testing to ensure reliability and usability. The following test types were conducted:

### 1. Unit Testing
- Verifies individual quiz components such as question loading, answer validation, and score calculation.

### 2. Functional Testing
- Ensures that UI elements (Submit, Next, Retake) function as expected.

### 3. Edge Case Testing
- Scenarios tested include submitting without an answer, clicking "Next" before submitting, and selecting multiple answers.

### 4. Usability Testing
- Confirms that feedback messages are clear and user-friendly.

## Test Cases
| Test Case ID | Description                    | Input                           | Expected Output                              | Status |
|-------------|--------------------------------|--------------------------------|----------------------------------------------|--------|
| TC-01       | Load First Question           | Start Quiz                     | First question appears                      | ✅ Pass |
| TC-02       | Select Correct Answer         | Select correct option & Submit | "Correct!" message appears                  | ✅ Pass |
| TC-03       | Select Incorrect Answer       | Select wrong option & Submit   | "Incorrect! The correct answer is..."       | ✅ Pass |
| TC-04       | Submit Without Selecting      | Click Submit without selecting | Warning message appears                      | ✅ Pass |
| TC-05       | Click Next Without Submitting | Click Next without answering   | No navigation, stays on current question    | ✅ Pass |
| TC-06       | Navigate to Next Question     | Submit answer & click Next     | Next question appears                        | ✅ Pass |
| TC-07       | Quiz Completion & Score       | Answer all questions           | Final score displayed                        | ✅ Pass |
| TC-08       | Retake Quiz                   | Click "Retake Quiz" after completion | Quiz restarts from Question 1       | ✅ Pass |

 Deployment
To deploy the application:
1. Build the project:
   ```bash
   npm run build
   ```
2. Deploy using a hosting service such as **Vercel**, **Netlify**, or **GitHub Pages**.

## Conclusion
The Bible Study Quiz Application** has been thoroughly tested and is ready for use. Users can enjoy an interactive and educational experience while testing their knowledge of the Old Testament.

---

