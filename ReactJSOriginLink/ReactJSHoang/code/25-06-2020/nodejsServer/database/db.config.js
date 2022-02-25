const databaseConfigure = { //why places this code in a separated file ?
    HOST: "localhost",
    USER: "root",
    PASSWORD: "",
    DB: "cecomtech",
    dialect: "mysql",
    pool: {
        max: 5,//maximum number of connection in pool
        min: 0,
        acquire: 30000,//try to connect(ms) before throwing error
        idle: 10000//maxtime(ms),connection can be idle before being released
    }
}

module.exports = databaseConfigure