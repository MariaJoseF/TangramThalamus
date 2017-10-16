using CookComputing.XmlRpc;
using System;
using System.IO;
using UnityEngine;
using UnityEditor;

namespace ThalamusTangram
{
    public class UnityListener : XmlRpcListenerService, ITMessages
    {
        private ThalamusConnector _thalamusCS;
        //string fileName = null;
        string subcategory = "";

        public UnityListener(ThalamusConnector thalamusCS)
        {
            _thalamusCS = thalamusCS;
        }

        public void Greeting(string player, bool robotN)
        {
            if (robotN)
            {
                subcategory = "greeting";
            }
            else
            {
                subcategory = "greeting_R";
            }

            _thalamusCS.TypifiedPublisher.PerformUtteranceFromLibrary("greeting" + Guid.NewGuid().ToString(), "sessionStart", subcategory , new string[] { "|player|" }, new string[] { player });
        }

        public void GameStart(string puzzle, bool robotN)
        {
            if (robotN)
            {
                subcategory = "puzzle";
            }
            else
            {
                subcategory = "puzzle_R";
            }

            _thalamusCS.TypifiedPublisher.PerformUtteranceFromLibrary("start" + Guid.NewGuid().ToString(), "sessionStart", subcategory, new string[] { "|puzzle|" }, new string[] { puzzle });
        }

        public void NextGame(string player, bool robotN)
        {
            if (robotN)
            {
                subcategory = "next_game";
            }
            else
            {
                subcategory = "next_game_R";
            }

            _thalamusCS.TypifiedPublisher.PerformUtteranceFromLibrary("nextGame" + Guid.NewGuid().ToString(), "sessionStart", subcategory, new string[] { "|player|" }, new string[] { player });
        }

        public void FingerHelp(bool robotN)
        {
            if (robotN)
            {
                subcategory = "finger_help";
            }
            else
            {
                subcategory = "finger_help_R";
            }

            _thalamusCS.TypifiedPublisher.PerformUtteranceFromLibrary("fingerHelp" + Guid.NewGuid().ToString(), "sessionStart", subcategory, new string[] { }, new string[] { });
        }

        public void ButtonHelp(bool robotN)
        {
            if (robotN)
            {
                subcategory = "button_help";
            }
            else
            {
                subcategory = "button_help_R";
            }

            _thalamusCS.TypifiedPublisher.PerformUtteranceFromLibrary("buttonHelp" + Guid.NewGuid().ToString(), "sessionStart", subcategory, new string[] { }, new string[] { });
        }

        public void Win(string puzzle, string player, bool robotN)
        {
            if (robotN)
            {
                subcategory = "win";
            }
            else
            {
                subcategory = "win_R";
            }

            _thalamusCS.TypifiedPublisher.PerformUtteranceFromLibrary("win" + Guid.NewGuid().ToString(), "sessionEnd", subcategory, new string[] { "|puzzle|", "|player|" }, new string[] { puzzle, player });
        }

        public void FastWin(string puzzle, string player, bool robotN)
        {
            if (robotN)
            {
                subcategory = "fast_win";
            }
            else
            {
                subcategory = "fast_win_R";
            }

            _thalamusCS.TypifiedPublisher.PerformUtteranceFromLibrary("fastWin" + Guid.NewGuid().ToString(), "sessionEnd", subcategory, new string[] { "|puzzle|", "|player|" }, new string[] { puzzle, player });
        }

        public void Quit(string player, bool robotN)
        {
            if (robotN)
            {
                subcategory = "quit";
            }
            else
            {
                subcategory = "quit_R";
            }

            _thalamusCS.TypifiedPublisher.PerformUtteranceFromLibrary("quit" + Guid.NewGuid().ToString(), "sessionEnd", subcategory, new string[] { "|player|" }, new string[] { player });
        }

        public void MotorHelp(bool robotN)
        {
            if (robotN)
            {
                subcategory = "motor_help";
            }
            else
            {
                subcategory = "motor_help_R";
            }

            _thalamusCS.TypifiedPublisher.PerformUtteranceFromLibrary("motorHelp" + Guid.NewGuid().ToString(), "help", subcategory, new string[] { }, new string[] { });
        }

        public void CloseHelp(bool robotN)
        {
            if (robotN)
            {
                subcategory = "close_help";
            }
            else
            {
                subcategory = "close_help_R";
            }

            _thalamusCS.TypifiedPublisher.PerformUtteranceFromLibrary("closeHelp" + Guid.NewGuid().ToString(), "help", subcategory, new string[] { }, new string[] { });
        }

        public void PositiveFeedback(string nPieces, string player, bool robotN)
        {
            if (robotN)
            {
                subcategory = "positive";
            }
            else
            {
                subcategory = "positive_R";
            }

            _thalamusCS.TypifiedPublisher.PerformUtteranceFromLibrary("positiveFeedback" + Guid.NewGuid().ToString(), "feedback", subcategory, new string[] { "|npieces|", "|player|" }, new string[] { nPieces.ToString(), player });
        }

        public void NegativeFeedback(bool robotN)
        {
            if (robotN)
            {
                subcategory = "negative";
            }
            else
            {
                subcategory = "negative_R";
            }

            _thalamusCS.TypifiedPublisher.PerformUtteranceFromLibrary("negativeFeedback" + Guid.NewGuid().ToString(), "feedback", subcategory, new string[] { }, new string[] { });
        }

        public void FirstAnglePrompt(string piece, string player, bool robotN)
        {
            if (robotN)
            {
                subcategory = "first";
            }
            else
            {
                subcategory = "first_R";
            }

            _thalamusCS.TypifiedPublisher.PerformUtteranceFromLibrary("firstAnglePrompt" + Guid.NewGuid().ToString(), "anglePrompt", subcategory, new string[] { "|piece|", "|player|" }, new string[] { piece, player });
        }

        public void FirstAnglePromptFinger(string piece, string player, bool robotN)
        {
            if (robotN)
            {
                subcategory = "first_finger";
            }
            else
            {
                subcategory = "first_finger_R";
            }

            _thalamusCS.TypifiedPublisher.PerformUtteranceFromLibrary("firstAnglePromptFinger" + Guid.NewGuid().ToString(), "anglePrompt", subcategory, new string[] { "|piece|", "|player|" }, new string[] { piece, player });
        }

        public void FirstAnglePromptButton(string piece, string player, bool robotN)
        {
            if (robotN)
            {
                subcategory = "first_button";
            }
            else
            {
                subcategory = "first_button_R";
            }

            _thalamusCS.TypifiedPublisher.PerformUtteranceFromLibrary("firstAnglePromptButton" + Guid.NewGuid().ToString(), "anglePrompt", subcategory, new string[] { "|piece|", "|player|" }, new string[] { piece, player });
        }

        public void SecondAnglePrompt(string piece, string player, bool robotN)
        {
            if (robotN)
            {
                subcategory = "sec";
            }
            else
            {
                subcategory = "sec_R";
            }

            _thalamusCS.TypifiedPublisher.PerformUtteranceFromLibrary("secondAnglePrompt" + Guid.NewGuid().ToString(), "anglePrompt", subcategory, new string[] { "|piece|", "|player|" }, new string[] { piece, player });
        }

        public void SecondAnglePromptFinger(string piece, string direction, string player, bool robotN)
        {
            if (robotN)
            {
                subcategory = "sec_finger";
            }
            else
            {
                subcategory = "sec_finger_R";
            }

            _thalamusCS.TypifiedPublisher.PerformUtteranceFromLibrary("secondAnglePromptFinger" + Guid.NewGuid().ToString(), "anglePrompt", subcategory, new string[] { "|piece|", "|direction|", "|player|" }, new string[] { piece, direction, player });
        }

        public void SecondAnglePromptButton(string piece, string nClicks, string player, bool robotN)
        {
            if (robotN)
            {
                subcategory = "sec_button";
            }
            else
            {
                subcategory = "sec_button_R";
            }

            _thalamusCS.TypifiedPublisher.PerformUtteranceFromLibrary("secondAnglePromptButton" + Guid.NewGuid().ToString(), "anglePrompt", subcategory, new string[] { "|piece|", "|nclicks|", "|player|" }, new string[] { piece, nClicks.ToString(), player });
        }

        public void ThirdAnglePrompt(string piece, string player, bool robotN)
        {
            if (robotN)
            {
                subcategory = "third";
            }
            else
            {
                subcategory = "third_R";
            }

            _thalamusCS.TypifiedPublisher.PerformUtteranceFromLibrary("thirdAnglePrompt" + Guid.NewGuid().ToString(), "anglePrompt", subcategory, new string[] { "|piece|", "|player|" }, new string[] { piece, player });
        }

        public void StopAnglePrompt(string piece, bool robotN)
        {
            if (robotN)
            {
                subcategory = "stop";
            }
            else
            {
                subcategory = "stop_R";
            }

            _thalamusCS.TypifiedPublisher.PerformUtteranceFromLibrary("stopAnglePrompt" + Guid.NewGuid().ToString(), "anglePrompt", subcategory, new string[] { "|piece|" }, new string[] { piece });
        }

        public void FirstIdlePrompt(string piece, string player, bool robotN)
        {
            if (robotN)
            {
                subcategory = "idle";
            }
            else
            {
                subcategory = "idle_R";
            }

            _thalamusCS.TypifiedPublisher.PerformUtteranceFromLibrary("firstIdlePrompt" + Guid.NewGuid().ToString(), "prompt", subcategory, new string[] { "|piece|", "|player|" }, new string[] { piece, player });
        }

        public void FirstPlacePrompt(string piece, string player, bool robotN)
        {
            if (robotN)
            {
                subcategory = "place";
            }
            else
            {
                subcategory = "place_R";
            }

            _thalamusCS.TypifiedPublisher.PerformUtteranceFromLibrary("firstPlacePrompt" + Guid.NewGuid().ToString(), "prompt", subcategory, new string[] { "|piece|", "|player|" }, new string[] { piece, player });
        }

        public void SecondPrompt1Position(string piece, string pos, string player, bool robotN)
        {
            if (robotN)
            {
                subcategory = "sec_1position";
            }
            else
            {
                subcategory = "sec_1position_R";
            }

            _thalamusCS.TypifiedPublisher.PerformUtteranceFromLibrary("secondPrompt1Position" + Guid.NewGuid().ToString(), "prompt", subcategory, new string[] { "|piece|", "|pos|", "|player|" }, new string[] { piece, pos, player });
        }

        public void SecondPrompt2Position(string piece, string pos1, string pos2, string player, bool robotN)
        {
            if (robotN)
            {
                subcategory = "sec_2position";
            }
            else
            {
                subcategory = "sec_2position_R";
            }

            _thalamusCS.TypifiedPublisher.PerformUtteranceFromLibrary("secondPrompt2Position" + Guid.NewGuid().ToString(), "prompt", subcategory, new string[] { "|piece|", "|pos1|", "|pos2|", "|player|" }, new string[] { piece, pos1, pos2, player });
        }

        public void SecondPromptPlace(string piece, string pos, string relativePiece, string player, bool robotN)
        {
            if (robotN)
            {
                subcategory = "sec_place";
            }
            else
            {
                subcategory = "sec_place_R";
            }

            _thalamusCS.TypifiedPublisher.PerformUtteranceFromLibrary("secondPromptPlace" + Guid.NewGuid().ToString(), "prompt", subcategory, new string[] { "|piece|", "|pos|", "|relativepiece|", "|player|" }, new string[] { piece, pos, relativePiece, player });
        }

        public void ThirdPrompt(string piece, string player, bool robotN)
        {
            if (robotN)
            {
                subcategory = "third";
            }
            else
            {
                subcategory = "third_R";
            }

            _thalamusCS.TypifiedPublisher.PerformUtteranceFromLibrary("thirdPrompt" + Guid.NewGuid().ToString(), "prompt", subcategory, new string[] { "|piece|", "|player|" }, new string[] { piece, player });
        }

        public void HardClue(string player, bool robotN)
        {
            if (robotN)
            {
                subcategory = "hard_clue";
            }
            else
            {
                subcategory = "hard_clue_R";
            }

            _thalamusCS.TypifiedPublisher.PerformUtteranceFromLibrary("hardClue" + Guid.NewGuid().ToString(), "prompt", subcategory, new string[] { "|player|" }, new string[] { player });
        }

        public void PGreeting(string player, bool robotN)
        {
            if (robotN)
            {
                subcategory = "greeting";
            }
            else
            {
                subcategory = "greeting_R";
            }

            _thalamusCS.TypifiedPublisher.PerformUtteranceFromLibrary("pGreeting" + Guid.NewGuid().ToString(), "pSessionStart", subcategory, new string[] { "|player|" }, new string[] { player });
        }

        public void PButtonHelp(bool robotN)
        {
            if (robotN)
            {
                subcategory = "rot_button";
            }
            else
            {
                subcategory = "rot_button_R";
            }

            _thalamusCS.TypifiedPublisher.PerformUtteranceFromLibrary("pButtonHelp" + Guid.NewGuid().ToString(), "pSessionStart", subcategory, new string[] { }, new string[] { });
        }

        public void PFingerHelp(bool robotN)
        {
            if (robotN)
            {
                subcategory = "rot_finger";
            }
            else
            {
                subcategory = "rot_finger_R";
            }

            _thalamusCS.TypifiedPublisher.PerformUtteranceFromLibrary("pFingerHelp" + Guid.NewGuid().ToString(), "pSessionStart", subcategory, new string[] { }, new string[] { });
        }

        public void PWin(string puzzle, string player, bool robotN)
        {
            if (robotN)
            {
                subcategory = "win";
            }
            else
            {
                subcategory = "win_R";
            }

            _thalamusCS.TypifiedPublisher.PerformUtteranceFromLibrary("pWin" + Guid.NewGuid().ToString(), "pSessionEnd", subcategory, new string[] { "|puzzle|", "|player|" }, new string[] { puzzle, player });
        }

        public void PChildTurn(string player, bool robotN)
        {
            if (robotN)
            {
                subcategory = "child";
            }
            else
            {
                subcategory = "child_R";
            }

            _thalamusCS.TypifiedPublisher.PerformUtteranceFromLibrary("pChildTurn" + Guid.NewGuid().ToString(), "pTurn", subcategory, new string[] { "|player|" }, new string[] { player });
        }

        public void PRobotTurn(bool robotN)
        {
            if (robotN)
            {
                subcategory = "robot";
            }
            else
            {
                subcategory = "robot_R";
            }

            _thalamusCS.TypifiedPublisher.PerformUtteranceFromLibrary("pRobotTurn" + Guid.NewGuid().ToString(), "pTurn", subcategory, new string[] { }, new string[] { });
        }

        public void PRobotDrag(bool robotN)
        {
            if (robotN)
            {
                subcategory = "robot_drag";
            }
            else
            {
                subcategory = "robot_drag_R";
            }

            _thalamusCS.TypifiedPublisher.PerformUtteranceFromLibrary("pRobotDrag" + Guid.NewGuid().ToString(), "pTurn", subcategory, new string[] { }, new string[] { });
        }

        public void PRobotRotDrag(bool robotN)
        {
            if (robotN)
            {
                subcategory = "robot_rot_drag";
            }
            else
            {
                subcategory = "robot_rot_drag_R";
            }

            _thalamusCS.TypifiedPublisher.PerformUtteranceFromLibrary("pRobotRotDrag" + Guid.NewGuid().ToString(), "pTurn", subcategory, new string[] { }, new string[] { });
        }

        public void PRobotWin(string nPieces, string player, bool robotN)
        {
            if (robotN)
            {
                subcategory = "robot_win";
            }
            else
            {
                subcategory = "robot_win_R";
            }

            _thalamusCS.TypifiedPublisher.PerformUtteranceFromLibrary("pRobotWin" + Guid.NewGuid().ToString(), "pTurn", subcategory, new string[] { "|npieces|", "|player|" }, new string[] { nPieces.ToString(), player });
        }

        public void PRobotReminder(bool robotN)
        {
            if (robotN)
            {
                subcategory = "robot_reminder";
            }
            else
            {
                subcategory = "robot_reminder_R";
            }

            _thalamusCS.TypifiedPublisher.PerformUtteranceFromLibrary("pRobotReminder" + Guid.NewGuid().ToString(), "pTurn", subcategory, new string[] { }, new string[] { });
        }

        public void PAskingPlace(string piece, string player, bool robotN)
        {
            if (robotN)
            {
                subcategory = "asking_place";
            }
            else
            {
                subcategory = "asking_place_R";
            }

            _thalamusCS.TypifiedPublisher.PerformUtteranceFromLibrary("pAskingPlace" + Guid.NewGuid().ToString(), "pHelp", subcategory, new string[] { "|piece|", "|player|" }, new string[] { piece, player });
        }

        public void PAskingRotate(string piece, string player, bool robotN)
        {
            if (robotN)
            {
                subcategory = "asking_rotate";
            }
            else
            {
                subcategory = "asking_rotate_R";
            }

            _thalamusCS.TypifiedPublisher.PerformUtteranceFromLibrary("pAskingRotate" + Guid.NewGuid().ToString(), "pHelp", subcategory, new string[] { "|piece|", "|player|" }, new string[] { piece, player });
        }

        public void PAskingPlaceWin(string player, bool robotN)
        {
            if (robotN)
            {
                subcategory = "asking_place_win";
            }
            else
            {
                subcategory = "asking_place_win_R";
            }

            _thalamusCS.TypifiedPublisher.PerformUtteranceFromLibrary("pAskingPlaceWin" + Guid.NewGuid().ToString(), "pHelp", subcategory, new string[] { "|player|" }, new string[] { player });
        }

        public void PAskingRotateWin(string player, bool robotN)
        {
            if (robotN)
            {
                subcategory = "asking_rotate_win";
            }
            else
            {
                subcategory = "asking_rotate_win_R";
            }

            _thalamusCS.TypifiedPublisher.PerformUtteranceFromLibrary("pAskingRotateWin" + Guid.NewGuid().ToString(), "pHelp", subcategory, new string[] { "|player|" }, new string[] { player });
        }

        public void PAskingPlaceWrong(string piece, bool robotN)
        {
            if (robotN)
            {
                subcategory = "asking_place_wrong";
            }
            else
            {
                subcategory = "asking_place_wrong_R";
            }

            _thalamusCS.TypifiedPublisher.PerformUtteranceFromLibrary("pAskingPlaceWrong" + Guid.NewGuid().ToString(), "pHelp", subcategory, new string[] { "|piece|" }, new string[] { piece });
        }

        public void PAskingRotateWrong(string piece, bool robotN)
        {
            if (robotN)
            {
                subcategory = "asking_rotate_wrong";
            }
            else
            {
                subcategory = "asking_rotate_wrong_R";
            }

            _thalamusCS.TypifiedPublisher.PerformUtteranceFromLibrary("pAskingRotateWrong" + Guid.NewGuid().ToString(), "pHelp", subcategory, new string[] { "|piece|" }, new string[] { piece });
        }

        public void PAskingQuit(bool robotN)
        {
            if (robotN)
            {
                subcategory = "asking_quit";
            }
            else
            {
                subcategory = "asking_quit_R";
            }

            _thalamusCS.TypifiedPublisher.PerformUtteranceFromLibrary("pAskingQuit" + Guid.NewGuid().ToString(), "pHelp", subcategory, new string[] { }, new string[] { });
        }

        public void PGivingPlace(string piece, string pos, bool robotN)
        {
            if (robotN)
            {
                subcategory = "giving_place";
            }
            else
            {
                subcategory = "giving_place_R";
            }

            _thalamusCS.TypifiedPublisher.PerformUtteranceFromLibrary("pGivingPlace" + Guid.NewGuid().ToString(), "pHelp", subcategory, new string[] { "|piece|", "|pos|" }, new string[] { piece, pos });
        }

        public void PGivingRotate(string piece, bool robotN)
        {
            if (robotN)
            {
                subcategory = "giving_rotate";
            }
            else
            {
                subcategory = "giving_rotate_R";
            }

            _thalamusCS.TypifiedPublisher.PerformUtteranceFromLibrary("pGivingRotate" + Guid.NewGuid().ToString(), "pHelp", subcategory, new string[] { "|piece|" }, new string[] { piece });
        }

        public void WriteJSON(string timestamp, string info, string path_file, string aux_path) 
        {

            /********************************
             */
            //string filePath = @"c:\Developer\Logs\";
            string filePath = path_file;
            Console.WriteLine(filePath);
            try
            {
                if (!Directory.Exists(filePath))
                {
                    Directory.CreateDirectory(filePath);
                    Console.WriteLine(filePath);
                }

            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
            }
            /********************************
            */

            if (_thalamusCS.fileName == null)
            {
                //_thalamusCS.fileName = filePath  +  String.Format("{0:dd-MM-yyyy hh-mm-ss}", DateTime.Now) + ".txt";
                _thalamusCS.fileName = filePath + aux_path + String.Format("{0:dd-MM-yyyy hh-mm-ss}", DateTime.Now) + ".txt";
                Console.WriteLine(filePath + @"\" + String.Format("{0:dd-MM-yyyy hh-mm-ss}", DateTime.Now) + ".txt");
                using (System.IO.StreamWriter file =
                    new System.IO.StreamWriter(_thalamusCS.fileName))
                {

                    file.WriteLine(timestamp + " " + info);
                }
            }
            else {
                using (System.IO.StreamWriter file =
                        new System.IO.StreamWriter(_thalamusCS.fileName, true))
                {

                    file.WriteLine(timestamp + " " + info);
                }
            }
        }

        public void CancelUtterance(string id) {
            _thalamusCS.TypifiedPublisher.CancelUtterance(id);
        }

        /*public void GlanceAtScreen(double x, double y)
        {
            _thalamusCS.TypifiedPublisher.GlanceAtScreen(x, y);
        }

        public void GazeAtScreen(double x, double y)
        {
            _thalamusCS.TypifiedPublisher.GazeAtScreen(x, y);
        }*/

        public void Dispose()
        {
        }
    }
}
