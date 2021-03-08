from Service.Controller import Controller


class View:
    def __init__(self):
        self.service = Controller()

    def runView(self):
        self.service.startGame()
