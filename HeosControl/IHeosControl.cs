namespace Test
{
    public enum HeosConnectStatus
    {
        NOT_CONNECT,
        CONNECT,
        ERROR
    }

    public enum HeosResponseStatus
    {
        ERROR,
        SUCCESS
    }

    public interface IHeosControl
    {
        /// <summary>
        /// Подключение к плееру
        /// </summary>
        /// <param name="address">адрес плеера</param>
        /// <param name="port">порт плеера</param>
        /// <returns>статус подключения</returns>
        HeosConnectStatus Connect(string address, uint port);

        /// <summary>
        /// Воспроизведение трека
        /// </summary>
        /// <param name="playerId">идентификатор плеера, к которому делается запрос</param>
        /// <returns>статус выполнения команды</returns>
        HeosResponseStatus Play(uint playerId);

        /// <summary>
        /// Остановка трека
        /// </summary>
        /// <param name="playerId">идентификатор плеера, к которому делается запрос</param>
        /// <returns>статус выполнения команды</returns>
        HeosResponseStatus Stop(uint playerId);

        /// <summary>
        /// Постановка трека на паузу 
        /// </summary>
        /// <param name="playerId">идентификатор плеера, к которому делается запрос</param>
        /// <returns>статус выполнения команды</returns>
        HeosResponseStatus Pause(uint playerId);

        /// <summary>
        /// Проиграть следующий трек
        /// </summary>
        /// <param name="playerId">идентификатор плеера, к которому делается запрос</param>
        /// <returns>статус выполнения команды</returns>
        HeosResponseStatus PlayNext(uint playerId);

        /// <summary>
        /// Проиграть предыдущий трек
        /// </summary>
        /// <param name="playerId">идентификатор плеера, к которому делается запрос</param>
        /// <returns>статус выполнения команды</returns>
        HeosResponseStatus PlayPrevious(uint playerId);

        /// <summary>
        /// Увеличить громкость на "step" делений
        /// </summary>
        /// <param name="playerId">идентификатор плеера, к которому делается запрос</param>
        /// <param name="step">шаг увеличения громкости</param>
        /// <returns>статус выполнения команды</returns>
        HeosResponseStatus VolumeUp(uint playerId, uint step);

        /// <summary>
        /// Уменьшить громкость на "step" делений
        /// </summary>
        /// <param name="playerId">идентификатор плеера, к которому делается запрос</param>
        /// <param name="step">шаг уменьшения громкости</param>
        /// <returns>статус выполнения команды</returns>
        HeosResponseStatus VolumeDown(uint playerId, uint step);
    }
}