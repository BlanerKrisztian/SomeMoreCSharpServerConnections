// ORM object relation mapping

// const  { something } = req.body, something = req.body.something

const { Sequelize, DataTypes} = require('Sequelize')

const dbHandler = new Sequelize("weather","root","",{
    host:"127.0.0.1",
    dialect:"mysql",
    port:3306,
})

const table = dbHandler.define("weathertype",{
    id: { type: DataTypes.INTEGER, autoIncrement: true, primaryKey: true, allowNull: false },
    name: {type: DataTypes.STRING, allowNull: false}
})
