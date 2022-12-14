using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Firebase.Auth; // 계정인증기능 사용
 
public class JoinBehaviour : MonoBehaviour{
    private FirebaseAuth auth; // 인증 객체 불러오기
    void Start(){
        auth = FirebaseAuth.DefaultInstance; // 인증 객체 초기화
        Join("inyongs@daum.net", "555555"); // 해당 이메일,비밀번호로 가입하기
    }
 
    void Join(string email, string password){
        // 이메일과 비밀번호로 가입하는 함수
       auth.CreateUserWithEmailAndPasswordAsync(email, password).ContinueWith(
            task => {
                if (!task.IsCanceled && !task.IsFaulted){
                    Debug.Log(email + " 로 회원가입 하셨습니다.");
                }
                else{
                    Debug.Log("회원가입에 실패하셨습니다.");
                }
            }
        );
    }
}