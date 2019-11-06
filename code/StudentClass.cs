using System;

class MainClass {
  public static void Main (string[] args) {
    Student katie = new Student("Katie",20,15,"Computer Science", "sand");

    Console.WriteLine(katie.ToString());
    
  }
}
public class Student{
      string name,sub,al;
      int age, grade;

  //default constructor
  public Student(){
    name = "Student";
    grade = 9;
    age = 14;
    sub = "School";
    al = "N/A";
  }
  //constructor
  public Student(string name, int age, int grade, string sub, string al){
      this.name = name;
      this.age = age;
      this.grade =  grade;
      this.sub = sub;
      this.al = al;
  }

  //sets 
  public void setName(string n){
    this.name = n;
  }

  public void setGrade(int g){
    this.grade = g;
  }

  public void setAge(int a){
    this.age = a;
  }

  public void setSub(string sub){
    this.sub = sub;
  }

  public void setAllergies(string al){
    this.al = al;
  }


  ///gets
  public string getName(){
    return this.name;
  }

  public string getSub(){
    return this.sub;
  }

  public string getAllergies(){
    return this.al;
  }

  public int getAge(){
    return this.age;
  }

  public int getGrade(){
    return this.grade;
  }

  public override string ToString(){
    //tostring method will print the object
    return $"{name} is {age} years old in grade {grade} and have favorite subject {sub} and are allergic to {al}";
  }
}

public class Teacher {
  // Attributes
  string subject, name;
  int age;

  // Default Constructor
  public Teacher() {
    subject = "math";
    name = "Rebecca or Karen";
    age = 43;
  }

  // Constructor
  public Teacher(string subject, string name, int age) {
    this.subject = subject;
    this.name = name;
    this.age = age;
  }

  // Setters
  public void setSubject(string subject) {
    this.subject = subject;
  }
  public void setName(string name) {
    this.name = name;
  }
  public void setAge(int age) {
    this.age = age;
  }

  // Getters
  public string getSubject() {
    return subject;
  }
  public string getName() {
    return name;
  }
  public int getAge() {
    return age;
  }

  // ToString to print all attributes
  public override string ToString() {
    return $"{name} is {age} years old and teaches {subject}.";
  }

}