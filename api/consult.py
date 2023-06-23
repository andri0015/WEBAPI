from flask import Flask
import requests


app = Flask(__name__)

@app.route('/api/consult')
def consult():

    result = requests.get('https://localhost:7159/api/employee')
    if result.code == 200:
        return result.json()
    else:
        return "Fail Consult"
    