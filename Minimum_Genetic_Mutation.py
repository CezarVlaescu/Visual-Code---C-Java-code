class Mutation:
    def __init__(self, x, y):
        self.x = x
        self.y = y
        x = []
        y = []
    def genetic(self, bank):
        i = ['AB']
        for i in self.x and self.y:
            bank = i
        return bank

obj = Mutation('AB', 'BC')
var = obj.genetic
print(var)




        