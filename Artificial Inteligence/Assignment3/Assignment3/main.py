from Assignment3.View.Console import *
from Assignment3.Repository.repository import *
from Assignment3.Service.controller import *
from Assignment3.Service.MapService import *

if __name__ == '__main__':
    repository = Repository()
    controller = Controller(repository)

    console = Console(controller)
    console.runMenu()

