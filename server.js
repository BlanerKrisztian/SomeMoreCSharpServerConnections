require("dotenv").config()
const express = require("express")
const router = require("./routes")
const cors = require("cors")
const dbHandler = require("./dbHandler")

//dbHandler.weathertype.sync() // creates table if it doesnt exist already
//dbHandler.weathertype.sync({alter:true}) // edits table if exists, creates if no table found
//dbHandler.weathertype.sync({force:true}) // deletes table and reconstructs


const server = express()
const PORT = process.env.PORT

server.use(cors())
server.use(express/* ^.^ BCAS */.json())
server.use(express.static("public"))
server.use(router)

server.listen(PORT,()=> console.log(`Server running on PORT ${PORT}.`))