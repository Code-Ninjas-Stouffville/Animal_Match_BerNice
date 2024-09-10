using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class QuestionGenerate : MonoBehaviour
{
    public string[] questionList = new string[] {
        "Out of these 3 fruits, which one should cats not eat?",
        "What are chickens?",
        "Which dog breed is the second fastest?",
        "What are male foxes not called?",
        "How many species of swans are there?",
        "How many hours do giant pandas eat consistently for?",
        "How many minutes can an octopus live out of water for?",
        "When were hamsters discovered?",
        "What color blood does an octopus have?",
        "What is the tallest species of penguin?",
        "How many bones does a shark have?",
        "How high can penguins jump?",
        "Where were hamsters discovered?",
        "What is the average lifespan of a hamster?",
        "Which Chinese province has the largest number of wild giant pandas?",
        "In China what are pandas also known as?",
        "How many feathers does the average chicken have?",
        "What does alektorophobia mean?",
        "How many toes does a cat have?",
        "How many eyelids does a cat's eye have?",
        "How many bones does a cat have?",
        "What is the name of the first dog in space?",
        "How many eyes does a honeybee have?",
        "What is the smallest mammal in the world?",
        "For how many years have sharks roamed the earth?",
        "How much bamboo does a giant panda eat in a day?",
        "What is a group of pandas called?",
        "A mixed-breed dog is also sometimes termed what?",
        "Which Canadian breed of dog is known for having webbed feet?",
        "Which breed of cat is known for having no tail?",
        "What object does a male penguin often gift to a female penguin to win her over?",
        "What is the name for a male panda?",
        "What is the only dog breed that can't bark?",
        "How many permanent teeth do dogs have?",
        "Why do cats not tend to eat sweet things?",
        "How many teeth will sharks grow and lose in their lifetime?",
        "What 2 dog breeds have solid blue tongues?",
        "What primary colour can dogs not see?",
        "How many muscles does a cat have in each ear?",
        "Which shark is responsible for most human deaths?"

    };

    public TMP_Text questionText;
    public TMP_Text Button1Text;
    public TMP_Text Button2Text;
    public TMP_Text Button3Text;
    public TMP_Text Button4Text;

    public int answeredQuestions = 0;

    // Start is called before the first frame update
    void Start()
    {
        CreateNewQuestion();
    }

    // Update is called once per frame
    void Update()
    {
        if (answeredQuestions >= 5)
        {
            //SceneManager.LoadScene();
        }
    }

    void CreateNewQuestion()
    {
        int questionIndex = Random.Range(0, questionList.Length);
        questionText.text = questionList[questionIndex];
        AssignButton(questionText.text);
    }

    void AssignButton(string question)
    {
        if (question == questionList[0])
        {
            Button1Text.text = "Blueberries";
            Button2Text.text = "Apricots";
            Button3Text.text = "Grapes";//
            Button4Text.text = "Mangos";
            Button3Text.transform.parent.gameObject.GetComponent<Answer>().correctAnswer = true;

        }
        else if (question == questionList[1])
        {

            Button1Text.text = "Omnivores";//
            Button2Text.text = "Herbivores";
            Button3Text.text = "Carnivores";
            Button4Text.text = "Photovore";
            Button1Text.transform.parent.gameObject.GetComponent<Answer>().correctAnswer = true;
        }
        else if (question == questionList[2])
        {
            Button1Text.text = "Greyhound";
            Button2Text.text = "Catahoula Leopard Dog";
            Button3Text.text = "Saluki";//
            Button4Text.text = "Afghan Hound";
            Button3Text.transform.parent.gameObject.GetComponent<Answer>().correctAnswer = true;
        }
        else if (question == questionList[3])
        {
            Button1Text.text = "Dogs";
            Button2Text.text = "Vixens";//
            Button3Text.text = "Reynards";
            Button4Text.text = "Tods";
            Button2Text.transform.parent.gameObject.GetComponent<Answer>().correctAnswer = true;
        }
        else if (question == questionList[4])
        {
            Button1Text.text = "8";
            Button2Text.text = "6";
            Button3Text.text = "5";
            Button4Text.text = "7";//
            Button4Text.transform.parent.gameObject.GetComponent<Answer>().correctAnswer = true;
        }
        else if (question == questionList[5])
        {

            Button1Text.text = "13-15";
            Button2Text.text = "7-13";
            Button3Text.text = "8-12";
            Button4Text.text = "10-16";//
            Button4Text.transform.parent.gameObject.GetComponent<Answer>().correctAnswer = true;
        }
        else if (question == questionList[6])
        {

            Button1Text.text = "20-30";//
            Button2Text.text = "10-20";
            Button3Text.text = "25-30";
            Button4Text.text = "15-25";
            Button1Text.transform.parent.gameObject.GetComponent<Answer>().correctAnswer = true;
        }
        else if (question == questionList[7])
        {

            Button1Text.text = "1826";
            Button2Text.text = "1846";
            Button3Text.text = "1839";//
            Button4Text.text = "1858";
            Button3Text.transform.parent.gameObject.GetComponent<Answer>().correctAnswer = true;
        }
        else if (question == questionList[8])
        {

            Button1Text.text = "Red";
            Button2Text.text = "Purple";
            Button3Text.text = "Green";
            Button4Text.text = "Blue";//
            Button4Text.transform.parent.gameObject.GetComponent<Answer>().correctAnswer = true;
        }
        else if (question == questionList[9])
        {

            Button1Text.text = "King Penguin";
            Button2Text.text = "Gentoo Penguin";
            Button3Text.text = "Emperor Penguin";//
            Button4Text.text = "Macaroni Penguin";
            Button3Text.transform.parent.gameObject.GetComponent<Answer>().correctAnswer = true;
        }
        else if (question == questionList[10])
        {

            Button1Text.text = "0";//
            Button2Text.text = "150";
            Button3Text.text = "100";
            Button4Text.text = "50";
            Button1Text.transform.parent.gameObject.GetComponent<Answer>().correctAnswer = true;
        }
        else if (question == questionList[11])
        {

            Button1Text.text = "9ft.";//
            Button2Text.text = "8ft.";
            Button3Text.text = "6ft.";
            Button4Text.text = "7ft.";
            Button1Text.transform.parent.gameObject.GetComponent<Answer>().correctAnswer = true;
        }
        else if (question == questionList[12])
        {

            Button1Text.text = "Greece";
            Button2Text.text = "Syria";//
            Button3Text.text = "China";
            Button4Text.text = "Romania";
            Button2Text.transform.parent.gameObject.GetComponent<Answer>().correctAnswer = true;
        }
        else if (question == questionList[13])
        {

            Button1Text.text = "1-2yrs";
            Button2Text.text = "2-3yrs";//
            Button3Text.text = "3-4yrs";
            Button4Text.text = "4-5yrs";
            Button2Text.transform.parent.gameObject.GetComponent<Answer>().correctAnswer = true;
        }
        else if (question == questionList[14])
        {

            Button1Text.text = "Sichuan";//
            Button2Text.text = "Guizhou";
            Button3Text.text = "Jiangxi";
            Button4Text.text = "Hainan";
            Button1Text.transform.parent.gameObject.GetComponent<Answer>().correctAnswer = true;
        }
        else if (question == questionList[15])
        {

            Button1Text.text = "White Bear";
            Button2Text.text = "Bamboo Bear";
            Button3Text.text = "Bear Cat";//
            Button4Text.text = "Parti-colored bear";
            Button3Text.transform.parent.gameObject.GetComponent<Answer>().correctAnswer = true;
        }
        else if (question == questionList[16])
        {

            Button1Text.text = "6,000";
            Button2Text.text = "4,000";
            Button3Text.text = "10,000";
            Button4Text.text = "8,000";//
            Button4Text.transform.parent.gameObject.GetComponent<Answer>().correctAnswer = true;
        }
        else if (question == questionList[17])
        {

            Button1Text.text = "Fear of pandas";
            Button2Text.text = "Fear of chickens";//
            Button3Text.text = "Fear of hamsters";
            Button4Text.text = "Fear of sharks";
            Button2Text.transform.parent.gameObject.GetComponent<Answer>().correctAnswer = true;
        }
        else if (question == questionList[18])
        {

            Button1Text.text = "18";//
            Button2Text.text = "20";
            Button3Text.text = "16";
            Button4Text.text = "10";
            Button1Text.transform.parent.gameObject.GetComponent<Answer>().correctAnswer = true;
        }
        else if (question == questionList[19])
        {

            Button1Text.text = "1";
            Button2Text.text = "3";
            Button3Text.text = "4";
            Button4Text.text = "2";//
            Button4Text.transform.parent.gameObject.GetComponent<Answer>().correctAnswer = true;
        }
        else if (question == questionList[20])
        {

            Button1Text.text = "230";//
            Button2Text.text = "321";
            Button3Text.text = "206";
            Button4Text.text = "345";
            Button1Text.transform.parent.gameObject.GetComponent<Answer>().correctAnswer = true;
        }
        else if (question == questionList[21])
        {

            Button1Text.text = "Mushka";
            Button2Text.text = "Laika";//
            Button3Text.text = "Strelka";
            Button4Text.text = "Belka";
            Button2Text.transform.parent.gameObject.GetComponent<Answer>().correctAnswer = true;
        }
        else if (question == questionList[22])
        {

            Button1Text.text = "0";
            Button2Text.text = "5";
            Button3Text.text = "3";//
            Button4Text.text = "2";
            Button3Text.transform.parent.gameObject.GetComponent<Answer>().correctAnswer = true;
        }
        else if (question == questionList[23])
        {

            Button1Text.text = "Bumblebee bat";//
            Button2Text.text = "Pygmy possum";
            Button3Text.text = "Mouse lemur";
            Button4Text.text = "Pygmy jerboa";
            Button1Text.transform.parent.gameObject.GetComponent<Answer>().correctAnswer = true;
        }
        else if (question == questionList[24])
        {

            Button1Text.text = "250 million";
            Button2Text.text = "500 million";
            Button3Text.text = "300 million";
            Button4Text.text = "450 million";//
            Button4Text.transform.parent.gameObject.GetComponent<Answer>().correctAnswer = true;
        }
        else if (question == questionList[25])
        {

            Button1Text.text = "47-83 pounds";
            Button2Text.text = "38-85 pounds";
            Button3Text.text = "26-84 pounds";//
            Button4Text.text = "59-86 pounds";
            Button3Text.transform.parent.gameObject.GetComponent<Answer>().correctAnswer = true;
        }
        else if (question == questionList[26])
        {
        
            Button1Text.text = "A dazzle";
            Button2Text.text = "An embarrassment";//
            Button3Text.text = "A smack";
            Button4Text.text = "A bloat";
            Button2Text.transform.parent.gameObject.GetComponent<Answer>().correctAnswer = true;
        }
        else if (question == questionList[27])
        {
  
            Button1Text.text = "Grey";
            Button2Text.text = "Mixed up";
            Button3Text.text = "Mongrel";//
            Button4Text.text = "Half and half";
            Button3Text.transform.parent.gameObject.GetComponent<Answer>().correctAnswer = true;
        }
        else if (question == questionList[28])
        {

            Button1Text.text = "Labrador Retriever";
            Button2Text.text = "Newfoundland";//
            Button3Text.text = "Canadian Eskimo Dog";
            Button4Text.text = "Nova Scotia Duck Tolling Retriever";
            Button2Text.transform.parent.gameObject.GetComponent<Answer>().correctAnswer = true;
        }
        else if (question == questionList[29])
        {

            Button1Text.text = "Siamese";
            Button2Text.text = "Persian";
            Button3Text.text = "Manx";//
            Button4Text.text = "Maine Coon";
            Button3Text.transform.parent.gameObject.GetComponent<Answer>().correctAnswer = true;
        }
        else if (question == questionList[30])
        {

            Button1Text.text = "A fish";
            Button2Text.text = "A piece of ice";
            Button3Text.text = "A pebble";//
            Button4Text.text = "A squid";
            Button3Text.transform.parent.gameObject.GetComponent<Answer>().correctAnswer = true;
        }
        else if (question == questionList[31])
        {
  
            Button1Text.text = "Boar";//
            Button2Text.text = "Dragon";
            Button3Text.text = "Bull";
            Button4Text.text = "Buck";
            Button1Text.transform.parent.gameObject.GetComponent<Answer>().correctAnswer = true;
        }
        else if (question == questionList[32])
        {

            Button1Text.text = "Basenji";//
            Button2Text.text = "Azawakh";
            Button3Text.text = "Mudi";
            Button4Text.text = "Lancashire";
            Button1Text.transform.parent.gameObject.GetComponent<Answer>().correctAnswer = true;
        }
        else if (question == questionList[33])
        {
 
            Button1Text.text = "28";
            Button2Text.text = "42";//
            Button3Text.text = "26";
            Button4Text.text = "50";
            Button2Text.transform.parent.gameObject.GetComponent<Answer>().correctAnswer = true;
        }
        else if (question == questionList[34])
        {
           
            Button1Text.text = "They worry about their teeth";
            Button2Text.text = "They count their calories";
            Button3Text.text = "They don't like sugar";
            Button4Text.text = "They can't taste sugar";//
            Button4Text.transform.parent.gameObject.GetComponent<Answer>().correctAnswer = true;
        }
        else if (question == questionList[35])
        {

            Button1Text.text = "45,000";
            Button2Text.text = "80,000";
            Button3Text.text = "60,000";
            Button4Text.text = "50,000";//
            Button4Text.transform.parent.gameObject.GetComponent<Answer>().correctAnswer = true;
        }
        else if (question == questionList[36])
        {

            Button1Text.text = "Chow Chow + Chinese Shar-Pei";//
            Button2Text.text = "Eurasier and the Thai Ridgeback";
            Button3Text.text = "Chinook + Otterhound";
            Button4Text.text = "Norwegian Lundehund + Azawakh";
            Button1Text.transform.parent.gameObject.GetComponent<Answer>().correctAnswer = true;
        }
        else if (question == questionList[37])
        {

            Button1Text.text = "Blue";
            Button2Text.text = "Red";//
            Button3Text.text = "Yellow";
            Button4Text.text = "They can't see any";
            Button2Text.transform.parent.gameObject.GetComponent<Answer>().correctAnswer = true;
        }
        else if (question == questionList[38])
        {

            Button1Text.text = "8";
            Button2Text.text = "18";
            Button3Text.text = "32";//
            Button4Text.text = "6";
            Button3Text.transform.parent.gameObject.GetComponent<Answer>().correctAnswer = true;
        }
        else if (question == questionList[39])
        {

            Button1Text.text = "Bull Shark";
            Button2Text.text = "Tiger Shark";
            Button3Text.text = "Requiem Shark";
            Button4Text.text = "Great White Shark";//
            Button4Text.transform.parent.gameObject.GetComponent<Answer>().correctAnswer = true;
        }

    }
}